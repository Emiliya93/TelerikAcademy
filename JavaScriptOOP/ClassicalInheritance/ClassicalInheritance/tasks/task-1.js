
/* Task Description */
/* 
	Create a function constructor for Person. Each Person must have:
	*	properties `firstname`, `lastname` and `age`
		*	firstname and lastname must always be strings between 3 and 20 characters, containing only Latin letters
		*	age must always be a number in the range 0 150
			*	the setter of age can receive a convertible-to-number value
		*	if any of the above is not met, throw Error 		
	*	property `fullname`
		*	the getter returns a string in the format 'FIRST_NAME LAST_NAME'
		*	the setter receives a string is the format 'FIRST_NAME LAST_NAME'
			*	it must parse it and set `firstname` and `lastname`
	*	method `introduce()` that returns a string in the format 'Hello! My name is FULL_NAME and I am AGE-years-old'
	*	all methods and properties must be attached to the prototype of the Person
	*	all methods and property setters must return this, if they are not supposed to return other value
		*	enables method-chaining
*/
function solve() {
    var Person = (function () {

        function checkAge(age) {
            var minAge = 0,
                maxAge = 150;

            age = +age;
            if (isNaN(age) || age < minAge || age > maxAge) {
                throw new Error('Age must always be a number in the range (' +
                    minAge + ', ' + maxAge + ')');
            }

            return true;
        }

        function isValidName(name) {
            var minChars = 3,
                maxChars = 20;

            if (!(/^[A-z]{3,20}$/.test(name))) {
                throw new Error('firstname and lastname must always be strings between' +
                    minChars + ' and ' + maxChars + ' characters, containing only Latin letters');
            }
            return true;
        }

        // Function constructor for Person
        function Person(firstName, lastName, age) {
            this.firstname = firstName;
            this.lastname = lastName;
            this.age = age;
        }

        // Define properties
        Object.defineProperty(Person.prototype, 'firstname', {
            get: function () {
                return this._firstname;
            },
            set: function (value) {
                isValidName(value);
                this._firstname = value;
                return this;
            }
        });
        Object.defineProperty(Person.prototype, 'lastname', {
            get: function () {
                return this._lastname;
            },
            set: function (value) {
                isValidName(value);
                this._lastname = value;
                return this;
            }
        });
        Object.defineProperty(Person.prototype, 'age', {
            get: function () {
                return this._age;
            },
            set: function (value) {
                checkAge(value);
                this._age = value;
                return this;
            }
        });
        Object.defineProperty(Person.prototype, 'fullname', {
            get: function () {
                return this._firstname + ' ' + this._lastname;
            },
            set: function (value) {
                var firstAndLastName = value.split(' ');

                this._fullname = value;
                this._firstname = firstAndLastName[0];
                this._lastname = firstAndLastName[1];
                return this;
            }
        });

        Person.prototype.introduce = function () {
            return ('Hello! My name is ' +
                this.fullname + ' and I am ' + this.age + '-years-old');
        };

        return Person;
    }());
    return Person;
}
module.exports = solve;