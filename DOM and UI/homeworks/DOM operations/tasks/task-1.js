/* globals $ */

/* 

Create a function that takes an id or DOM element and an array of contents

* if an id is provided, select the element
* Add divs to the element
  * Each div's content must be one of the items from the contents array
* The function must remove all previous content from the DOM element provided
* Throws if:
  * The provided first parameter is neither string or existing DOM element
  * The provided id does not select anything (there is no element that has such an id)
  * Any of the function params is missing
  * Any of the function params is not as described
  * Any of the contents is neight `string` or `number`
    * In that case, the content of the element **must not be** changed   
*/

module.exports = function () {

  return function (selector, contents) {
    var element,
      fragment,
      divNewElement,
      i,
      len,
      content;

    fragment = document.createDocumentFragment();
    len = contents.length;

if (typeof (selector) === 'string') {
      element = document.getElementById(selector);
      if (element === null) {
        throw new Error('The provided id does not select anything (there is no element that has such an id)');
      }
    } else {
      element = selector;
    }

    if (typeof (selector) !== 'string' && !(selector instanceof HTMLElement)) {
      throw new Error('The provided first parameter is neither string or existing DOM element!');
    }

    for (i = 0; i < len; i += 1) {
      content = contents[i];
      if (typeof (content) !== 'string' && typeof (content) !== 'number') {
        throw new Error('Any of the contents is neight `string` or `number`');
      }
      divNewElement = document.createElement('div');
      divNewElement.innerHTML = content;
      fragment.appendChild(divNewElement);
    }
    element.innerHTML = '';
    element.appendChild(fragment);
  };
};