function solve(){
  return function(selector){
      if (typeof selector === 'undefined') {
          throw new Error('Selector can not be undefined!');
      }

      var selectedElement = $(selector)
            .hide(),

          divContainer = $('<div />')
            .addClass('dropdown-list')
            .append(selectedElement),

          options = selectedElement.find('option'),
          optionsLength = options.length,

          currentDiv = $('<div />')
            .addClass('current'),

          divOptionsContainer = $('<div />')
            .addClass('options-container')
            .hide(),
          
          i;

      if (optionsLength) {
          var firstOption = options[0],
              text = firstOption.innerHTML;;
          currentDiv
              .attr('data-value', firstOption.value)
              .text(text);
      }

      for (i = 0; i < optionsLength; i += 1) {
          var currentOption = options[i],
              newDiv = $('<div />')
                .addClass('dropdown-item')
                .attr('data-value', currentOption.value)
                .text(currentOption.text)
                .appendTo(divOptionsContainer);
      }

      currentDiv.on('click', function () {
          $this = $(this);
          $this.text('Select a value');

          divOptionsContainer.css('display', '');
      });

      divOptionsContainer.on('click', '.dropdown-item', function () {
      
          var $this = $(this),
              text = $this.text(),
              value = $this.attr('data-value');

          currentDiv
              .attr('data-value', value)
              .text(text);

          divOptionsContainer.hide();

          selectedElement
              .val(value);
      });

      divContainer
          .append(currentDiv)
          .append(divOptionsContainer)
          .appendTo('body');
  };
}

module.exports = solve;