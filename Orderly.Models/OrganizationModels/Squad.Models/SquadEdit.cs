using Orderly.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Orderly.Models
{
    public class SquadEdit
    {
        public int Id { get; set; }
        public int PlatoonId { get; set; }
        [ForeignKey(nameof(PlatoonId))]
        public virtual Platoon Platoon { get; set; }
        [Required]
        [Display(Name = "Squad")]
        public string Name { get; set; }
        public string Familiar { get; set; }
        [Display(Name = "Personnel Assigned")]
        public List<Personnel> Assigned { get; set; } = new List<Personnel>();
        public List<Team> Teams { get; set; } = new List<Team>();

    }
}
