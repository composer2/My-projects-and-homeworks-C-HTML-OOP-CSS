var stage = new Kinetic.Stage({
    container: 'container',
    width: 500,
    height: 350
});

var points = [];
var grass = 50;
for (var i = 0; i <= stage.getWidth(); i += 50) {
    //x
    //y
    points.push(i);
    points.push(300 + grass);
    grass *= -1;
}
var layer = new Kinetic.Layer();
var bgLayer = new Kinetic.Layer();

bgLayer.add(new Kinetic.Line({
    points: points,
    fill: 'green',
    stroke: 'green',
    closed: true
}));


var rect = new Kinetic.Rect({
    x: 0,
    y: 150,
    width: 200,
    height: 150,
    fill: 'blue',
    stroke: '#ccc'
});

function animFrame() {
    rect.setX(rect.getX() + 5);
    layer.draw();
    requestAnimationFrame(animFrame);
}

layer.add(rect);

stage.add(layer);
stage.add(bgLayer);

animFrame();