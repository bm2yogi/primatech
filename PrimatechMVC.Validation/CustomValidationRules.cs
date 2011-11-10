using System;
using System.ComponentModel.DataAnnotations;

namespace PrimatechMVC.Validation
{
    public class CustomValidationRules
    {
         public static ValidationResult DepartmentExists(string value, ValidationContext context)
         {
             if (!value.Equals("Level 5", StringComparison.InvariantCultureIgnoreCase))
             {
                 return new ValidationResult(String.Format(Localization.Validation.DepartmentDoesNotExist, value));
             }

             return null;
         }
    }
}