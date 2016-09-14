function toArray(obj) {
	var arr,
		prop;
	if (obj.length) {
		arr = Array.prototype.slice.apply(obj);
	} else {
		arr = [];
		for (prop in obj) {
			if (typeof obj[prop] !== 'function') {
				arr.push({
					prop: prop,
					value: obj[prop]
				});
			}
		}
	}
	return arr;
}
function passArguments(){
	console.log(toArray(arguments));
}

var obj={
	firstname:'Boncho',
	lastname:'Belutov',
	specialites:['eating','sleeping','layingAround']
};
console.log('Arguments collection:');
passArguments(1,2,3,4,5,6,7);
console.log("object: ");
console.log(toArray(obj));