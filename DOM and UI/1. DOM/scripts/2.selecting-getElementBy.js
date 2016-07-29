window.onload = function () {
    var mainNav = document.getElementById('main-nav');
    console.log('mainNav.innerHTML ' + mainNav.innerHTML);
    //console.log(mainNav.innerText);
    console.log('---------------------------------------------------------');

    var ul = mainNav.getElementsByTagName('ul')[0];
    console.log('ul.innerHTML ' + ul.innerHTML);
    //console.log(ul.innerText);
    console.log('---------------------------------------------------------');

    var navItems = ul.getElementsByTagName('li');
    for (var i = 0; i < navItems.length; i += 1) {
        console.log('navItems.innerHTML ' + navItems[i].innerHTML.trim());
        //console.log('navItems.innerText ' + navItems[i].innerText);
    }
    console.log('---------------------------------------------------------');
    var navButtons = ul.getElementsByTagName('a');
    for (i = 0; i < navButtons.length; i += 1) {
        console.log('navButtons.innerHTML ' + navButtons[i].innerHTML);
        //console.log('navButtons.innerText '+navButtons.innerText);
    }
    console.log('---------------------------------------------------------');

};