/**
 * Created by jg_97 on 10/7/2016.
 */
console.log(isNaN(NaN)); //NaN
console.log(isNaN(NaN)); //true
console.log(typeof NaN);

console.log(1/0) //infinity
console.log(-1/0) //- infinity

console.log(isFinite(42)); //true
console.log((isFinite(3.14)));//true

console.log((isFinite(1/0))); // false
console.log((isFinite(-1/0))); //false
console.log(isFinite(Infinity));
console.log(isFinite(-Infinity));
