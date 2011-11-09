using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace PrimatechMVC.ModelMetadata
{
    public class EmployeeProfileMetadata
    {
        [Display(ResourceType = typeof(Localization.Employees), Name = "Employee_Id")]
        public int EmployeeId { get; set; }

        [Display(ResourceType = typeof(Localization.Employees), Name = "FirstName")]
        [Required, StringLength(50, MinimumLength = 45, ErrorMessageResourceType = typeof(Localization.Validation), ErrorMessageResourceName = "StringLengthNotInRange")]
        public string FirstName { get; set; }
        
        [Display(ResourceType = typeof(Localization.Employees), Name = "LastName")]
        [Required, StringLength(50, MinimumLength = 45)]
        public string LastName { get; set; }

        [Range(0.0d, 1.0d)]
        public double ProficiencyIndex { get; set; }

        [Required, Compare("Department")]
        public string Position { get; set; }

        [Required]
        public string Department { get; set; }

        [Display(ResourceType = typeof(Localization.Employees), Name = "HireDate")]
        public DateTime HireDate { get; set; }
        
        [RegularExpression(@"^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*)\.+[a-zA-Z]{2,9})$")]
        public string Email { get; set; }
    }
}