function solve() {
    return function (selector, isCaseSensitive) {
        var element = selector;

        if (typeof element === "string") {
            element = document.querySelector(element);
        }
        if (!element || !(element instanceof HTMLElement)) {
            throw new Error("Invalid HTML element or selector");
        }

        var fragment = document.createDocumentFragment();

        //first part add item
        var addControls = document.createElement("div");
        addControls.className = 'add-controls';

        var labelAddControls = document.createElement("label");
        labelAddControls.innerHTML = 'Enter text: ';

        var textBoxAddControls = document.createElement("input");
        textBoxAddControls.innerHTML = "Add";

        var buttonAddControls = document.createElement("a");
        buttonAddControls.innerHTML = 'Add';
        buttonAddControls.addEventListener("click", onAddButtonClick, false);
        buttonAddControls.className = 'button';
        buttonAddControls.style.display = 'inline-block';

        labelAddControls.appendChild(textBoxAddControls);
        addControls.appendChild(labelAddControls);
        addControls.appendChild(buttonAddControls);
        //append first part        
        fragment.appendChild(addControls);
        //event on the add button
        function onAddButtonClick(ev) {
            var valueToAdd = textBoxAddControls.value;
            textBoxAddControls.value = "";
            addTextStrong.innerHTML = valueToAdd;
            resultList.appendChild(listItems.cloneNode(true));
        }

        //second part search item
        var searchControls = document.createElement('div');
        searchControls.className = 'search-controls';

        var labelSearchControl = document.createElement('label');
        labelSearchControl.innerHTML = 'Search:';

        var textBoxSearchControl = document.createElement('input');
        textBoxSearchControl.addEventListener('input', onInputInTextbox, false);
        labelSearchControl.appendChild(textBoxSearchControl);
        searchControls.appendChild(labelSearchControl);
        //append second part
        fragment.appendChild(searchControls);
        //event on the searchBox

        var isCaseSensitiveOnOrOff = isCaseSensitive;
        function onInputInTextbox(params) {
            var i = 0,
                len,
                text,
                pattern = textBoxSearchControl.value;
            if (!isCaseSensitiveOnOrOff) {
                pattern = pattern.toLowerCase();
            }

            for (i = 0, len = ItemsList.length; i < len; i += 1) {
                text = ItemsList[i].getElementsByTagName("strong")[0].innerHTML;
                if (!isCaseSensitive) {
                    text = text.toLowerCase();
                }
                if (text.indexOf(pattern) < 0) {
                    ItemsList[i].style.display = "none";
                } else {
                    ItemsList[i].style.display = "";
                }
            }
        }

        //third part result
        var resultControls = document.createElement('div');
        resultControls.className = 'result-controls';

        var resultList = document.createElement('ul');
        resultList.className = 'items-list';
        resultList.addEventListener('click', removeElementFormList, false);


        var listItems = document.createElement('li');
        listItems.className = 'list-item';

        var deleteButton = document.createElement('a');
        deleteButton.className = 'button';
        deleteButton.innerHTML = 'X';

        addTextStrong = document.createElement('strong');

        listItems.appendChild(deleteButton);
        listItems.appendChild(addTextStrong);

        resultControls.appendChild(resultList);
        var ItemsList = document.getElementsByClassName('list-item');

        function removeElementFormList(ev) {
            var button = ev.target,
                parent;
            if (button.className.indexOf('button') < 0) {
                return;
            }
            parent = button;

            while (parent && parent.className.indexOf("list-item") < 0) {
                console.log(parent.nodeName);
                parent = parent.parentNode;
            }
            if (!parent) {
                return;
            }
            resultList.removeChild(parent);
        }

        //append third part
        fragment.appendChild(resultControls);

        element.className += 'items-control';
        element.appendChild(fragment);
    };
}