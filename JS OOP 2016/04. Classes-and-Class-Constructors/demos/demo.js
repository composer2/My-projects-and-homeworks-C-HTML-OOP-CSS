class Point2D {
    constructor(x, y) {
        this._x = x;
        this._y = y;
    }

    static get ZERO() {
        return new Point2D(0, 0);
    }

    static getDistance(pointA, pointB) {
        const sqrDistance = 
                (pointA._x - pointB._x) * (pointA. _x - pointB._x) + 
                (pointA._y - pointB._y) * (pointA. _y - pointB._y);
        return Math.sqrt(sqrDistance);
    }
}
let point1=new Point2D(2,2);
let point2=new Point2D(3,5); 

console.log( Point2D.getDistance(point2,Point2D.ZERO));