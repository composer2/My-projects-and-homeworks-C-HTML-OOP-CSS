(function () {
    //- Write script that shows a message in a popup `<div>` and after 2 seconds redirects to a different site.
    //- Use `setTimeout` within a `Promise
var body=document.getElementById('body');
body.style.background='pink';
    function popUp() {
        return new Promise(function (resolve, reject) {
            setTimeout(function () {
                resolve(showMessage);
                reject(error);
            }, 2000);
        });
    }

    function showMessage() {
        var popup = document.getElementById("pop-up");
        popup.innerHTML = "<p id='text'>I am a pop up<br/>We are going to Telerik Academy page</p>";
        popup.style.borderStyle = "solid";
        popup.style.borderRadius = "20px";
        popup.style.width = "200px";
        popup.style.height = "200px";
        popup.style.position = 'absolute';
        popup.style.left = '25%';
        popup.style.top = '25%';
        popup.style.zIndex = 99999;
        popup.style.fontSize = "30px";
        popup.style.textAlign = 'center';
        popup.style.fontWeight = 'bold';
        popup.style.background = 'lightgreen';

        var text = document.getElementById('text');
        text.style.paddingTop = '10px';
    }
    function redirectLink() {
        window.location = "http://www.telerikacademy.com";
    }
    function error() {
        console.log("Server is not responding");
    }


    popUp()
        .then(showMessage)
        .then(redirectLink)
        .catch(error);
} ());