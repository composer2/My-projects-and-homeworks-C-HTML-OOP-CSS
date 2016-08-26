"use strict";

(function () {
    "use strict";

    console.log("##Unicode");

    // same as ES5.1
    console.log("𠮷".length == 2);

    // new RegExp behaviour, opt-in ‘u’
    //    "𠮷".match(/./u)[0].length == 2

    // new form
    "𠮷" == "𠮷" == "𠮷";

    // new String ops
    console.log("𠮷".codePointAt(0) == 0x20BB7);

    // for-of iterates code points
    var _iteratorNormalCompletion = true;
    var _didIteratorError = false;
    var _iteratorError = undefined;

    try {
        for (var _iterator = "𠮷"[Symbol.iterator](), _step; !(_iteratorNormalCompletion = (_step = _iterator.next()).done); _iteratorNormalCompletion = true) {
            var c = _step.value;

            console.log(c);
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