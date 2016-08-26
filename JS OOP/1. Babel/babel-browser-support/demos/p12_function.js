"use strict";

(function () {
	"use strict";

	console.log("##Function");

	// default parameters
	function address(city) {
		var state = arguments.length <= 1 || arguments[1] === undefined ? 'MI' : arguments[1];
		var country = arguments.length <= 2 || arguments[2] === undefined ? 'USA' : arguments[2];

		return { city: city, state: state, country: country };
	}

	console.log(address('Dayton', 'OH'));
	console.log(address('Detroit'));

	// Rest parameters
	function family(father, mother) {
		for (var _len = arguments.length, children = Array(_len > 2 ? _len - 2 : 0), _key = 2; _key < _len; _key++) {
			children[_key - 2] = arguments[_key];
		}

		children = children.sort();
		return father + " and " + mother + " have " + children.length + " children";
	}
	console.log(family('bill', 'belle', 'a', 'x', 'b'));
})();