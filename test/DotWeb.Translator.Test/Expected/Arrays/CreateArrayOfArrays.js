﻿Arrays.prototype.CreateArrayOfArrays = function() {
	var inner = [1, 2, 3];
	var CS$0$0000 = new Array(2);
	CS$0$0000[0] = inner;
	CS$0$0000[1] = inner;
	var array = CS$0$0000;
	System.Console.WriteLine$0(array);
};