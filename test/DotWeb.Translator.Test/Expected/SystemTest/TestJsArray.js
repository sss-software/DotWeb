﻿H8.SystemTests.prototype.TestJsArray = function() {
	var array = new Array();
	if (Array.isArray(array)) {
		var part = array.slice(0, 1);
		System.Console.WriteLine$1(part.join(","));
	}
	array.splice(0, 0);
	array.splice(0, 0, 1);
	array.splice(0, 0, 1, "two");
	var x = new Array(1, 2);
	System.Console.WriteLine$0(x[0]);
	x[1] = 1;
};
