using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace PrimatechMVC.Validation
{
    public class GreaterThanAttribute : ValidationAttribute, IClientValidatable
    {
        private readonly int _minimumValue;

        public GreaterThanAttribute(int minimumValue)
        {
            _minimumValue = minimumValue;
        }

        public IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata, ControllerContext context)
        {
            var errorMessage = FormatErrorMessage(metadata.GetDisplayName());
            yield return new ModelClientValidationGreaterThanRule(errorMessage, _minimumValue);
        }

        public override string FormatErrorMessage(string name)
        {
            return string.Format(ErrorMessageString, name, _minimumValue);
        }

        public override bool IsValid(object value)
        {
            try
            {
                return Convert.ToInt32(value) > _minimumValue;
            }
            catch
            {
                return false;
            }
        }
    }
}