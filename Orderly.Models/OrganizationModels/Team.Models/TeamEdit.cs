using Orderly.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Orderly.Models
{
    public class TeamEdit
    {
        public int Id { get; set; }
        public int SquadId { get; set; }
        [ForeignKey(nameof(SquadId))]
        public virtual Squad Squad { get; set; }
        [Required]
        [Display(Name = "Team")]
        public string Name { get; set; }
        public string Familiar { get; set; }
        public List<Personnel> Assigned { get; set; } = new List<Personnel>();

    }
}
