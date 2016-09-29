(function () {

    function printDOM(msg) {
        document.getElementById('output').innerHTML += `<div>${msg}</div>`;
    }

    let xhr = new XMLHttpRequest();

    let url = "1-data.json";

    xhr.open('GET', url, true);

    xhr.onreadystatechange = function () {
        if (xhr.readyState === 4) {
            printDOM('Request completed');

            let status = Math.floor(xhr.status / 100);

            switch (status) {
                case 2:
                    //parse the result from text to JSON obj so we can handle props
                    let body = JSON.parse(xhr.responseText);
                    printDOM(body.name); break;
                case 4:
                case 5:
                    printDOM(xhr.responseText); break;

            }
        }

        //printDOM(xhr.readyState);
    };

    xhr.send(null);
} ());