var canvas = document.getElementById('the-canvas');
var ctx = canvas.getContext('2d');

ctx.moveTo(100, 100);
ctx.lineTo(150, 350);
ctx.moveTo(100, 100);

ctx.bezierCurveTo(canvas.width, 0,
    canvas.width, canvas.height / 2,
    150, 350);
ctx.stroke();