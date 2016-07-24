var canvas = document.getElementById('the-canvas');
var ctx = canvas.getContext('2d');

var i = 0,
    count = 100;
ctx.strokeStyle = 'white';
for (var i = 0; i < count; i++) {
    ctx.fillRect(i * 5, i * 3.5, 50, 100);
    ctx.strokeRect(i * 5, i * 3.5, 50, 100);
}

var imageData = ctx.getImageData(50, 50, 100, 100);

var data = imageData.data;
for (var i = 0; i < data.length; i += 4) {
    data[i] = 0;
    data[i + 1] = 0;
    data[i + 2] = 0;
}
ctx.putImageData(imageData, 50, 50);