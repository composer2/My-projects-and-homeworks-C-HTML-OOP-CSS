var p1 = new Promise(function(resolve, reject) {
  resolve('Success');
});
////A

// p1.then(function(value) {
//   console.log(value); // "Success!"
//   throw 'oh, no!';
// }).catch(function(e) {
//   console.log(e); // "oh, no!"
// }).then(function(){
//   console.log('after a catch the chain is restored');
// }, function () {
//   console.log('Not fired due to the catch');
// });

//B

// The following behaves the same as above
p1.then(function(value) {
  console.log(value); // "Success!"
  return Promise.reject('oh, no!');
}).catch(function(e) {
  console.log(e); // "oh, no!"
}).then(function(){  
  console.log('after a catch the chain is restored');
}, function () {
  console.log('Not fired due to the catch');
});

////C

// // Throwing an error will call the catch method most of the time
// var p1 = new Promise(function(resolve, reject) {
//   throw 'Uh-oh!';
// });

// p1.catch(function(e) {
//   console.log(e); // "Uh-oh!"
// });

// // Errors thrown inside asynchronous functions will act like uncaught errors
// var p2 = new Promise(function(resolve, reject) {
//   setTimeout(function() {
//     throw 'Uncaught Exception!';
//   }, 1000);
// });

// p2.catch(function(e) {
//   console.log(e); // This is never called
// });

// // Errors thrown after resolve is called will be silenced
// var p3 = new Promise(function(resolve, reject) {
//   resolve();
//   throw 'Silenced Exception!';
// });

// p3.catch(function(e) {
//    console.log(e); // This is never called
// });