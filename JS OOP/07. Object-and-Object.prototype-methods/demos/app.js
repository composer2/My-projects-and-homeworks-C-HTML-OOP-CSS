(function () {
    var o,
        obj = {
            prop: function () {

            },
            foo: 'bar'
        };
    console.log(obj.foo);
    obj.foo = 'baz';
    console.log(obj.foo);

    obj.jump = 'jumpy';
    delete obj.prop;
    console.log(obj.jump);

    o = Object.seal(obj);
    console.log(o === obj);
    console.log(Object.isSealed(obj));

    obj.foo = 'opa';
    console.log(obj.foo);

    //obj.duck = 'the friendly duck';
    //console.log(obj.duck);
    delete obj.foo;
    console.log(obj);

    function fail(){
        'use strict';
        delete obj.foo;
        obj.spark='spark';
    }
    //fail();
//Object.defineProperty(obj, 'ohai', {value: 17}); // throws a TypeError
    Object.defineProperty(obj, 'foo', {value: 'eit'}); // changes existing property value
    console.log(obj.foo);
} ());