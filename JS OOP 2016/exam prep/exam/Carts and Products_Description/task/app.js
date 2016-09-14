/* globals require console*/

"use strict";

let { ShoppingCart, Product } = require("./task-2")();

let sc = new ShoppingCart();


let p1 = new Product("Type 1", "Pr 1", 2);
let p2 = new Product("Type 1", "Pr 1", 2);
let p3 = new Product("Type 1", "Pr 1", 3);
let p4 = new Product("Type 1", "Pr 1", 2);
let p5 = new Product("Type 1", "Pr 1", 1);
let p6 = new Product("Type 1", "Pr 2", 6);
let p7 = new Product("Type 1", "Pr 2", 4);

sc.add(p1).add(p2).add(p3).add(p4).add(p5).add(p6).add(p7);

//console.log(sc);
 //console.log(sc.showCost());
 //console.log(sc);
 //console.log(sc.showProductTypes());

 console.log(sc.getInfo());

// sc.remove(p);