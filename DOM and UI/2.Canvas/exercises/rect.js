var canvas = document.getElementById('the-canvas');
var ctx = canvas.getContext('2d');

ctx.fillRect(50, 100, 75, 150);
ctx.strokeStyle = '#fff';
ctx.lineWidth = 5;
ctx.strokeRect(50, 100, 75, 150);