using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace PrimatechMVC.Validation
{
    public class GreaterThanAttribute : ValidationAttribute, IClientValidatable
    {
        private readonly int _minimumValue;
        public const string ValidationType = "greaterthan";

        public GreaterThanAttribute(int minimumValue)
        {
            _minimumValue = minimumValue;
        }

        public IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata, ControllerContext context)
        {
            yield return new ModelClientValidationGreaterThanRule(metadata.GetDisplayName(), _minimumValue);
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