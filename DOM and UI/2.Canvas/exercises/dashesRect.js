var canvas = document.getElementById('the-canvas');
var ctx = canvas.getContext('2d');

ctx.strokeStyle = '#fff';
ctx.lineWidth = 5;
ctx.setLineDash([10]);

ctx.strokeRect(70, 70, 200, 200);