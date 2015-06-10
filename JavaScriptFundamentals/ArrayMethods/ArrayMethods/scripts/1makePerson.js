function makePerson(firstName, lastName, age, isFemale) {
    return {
        firstName: firstName,
        lastName: lastName,
        age: age,
        gender: isFemale
    };
}

var gender = true;
var people = [1, 1, 1, 1, 1, 1, 1, 1, 1, 1].map(function(_, i){
    return makePerson('Person', (i + 1), i * 5 + 17, !gender)
});

console.log('--------------------------------');
console.log('Task 1:')
console.log(people);
console.log('--------------------------------');