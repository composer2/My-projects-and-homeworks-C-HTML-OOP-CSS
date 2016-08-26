(function (){
    function printMessage(text){
        $('#messages-list').append("<li>Message: "+text+"</li>");
    }
    var $specialItem=$('.special');
    printMessage($specialItem.html());
    printMessage($specialItem.next().html());
    printMessage($specialItem.prev().html());

    printMessage($specialItem.nextSibling);
}());