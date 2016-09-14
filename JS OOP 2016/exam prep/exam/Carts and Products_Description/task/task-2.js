/* globals module */

"use strict";

function solve() {
    let validate = {
        validateIfObject: function (value, name = 'Value') {
            if (typeof value !== 'object') {
                throw new Error(' must be an object');
            }
        },
        validateIfNumber: function (value, name = 'Value') {
            value = +value;
            if (isNaN(value)) {
                throw new Error(' must be a number');
            }
            if (typeof value !== 'number') {
                throw new Error(' must be a number');
            }
        },
        validateIfUndefined: function (value, name = 'Value') {
            if (value === undefined) {
                throw new Error(" cannot be an empty string");
            }
        },
        validateString: function (value, name = "Value") {
            this.validateIfUndefined(value, name);
            if (typeof value !== 'string') {
                throw new Error(' must be string');
            }
        },

    };

    class Product {
        constructor(productType, name, price) {
            this.productType = productType;
            this.name = name;
            this.price = price;
            return this;
        }
        get name() {
            return this._name;
        }
        set name(value) {
            validate.validateString(value);
            this._name = value;
        }

        get price() {
            return this._price;
        }
        set price(value) {
            validate.validateIfNumber(value);
            this._price = +value;
        }
        get productType() {
            return this._productType;
        }
        set productType(value) {
            validate.validateString(value);
            this._productType = value;
        }
    }

    function indexOfElementWithIdInCollection(collection, name, price, productType) {
        let i, len;
        for (i = 0, len = collection.length; i < len; i += 1) {
            if (collection[i].name === name && collection[i].price === price && collection[i].productType === productType) {
                return i;
            }
        }
        return -1;
    }
    function getSortingFunction(firstParameter, secondParameter) {
        if (firstParameter.productType < secondParameter.productType) {
            return -1;
        }
        else if (firstParameter.productType > secondParameter.productType) {
            return 1;
        }
        else {
            return 0;
        }
    }

    class ShoppingCart {
        constructor() {
            this.products = [];
            return this;
        }

        add(product) {
            this.products.push(product);
            return this;
        }
        remove(product) {
            if (this.products.length === 0) {
                throw new Error('There are not products in the ShoppingCart instance');
            }
            var foundIndex = indexOfElementWithIdInCollection(this.products, product.name, product.price, product.productType);
            if (foundIndex < 0) {
                throw new Error(`The ShoppingCart instance does not contain this product`);
            }
            this.products.splice(foundIndex, 1);
            return this;
        }
        showCost() {
            if (this.products.length === 0) {
                return 0;
            }
            let sum = 0;
            for (let item of this.products) {
                //             item.price=+item.price;
                sum += item.price;
            }

            return sum;
        }
        showProductTypes() {
            let arr = [];
            if (this.products.length === 0) {
                return arr;
            }
            this.products = this.products.sort(getSortingFunction);

            for (var i = 0, len = this.products.length; i < len; i++)
                arr[this.products[i]['productType']] = this.products[i];
            
            this.products = [];
            
            for (var key in arr) {
                this.products.push(key);
            }
            return this.products;
        }
        getInfo() {
            let obj = {
                products: [],
                totalPrice: 0
            };
            if (this.products.length === 0) {
                return obj;
            }
            let totalCost = 0;
            obj.totalPrice = this.showCost();
            let arr = [];

            this.products = this.products.sort(getSortingFunction);
            for (let i = 0, len = this.products.length; i < len; i++){

                arr[this.products[i]['name']] = this.products[i];

            }
            for (let item in arr) {
                obj.products.push({
                    name: item,
                    totalCost: 0,
                    quantity: 1,
                });                
            }
            return obj;
        }
    }
    function removeDuplicates(myArr, prop) {
        return myArr.filter((obj, pos, arr) => {
            return arr.map(mapObj => mapObj[prop]).indexOf(obj[prop]) === pos;
        });
    }
    return {
        Product, ShoppingCart
    };
}

module.exports = solve;