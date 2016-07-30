/* globals $ */

/* 
Create a function that takes a selector and COUNT, then generates inside a UL with COUNT LIs:   
  * The UL must have a class `items-list`
  * Each of the LIs must:
    * have a class `list-item`
    * content "List item #INDEX"
      * The indices are zero-based
  * If the provided selector does not selects anything, do nothing
  * Throws if
    *ready COUNT is a `Number`, but is less than 1
    *ready COUNT is **missing**, or **not convertible** to `Number`
      * _Example:_
        * Valid COUNT values:
          * 1, 2, 3, '1', '4', '1123'
        * Invalid COUNT values:
          * '123px' 'John', {}, [] 
*/



function solve() {
  return function (selector, count) {
    count = +count;
    var $selector;

    if (typeof (count) !== 'number' || count < 1 || (!count)) {
      throw new Error("COUNT is **missing**, or **not convertible** to `Number");
    }

    if (typeof (selector) === 'string') {
      $selector = $(selector);
    } else {
      throw new Error('No such element');
    }
    if ($selector === null) {
      throw new Error('Invalid selector');
    }

    var $ulList = $('<ul/>')
      .addClass(`items-list`)
      .appendTo($selector);
    for (var index = 0; index < count; index += 1) {
      $('<li>' + 'List item #' + index + '</li>')
        .addClass(`list-item`)
        .appendTo($ulList);
    }
  };
};

module.exports = solve;