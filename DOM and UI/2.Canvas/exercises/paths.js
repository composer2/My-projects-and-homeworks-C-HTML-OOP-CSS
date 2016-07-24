var canvas = document.getElementById('the-canvas');
var ctx = canvas.getContext('2d');

ctx.beginPath();

ctx.moveTo(0, 0);
ctx.lineTo(50, 70);

ctx.lineTo(50, 170);
ctx.lineTo(250, 150);

//ctx.moveTo(250, 100);
//ctx.lineTo(50, 70);

ctx.fill();
ctx.strokeStyle = "white";
ctx.lineWidth = 5;

ctx.closePath(); //close the path from last to first point

ctx.stroke();