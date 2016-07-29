window.onload = function () {
    var mainNav = document.querySelector('#main-nav');
    var navItems = document.querySelectorAll('#main-nav ul > li > a');
    for (var i = 0; i < navItems.length; i += 1) {
        console.log(navItems[i].innerHTML);
    }
};