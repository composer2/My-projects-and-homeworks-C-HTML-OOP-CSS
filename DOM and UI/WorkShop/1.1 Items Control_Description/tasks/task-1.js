function solve() {
  return function (selector, isCaseSensitive) {
    var root = document.querySelector(selector);
    var mainDiv = document.createElement('div');
    mainDiv.className = 'items-control';

    var fragment = document.createDocumentFragment();
    //adding elements part
    var addControls = document.createElement('div');
    addControls.className = 'add-controls';
    var addControlsLabel = document.createElement('label');
    addControlsLabel.innerHTML = 'Enter text';
    var addControlsText = document.createElement('input');

    var addControlsButton = document.createElement('a');
    addControlsButton.className = 'button';
    addControlsButton.innerHTML = 'Add';
    addControlsButton.style.display = 'inline-block';

    addControls.appendChild(addControlsLabel);
    addControls.appendChild(addControlsText);
    addControls.appendChild(addControlsButton);
    //Search elements
    var searchControls = document.createElement('div');
    searchControls.className = 'search-controls';
    var searchControlsText = document.createElement('label');
    searchControlsText.innerHTML = 'Search:';
    var searchControlsInput = document.createElement('input');

    searchControls.appendChild(searchControlsText);
    searchControls.appendChild(searchControlsInput);

    //Result elements
    var resultControls = document.createElement('div');
    resultControls.className = 'result-controls';
    var resultControlsList = document.createElement('ul');
    resultControlsList.className = 'items-list';
    resultControls.appendChild(resultControlsList);

    resultControlsList.addEventListener('click', function (ev) {
      var targetLi = ev.target.parentElement;
      resultControlsList.removeChild(targetLi);
    }, false);

    var isCaseSensitiveOnOrOff = isCaseSensitive;
    searchControlsInput.addEventListener('input', function (ev) {
      var pattern = ev.target.value;
      if (!isCaseSensitiveOnOrOff) {
        pattern = pattern.toLowerCase();
      }
      var lis = resultControlsList.children;
      for (var i = 0; i < lis.length; i += 1) {
        var liText = lis[i].lastChild.innerHTML;
        if (!isCaseSensitiveOnOrOff) {
          liText = liText.toLowerCase();
        }
        if (liText.indexOf(pattern) < 0) {
          lis[i].style.display = 'none';
        } else {
          lis[i].style.display = "";
        }
      }
      //TODO  Typing in the `input` must refresh the contents of the element with class `result-controls`  
    }, false);

    addControlsButton.addEventListener('click', function (ev) {
      var inputText = ev.target.previousElementSibling.value;
      ev.target.previousElementSibling.value = '';
      var newLiItem = document.createElement('li');
      newLiItem.className = 'list-item';
      var textParagraph = document.createElement('p');
      textParagraph.innerHTML = inputText;
      textParagraph.className = 'add-controls';
      var buttonWithX = document.createElement('a');
      buttonWithX.className = 'button';
      buttonWithX.innerHTML = 'X';
      newLiItem.appendChild(buttonWithX);
      newLiItem.appendChild(textParagraph);
      resultControlsList.appendChild(newLiItem);
    }, false);


    mainDiv.appendChild(addControls);
    mainDiv.appendChild(searchControls);
    mainDiv.appendChild(resultControls);

    fragment.appendChild(mainDiv);
    root.appendChild(fragment);
  };
}

module.exports = solve;