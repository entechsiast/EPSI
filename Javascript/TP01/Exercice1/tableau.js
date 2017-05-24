/**
 * Created by jg_97 on 10/7/2016.
 */

// créer tableau avec syntaxea alternative + pusher 5 chaines de caractère dans le tableau
// trouver la méthode qui permet de
// - supprimer le 1 er élement du tableau
// - supprimer dernier  element
// - supprimer le 2eme element
// remplacer le 2eme element avec 2 nombres entiers

var tableau = ['foo','bar','baz','lorem'];
console.log('tableau original : ' + tableau);

//ajoute la 5eme valeur
tableau.push('ipsum');
console.log('ajoute une 5ème valeur : '+ tableau);

//supprime la dernière valeur
tableau.pop();
console.log('suprime la dernière valeur : '+ tableau);

//supprime la 1er valeur
tableau.shift();
console.log('supprime la 1er valuer: ' + tableau);

//supprime le 2eme element
tableau.splice(1,1);
console.log('supprime le 2eme element : ' + tableau);

//remplace les 2eme et 3eme element

var nombre2 = 2;
var nombre3 = 3;

tableau[1] = parseInt((nombre2));
tableau[2] = parseInt((nombre3));

console.log('remplace les 2 et 3 eme valuers du tableau : ' + tableau);
//ajouter un nombre à virgule flottant au début de la liste
tableau.unshift(3.14);
console.log('ajoute un nombre à virgule au début de la liste : ' + tableau);

//ajouter un nombre à virgule flottant en 3eme position de la liste

tableau[2] = 5.14;
console.log('ajoute un nombre réel en 3eme position: ' + tableau);

// affiche le tableau
console.log(tableau);


