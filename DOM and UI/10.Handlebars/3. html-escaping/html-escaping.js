(function () {
'use strict';
var obj={
    htmlString:"<h1>This is heading</h1>",
    escapedHtmlString:new Handlebars.SafeString('<h1>This is heading</h1')
},
templateHTML=document.getElementById('template').innerHTML,
template=Handlebars.compile(templateHTML);
document.getElementById('root').innerHTML=template(obj);


} ());