(function () {
    function printDOM(msg) {
        document.getElementById('output').innerHTML += `<div>${msg}</div>`;
    }
    let url = '1-data.json';
    // //asynchronous callbacks
    // $.ajax({
    //     contentType:'application/json',
    //     url: url,
    //     success: function (data) {
    //         printDOM(data.name);
    //     }
    // });
    // $.ajax({
    //     contentType:'application/json',        
    //     url: '1-data2.json',
    //     success: function (data) {
    //         printDOM(data.name);
    //     }
    // });

    // //synchronous callbacks
    // $.ajax({
    //     contentType:'application/json',        
    //     url: url,
    //     success: function (data) {
    //         printDOM(data.name);
    //         $.ajax({
    //             url: '1-data2.json',
    //             success: function (data) {
    //                 printDOM(data.name);
    //             }
    //         });
    //     }
    // });

    //promises
    $.ajax({
        contentType: 'application/json',
        url: '1-data.json',
    }).success(function (data) {
        printDOM(data.name);
    });
    // //same promise with DONE
    // $.ajax({
    //     url: '1-data2.json',
    // }).done(function (data){
    //     printDOM(data.name);
    // });

    //standart promise
    $.ajax({
        contentType: 'application/json',
        url: '1-data2.json',
    })
        .then(
        function (data) {
            printDOM(data.name);
        },
        function (error) {
            printDOM(error);
        });
} ());