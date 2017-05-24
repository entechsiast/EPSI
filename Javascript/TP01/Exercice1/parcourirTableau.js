/**
 * Created by jg_97 on 10/7/2016.
 */
var a = [42, 3.14,'foo'];

console.log('boucle FOR');

for (var i = 0; i < a.length; i++){
    console.log(a[i]);
}

console.log('boucle for 2');

for (var i in a){
    console.log(a[i]);
}

console.log('boucle FOREACH');


var callback = function(currentValue,index,array){
    //console.log(this);
    console.log(currentValue);
    console.log(index);
};

a.forEach(callback)
