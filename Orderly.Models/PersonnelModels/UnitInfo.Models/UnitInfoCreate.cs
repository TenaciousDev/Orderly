using Orderly.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Orderly.Models
{
    public class UnitInfoCreate
    {
        public int Id { get; set; }
        public int TeamId { get; set; }
        [ForeignKey(nameof(TeamId))]
        public virtual Team Team { get; set; }
        public string Role { get; set; }
        [Display(Name = "Arrival Date")]
        public DateTimeOffset Arrived { get; set; }
        [Display(Name = "Loss Date")]
        public DateTimeOffset? LossDate { get; set; }
        [Display(Name = "Duty Status")]
        public string DutyStatus { get; set; }
    }
}
