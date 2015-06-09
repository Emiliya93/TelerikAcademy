var obj = {
    name: 'Smiley',
    age: 21,
    weight: 59,
    height: 166
};

console.log('Task 4:');
console.log('Has my object property length?');
console.log(hasProperty(obj, 'length'));
console.log('Has my object property name?');
console.log(hasProperty(obj, 'name'));
console.log('----------------------------------------------------');

function hasProperty(obj, prop) {
    for (var property in obj) {
        if (property === prop) {
            return true;
        }
    }
    return false;
}