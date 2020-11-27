using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orderly.Data
{
    public enum Grade { E1, E2, E3, E4, E5, E6, E7, E8, E9, O1, O2, O3, O4, O5, O6, O7, O8, O9, O10, W1, W2, W3, W4, W5 }

    public enum BioSex { Male, Female, Other }
    //public enum Gender { }
    public enum MaritalStatus { NeverMarried, Married, Divorced, Widowed, Estranged, Other }
    public class Personnel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public Grade Grade { get; set; }
        public string Rank { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }
        [Required]
        public BioSex Sex { get; set; }
        [Required]
        public string SSN { get; set; }
        [Required]
        [Display(Name = "DoD ID")]
        public string DOD { get; set; }
        [Required]
        [Display(Name = "Date of Birth")]
        public DateTimeOffset DOB { get; set; }
        public int Age { get; set; }
        [Required]
        [Display(Name = "Marital Status")]
        public MaritalStatus MaritalStatus { get; set; }
    }
}
