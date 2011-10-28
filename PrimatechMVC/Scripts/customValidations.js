/// <reference path="jquery-1.6.4-vsdoc.js" />
/// <reference path="jquery.validate-vsdoc.js" />
/// <reference path="jquery.validate.unobtrusive.js" />

jQuery.validator.addMethod("greaterthan", function (valueToValidate, valueElement, additionalParams) {
    return valueToValidate > parseInt(additionalParams.minvalue);
});

jQuery.validator.unobtrusive.adapters.add("greaterthan", ["minvalue"], function(options) {
    options.rules.greaterthan = options.params;
    options.messages.greaterthan = options.message;
});