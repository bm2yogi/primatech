using System;
using System.ComponentModel.DataAnnotations;

namespace PrimatechMVC.ModelMetadata
{
    public class EmployeeProfileMetadata
    {
        [Display(ResourceType = typeof(Localization.Employees), Name = "Employee_Id")]
        public int EmployeeId { get; set; }

        [Display(ResourceType = typeof(Localization.Employees), Name = "FirstName")]
        [Required, StringLength(50, MinimumLength = 45, ErrorMessageResourceType = typeof(Localization.Validation), ErrorMessageResourceName = "StringLengthNotInRange")]
        public string FirstName { get; set; }
        
        [StringLength(50, MinimumLength = 45)]
        [Display(ResourceType = typeof(Localization.Employees), Name = "LastName")]
        public string LastName { get; set; }

        [Range(0.0d, 1.0d)]
        public double ProficiencyIndex { get; set; }

        [RegularExpression(@"^\d{3}-\d{2}-\d{4}$")]
        public string SocialSecurityId { get; set; }

        public string Position { get; set; }

        public string Department { get; set; }

        [Display(ResourceType = typeof(Localization.Employees), Name = "HireDate")]
        public DateTime HireDate { get; set; }

        public string Email { get; set; }
    }
}