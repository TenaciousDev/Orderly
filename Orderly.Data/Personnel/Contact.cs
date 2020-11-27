using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orderly.Data
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
        [Display(Name = "Personal Email")]
        public string PersonalEmail { get; set; }
        [Display(Name = ".mil Email")]
        public string MilEmail { get; set; }
        [Display(Name = "Does SM have Drivers License?")]
        public bool HasDriversLicense { get; set; }
        [Display(Name = "Vehicle Make")]
        public string VehicleMake { get; set; }
        [Display(Name = "Vehicle Model")]
        public string VehicleModel { get; set; }
        [Display(Name = "Vehicle Model")]
        public string VehicleColor { get; set; }
        [Display(Name = "Vehicle Color")]
        public string VehiclePlate { get; set; }
        [Display(Name = "Vehicle Year")]
        public int VehicleYear { get; set; }
        [Display(Name = "Last Vehicle Inspection")]
        public DateTimeOffset? VehicleInspected { get; set; }
    }
}
