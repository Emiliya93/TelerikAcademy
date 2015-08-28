/* 
Create a function that:
*   **Takes** a collection of books
    *   Each book has propeties `title` and `author`
        **  `author` is an object that has properties `firstName` and `lastName`
*   **finds** the most popular author (the author with biggest number of books)
*   **prints** the author to the console
	*	if there is more than one author print them all sorted in ascending order by fullname
		*   fullname is the concatenation of `firstName`, ' ' (empty space) and `lastName`
*   **Use underscore.js for all operations**
*/

function solve() {
    return function (books) {
        var booksWithAuthorFullName = _.chain(books)
        .map(function (book) {
            book.author.fullName = book.author.firstName + ' ' + book.author.lastName;

            return book;
        });

        var maxBooksCountFromSameAuthor = _.chain(booksWithAuthorFullName)
        .countBy(function (book) {
            return book.author.fullName;
        })
        .pairs()
        .max(_.last)
        .last()
        .value();

        var groupedByAuthor = _.chain(booksWithAuthorFullName)
        .groupBy(function (book) {
            return book.author.fullName;
        })
        .where({ length: maxBooksCountFromSameAuthor })
        .sortBy(function (bookGroup) {
            return bookGroup[0].author.fullName;
        })
        .map(function (bookGroup) {
            console.log(bookGroup[0].author.fullName);
        });
    };
}

module.exports = solve;

//var books = [{
//    title: 'Book is 3',
//    author: {
//        firstName: 'Toyger',
//        lastName: 'Ninos'
//    }
//}, {
//    title: 'Big hit',
//    author: {
//        firstName: 'Miles',
//        lastName: 'Pietari'
//    }
//}, {
//    title: 'Boo is k42',
//    author: {
//        firstName: 'Toyger',
//        lastName: 'Ninos'
//    }
//}, {
//    title: 'Avtobiografiq na Zlatko',
//    author: {
//        firstName: 'neSumZlatko',
//        lastName: 'Hardmod'
//    }
//}, {
//    title: 'n00b',
//    author: {
//        firstName: 'Miles',
//        lastName: 'Pietari'
//    }
//}, {
//    title: 'n0b',
//    author: {
//        firstName: 'Miles',
//        lastName: 'Pietari'
//    }
//}
//, {
//    title: 'Just a bOOk',
//    author: {
//        firstName: 'Toyger',
//        lastName: 'Ninos'
//    }
//}];

//solve()(books);