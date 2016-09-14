"use strict";

(function () {
	"use strict";

	console.log("##Promise");

	// a slow function that returns data
	function findGuy() {
		sleep(100); // simulate a slow operation
		var guy = {
			isBad: Math.random() < 0.5
		};
		return guy;
	}

	// create a promise
	var badGuyPromise = new Promise(function (resolve, reject) {
		var guy = findGuy();
		if (guy.isBad) {
			resolve("the guy is bad");
		} else {
			reject('the guy is ok');
		}
	});

	badGuyPromise.then(function (badGuy) {
		return console.log(badGuy);
	})["catch"](function (msg) {
		return console.log(msg);
	});

	// do not do this at home
	function sleep(milliseconds) {
		var start = new Date().getTime();
		while (true) {
			if (new Date().getTime() - start > milliseconds) break;
		}
	}
})();