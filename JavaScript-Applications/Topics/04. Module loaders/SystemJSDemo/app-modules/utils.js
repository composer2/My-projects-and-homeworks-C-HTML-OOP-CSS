function clone(obj) {
    return JSON.parse(JSON.stringify(obj));
}

function* idGenerator(){
     let currId=0;

     while(true){
         yield currId;
         currId+=1;
     }
}

export {clone,idGenerator};