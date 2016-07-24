(function name(params) {
    var canvas = document.getElementById("the-canvas"),
        ctx = canvas.getContext("2d"),
        text = 'Telerik Academy',
        x = 50,
        y = 50,
        minFontSize = '28',
        fontFamily = 'Arial',
        fillColor = 'yellowgreen',
        strokeColor = '#003311',

        currentFontSize = 48,
        offset = 5;

    ctx.fillStyle = 'yellowgreen';
    ctx.strokeStyle = '#003311';

    while (minFontSize <= currentFontSize) {
        ctx.font = currentFontSize + 'px ' + fontFamily;
        ctx.fillText(text, x, y);
        ctx.strokeText(text, x, y);
        y += currentFontSize + offset;
        currentFontSize -= 4;
    }
}());