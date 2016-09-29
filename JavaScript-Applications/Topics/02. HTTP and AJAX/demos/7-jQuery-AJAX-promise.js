(function () {
    function printDOM(msg) {
        document.getElementById('output').innerHTML += `<div>${msg}</div>`;
    }

    function getData() {
        var promise = new Promise(function (resolve, reject) {
            return $.ajax({
                contentType:'application/json',
                url: '1-data2.json',
                success:function (data){
                    resolve(data);
                }
            });
        });
        return promise;
    }
    getData()
        .then(function (data) {
            printDOM(data.age);
        });
} ());