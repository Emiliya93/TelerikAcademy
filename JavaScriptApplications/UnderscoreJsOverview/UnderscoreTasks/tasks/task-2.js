/*
Create a function that:
*   Takes an array of students
    *   Each student has a `firstName`, `lastName` and `age` properties
*   **finds** the students whose age is between 18 and 24
*   **prints**  the fullname of found students, sorted lexicographically ascending
    *   fullname is the concatenation of `firstName`, ' ' (empty space) and `lastName`
*   **Use underscore.js for all operations**
*/

function solve(){
    return function (students) {
        _.chain(students)
        .filter(function (student) {
            return student.age >= 18 && student.age <= 24;
        })
        .map(function (student) {
            student.fullName = student.firstName + ' ' + student.lastName;
            return student;
        })
        .sortBy(function (student) {
            return student.fullName;
        })
        .map(function (student) {
            console.log(student.fullName);
        });

  };
}

module.exports = solve;


//var students = [{
//        firstName: 'NAME #3',
//        lastName: 'NAME #2',
//        age:18
//    },
//    {
//        firstName: 'NAME #4',
//        lastName: 'NAME #1',
//        age: 19
//    },
//    {
//        firstName: 'NAME #4',
//        lastName: 'NAME #7',
//        age: 29
//    }];
//solve()(students);
