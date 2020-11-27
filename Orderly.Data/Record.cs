using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Orderly.Data
{
    public class Record
    {
        [Key]
        public int Id { get; set; }
        public int PersonnelId { get; set; }
        [ForeignKey(nameof(PersonnelId))]
        public virtual Personnel Personnel { get; set; }
        public int? ContactId { get; set; }
        [ForeignKey(nameof(ContactId))]
        public virtual Contact Contact { get; set; }
        public int? HousingId { get; set; }
        [ForeignKey(nameof(HousingId))]
        public virtual Housing Housing { get; set; }
        public int? UnitInfoId { get; set; }
        [ForeignKey(nameof(UnitInfoId))]
        public virtual UnitInfo UnitInfo { get; set; }
        public int? TeamId { get; set; }
        [ForeignKey(nameof(TeamId))]
        public virtual Team Team { get; set; }
        public int? SquadId { get; set; }
        [ForeignKey(nameof(SquadId))]
        public virtual Squad Squad { get; set; }
        public int? PlatoonId { get; set; }
        [ForeignKey(nameof(PlatoonId))]
        public virtual Platoon Platoon { get; set; }
    }
}
