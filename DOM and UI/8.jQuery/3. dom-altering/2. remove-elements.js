(function () {
    var i,
        count=64,
        $list;
    $list = $('#items-list');

    for( i = 0; i < count; i+= 1){
        $list.append('<li>Item #'+i+'</li>');
    }

    $('#delete-even').on('click',function (){
       $list.find('li:even').remove(); 
    });

    $('#fade-button').on('click',function (){
       $list.fadeOut(3000);
       $list.fadeIn(3000);       
    });

    $('#animate-button').on('click',function (){
       $list.animate({
           height:'toggle',
       },4000,function (){
          //anim completed 
       }); 
    });
} ());