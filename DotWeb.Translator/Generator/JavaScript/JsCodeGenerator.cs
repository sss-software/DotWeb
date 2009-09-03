﻿// Copyright 2009, Frank Laub
//
// This file is part of DotWeb.
//
// DotWeb is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// DotWeb is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with DotWeb.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.IO;
using System.CodeDom.Compiler;
using DotWeb.Translator.CodeModel;
using DotWeb.Client;
using DotWeb.Translator.Properties;

namespace DotWeb.Translator.Generator.JavaScript
{
	static class TypeExtensions
	{
		public static bool HasBase(this Type type) {
			if (type.BaseType == typeof(object) ||
				type.BaseType == typeof(JsAccessible) ||
				type.BaseType == typeof(JsNativeBase)) {
				return false;
			}
			return true;
		}
	}

	public class JsCodeGenerator: ICodeStatementVisitor, ICodeMemberVisitor
	{
		private JsPrinter printer = new JsPrinter();
		private IndentedTextWriter writer;
		private CodeMethodMember currentMethod;

		public JsCodeGenerator(TextWriter output, bool writeHeader) {
			this.writer = new IndentedTextWriter(output, "\t");
			if (writeHeader) {
				this.writer.WriteLine("// Generated by H8 at: {0}", DateTime.Now);
				this.writer.WriteLine();
				this.writer.WriteLine(Resources.Runtime);
			}
		}

		public void WriteEntry(CodeTypeDeclaration type) {
			this.writer.WriteLine("$wnd.onload = function() {");
			this.writer.Indent++;
			this.writer.WriteLine("new {0}().$ctor();", Print(type.Type));
//			this.writer.WriteLine("alert(script);");
//			this.writer.WriteLine("script.$ctor();");
			this.writer.Indent--;
			this.writer.WriteLine("}");
		}

		public void Write(CodeNamespace ns) {
			ns.Accept(this);
			this.writer.Flush();
		}

		public void Write(CodeTypeDeclaration type) {
			type.Accept(this);
			this.writer.Flush();
		}

		public void Write(CodeMethodMember method) {
			method.Accept(this);
			this.writer.Flush();
		}

		private void WriteLine() {
			this.writer.WriteLine();
		}

		private void WriteLine(object arg) {
			this.writer.WriteLine(arg);
		}

		private void WriteLine(string format, params object[] args) {
			this.writer.WriteLine(format, args);
		}

		private void Write(List<CodeStatement> stmts) {
			foreach (CodeStatement stmt in stmts) {
				stmt.Accept(this);
			}
		}

		private string Print(Type type) {
			return this.printer.Print(type);
		}

		private string Print(CodeExpression expr) {
			return this.printer.Print(expr);
		}

		private string EncodeName(string name) {
			return this.printer.EncodeName(name);
		}

		#region Statements
		public void Visit(CodeSwitchStatement stmt) {
			WriteLine("switch({0}) {{", Print(stmt.Expression));
			this.writer.Indent++;
			foreach (CodeCase cc in stmt.Cases) {
				if (cc.Expressions.Count == 0) {
					WriteLine("default:");
				}
				else {
					foreach (CodeExpression exp in cc.Expressions) {
						WriteLine("case {0}:", Print(exp));
					}
				}
				this.writer.Indent++;
				Write(cc.Statements);
				WriteLine("break;");
				this.writer.Indent--;
			}
			this.writer.Indent--;
			WriteLine("}}");
		}

		public void Visit(CodeVariableDeclarationStatement stmt) {
//			WriteLine("var {1}; // {0}", Print(stmt.Type), stmt.Name);
		}

		public void Visit(CodeCommentStatement stmt) {
			WriteLine("// {0}", stmt.Comment);
		}

		private Dictionary<int, CodeVariableReference> locals = new Dictionary<int, CodeVariableReference>();

		public void Visit(CodeAssignStatement stmt) {
			string rhs;
			CodePrimitiveExpression cpe = stmt.Right as CodePrimitiveExpression;
			if (cpe != null) {
				CodeTypeEvaluator evaluator = new CodeTypeEvaluator(this.currentMethod.Info);
				Type type = evaluator.Evaluate(stmt.Left);
				object target = Convert.ChangeType(cpe.Value, type);
				rhs = this.printer.PrintLiteral(target);
			}
			else {
				rhs = Print(stmt.Right);
			}
			CodeVariableReference cvr = stmt.Left as CodeVariableReference;
			if (cvr != null) {
				if (!locals.ContainsKey(cvr.Index)) {
					locals.Add(cvr.Index, cvr);
					this.writer.Write("var ");
				}
			}
			WriteLine("{0} = {1};", Print(stmt.Left), rhs);
		}

		public void Visit(CodeExpressionStatement stmt) {
			string code = Print(stmt.Expression);
			if(!string.IsNullOrEmpty(code))
				WriteLine("{0};", code);
		}

		public void Visit(CodeReturnStatement stmt) {
			if (stmt.Expression != null)
				WriteLine("return {0};", Print(stmt.Expression));
			else {
				if (currentMethod != null && currentMethod.Statements.Last() == stmt) {
					return;
				}
				WriteLine("return;");
			}
		}

		public void Visit(CodeWhileStatement stmt) {
			WriteLine("while({0}) {{", Print(stmt.TestExpression));
			this.writer.Indent++;
			Write(stmt.Statements);
			this.writer.Indent--;
			WriteLine("}}");
		}

