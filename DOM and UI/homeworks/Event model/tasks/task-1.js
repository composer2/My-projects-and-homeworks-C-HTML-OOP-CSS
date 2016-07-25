/* globals $ */

/* 

Create a function that takes an id or DOM element and:
  
    If an id is provided, select the element
    Finds all elements with class button or content within the provided element
        Change the content of all .button elements with "hide"
    When a .button is clicked:
        Find the topmost .content element, that is before another .button and:
            If the .content is visible:
                Hide the .content
                Change the content of the .button to "show"
            If the .content is hidden:
                Show the .content
                Change the content of the .button to "hide"
            If there isn't a .content element after the clicked .button and before other .button, do nothing
    Throws if:
        The provided DOM element is non-existant
        The id is neither a string nor a DOM element


*/

function solve() {
  return function (selector) {
    var selectedElement;
    var buttonElements;
    var contentElements;
    var i;
    var len;
    if (!(selector) && !(selector instanceof HTMLElement)) {
      throw new Error(' The id is neither a string nor a DOM element');
    }
    if (typeof (selector) === 'string') {
      selectedElement = document.getElementById(selector);
    } else {
      throw new Error('The provided DOM element is non-existant');
    }
    buttonElements = selectedElement.getElementsByClassName("button");
    contentElements = selectedElement.getElementsByClassName("content");
    len = buttonElements.length;
    for (i = 0; i < len; i += 1) {
      buttonElements[i].innerHTML = "hide";
    }

    selectedElement.addEventListener('click', OnButtonClickedEvent);

    function OnButtonClickedEvent(ev) {
      var clicked = ev.target;
      if (!clicked) {
        return;
      }
      if (clicked.className === "button") {
        if (clicked.innerHTML === "hide") {
          clicked.innerHTML = "show";
          while (clicked.className !== "content") {
            clicked = clicked.nextElementSibling;
            if (clicked === null) {
              return;
            }
          }
          clicked.style.display = 'none';
        } else {
          clicked.innerHTML = "hide";
          while (clicked.className !== "content") {
            clicked = clicked.nextElementSibling;
            if (clicked === null) {
              return;
            }
          }
          clicked.style.display = '';
        }
      }
    };
  };
};

module.exports = solve;