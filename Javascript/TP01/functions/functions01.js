/**
 * Created by jg_97 on 10/7/2016.
 */


//définit la fonction

function hello(){
    console.log('hello');
}

//appel de la fonction
hello();

function hello(name){
    console.log('hello ' + name);
}

var user = 'Toto';

hello(user);

var salut = function(nom){
    console.log('Salut '+nom)
};

salut('JavaScript');

var tableau = [];

tableau.push(
    function(nom) {
        console.log('Salut '+nom);
    }
);

tableau[0]('Javascript');


//IIFE: Immediately Invoked Function expression
//crée un Objet FUNCTION que l'on peut appeler comme une fonction.
(function() {
    console.log('Hello World !');
})();


var message = 'Wati B !';

(function(text) {
    console.log(text);
})(message);


function function1(optionnal) {
    if (typeof optionnal === "undefined"){
        optionnal = "default value";
    }
    console.log(param);
}

function function2(param){
    if (param === undefined){
        param = "default value";
    }
    console.log(param);
}

function2();
function2('undefined');


function function3() {
    for (var i = 0; i < arguments.length; i++){
        console.log(arguments[i]);
    }
}
function3('foo','bar','baz');


function hello(name){
    console.log('Hello '+ name);
}

console.log(typeof hello); //function
console.log(hello)



//surcharge

function hello(){
    console.log('hello  world !');
}
function hello(){
    console.log('hello everybody!');
}

hello();



var myObject = new Object();

myObject.x = 42
myObject.getX = function(){
    return this.x;
}

console.log(myObject.getX());


var myObject = {
    x:42,
    getX:function(){
        return this.x;
    }
};

console.log((myObject.getX()));



var car = {
    wheels:4
};

var bus = Object.create(car);
bus.seats = 20;


console.log(car);
console.log(car.__proto__);

console.log(bus);
console.log(bus.__proto__);
console.log(bus.wheels);
console.log(bus.seats);
console.log(bus.engine);


'use strict'

function function7(){
    console.log(this);
}

function function6(){
    'use strict';
    console.log(this);
}


var o = new Object()


function1();//global || windows
function6();

