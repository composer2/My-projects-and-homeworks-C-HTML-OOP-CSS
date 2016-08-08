function solve() {
  return function () {
    $.fn.listview = function (data) {
      var $this = $(this);
      var dataTemplate = $this.data('template');
      var template = handlebars.compile($('#' + dataTemplate).html());
      for(var i = 0; i < data.length; i+= 1){
        $this.append(template(data[i]));
      }
      return this;
    };
  };
}

module.exports = solve;