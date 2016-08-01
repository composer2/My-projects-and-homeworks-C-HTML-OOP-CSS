function solve() {
    return function (selector) {
        if ($.type(selector) !== 'string' || !$(selector).length) {
            throw Error('Invalid selector!');
        }

        $selector = $(selector);
        $button = $(selector + ' .button');
        $button.text('hide');
        $content = $(selector + ' .content');

        $selector.on('click', '.button', showHide);

        function showHide() {
            $nextContent = $(this).nextAll('.content:first');

            if ($nextContent.next().hasClass('button')
                && !$(this).next().hasClass('button')) {
                if ($nextContent.css('display') === 'none') {
                    $nextContent.css('display', '');
                    $(this).text('hide');
                }
                else {
                    $nextContent.css('display', 'none');
                    $(this).text('show');
                }
            }
        }
    };
};