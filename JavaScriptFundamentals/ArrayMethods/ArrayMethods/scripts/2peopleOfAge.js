function makePerson(firstName, lastName, age, isFemale) {
    return {
        firstName: firstName,
        lastName: lastName,
        age: age,
        gender: isFemale
    };
}

var gender = true;
var people = [1, 1, 1, 1, 1, 1, 1, 1, 1, 1].map(function (_, i) {
    return makePerson('Person', (i + 1), i * 5 + 17, !gender)
});

var adultPeople = people.filter(function (item) {
    return (item.age >= 18);
});

console.log('Task 2:');
console.log(adultPeople);
console.log('--------------------------------');