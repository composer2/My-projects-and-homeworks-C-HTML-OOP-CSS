window.onload = function () {
    var divs = document.getElementsByTagName('div');
    console.log(divs instanceof Array);
    console.log(divs instanceof HTMLCollection);
    console.log(divs[0] instanceof HTMLDivElement);
    console.log(divs instanceof HTMLElement);//select only one true/many false

    for (var i = 0; i < divs.length; i += 1) {
        console.log('div [' + i + '] = ' + divs[i]);
    }
};