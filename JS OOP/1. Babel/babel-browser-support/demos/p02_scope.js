'use strict';

(function () {
	"use strict";

	console.log('##Scope');

	// let/const have block scope
	var flag = true; // notice the constant
	if (flag) {
		var a = 1;
		var b = 2;
	}

	console.log(1);
	//console.log(b);  // Will cause an error

	// no hoisting
	function f1() {
		console.log('c:', c); // prints undefined
		//console.log('d:', d); // error
		var c = 3;
		var d = 4;
	}
	f1();

	// let with for loop, notice how is is scoped
	for (var i = 0; i < 4; i++) {
		console.log(i);
	}
	//console.log(i);  // error
})();