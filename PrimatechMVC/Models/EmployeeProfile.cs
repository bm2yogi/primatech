using System;
using System.ComponentModel.DataAnnotations;
using PrimatechMVC.ModelMetadata;

namespace PrimatechMVC.Models
{
    [MetadataType(typeof(EmployeeProfileMetadata))]
    public class EmployeeProfile
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double ProficiencyIndex { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
        public DateTime HireDate { get; set; }
        public string Email { get; set; }
    }
}