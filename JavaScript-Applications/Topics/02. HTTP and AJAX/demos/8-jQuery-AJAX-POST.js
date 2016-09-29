(function (){
    function printDOM(msg) {
        document.getElementById('output').innerHTML += `<div>${msg}</div>`;
    }
    let url='1-data2.json';

//to catch an error we have to use promises .error or .fail
    $.getJSON(url,function (data){
       printDOM(data.isCool); 
    }).error(function (err){  //.fail
        alert('BiG FAT ERROR');
    });
}());