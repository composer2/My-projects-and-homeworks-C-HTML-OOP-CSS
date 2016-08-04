(function () {
    function getPost(count) {
        var posts,
            i;
        count = count || 10;
        posts = [];
        for (i = 0; i < count; i += 1) {
            posts.push({
                id: i + 1,
                title: 'Post #' + (i + 1),
                author: {
                    name: 'Author #' + (i + 3)
                }
            });
        }
        return posts;
    }
    var postTemplate = Handlebars.compile(document.getElementById('posts-list-template').innerHTML);
    document.getElementById('posts').innerHTML = postTemplate({
        posts: getPost(10)
    });
} ());