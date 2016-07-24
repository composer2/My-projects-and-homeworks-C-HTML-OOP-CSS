// //objects-overview
// var maxNumber = 16,
//     binaryDigits,
//     number,
//     numberInBinary,
//     paddedBinary;

// binaryDigits = maxNumber.toString(2).length - 1;
// for (var number = 0; number < maxNumber; number++) {
//     numberInBinary = number.toString(2);
//     paddedBinary = padLeft(numberInBinary, binaryDigits);
//     console.log('The number ' + number + ' is represented in binary as ' + paddedBinary);
// }

// function padLeft(number, diggits) {
//     return '00000000000000000000000000000000000000000'.substr(0, diggits - number.length) + number;
// }

// // reference-primitive-types
// console.log('typeof new Object() === typeof new Array() =>' + (typeof new Object() === typeof new Array()));
// console.log('typeof new Object() === typeof new Date() =>' + (typeof new Object() === typeof new Date()));
// console.log('typeof new Array() === typeof new Date() =>' + (typeof new Array() === typeof new Date()));

// //primitive-types
// var num = 5,
//     numObj = new Number(5);
// console.log('(number == numberObj) = ' + (num == numObj));
// console.log('(number === numberObj) = ' + (num === numObj));
// console.log('typeof num = ' + typeof num);
// console.log('typeof numObj = ' + typeof numObj);
// console.log('(typeof num === typeof numObj) =' + (typeof numObj === typeof num));
// console.log('----------------------------------------------');
// var fname = 'Pesho',
//     lname = 'Ivanov',
//     person = {
//         firstName: fname,
//         lastName: lname,
//         toString: function personToString() {
//             return this.firstName + " " + this.lastName;
//         }
//     };
// console.log(person);
// lname = 'Petrov';
// console.log(lname);

// //reference-types
// var marks, students;
//     marks=[
//         {subject: 'JavaScript',score:5.50},
//         {subject: 'OOP',score:5.00},
//         {subject: 'Photoshop',score:6.00},
//         {subject: 'Slice and dice',score:4.50}];

//     students={name: 'Bon Bonbon',marks: marks};

//     printStudent(students);
//     marks[2].score=5.00;
//     printStudent(students)

//     function printStudent(students) {
//         for(var i in marks){
//         console.log('<strong>' +marks[i].subject+'</strong>'+' : '+marks[i].score);
//         }
//     }

// //json-objects
// var person = {
//     firstname: 'Bon',
//     lastname: 'Bonbon',
//     toString: function() {
//         return this.firstname + " " + this.lastname;
//     }
// };
// console.log(person);
// renamePerson(person, 'Stamat');
// console.log(person);

// function renamePerson(personObj, fname, lname) {
//     personObj.firstname = fname || personObj.firstname;
//     personObj.lastnamestname = lname || personObj.lastname;
// }

// //json-build-function
// var belutov = buildPerson('Boncho', 'Belutov'),
//     dimitrov = buildPerson('Asen', 'Dimitrov');

// console.log(belutov);
// console.log(dimitrov);

// function buildPerson(fname, lname) {
//     return {
//         fname: fname,
//         lname: lname,
//         toString: function getFullName() {
//             return this.fname + " " + this.lname;
//         }
//     };
// }

//associative-arrays
var text = 'When I was born my parents named me Pesho Ivanov, and still my name is Pesho Ivanov and now I am 102 years old. Two years ago my first name was Pesho, and my last name was Ivanov. ',
    words = getWords(text),
    wordsCount = countWords(words),
    word;
for (word in wordsCount) {
    console.log(word + ' -> ' + wordsCount[word]);
}

function getWords(text) {
    var words = text.split(/[\s\.,-?!)(]/),
        i;
    for (i = 0; i < words.length; i++) {
        if (words[i] === "") {
            words.splice(i, 1);
        }
    }
    return words;
}

function countWords(words) {
    var wordsCount = {},
        word, i;
    for (i in words) {
        word = words[i].toLowerCase();
        if (wordsCount[word]) {
            wordsCount[word]++;
        } else {
            wordsCount[word] = 1;
        }
    }
    return wordsCount;
}