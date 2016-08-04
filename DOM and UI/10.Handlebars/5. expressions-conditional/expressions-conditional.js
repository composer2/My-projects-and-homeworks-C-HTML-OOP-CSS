(function () {
    function getPost(count) {
        var posts, post, i;
        count = count || 10;
        posts = [];
        for (i = 0; i < count; i += 1) {
            post = {
                id: i + 1,
                title: "Post #" + (i + 1)
            };
            if (i % 3) {
                post.author = 'Author #' + (i + 3);
            }
            posts.push(post);
        }
        return posts;
    }
    var posts = getPost(15);

    var postTemplate = Handlebars.compile(document.getElementById('posts-list-template').innerHTML);
    document.getElementById('posts').innerHTML = postTemplate({ 
        posts: posts 
    });

} ());