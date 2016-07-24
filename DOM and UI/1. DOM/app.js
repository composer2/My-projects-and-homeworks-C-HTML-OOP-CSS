var liLive = document.getElementsByTagName('li');
var liStatic = document.querySelectorAll('li');

console.log(liLive);
console.log(liStatic);

var ul = document.getElementsByTagName('ul')[0];
ul.innerHTML += '<li>Koce</li>';

console.log(liLive);
console.log(liStatic);