		public void Visit(CodeRepeatStatement stmt) {
			WriteLine("do {{");
			this.writer.Indent++;
			Write(stmt.Statements);
			this.writer.Indent--;
			WriteLine("}} while({0});", Print(stmt.TestExpression));
		}

		public void Visit(CodeIfStatement stmt) {
			WriteLine("if ({0}) {{", Print(stmt.Condition));
			this.writer.Indent++;
			Write(stmt.TrueStatements);
			this.writer.Indent--;
			WriteLine("}}");
			if (stmt.FalseStatements.Count > 0) {
				WriteLine("else {{");
				this.writer.Indent++;
				Write(stmt.FalseStatements);
				this.writer.Indent--;
				WriteLine("}}");
			}
		}

		public void Visit(CodeThrowStatement stmt) {
			WriteLine("throw {0}", Print(stmt.Expression));
		}

		#endregion

		#region Members
		public void Visit(CodeTypeDeclaration type) {
			try {
				if (type.Type.IsDefined(typeof(JsAnonymousAttribute), true))
					return;

				string typeName = Print(type.Type);

				bool isNative = type.Type.IsSubclassOf(typeof(JsNativeBase));
				if (isNative) {
					WriteLine("if(typeof({0}) == 'undefined') {{", typeName);
					this.writer.Indent++;
					//WriteLine("alert('defining {0}');", typeName);
				}

				WriteLine("{0} = function() {{", typeName);
				bool hasBase = type.Type.HasBase();
				this.writer.Indent++;
				if (hasBase) {
					WriteLine("this.$super.constructor();");
				}
				// field initializers go here
				this.writer.Indent--;
				WriteLine("}};");

				if (hasBase) {
					WriteLine("{0}.$extend({1});", typeName, Print(type.Type.BaseType));
				}

				if (isNative) {
					this.writer.Indent--;
					WriteLine("}}");
				}

				WriteLine();

				type.Methods.ForEach(x => x.Accept(this));
				WriteLine();

//				type.Properties.ForEach(x => x.Accept(this));
//				WriteLine();
			}
			finally {
				this.writer.Flush();
			}
		}

		public void Visit(CodeMethodMember method) {
			this.printer.CurrentMethod = method.Info;
			this.currentMethod = method;

			if (!method.Statements.Any()) {
				return;
			}

			if (method.Statements.First() is CodeReturnStatement) {
				return;
			}

			if (method.IsGlobal) {
				Write(method.Statements);
				return;
			}

			string[] args = method.Parameters.Select(x => Print(x)).ToArray();
			string name = method.Name;
			if (method.Info.IsConstructor) {
				WriteLine("{0}.prototype.{1} = function({2}) {{",
					Print(method.Info.DeclaringType),
					JsPrinter.CtorMethodName,
					string.Join(", ", args)
				);
			}
			else if (method.Info.IsStatic) {
				if (name == ".cctor")
					name = JsPrinter.CtorMethodName;

				WriteLine("{0}.{1} = function({2}) {{",
					Print(method.Info.DeclaringType),
					EncodeName(name),
					string.Join(", ", args)
				);
			}
			else {
				WriteLine("{0}.prototype.{1} = function({2}) {{",
					Print(method.Info.DeclaringType),
					EncodeName(name),
					string.Join(", ", args)
				);
			}

			this.writer.Indent++;
			if (string.IsNullOrEmpty(method.NativeCode)) {
				Write(method.Statements);
				if (method.Info.IsConstructor) {
					WriteLine("return this;");
				}
			}
			else {
				this.writer.WriteLine(method.NativeCode);
			}
			this.writer.Indent--;
			WriteLine("}};");
			WriteLine();
		}

		public void Visit(CodeFieldMember field) {
			WriteLine("{0}: {1} // field: {2}",
				EncodeName(field.Name), 
				"{}", 
				Print(field.Info.FieldType)
			);
		}

		public void Visit(CodeEventMember evt) {
			WriteLine("{0}: {1} // event: {2}",
				EncodeName(evt.Name), 
				"[]", 
				Print(evt.Info.EventHandlerType));
		}

		public void Visit(CodePropertyMember property) {
			//string name = EncodeName(property.Name);
			//if (property.Info.GetAccessors().Any(x => x.IsStatic)) {
			//    WriteLine("{0}.prototype.{1} = function() {{",
			//        Print(property.Info.DeclaringType),
			//        name
			//    );
			//}
			//else {
			//    WriteLine("{0}.{1} = function() {{",
			//        Print(property.Info.DeclaringType),
			//        name
			//    );
			//}

			//this.writer.Indent++;
			//this.writer.WriteLine("return this.get_{0}();", name);
			//this.writer.Indent--;
			//WriteLine("}};");
			//WriteLine();

			//WriteLine("{0}: '' // property: {1}",
			//    EncodeName(property.Name),
			//    Print(property.Info.PropertyType));
		}

		public void WriteNamespaceDecl(CodeNamespace ns) {
			if (!string.IsNullOrEmpty(ns.Name)) {
				StringBuilder sb = new StringBuilder();
				string[] parts = ns.Name.Split('.');
				foreach (string part in parts) {
					if (sb.Length > 0) {
						sb.Append(".");
					}
					sb.Append(part);

					WriteLine("if(typeof({0}) == 'undefined') {0} = {{}};", sb.ToString());
				}
				WriteLine();
			}
		}

		public void Visit(CodeNamespace ns) {
			WriteNamespaceDecl(ns);

			foreach (CodeTypeDeclaration type in ns.Types) {
				Write(type);
			}
		}
		#endregion
	}
}
