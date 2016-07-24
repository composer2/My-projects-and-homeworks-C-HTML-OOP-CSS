var canvas = document.getElementById('the-canvas');
var ctx = canvas.getContext('2d');

ctx.beginPath();

ctx.moveTo(100, 150);
ctx.lineTo(250, 150);

ctx.quadraticCurveTo(100, 500, 250, 450);

ctx.stroke();