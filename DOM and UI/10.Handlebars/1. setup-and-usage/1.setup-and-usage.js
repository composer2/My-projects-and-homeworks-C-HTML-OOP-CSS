(function () {
    var post,
        postTemplateHTML,
        postTemplate;
    post = {
        title: 'Creating templates with HandleBars.js',
        content: 'Creating templates with HandleBars.js is prety easy and intuitive, HandleBars support <strong>one-way data binding</strong>and defines dynamic HTML'
    };
    postTemplateHTML = document.getElementById('post-template').innerHTML;

    postTemplate = Handlebars.compile(postTemplateHTML);

document.getElementById('root').innerHTML=postTemplate(post);
} ());