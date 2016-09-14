const foo = Symbol();
const bar = Symbol();
console.log( foo !== bar);
console.log( typeof foo === "symbol");
console.log( typeof bar === "symbol");
let obj = {};
obj[foo] = "foo";
obj[bar] = "bar";
console.log( JSON.stringify(obj)); // {}
console.log( Object.keys(obj)); // []
console.log( Object.getOwnPropertyNames(obj)); // []
console.log( Object.getOwnPropertySymbols(obj)); // [ foo, bar ]