(function (){
    var $holder,$list,count,i;
    count=15;
    
    $holder=$('#holder');
    $holder.append('<h1>Header</h1>');

    $list=$('<ul/>');
    for( i = 0; i < count; i+= 1){
        $('<li>'+i+'</li>').appendTo($list);
    }
    $holder.prepend($list);
}());