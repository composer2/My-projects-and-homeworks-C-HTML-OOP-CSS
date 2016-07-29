window.onload=function () {  
    var divs = document.getElementsByTagName('div');
    
    var queryDivs = document.querySelectorAll('div');

    var newDiv = document.createElement('div');
    newDiv.innerHTML = 'Im newbie';

    var button=document.getElementsByTagName('a')[0];
    button.addEventListener('click', addDiv, false);
    
    function addDiv() {
        document.body.appendChild(newDiv.cloneNode(true));
        console.log('getElementsByTagName(\"div\") = ' + divs.length);
        console.log('querySelectorAll(\"div\") = ' + queryDivs.length);
    }
};
