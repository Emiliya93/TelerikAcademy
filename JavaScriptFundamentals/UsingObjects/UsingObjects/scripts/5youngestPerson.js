var youngest = {},
    people = [
    {
        firstname : 'Gosho',
        lastname: 'Petrov',
        age: 32
    },
    {
        firstname : 'Bay',
        lastname: 'Ivan',
        age: 81
    },
    {
        firstname: 'Smiley',
        lastname: 'Smith',
        age: 21
    }
];

function findYoungestPerson(people) {
    var i,
        youngest = {},
        len = people.length;

    youngest = people[0];
    for (i = 1; i < len; i += 1) {
        if (youngest.age > people[i].age) {
            youngest = people[i];
        }
    }

    return youngest;
}

console.log('Tasl 5:');
youngest = findYoungestPerson(people);
console.log('Youngest person:');
console.log(youngest.firstname + ' ' + youngest.lastname);
console.log('----------------------------------------------------');