window.onload = function() {
    var theCanvas = document.getElementById('the-canvas');
    var canvasCtx = theCanvas.getContext("2d");

    canvasCtx.lineWidth = "5";
    canvasCtx.fillStyle = "purple";
    canvasCtx.strokeStyle = "#777";

    canvasCtx.fillRect(100, 100, 200, 175);
    canvasCtx.strokeRect(10, 10, 100, 75);

    canvasCtx.fillStyle = "yellow";
    canvasCtx.strokeStyle = "#000";
    canvasCtx.beginPath();
    canvasCtx.arc(200, 187, 60, 0, 2 * Math.PI);
    canvasCtx.fill();
    canvasCtx.arc(60, 47, 30, 0, 2 * Math.PI);
    canvasCtx.stroke();
};