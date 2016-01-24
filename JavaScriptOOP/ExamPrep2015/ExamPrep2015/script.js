function solve() {
    var module = (function () {
        var playable,
            validator,
            CONSTANTS = {
                TEXT_MIN_LENGTH: 3,
                TEXT_MAX_LENGTH: 25
            };

        // Validator for checks
        validator = {
            validateIfUndefined: function(val, name){
                name = name || 'Value';

                if (typeof val === 'undefined') {
                    throw new Error(name + ' cannot be undefined!');
                }
            },

            validateString: function (val, name) {
                this.validateIfUndefined(val, name);

                if (typeof val !== 'string') {
                    throw new Error(name + ' must be a string!');
                }

                if (val.length < CONSTANTS.TEXT_MIN_LENGTH ||
                    val.length > CONSTANTS.TEXT_MAX_LENGTH) {
                    throw new Error(name + ' must be between ' + CONSTANTS.TEXT_MIN_LENGTH + ' and ' + CONSTANTS.TEXT_MAX_LENGTH);
                }
            },
            validatePositiveNumber: function (val, name) {
                this.validateIfUndefined(val, name);

                if (typeof val !== 'number') {
                    throw new Error(name + ' must be number!');
                }

                if (val <= 0) {
                    throw new Error(name + ' must be positive number');
                }
            }
        };

        playable = (function () {
            var playable = Object.create({});

            // define method/function to object/class
            Object.defineProperty(playable, 'init', {
                value: function () {

                }
            });

            // define property to object/class
            Object.defineProperty(playable, 'id', {
                get: function () {
                    return this._id;
                }
            });

            Object.defineProperty(playable, 'title', {
                get: function () {

                },
                set: function () {

                }
            });

            return playable;
        }());

        return {

        }
    }());

    return module;
}