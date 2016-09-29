    var dropBomb=(function (){
        return function (){
            setTimeout(function (){
          document.getElementById('bomb').innerHTML='BooM';      
            },3000);
        };
    }());
    document.getElementById ('drop-bomb').onclick=dropBomb;