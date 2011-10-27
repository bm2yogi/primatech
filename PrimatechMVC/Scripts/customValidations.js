jQuery.validator.addMethod("ismyname", function (element, value) {
    return this.optional(element) || value.toLower() == "bm2yogi";
});