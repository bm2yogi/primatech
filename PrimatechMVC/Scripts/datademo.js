function square(number) {
    alert(number + ' squared = ' + number * number);
}

$(document).ready(function () {
    var alphadata = { color: 'red', city: 'seattle' };
    var betadata = { func: square, number: 5 };

    $("#alfa").data("alphadata", alphadata);
    $("#bravo").data("foo", betadata);

    var data = $('#bravo').data();
    data.foo.func(data.foo.number);

    data = $('#alfa').data();
    data.func(data.number);

});
