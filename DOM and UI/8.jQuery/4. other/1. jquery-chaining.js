(function () {
    function onSuccessButtonClick(ev) {
        $('#success-list').append(
            $('<li />')
                .addClass('success-item')
                .html('success')
        );
    }
    
    $('<button />')
    .addClass('btn-success')
    .html('Click for success')
    .on('click',onSuccessButtonClick)
    .prependTo(document.body);
} ());