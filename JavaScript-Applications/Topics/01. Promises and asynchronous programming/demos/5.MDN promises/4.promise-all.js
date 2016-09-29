// Promise.all passes an array of values from all the promises 
// in the iterable object that it was passed. The array of 
// values maintains the order of the original iterable object,
//  not the order that the promises were resolved in. 
//  If something passed in the iterable array is not a promise,
//   it's converted to one by Promise.resolve.

var p1 = Promise.resolve(3);
var p2 = 1337;
var p3 = new Promise((resolve, reject) => {
  setTimeout(resolve, 100, "foo");
}); 

Promise.all([p1, p2, p3]).then(values => { 
  console.log(values); // [3, 1337, "foo"] 
});

// Promise.all fail-fast behaviour
// Promise.all is rejected if one of the elements is rejected and 
// Promise.all fails fast: If you have four promises which resolve
//  after a timeout, and one rejects immediately, then Promise.all 
//  rejects immediately.
var p1 = new Promise((resolve, reject) => { 
  setTimeout(resolve, 1000, "one"); 
}); 
var p2 = new Promise((resolve, reject) => { 
  setTimeout(resolve, 2000, "two"); 
});
var p3 = new Promise((resolve, reject) => {
  setTimeout(resolve, 3000, "three");
});
var p4 = new Promise((resolve, reject) => {
  setTimeout(resolve, 4000, "four");
});
var p5 = new Promise((resolve, reject) => {
  reject("reject");
});

Promise.all([p1, p2, p3, p4, p5]).then(value => { 
  console.log(value);
}, reason => {
  console.log(reason);
});

//From console:
//"reject"