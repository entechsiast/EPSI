/**
 * Created by jg_97 on 10/7/2016.
 */
var nombre1 = 1;
var nombre2 = 3.14;
var chaine = 'hello world';
var boolean = true;
var objet = new Object();
var valeurNulle = null;
var valeurNonDefinie = undefined;

console.log(typeof  nombre1);
console.log(typeof  nombre2);
console.log(typeof  chaine);
console.log(typeof  boolean);
console.log(typeof  objet);
console.log(typeof  nombre1);
console.log(typeof  valeurNulle);
console.log(typeof  valeurNonDefinie);

console.log(nombre1+ ' ' + nombre2 + ' ' + chaine + ' ' + boolean)//etc...


var chaine1 = '42';
var chaine2 = '1.61227387537';

var entier = parseInt(chaine1);
var float =  parseFloat(chaine2);

console.log(typeof entier);
console.log(typeof float);

console.log(Number.isInteger(entier));
console.log(Number.isInteger(float));