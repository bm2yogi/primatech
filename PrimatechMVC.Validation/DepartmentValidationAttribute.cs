using System;
using System.ComponentModel.DataAnnotations;

namespace PrimatechMVC.Validation
{
    public class DepartmentValidationAttribute : ValidationAttribute
    {
        private string _department;
        public const string Level5 = "Level 5";

        public DepartmentValidationAttribute() : base(Localization.Validation.DepartmentDoesNotExist) { }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            _department = value.ToString();

            return DepartmentIsLevelFive ? ErrorResult : null;
        }

        private bool DepartmentIsLevelFive
        {
            get { return _department.Equals(Level5, StringComparison.InvariantCultureIgnoreCase); }
        }

        private ValidationResult ErrorResult
        {
            get { return new ValidationResult(FormatErrorMessage(_department)); }
        }
    }
}