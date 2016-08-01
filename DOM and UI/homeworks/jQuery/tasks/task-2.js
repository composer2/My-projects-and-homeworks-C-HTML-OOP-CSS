/* globals $ */

/*
Create a function that takes a selector and:
* Finds all elements with class `button` or `content` within the provided element
  * Change the content of all `.button` elements with "hide"
* When a `.button` is clicked:
  * Find the topmost `.content` element, that is before another `.button` and:
    * If the `.content` is visible:
      * Hide the `.content`
      * Change the content of the `.button` to "show"       
    * If the `.content` is hidden:
      * Show the `.content`
      * Change the content of the `.button` to "hide"
    * If there isn't a `.content` element **after the clicked `.button`** and **before other `.button`**, do nothing
* Throws if:
  * The provided ID is not a **jQuery object** or a `string` 

*/
function solve() {
  return function (selector) {
    var $selector;

    if (typeof (selector) === 'string') {
      $selector = $(selector);
    } else {
      throw new Error('No such element');
    }
    if ($selector === null || $selector.length === 0) {
      throw new Error('Invalid selector');
    }
    var listButtons = $selector.find('.button');
    if (listButtons.length === 0) {
      return;
    }

    $('.button').on("click", function () {
     var button=$(this);
      if (($(this).next( ".button" ).length>0)) {
        $(this).first().html($(this).first().html().replace('hide', 'show'));
        $(this).next( ".button" ).css( "display", "none" );
        if ($(".button").next('.content').length===0) {
        $(this).next( ".button" ).css( "display", "none" );          
        }
      } else if (($(this).next( ".button" ).length>0)) {
        $(this).first().html($(this).first().html().replace('show', 'hide'));
          $(this).next( ".button" ).css( "display", "" );        
        if ($(this).children().length === 0) {
          $(this).next( ".button" ).css( "display", "" );
        }
      }
    });
    listButtons.each(function () {
      $(this).prepend('hide');
    });

  };
};

module.exports = solve;