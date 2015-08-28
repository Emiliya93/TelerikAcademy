
/* 
Create a function that:
*   Takes an array of students
    *   Each student has a `firstName` and `lastName` properties
*   **Finds** all students whose `firstName` is before their `lastName` alphabetically
*   Then **sorts** them in descending order by fullname
    *   fullname is the concatenation of `firstName`, ' ' (empty space) and `lastName`
*   Then **prints** the fullname of founded students to the console
*   **Use underscore.js for all operations**
*/

function solve(){
    return function (students) {

        //var filteredByNameStudents = _.chain(students)
        //    .filter(function (student) {
        //        return student.firstname < student.lastname;
        //    })
        //    .value();

        var sortedStudents = _.chain(students)
            .filter(function (student) {
                return student.firstName < student.lastName;
            })
            .map(function (student) {
                student.fullName = student.firstName + ' ' + student.lastName;
                return student;
            })
            .sortBy(function (student) {
                return student.fullName;
            })
            .reverse()
            .value();
        
        _.map(sortedStudents, function (student) {
            console.log(student.fullName);
        })
  };
}

module.exports = solve;

//var students = [{
//    firstName: 'NAME #3',
//    lastName: 'NAME #2'
//}, {
//    firstName: 'NAME #4',
//    lastName: 'NAME #1'
//}, {
//    firstName: 'NAME #4',
//    lastName: 'NAME #7'
//}];
//solve()(students);
