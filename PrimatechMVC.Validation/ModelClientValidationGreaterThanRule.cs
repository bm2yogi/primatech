using System.Web.Mvc;

namespace PrimatechMVC.Validation
{
    internal class ModelClientValidationGreaterThanRule : ModelClientValidationRule
    {
        public ModelClientValidationGreaterThanRule(string errorMessage, int minimumValue)
        {
            this.ErrorMessage = errorMessage;
            this.ValidationType = "greaterthan";
            this.ValidationParameters.Add("minvalue", minimumValue);
        }
    }
}