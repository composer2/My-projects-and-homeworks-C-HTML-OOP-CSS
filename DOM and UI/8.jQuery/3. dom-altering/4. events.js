(function (){
    
        function printMessage(text) {
            $('#messages-list').append('<li>Message: <strong>' + text + '</strong></li>');
        }

        function onButtonClick() {
            $('.current').removeClass('current');
            $(this).addClass('current');
        }

        function onOptimizedButtonClick() {
            var message = $(this).text() + ' clicked';
            printMessage(message);
        }

        function onInputChange() {
            var message = 'Input value changed to ' + $(this).val();
            printMessage(message);
        }

        $(document).ready(function() {
            $('.button').on('click', onButtonClick);
            $('#tb-text').on('change', onInputChange);
           // $('ul.buttons-group').on('click', 'a', onOptimizedButtonClick);
        });
}());