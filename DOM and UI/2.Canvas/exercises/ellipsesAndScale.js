var canvas = document.getElementById('the-canvas');
var ctx = canvas.getContext('2d');
ctx.save();
ctx.beginPath();
ctx.scale(0.5, 1);
ctx.arc((1 / 0.5) * 100, 100, 75, 0, 2 * Math.PI);
//the real center point 100-100
ctx.lineWidth = 5;
ctx.stroke();
ctx.restore();

ctx.save();
ctx.beginPath();
ctx.scale(0.5, 1);
ctx.arc((1 / 0.5) * 310, 100, 75, 0, 2 * Math.PI);
ctx.fillStyle = "white";
ctx.fill();
ctx.restore();