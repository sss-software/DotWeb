﻿Conditionals.prototype.SimpleIfAndNot = function(x, y) {
	var ret = 0;
	if (x && !y) {
		ret = 1;
	}
	else {
		ret = 2;
	}
	ret = ret + 1;
	return ret;
};
