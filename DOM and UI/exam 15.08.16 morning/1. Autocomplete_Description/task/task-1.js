/* globals document, window, console */

function solve() {
    return function (selector, initialSuggestions) {

        var root = document.querySelector(selector);
        var fragment = document.createDocumentFragment();
        var listItems = root.getElementsByClassName('suggestions-list');

        if (initialSuggestions) {
            var arr = [];
            for (var i = 0; i < initialSuggestions.length; i += 1) {
                arr.push(initialSuggestions[i].toLowerCase());
            }
            initialSuggestions = arr.filter(function (elem, index, self) {
                return index == self.indexOf(elem);

            });
            for (var i = 0, len = initialSuggestions.length; i < len; i += 1) {
                var suggestions = initialSuggestions[i];
                var liItem = document.createElement('li');
                liItem.className += ' suggestion';
                liItem.style.display = 'none';
                var liButton = document.createElement('a');
                liButton.className += ' suggestion-link';
                liButton.href = '#';
                liButton.innerHTML = suggestions;
                liItem.appendChild(liButton);
                listItems[0].appendChild(liItem);
            }
        }


        var input = document.getElementsByClassName('tb-pattern');
        input[0].addEventListener('input', function (ev) {
            var pattern = (ev.target.value).toLowerCase();

            var allButtons = document.getElementsByClassName('suggestion-link');

            for (var k = 0, length = allButtons.length; k < length; k += 1) {
                var liText = (allButtons[k].innerHTML).toLowerCase();

                if (pattern === '') {
                    allButtons[k].parentElement.style.display = 'none';
                } else {

                    if (liText.indexOf(pattern) >= 0) {
                        allButtons[k].parentElement.style.display = 'block';
                    } else {
                        allButtons[k].parentElement.style.display = 'none';
                    }
                }
            }
        }, false);

        listItems[0].addEventListener('click', function (ev) {
            var targetText = ev.target.innerHTML;
            input[0].value = targetText;
        }, false);

        var addBtn = document.getElementsByClassName('btn-add');
        addBtn[0].addEventListener('click', function (ev) {

            var inputText = input[0].value;
            input[0].value = '';
            var liItem = document.createElement('li');
            liItem.className += ' suggestion';
            liItem.style.display = 'none';
            var liButton = document.createElement('a');
            liButton.className += ' suggestion-link';
            liButton.href = '#';
            liButton.innerHTML = inputText;
            liItem.appendChild(liButton);
            listItems[0].appendChild(liItem);
        }, false);
        var lis = document.getElementsByClassName('suggestion');
    };
}

module.exports = solve;