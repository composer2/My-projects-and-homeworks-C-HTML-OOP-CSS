var canvas = document.getElementById('the-canvas');
var ctx = canvas.getContext('2d');

ctx.fillRect(100, 100, 100, 100);
ctx.fillStyle = 'white';
ctx.save(); //save current state
ctx.scale(1.75, 0.5);
//scale се натрупва

ctx.fillRect(100, 100, 100, 100);
ctx.restore(); //restore state at save
ctx.fillRect(100, 210, 100, 100);