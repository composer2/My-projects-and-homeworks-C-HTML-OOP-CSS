"use strict";

function _defineProperty(obj, key, value) { if (key in obj) { Object.defineProperty(obj, key, { value: value, enumerable: true, configurable: true, writable: true }); } else { obj[key] = value; } return obj; }

(function () {
    "use strict";

    console.log("##Symbols");
    //limited support

    var sym = Symbol("foo");
    var obj = _defineProperty({}, sym, 1);
    console.log(obj[sym]);
})();