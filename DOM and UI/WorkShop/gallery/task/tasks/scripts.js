/* globals $ */

function solve() {
$.fn.gallery = function (column) {
  column = column|| 4;
  var $gallery = $(this).addClass('gallery');
  var $selected = $gallery.find('.selected');
  var $galeryList = $gallery.find('.gallery-list');
  var $allImages = $galeryList.find('img');
  var $prevImage = $selected.find('#previous-image');
  var $currentImage = $selected.find('#current-image');
  var $nextImage = $selected.find('#next-image');
  var $disabled = $('<div />').addClass('disabled-background').appendTo($gallery);


  $allImages.each(function (index, image) {
    if (index % column === 0) {
      $(image).parent().addClass('clearfix');//.css( "clear", "both" ); if css style missing
    }
  });

  $galeryList.on('click', '.image-container', function () {
    var $clickedImg = $(this);
    var currIndex = $clickedImg.find('img').attr('data-info') - 1;
    var prevIndex = currIndex - 1;
    var $prev = $allImages.eq(prevIndex);
    var nextIndex = (currIndex + 1) % $allImages.length;
    var $next = $allImages.eq(nextIndex);
    $currentImage.attr('src', $clickedImg.find('img').attr('src')).attr('data-info', currIndex + 1);;
    $prevImage.attr('src', $prev.attr('src')).attr('data-info', prevIndex + 1);
    $nextImage.attr('src', $next.attr('src')).attr('data-info', nextIndex + 1);

    $galeryList.addClass('blurred');
    $selected.show();
    $disabled.show();
  });

  $currentImage.click(function () {
    $galeryList.removeClass('blurred');
    $selected.hide();
    $disabled.hide();
  });
  $prevImage.on('click', function () {
    var $clickedPrevImg = $(this);
    var currIndex = $clickedPrevImg.attr('data-info') - 1;
    var prevIndex = currIndex - 1;
    var nextIndex = (currIndex + 1) % $allImages.length;
    var $current = $allImages.eq(currIndex);
    var $prev = $allImages.eq(prevIndex);
    var $next = $allImages.eq(nextIndex);
    $currentImage.attr('src', $current.attr('src')).attr('data-info', currIndex + 1);;
    $prevImage.attr('src', $prev.attr('src')).attr('data-info', prevIndex + 1);
    $nextImage.attr('src', $next.attr('src')).attr('data-info', nextIndex + 1);
  });
  $nextImage.on('click', function () {
    var $clickedNextImg = $(this);
    var currIndex = $clickedNextImg.attr('data-info') - 1;
    var prevIndex = currIndex - 1;
    var nextIndex = (currIndex + 1) % $allImages.length;
    var $current = $allImages.eq(currIndex);
    var $prev = $allImages.eq(prevIndex);
    var $next = $allImages.eq(nextIndex);
    $currentImage.attr('src', $current.attr('src')).attr('data-info', currIndex + 1);;
    $prevImage.attr('src', $prev.attr('src')).attr('data-info', prevIndex + 1);
    $nextImage.attr('src', $next.attr('src')).attr('data-info', nextIndex + 1);
  });
  $disabled.hide();
  $selected.hide();
};
}
module.exports = solve;