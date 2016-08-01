/* globals module */
function solve() {

  function clear(node) {
    while (node.firstChild) {
      node.removeChild(node.firstChild);
    }
  }

   
  return  function createImagesPreviewer(selector, items) {
  //chech selector and items and length
  var root = document.querySelector(selector);
  clear(root);
  var fragment = document.createDocumentFragment();

  //create two div elements
  var imagePreviewer = document.createElement('div');
  imagePreviewer.style.display = 'inline-block';
  imagePreviewer.style.width = '75%';
  imagePreviewer.style.float = 'left';
  imagePreviewer.style.textAlign = 'center';



  var aside = document.createElement('div');
  aside.style.display = 'inline-block';
  aside.style.width = '25%';
  aside.style.textAlign = 'center';
  //aside.style.float='right';

  //create selected title and image
  var selectedParent = document.createElement('div');
  selectedParent.classList.add('image-preview');
  var selectedImageHeader = document.createElement('h3');
  selectedImageHeader.innerText = items[0].title;
  var selectedImage = document.createElement('img');
  selectedImage.src = items[0].url;
  selectedImage.style.width = '80%';
  selectedParent.appendChild(selectedImageHeader);
  selectedParent.appendChild(selectedImage);
  imagePreviewer.appendChild(selectedParent);


  //creat input form and header button
  var input = document.createElement('input');
  var inputHeader = document.createElement('h3');
  inputHeader.innerText = 'Filter';
  input.addEventListener('keyup', onInputFilter, false);

  //create list where to append all images
  var listOfItems = document.createElement('ul');
  listOfItems.style.listStyleType = 'none';
  listOfItems.style.height = '500px';
  listOfItems.style.overflowY = 'scroll';
  listOfItems.addEventListener('click', onButtonClick, false);
  listOfItems.addEventListener('mouseover', changeBackgroundOnMouseover, false);
  listOfItems.addEventListener('mouseout', changeBackgroundOnMouseout, false);
  //create li elements
  var li = document.createElement('li');
  li.classList.add('image-container');
  //create h3 for the image
  var imageHeader = document.createElement('h3');
  //create the image
  var image = document.createElement('img');
  image.style.width = '90%';
  for (var i = 0; i < items.length; i += 1) {

    var currentItem = items[i];
    var currentLi = li.cloneNode(true);

    var currentImageHeader = imageHeader.cloneNode(true);
    currentImageHeader.innerText = currentItem.title;

    var currentImage = image.cloneNode(true);
    currentImage.src = currentItem.url;

    currentLi.appendChild(currentImageHeader);
    currentLi.appendChild(currentImage);

    listOfItems.appendChild(currentLi);
  }


  aside.appendChild(inputHeader);
  aside.appendChild(input);
  aside.appendChild(listOfItems);

  fragment.appendChild(imagePreviewer);
  fragment.appendChild(aside);

  root.appendChild(fragment);

  function onButtonClick(ev) {
    var target = ev.target;
    if (target.tagName === 'IMG') {
      var header = target.previousElementSibling.innerText;
      var source = target.src;
      selectedImageHeader.innerText = header;
      selectedImage.src = source;
    }
  }
  function changeBackgroundOnMouseover(ev) {
    var target = ev.target;
    if (target.tagName === 'IMG') {
      target.parentElement.style.backgroundColor = 'lightgray';
      target.parentElement.style.cursor = 'pointer';
    }
  }
  function changeBackgroundOnMouseout(ev) {
    var target = ev.target;
    if (target.tagName === 'IMG') {
      target.parentElement.style.backgroundColor = 'white';
    }
  }

  function onInputFilter(ev) {
    var text = ev.target.value;
    var liChildren = listOfItems.getElementsByTagName('li');
    for (var i = 0; i < liChildren.length; i += 1) {
      var currentLi = liChildren[i];
      var header = currentLi.firstElementChild.innerText;

      if (header.toLowerCase().indexOf(text.toLowerCase()) >= 0) {
        currentLi.style.display = 'block';
      } else {
        currentLi.style.display = 'none';
      }
    }
  }
}
}
module.exports = solve;