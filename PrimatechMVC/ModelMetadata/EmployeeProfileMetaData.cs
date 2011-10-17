using System.ComponentModel.DataAnnotations;
using PrimatechMVC.Validation;

namespace PrimatechMVC.ModelMetadata
{
    public class EmployeeProfileMetadata
    {

        [GreaterThan(100)]
        public int EmployeeId { get; set; }
        [StringLength(5, MinimumLength = 3)]
        public string FirstName { get; set; }
        //[Display(ResourceType=typeof(Localization.Employees), Name = "LastName")]
        //[StringLength(5, MinimumLength = 3, ErrorMessageResourceType = typeof(Localization.Validation), ErrorMessageResourceName = "StringLengthNotInRange")]
        public string LastName { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
        public string HireDate { get; set; }
        //[Required(ErrorMessageResourceType = typeof(Localization.Validation), ErrorMessageResourceName = "EmailAddressIsRequired")]
        //[Email(ErrorMessageResourceType = typeof(Localization.Validation), ErrorMessageResourceName = "EmailAddressInvalidFormat")]
        public string Email { get; set; }
    }
}