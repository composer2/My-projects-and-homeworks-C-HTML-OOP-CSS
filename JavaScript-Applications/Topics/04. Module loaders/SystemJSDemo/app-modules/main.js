import 'jquery';

const startButtun =
    $('<button />', { id: 'btn-start' })
        .html('Start the app')
        .prependTo($('body'));
startButtun.on('click', function () {

    // //promise chaining not easy to read
    // System.import('data').then(function (db) {
    //     return System.import('seed-data');//will return another promise with data form seed-data then we use it somehow
    // }).then(function (something){
    //     //do something
    // });
    Promise.all([    //same like above much readable //need/takes an array of promises
        System.import('data'),
        System.import('seed-data'),
        System.import('person-component')
    ]).then(function (modules) { //modules will be an array with all the resolved values from the promise
        //console.log(modules[0]); //this will refer to 'data'
        const [data, seedData, personComponent] = modules; //data=modules[0], seedData=modules[1], personComponent=modules[2]
        // console.log(data);  
        // console.log(seedData);  
        // console.log(personComponent);  
        seedData.seed();
        personComponent.attachEvents();
        
    });
});

