window.onload = function() {
    var hiddenDiv = document.createElement('div'),
        count = 1000,
        containerDiv = document.createElement('div'),
        i,
        finalDiv = document.createElement('div');
    hiddenDiv.classList.add('hidden');
    for (i = 0; i < count; i++) {
        containerDiv.appendChild(hiddenDiv.cloneNode(true));
    }
    for (i = 0; i < count; i += 1) {
        finalDiv.appendChild(containerDiv.cloneNode(true));
    }
    document.getElementById('content').appendChild(finalDiv);
};

function regularLoop(elements) {
    var i,
        el;
    for (i = 0; i < elements.length; i++) {
        el = elements[i];
    }
}

function cachedLengthLoop(elements) {
    var i,
        el;
    for (i = 0, len = elements.length; i < len; i++) {
        el = elements[i];
    }
}

function onStartTestButtonClick() {
    var divs = document.getElementsByClassName('hidden'),
        startTime,
        endTime;
    //measure the regular iteration
    startTime = new Date();
    regularLoop(divs);
    endTime = new Date();
    output.innerHTML += '<p>Legular loop executed in ' + (endTime - startTime) + '</p>';
    //measure the iteration with cached length
    startTime = new Date();
    cachedLengthLoop(divs);
    endTime = new Date();
    output.innerHTML += '<p>Loop with cached length executed in ' + (endTime - startTime) + '</p>';
}