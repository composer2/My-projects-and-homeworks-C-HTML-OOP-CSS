var arrObj={
    length:3,
    '0':'One',
    '1':'Two',
    '2':'Three'
};

var arr=Array.prototype.slice.call(arrObj);
console.log(arr);

var person={
    init:function (name,age){
        this.name=name;
        this.age=age;
        return this;
    },
    introduce:function (){
        console.log('Hello I am '+this.name+' and I am '+this.age+' years old.');
    }
};

var snoopy={
    name:'Snoopy',
    age:21
};

var peshoPeshev=Object.create(person).init('Pesho Peshev',18);
peshoPeshev.introduce();
person.introduce.call(snoopy);