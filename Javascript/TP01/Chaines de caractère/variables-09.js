/**
 * Created by jg_97 on 10/7/2016.
 */


// création d'un objet
var obj = new Object();

// création d'un objet (syntaxe alternative)
var obj2 = {};

// affectation de propriétés à l'objet
obj.nombre = 42;
obj.date = new Date();
obj.loveJS = true;
obj.afficheDate = function(){
    console.log(this.date);
}

// objet 2

obj2.nombre = 42;
obj2.date = new Date();
obj2.loveJS = true;
obj2.afficheDate = function(){
    console.log(this.date);
}

//crétion d'objet et affectation de propriétés
var obj3 = {
    nombre : 42,
    date : new Date()
};

//affectation de propriétés (syntaxe en mode tableau)
obj3['love JS'] = true; // fonctionne si la clé contient des espaces
obj3.afficheDate = function(){
    console.log(this.date);
}

console.log(obj);
console.log(obj2);
console.log(obj3);
obj3.afficheDate();