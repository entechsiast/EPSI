/**
 * Created by jg_97 on 10/7/2016.
 */

//expressions régulières

//syntaxe statique
var regexp = /bar$/; // = je veux trouver un bar qui demarre la ligne  ^ signifie que la phrase commence par bar $ signifie que la phrase fini par bar

//syntaxe dynamique
var regexp2 = new RegExp("bar$"); // je veux juste trouver un bar

var texte = "foo bar";
var texte2 = "bar bar";

console.log(texte.match(regexp));
console.log(texte2.match(regexp2));

console.log(texte.replace('bar','baz'));
console.log(texte2.replace('bar','baz'));

console.log(texte2.replace(regexp2,'baz'));