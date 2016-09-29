(function () {

    function printDOM(msg) {
        document.getElementById('output').innerHTML += `<div>${msg}</div>`;
    }

    let request = (function () {

        function send(url, options = {}) {
            let xhr = new XMLHttpRequest();

            xhr.open(options.verb = 'GET', url, true);

            xhr.onreadystatechange = function () {
                let statusType;
                if (xhr.readyState === 4) {
                    statusType = (xhr.status / 100) | 0;
                    switch (statusType) {
                        case 2:
                            if (typeof options.success === 'function') {
                                options.success(xhr.responseText);
                            }
                            break;
                        case 4:
                        case 5:
                            if (typeof options.error === 'function') {
                                options.error(xhr.responseText);
                            }
                            break;
                    }
                }
            };

            options.body = options.body || null;
            xhr.send(options.body);
        }

        return { send };
    } ());



    let url = "1-data.json";
    let url2 = "1-data2.json";
    
    request.send(url, {
        success: function (respond) {
            printDOM(respond);
            request.send(url2,{
                success:function (respond){
                    printDOM(respond);
                }
            });
        },
        error: function (error) {
            printDOM(error);
        }
    });
} ());