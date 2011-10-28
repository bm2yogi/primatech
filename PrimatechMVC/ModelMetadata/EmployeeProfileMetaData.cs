using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using PrimatechMVC.Validation;

namespace PrimatechMVC.ModelMetadata
{
    public class EmployeeProfileMetadata
    {
        [Display(ResourceType =typeof(Localization.Employees), Name="EmployeeId")]
        [GreaterThan(100, ErrorMessageResourceType=typeof(Localization.Validation), ErrorMessageResourceName = "EmployeeNumberTooSmall")]
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        [Display(ResourceType = typeof(Localization.Employees), Name = "LastName")]
        [StringLength(5, MinimumLength = 3, ErrorMessageResourceType = typeof(Localization.Validation), ErrorMessageResourceName = "StringLengthNotInRange")]
        public string LastName { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
        
        [DataType(DataType.Date)]
        public string HireDate { get; set; }
        
        [Required(ErrorMessageResourceType = typeof(Localization.Validation), ErrorMessageResourceName = "EmailAddressIsRequired")]
        [Remote("IsExistingEmail", "Employees", ErrorMessageResourceType = typeof(Localization.Validation), ErrorMessageResourceName = "EmailAddressExists")]
        [Email(ErrorMessageResourceType = typeof(Localization.Validation), ErrorMessageResourceName = "EmailAddressInvalidFormat")]
        public string Email { get; set; }
    }
}