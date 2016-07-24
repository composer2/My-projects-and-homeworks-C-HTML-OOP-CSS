var canvas = document.getElementById('the-canvas');
var ctx = canvas.getContext('2d');

ctx.beginPath();
var x = 100,
    y = 100,
    r = 75;
ctx.moveTo(x + r, y);
ctx.arc(x, y, r, 0, 2 * Math.PI);
ctx.stroke();

ctx.beginPath();
var x = 300,
    y = 100,
    r = 75;
ctx.moveTo(x + r, y);
ctx.arc(x, y, r, 0, 1.5 * Math.PI);
ctx.stroke();

ctx.beginPath();
var x = 100,
    y = 300,
    r = 75;
ctx.moveTo(x + r, y);
ctx.arc(x, y, r, 0, 1.5 * Math.PI, true); //draw counterclockwise
ctx.lineTo(x + r, y);
ctx.stroke();
//ctx.fill();

ctx.beginPath();
var x = 300,
    y = 300,
    r = 75;
ctx.moveTo(x, y);
ctx.arc(x, y, r, 0, 1.5 * Math.PI, true); //draw counterclockwise
ctx.closePath();
ctx.stroke();
//ctx.fill();