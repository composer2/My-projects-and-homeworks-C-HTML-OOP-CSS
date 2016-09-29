(function () {

    function printDOM(msg) {
        document.getElementById('output').innerHTML += `<div>${msg}</div>`;
    }

    let xhr = new XMLHttpRequest();

    let url = "1-data.json";

    xhr.open('GET', url, true);

    xhr.onreadystatechange = function () {
        if (xhr.readyState===4) {
            printDOM('Request completed');
        }
        
        //printDOM(xhr.readyState);
    };

    xhr.send(null);
} ());