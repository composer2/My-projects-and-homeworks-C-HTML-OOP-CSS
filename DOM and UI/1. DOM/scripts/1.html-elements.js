window.onload = function () {

    var ninjaImg = document.getElementById('ninja-image');
    ninjaImg.src = "images/telerik-ninja.jpg";
    ninjaImg.width = 200;

    var isVisibleNinja = true,
        update = -1,
        times = 20;

    function animFrame() {
        if (isVisibleNinja) {
            ninjaImg.width = 0;
        } else {
            ninjaImg.width = 400;
        }
        isVisibleNinja = !isVisibleNinja;

        ninjaImg.width = (20 - times) * 50;
        times += update;
        if (times === 0) {
            update *= -1;
        } else if (times === 20) {
            update *= -1;
        }
        requestAnimationFrame(animFrame);
    }
    animFrame();
};