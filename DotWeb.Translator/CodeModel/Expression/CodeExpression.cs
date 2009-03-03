﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotWeb.Translator.CodeModel
{
	public abstract class CodeExpression : CodeObject
	{
		public virtual CodeExpression Invert() {
			return new CodeUnaryExpression(this, CodeUnaryOperator.Not);
		}
	}
}