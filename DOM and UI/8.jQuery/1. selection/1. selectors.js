(function () {

    function printContent(text) {
        $('#message-list').append('<li>Message: <strong>' + text + '</strong></li>');
    }
    var $item=$('ul li');
    printContent($item.length);
    printContent($('.widget').text());
} ());