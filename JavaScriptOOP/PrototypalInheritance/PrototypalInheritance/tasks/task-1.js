/* Task Description */
/*
* Create an object domElement, that has the following properties and methods:
  * use prototypal inheritance, without function constructors
  * method init() that gets the domElement type
    * i.e. `Object.create(domElement).init('div')`
  * property type that is the type of the domElement
    * a valid type is any non-empty string that contains only Latin letters and digits
  * property innerHTML of type string
    * gets the domElement, parsed as valid HTML
      * <type attr1="value1" attr2="value2" ...> .. content / children's.innerHTML .. </type>
  * property content of type string
    * sets the content of the element
    * works only if there are no children
  * property attributes
    * each attribute has name and value
    * a valid attribute has a non-empty string for a name that contains only Latin letters and digits or dashes (-)
  * property children
    * each child is a domElement or a string
  * property parent
    * parent is a domElement
  * method appendChild(domElement / string)
    * appends to the end of children list
  * method addAttribute(name, value)
    * throw Error if type is not valid
  * method removeAttribute(attribute)
    * throw Error if attribute does not exist in the domElement
*/


/* Example

var meta = Object.create(domElement)
	.init('meta')
	.addAttribute('charset', 'utf-8');

var head = Object.create(domElement)
	.init('head')
	.appendChild(meta)

var div = Object.create(domElement)
	.init('div')
	.addAttribute('style', 'font-size: 42px');

div.content = 'Hello, world!';

var body = Object.create(domElement)
	.init('body')
	.appendChild(div)
	.addAttribute('id', 'cuki')
	.addAttribute('bgcolor', '#012345');

var root = Object.create(domElement)
	.init('html')
	.appendChild(head)
	.appendChild(body);

console.log(root.innerHTML);
Outputs:
<html><head><meta charset="utf-8"></meta></head><body bgcolor="#012345" id="cuki"><div style="font-size: 42px">Hello, world!</div></body></html>
*/


function solve() {
    var domElement = (function () {
        function checkForValidType(type) {
            if (typeof type !== 'string') {
                throw new Error('Type is not valid string!');
            }
            if (!(/^[A-z0-9]+$/i.test(type))) {
                throw new Error('A valid type is any non-empty string that contains only Latin letters and digits');
            }
            return true;
        }

        function checkForValidAttributeName(name) {
            if (!(/^[A-Z0-9\-]+$/i.test(name))) {
                throw new Error('A valid attribute has a non-empty string for a name that contains only Latin letters and digits or dashes.');
            }

            return true;
        }

        function getSortedAttributesString(attributes) {
            var attributesString = '',
                keys = [];

            for (var key in attributes) {
                keys.push(key);
            }

            keys.sort();
            var currentKey;

            for (var ind = 0, len = keys.length; ind < len; ind += 1) {
                currentKey = keys[ind];
                attributesString += ' ' + currentKey + '="' + attributes[currentKey] + '"';
            }

            return attributesString;
        }

        var domElement = {
            init: function (type) {
                this.type = type;
                this.attributes = {};
                this.content = '';
                this.children = [];
                this.parent;

                return this;
            },

            get innerHTML() {
                // return '<' + this.type + '></' + this.type + '>';
                var child,
                    i,
                    len,
                    innerHTML = '<' + this.type;

                innerHTML += getSortedAttributesString(this.attributes) + '>';

                for (i = 0, len = this.children.length; i < len; i += 1) {
                    child = this.children[i];

                    if (typeof (child) === 'string') {
                        innerHTML += child;
                    } else {
                        innerHTML += child.innerHTML;
                    }
                }

                innerHTML += this.content;
                innerHTML += '</' + this.type + '>';

                return innerHTML;
            },

            get type() {
                return this._type;
            },
            set type(value) {
                checkForValidType(value);
                this._type = value;
            },

            get content() {
                if (this._children.length !== 0) {
                    return '';
                }

                return this._content;
            },
            set content(value) {
                this._content = value;
            },

            get attributes() {
                return this._attributes;
            },
            set attributes(value) {
                this._attributes = value;
            },

            get children() {
                return this._children;
            },
            set children(value) {
                this._children = value;
            },

            get parent() {
                return this._parent;
            },
            set parent(value) {
                if (!domElement.isPrototypeOf(value)) {
                    throw new Error('Parent must be a dom element!');
                }
                this._parent = value;
            },

            appendChild: function (child) {
                this.children.push(child);

                if (typeof child === 'object') {
                    child.parent = this;
                }

                return this;
            },
            addAttribute: function (name, value) {
                checkForValidAttributeName(name);

                this.attributes[name] = value;

                return this;
            },
            removeAttribute: function (attribute) {
                if (!(this.attributes[attribute])) {
                    throw new Error('Attribute does not exist!');
                }

                delete this.attributes[attribute];

                return this;
            },
        };
        return domElement;
    }());
    return domElement;
}

module.exports = solve;
// debugger;
// var domElement = solve();
// var parent = Object.create(domElement)
					// .init('html')
					// .addAttribute('id', 'myindex.html'),
				// child = Object.create(domElement)
					// .init('head')
					// .addAttribute('id', 'myhead');
// parent.appendChild(child);
// parent.removeAttribute('id');
// var html = parent.innerHTML;
// console.log(html);
