// The Promise.resolve(value) method returns a Promise object
// that is resolved with the given value.If the value is a 
// thenable(i.e.has a "then" method), the returned promise
// will "follow" that thenable, adopting its eventual state;
// otherwise the returned promise will be fulfilled with the value.

// //A

// Promise.resolve("Success").then(function(value) {
//   console.log(value); // "Success"
// }, function(value) {
//   // not called
// });

// //B

// var p = Promise.resolve([1,2,3]);
// p.then(function(v) {
//   console.log(v[0]); // 1
// });

// //C

// var original = Promise.resolve(true);
// var cast = Promise.resolve(original);
// cast.then(function(v) {
//   console.log(v); // true
// });

//D
// Resolving a thenable object

var p1 = Promise.resolve({ 
  then: function(onFulfill, onReject) { onFulfill("fulfilled!"); }
});
console.log(p1 instanceof Promise) // true, object casted to a Promise

p1.then(function(v) {
    console.log(v); // "fulfilled!"
  }, function(e) {
    // not called
});

// Thenable throws before callback
// Promise rejects
var thenable = { then: function(resolve) {
  throw new TypeError("Throwing");
  resolve("Resolving");
}};

var p2 = Promise.resolve(thenable);
p2.then(function(v) {
  // not called
}, function(e) {
  console.log(e); // TypeError: Throwing
});

// Thenable throws after callback
// Promise resolves
var thenable = { then: function(resolve) {
  resolve("Resolving");
  throw new TypeError("Throwing");
}};

var p3 = Promise.resolve(thenable);
p3.then(function(v) {
  console.log(v); // "Resolving"
}, function(e) {
  // not called
});
