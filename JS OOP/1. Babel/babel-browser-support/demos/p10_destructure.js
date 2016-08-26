"use strict";

(function () {
	"use strict";

	console.log("##Destructure");

	var a = 1;
	var b = 2;
	var c = 'w'; // a=1, b=2, c='w'

	// swap:

	var a = 10;
	var b = 20;
	// a=20, b=10

	// fields in function parameters
	var _ref = [b, a];
	a = _ref[0];
	b = _ref[1];
	var book = {
		id: 99,
		title: 'Stranger in a Strange Land',
		author: 'Robert Heinlein',
		year: 1961
	};

	var xx = {
		id: 42
	};

	function getId(_ref2) {
		var id = _ref2.id;

		return id;
	}

	function formattedTitle(_ref3) {
		var title = _ref3.title;
		var author = _ref3.author;

		return title + ' by ' + author;
	}

	console.log(getId(book));
	console.log(formattedTitle(book));
})();