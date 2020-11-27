using Orderly.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Orderly.Models
{
    public class PersonnelEdit
    {
        public int Id { get; set; }
        public Grade Grade { get; set; }
        public string Rank { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }
        public BioSex Sex { get; set; }
        public string SSN { get; set; }
        [Display(Name = "DoD ID")]
        public string DOD { get; set; }
        [Display(Name = "Date of Birth")]
        public DateTimeOffset DOB { get; set; }
        public int Age
        {
            get
            {
                var age = DateTime.Now.Year - DOB.Year;
                if (DOB.Date > DateTime.Now.AddYears(-age)) age--;
                return age;
            }
        }
        [Required]
        [Display(Name = "Marital Status")]
        public MaritalStatus MaritalStatus { get; set; }
    }
}
