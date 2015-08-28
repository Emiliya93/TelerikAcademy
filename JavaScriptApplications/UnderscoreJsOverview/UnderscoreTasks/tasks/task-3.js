/* 
Create a function that:
*   Takes an array of students
    *   Each student has:
        *   `firstName`, `lastName` and `age` properties
        *   Array of decimal numbers representing the marks         
*   **finds** the student with highest average mark (there will be only one)
*   **prints** to the console  'FOUND_STUDENT_FULLNAME has an average score of MARK_OF_THE_STUDENT'
    *   fullname is the concatenation of `firstName`, ' ' (empty space) and `lastName`
*   **Use underscore.js for all operations**
*/

function solve(){
    return function (students) {
        var studentWithHighestMark = _.chain(students)
        .map(function (student) {
            var sumOfAllMarks = _.reduce(
                student.marks,
                //function (memo, mark, index, list) {
                function (memo, mark) {
                    return memo + mark;
                },
                0);
            var allMarksCount = student.marks.length;
            student.averageMark = sumOfAllMarks / allMarksCount;

            return student;
        })
        .max(function (student) {
            return student.averageMark;
        })
        .value();

        studentWithHighestMark.fullName = studentWithHighestMark.firstName + ' ' + studentWithHighestMark.lastName;
        console.log(studentWithHighestMark.fullName + ' has an average score of ' + studentWithHighestMark.averageMark);
  };
}

module.exports = solve;


//var students = [{
//    firstName: 'Valter',
//    lastName: 'Nicphore',
//    age: 65,
//    marks: [6, 6, 5, 4, 3, 6]
//},
//{
//    firstName: 'Val',
//    lastName: 'Nic',
//    age: 65,
//    marks: [2, 3, 2, 4, 3]
//},
//{
//    firstName: 'Val',
//    lastName: 'Nice',
//    age: 65,
//    marks: [2, 3, 4]
//}];
//solve()(students);
