using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace PrimatechMVC.Validation
{
    public class EmailAttribute : RegularExpressionAttribute, IClientValidatable
    {
        private const string EmailPattern = @"^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*)\.+[a-zA-Z]{2,9})$";

        public EmailAttribute() : base(EmailPattern) { }

        public IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata, ControllerContext context)
        {
            yield return new ModelClientValidationRegexRule(FormatErrorMessage(metadata.GetDisplayName()), EmailPattern);
        }
    }
}
