"use strict";

function _defineProperty(obj, key, value) { if (key in obj) { Object.defineProperty(obj, key, { value: value, enumerable: true, configurable: true, writable: true }); } else { obj[key] = value; } return obj; }

(function () {
	"use strict";

	var _obj;

	console.log("##Enhanced Object Literals");

	// New object features
	var p = 42;

	var obj = (_obj = {
		a: 1,
		p: p }, _defineProperty(_obj, 'b' + 2 * 3, 'computed property'), _defineProperty(_obj, "findMeaningOfLife", function findMeaningOfLife(age) {
		return age < 0 ? 0 : 42;
	}), _obj);
	console.log(obj.b6);
	console.log(obj.findMeaningOfLife(1));
})();