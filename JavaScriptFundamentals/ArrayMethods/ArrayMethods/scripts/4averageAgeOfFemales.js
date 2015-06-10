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

console.log('Task 4:');

function averageAgeOfFemales(people) {
    var sum = 0,
        average = 0,
        count = 0;
    sum = people.forEach(function(item) {
        if (item.gender === true) {
            sum += item.age;
            console.log(sum);
            console.log(item); 
        }
    })
}

averageAgeOfFemales(people);
