/* Task Description */
/* 
	*	Create a module for working with books
		*	The module must provide the following functionalities:
			*	Add a new book to category
				*	Each book has unique name, author and ISBN
			*	List all books
				*	Books are sorted by ID
				*	This can be done by author, by category or all
			*	Add new category
				*	Each category has a unique name 
			*	List all categories
				*	Categories are sorted by ID
		*	Each book/catagory has a unique identifier (ID) that is a number greater than 1
			*	When adding a book/category, the is generated automatically
		*	Add validation everywhere, where possible
			*	Book and category names must be between 2 and 100 characters, including letters, digits and special characters ('!', ',', '.', etc)
			*	Unique params are Book name, Category name, and Book ISBN
				* Book authors can be repeated
			*	If something is not valid - throw Error
*/
function solve() {
    var library = (function () {
        var books = [];
        var categories = [];

        function sortByID(obj) {
            return obj.sort(function (a, b) {
                return a.id - b.id;
            });
        }

        function listBooks(obj) {
            var sortedBooks = [];

            if (!obj) {
                // List all books
                sortedBooks = books;
            } else if (obj.category !== undefined) {
                // List by category
                sortedBooks = books.filter(function (book) {
                    return book.category === obj.category;
                });
            } else if (obj.author !== undefined) {
                // List by author
                sortedBooks = books.filter(function (book) {
                    return book.author === obj.author;
                })
            }

            if (sortedBooks.length === 0) {
                return [];
            }

            sortedBooks = sortByID(sortedBooks);

            return sortedBooks;
            //return books;
        }

        function addBook(book) {
            function checkForValidLength(str) {
                var minChars = 2,
                    maxChars = 100;

                if (str.length < minChars || str.length > maxChars) {
                    throw new Error('Book title and category must be between ' + minChars + ' and ' + maxChars + '!');
                }
            }

            function checkForValidAuthor(str) {
                if (str === '') {
                    throw new Error('Author must be non-empty string!');
                }
            }

            function checkForValidISBN(isbn) {
                var short = 10,
                    long = 13,
                    digitsCount = 0;
                isbn = +isbn;
                if (isNaN(isbn)) {
                    throw new Error('Not valid ISBN');
                }

                while (isbn) {
                    digitsCount += 1;
                    isbn = isbn / 10;
                    isbn = Math.floor(isbn);
                }

                if (digitsCount === short || digitsCount === long) {
                    return;
                }
                throw new Error('Invalid ISBN!');
            }

            function checkForUniqueTitleAndISBN(title, isbn) {
                var i,
                    len = books.length;

                for (i = 0; i < len; i += 1) {
                    if (books[i].title === title || books[i].isbn === isbn) {
                        throw new Error('Title or ISBN already exists!');
                    }
                }
            }

            function checkForExistingCategory(category) {
                return categories.some(function (item) {
                    return item.name === category;
                });
            }

            function indexOfCategoryName(category) {
                var i,
                    len = categories.length;

                for (i = 0; i < len; i += 1) {
                    if (categories[i].name === category) {
                        return i;
                    }
                }

                return -1;
            }

            // Validate data
            //TODO: replace === undefined with !
            if (book === undefined || book.title === undefined ||
                book.isbn === undefined || book.author === undefined ||
                book.category === undefined) {
                throw new Error('Missing title, category, author or isbn')
            }

            checkForValidLength(book.title);
            checkForValidLength(book.category);
            checkForValidAuthor(book.author);
            checkForValidISBN(book.isbn);
            checkForUniqueTitleAndISBN(book.title, book.isbn);

            book.ID = books.length + 1;
            books.push(book);

            if (checkForExistingCategory(book.category)) {
                var index = indexOfCategoryName(book.category);

                if (index > -1) {
                    categories[index].books.push(book);
                }
            } else {
                var newCategory = {
                    name: book.category,
                    ID: categories.length + 1,
                    books: []
                }
                categories.push(newCategory);
                categories[categories.length - 1].books.push(book);
            }

            return book;
        }

        function listCategories() {
            var sortedCategories = sortByID(categories);

            return sortedCategories.map(function (item) {
                return item.name;
            });
        }

        return {
            books: {
                list: listBooks,
                add: addBook
            },
            categories: {
                list: listCategories
            }
        };
    }());
    return library;
}
module.exports = solve;

//var bookToAdd = {
//    title: 'BOOK #1',
//    isbn: '1234567890',
//    author: 'John Doe',
//    category: 'Book Category'
//},
//    bookToAdd2 = {
//        title: 'BOOK #2',
//        isbn: '1234567890123',
//        author: 'John Doe',
//        category: 'Book Category'
//    };
    //},
    //bookToAdd3 = {
    //    title: 'BOOK #3',
    //    isbn: '1234545850',
    //    author: 'John Joy',
    //    category: 'Book Category2'
    //};

//debugger;
//var lib = solve();
//lib.books.add(bookToAdd);
//lib.books.add(bookToAdd2);
////lib.books.add(bookToAdd3);

//lib.books.list();
//lib.books.list({ category: 'Book Category2' });
//lib.books.list({ author: 'John Joy' });

//lib.categories.list();