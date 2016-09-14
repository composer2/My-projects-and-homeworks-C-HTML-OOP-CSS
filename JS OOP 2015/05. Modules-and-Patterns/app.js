function getRandomEx(){
    var exception=[
        'var f;f();',
        'f()',
        'function(){}'
    ];
    var index=(Math.random()*exception.length)|0;
    console.log(eval(exception[index])+" hallo");
}
getRandomEx();