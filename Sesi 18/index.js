const mapper = {
    a: 'b', e: 'f', i: 'j', o: 'p', u: 'v'
}

function removeSpaces (text) {
    return text.split(' ').join('');
}

function reverseText (text) {
    return text.split('').reverse().join('');
}

function updateVowels (text) {
    var text = text.toLowerCase();
    return text.replace(/[aeiou]/gi, temp => mapper[temp])
}

var password = 'dimitri w';
// var abc = 'a b c d e f g h i j k l m n O p q r s t u v w x y z'
var noSpaces = removeSpaces(password);
var reversed = reverseText(noSpaces);
var encryptedPassword = updateVowels(reversed);

console.log(noSpaces);
console.log(reversed);
console.log(encryptedPassword);