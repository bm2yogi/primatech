using System;
using System.ComponentModel.DataAnnotations;

namespace PrimatechMVC.Validation
{
    public class ColorLevelValidationAttribute : ValidationAttribute
    {
        private CustomValidationAttribute _customValidationAttribute;

        public ColorLevelValidationAttribute(Type validatorType, string method)
        {
            _customValidationAttribute = new CustomValidationAttribute(validatorType, method);
        }
    }
}