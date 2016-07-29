window.onload=function () {
    var mainNav=document.querySelector('#main-nav'),
    navItems=mainNav.querySelectorAll('ul > li > a');

    for(var i = 0; i < navItems.length; i+= 1){
        console.log(navItems[i].innerHTML);
    }
};