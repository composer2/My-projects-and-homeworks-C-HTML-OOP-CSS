(function () {
    function printDOM(msg) {
        document.getElementById('output').innerHTML += `<div>${msg}</div>`;
    }

    let url = 'some.html';
    //load file form location with jquery
    //load has a success callback 
    $('.container').load(url, function () {
        $('#it-works').on('mouseover', function () {
            $(this).css('background', 'blue');
        });

        $('#it-works').on('mouseout', function () {
            $(this).css('background', 'white');
        });
    });
} ());