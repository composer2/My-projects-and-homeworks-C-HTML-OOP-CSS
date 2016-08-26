"use strict";

(function () {
	"use strict";

	var _marked = [oddsGenerator].map(regeneratorRuntime.mark);

	console.log("##Generator");

	// putting * after function indicates that it is a generator
	function oddsGenerator() {
		var max, odd;
		return regeneratorRuntime.wrap(function oddsGenerator$(_context) {
			while (1) {
				switch (_context.prev = _context.next) {
					case 0:
						max = 10;
						odd = 1;

					case 2:
						_context.next = 4;
						return odd;

					case 4:
						// value to be returned
						odd += 2;

					case 5:
						if (odd < max) {
							_context.next = 2;
							break;
						}

					case 6:
					case "end":
						return _context.stop();
				}
			}
		}, _marked[0], this);
	}

	var odds = oddsGenerator();
	var _iteratorNormalCompletion = true;
	var _didIteratorError = false;
	var _iteratorError = undefined;

	try {
		for (var _iterator = odds[Symbol.iterator](), _step; !(_iteratorNormalCompletion = (_step = _iterator.next()).done); _iteratorNormalCompletion = true) {
			var odd = _step.value;

			console.log(odd);
		}
	} catch (err) {
		_didIteratorError = true;
		_iteratorError = err;
	} finally {
		try {
			if (!_iteratorNormalCompletion && _iterator["return"]) {
				_iterator["return"]();
			}
		} finally {
			if (_didIteratorError) {
				throw _iteratorError;
			}
		}
	}
})();