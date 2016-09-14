var factorial = function (n) {
    if (n === 0) {
        return 1;
    }
    return n * factorial(n - 1);
};

console.log(factorial(5));

var fact = factorial;
console.log(fact(5));

factorial = function () {
    return 'Opa N/A factorial';
};

//console.log(factorial(5));
console.log(fact(5));