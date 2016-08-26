var Shapes = (function () {
    var Shape = (function () {
        function MyShape(x, y) {
            this._x = x;
            this._y = y;
        }

        MyShape.prototype = {
            serialize: function () {
                var serializedShape = {
                    x: this._x,
                    y: this._y
                };
                return serializedShape;
            }
        };
        return MyShape;
    } ());

    var Rect=(function (){
        function MyRect(x,y,width,height){
            Shape.call(this,x,y);
            this._width=width;
            this._height=height;
        }

        MyRect.prototype=Object.create(Shape.prototype);

        MyRect.prototype.serialize=function (){
            var serializedRect=Shape.prototype.serialize.call(this);
            serializedRect.width=this._width;
            serializedRect.height=this._height;
            return serializedRect;
        };
        return MyRect;
    }());
    return{
        Shape:Shape,
        Rect:Rect
    };

} ());
var shape=new Shapes.Shape(5,10);
var rect=new Shapes.Rect(10,14,30,50);

console.log(shape.serialize());
console.log(rect.serialize());