/*  jquery nice select - v1.1.0
    https://github.com/hernansartorio/jquery-nice-select
    made by hernán sartorio  */
 
(function($) {

  $.fn.niceselect = function(method) {
    // methods
      if (typeof method == 'string') {   
          if (method == 'update') {
        this.each(function() {
          var $select = $(this);
          var $dropdown = $(this).next('.nice-select');
          var open = $dropdown.hasclass('open');
          
            if ($dropdown.length) {
            $dropdown.remove();
            create_nice_select($select);
            
            if (open) {
              $select.next().trigger('click');
            }
          }
        });
          } else if (method == 'destroy') {
        this.each(function() {
          var $select = $(this);
          var $dropdown = $(this).next('.nice-select');
          
            if ($dropdown.length) {
            $dropdown.remove();
            $select.css('display', '');
          }
        });
              if ($('.nice-select').length == 0) {
          $(document).off('.nice_select');
        }
      } else {
        console.log('method "' + method + '" does not exist.')
      }
      return this;
    }
      
    // hide native select
    this.hide();
    
    // create custom markup
    this.each(function() {
      var $select = $(this);
      
        if (!$select.next().hasclass('nice-select')) {
          
        create_nice_select($select);
      }
    });
    
    function create_nice_select($select) {
      $select.after($('<div></div>')
        .addclass('nice-select')
        .addclass($select.attr('class') || '')
        .addclass($select.attr('disabled') ? 'disabled' : '')
        .attr('tabindex', $select.attr('disabled') ? null : '0')
        .html('<span class="current"></span><ul class="list"></ul>')
      );
        
      var $dropdown = $select.next();
      var $options = $select.find('option');
      var $selected = $select.find('option:selected');
      
      $dropdown.find('.current').html($selected.data('display') || $selected.text());
      
      $options.each(function(i) {
        var $option = $(this);
        var display = $option.data('display');

        $dropdown.find('ul').append($('<li></li>')
          .attr('data-value', $option.val())
          .attr('data-display', (display || null))
          .addclass('option' +
            ($option.is(':selected') ? ' selected' : '') +
            ($option.is(':disabled') ? ' disabled' : ''))
          .html($option.text())
        );
      });
    }
    
    /* event listeners */
    
    // unbind existing events in case that the plugin has been initialized before
    $(document).off('.nice_select');
    
    // open/close
    $(document).on('click.nice_select', '.nice-select', function(event) {
      var $dropdown = $(this);
      
      $('.nice-select').not($dropdown).removeclass('open');
      $dropdown.toggleclass('open');
      
      if ($dropdown.hasclass('open')) {
        $dropdown.find('.option');  
        $dropdown.find('.focus').removeclass('focus');
        $dropdown.find('.selected').addclass('focus');
      } else {
        $dropdown.focus();
      }
    });
    
    // close when clicking outside
    $(document).on('click.nice_select', function(event) {
      if ($(event.target).closest('.nice-select').length === 0) {
        $('.nice-select').removeclass('open').find('.option');  
      }
    });
    
    // option click
    $(document).on('click.nice_select', '.nice-select .option:not(.disabled)', function(event) {
      var $option = $(this);
      var $dropdown = $option.closest('.nice-select');
      
      $dropdown.find('.selected').removeclass('selected');
      $option.addclass('selected');
      
      var text = $option.data('display') || $option.text();
      $dropdown.find('.current').text(text);
      
      $dropdown.prev('select').val($option.data('value')).trigger('change');
    });

    // keyboard events
    $(document).on('keydown.nice_select', '.nice-select', function(event) {    
      var $dropdown = $(this);
      var $focused_option = $($dropdown.find('.focus') || $dropdown.find('.list .option.selected'));
      
      // space or enter
      if (event.keycode == 32 || event.keycode == 13) {
        if ($dropdown.hasclass('open')) {
          $focused_option.trigger('click');
        } else {
          $dropdown.trigger('click');
        }
        return false;
      // down
      } else if (event.keycode == 40) {
        if (!$dropdown.hasclass('open')) {
          $dropdown.trigger('click');
        } else {
          var $next = $focused_option.nextall('.option:not(.disabled)').first();
          if ($next.length > 0) {
            $dropdown.find('.focus').removeclass('focus');
            $next.addclass('focus');
          }
        }
        return false;
      // up
      } else if (event.keycode == 38) {
        if (!$dropdown.hasclass('open')) {
          $dropdown.trigger('click');
        } else {
          var $prev = $focused_option.prevall('.option:not(.disabled)').first();
          if ($prev.length > 0) {
            $dropdown.find('.focus').removeclass('focus');
            $prev.addclass('focus');
          }
        }
        return false;
      // esc
      } else if (event.keycode == 27) {
        if ($dropdown.hasclass('open')) {
          $dropdown.trigger('click');
        }
      // tab
      } else if (event.keycode == 9) {
        if ($dropdown.hasclass('open')) {
          return false;
        }
      }
    });

    // detect css pointer-events support, for ie <= 10. from modernizr.
    var style = document.createelement('a').style;
    style.csstext = 'pointer-events:auto';
    if (style.pointerevents !== 'auto') {
      $('html').addclass('no-csspointerevents');
    }
    
    return this;

  };

}(jquery));