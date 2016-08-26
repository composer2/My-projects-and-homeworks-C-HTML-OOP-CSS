(function (){
    function printMessage(text){
        $('#messages-list').append('<li>Message: '+text+'</li>');
    }
    var $specialItem=$('.special');
    
    printMessage("first: "+$specialItem.text());
    printMessage("parent id: "+$specialItem.parent().attr('id'));
    printMessage('div id: '+$specialItem.parents('div').attr('id'));
    printMessage('wrapper id: '+$specialItem.parents('#wrapper').attr('id'));
    printMessage('#items-list children count: '+$("#items-list").children().length);   
}());