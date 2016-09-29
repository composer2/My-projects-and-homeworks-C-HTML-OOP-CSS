// The then() method returns a Promise. It takes two arguments:
// callback functions for the success and failure cases of the Promise.

var p1 = new Promise(function(resolve, reject) {
  resolve("Success!");
  // or
  // reject ("Error!");
});

p1.then(function(value) {
  console.log(value); // Success!
}, function(reason) {
  console.log(reason); // Error!
});

//Chaining
var p2 = new Promise(function(resolve, reject) {
  resolve(1);
});

p2.then(function(value) {
  console.log(value); // 1
  return value + 1;
}).then(function(value) {
  console.log(value); // 2
});

p2.then(function(value) {
  console.log(value); // 1
});

//You can also use chaining to implement one function 
//with a Promise-based API on top of another such function.

function fetch_current_data() {
  // The fetch() API returns a Promise.  This function
  // exposes a similar API, except the fulfillment
  // value of this function's Promise has had more
  // work done on it.
  return fetch("current-data.json").then((response) => {
    if (response.headers.get("content-type") != "application/json") {
      throw new TypeError();
    }
    var j = response.json();
    // maybe do something with j
    return j; // fulfillment value given to user of
              // fetch_current_data().then()
  });
}