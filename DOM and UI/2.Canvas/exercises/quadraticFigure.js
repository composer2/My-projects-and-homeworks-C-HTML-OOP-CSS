var canvas = document.getElementById('the-canvas');
var ctx = canvas.getContext('2d');

function quadraticCurve(ctx, s1, s2, c) {
    ctx.beginPath();
    ctx.moveTo(s1.x, s2.y);
    ctx.quadraticCurveTo(c.x, c.y, s2.x, s2.y);
    ctx.stroke();
}
var s1 = {
    x: 10,
    y: 340
};
var s2 = {
    x: 450,
    y: 340
};
var i = 0;

function anim() {
    ctx.clearRect(0, 0, canvas.width, canvas.height);
    var c = {
        x: i * 5,
        y: 0
    };
    i += 1;
    quadraticCurve(ctx, s1, s2, c);
    requestAnimationFrame(anim);
    //setTimeout(anim, 100);
}

anim();