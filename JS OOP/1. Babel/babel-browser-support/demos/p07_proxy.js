"use strict";

(function () {
	"use strict";

	console.log("##Proxy");

	var idHandler = {
		get: function get(target, propName) {
			if (propName in target) return target[propName];
			if (propName === 'id') {
				var id = 'id_' + this._id++;
				target['id'] = id;
				return id;
			}
			return undefined;
		},
		_id: 1
	};

	var user = {
		name: 'cat'
	};

	user = new Proxy(user, idHandler);

	console.log(user.name);
	console.log(user.id);
	console.log(user.age);
})();