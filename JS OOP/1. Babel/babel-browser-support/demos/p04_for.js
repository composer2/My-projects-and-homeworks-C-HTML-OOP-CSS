"use strict";

(function () {
    "use strict";

    console.log("##For");

    var array = ['a', 'b', 'c'];

    for (var i in array) {
        console.log(i);
    } // prints "0", "1", "2"
    var _iteratorNormalCompletion = true;
    var _didIteratorError = false;
    var _iteratorError = undefined;

    try {
        for (var _iterator = array[Symbol.iterator](), _step; !(_iteratorNormalCompletion = (_step = _iterator.next()).done); _iteratorNormalCompletion = true) {
            var _i = _step.value;
            console.log(_i);
        } // prints "a", "b", "c"

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