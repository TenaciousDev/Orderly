using Orderly.Data;
using Orderly.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orderly.Services
{
    public class RecordService
    {
        private readonly ApplicationUser _user;

        public RecordService(ApplicationUser user)
        {
            _user = user;
        }
        public bool CreateRecord(RecordCreate model)
        {
            var entity = new Record()
            {
                PersonnelId = model.PersonnelId,
                ContactId = model.ContactId,
                HousingId = model.HousingId,
                UnitInfoId = model.UnitInfoId,
                PlatoonId = model.PlatoonId,
                SquadId = model.SquadId,
                TeamId = model.TeamId,
                CreatedBy = _user,
                CreatedUtc = DateTimeOffset.Now.Date,
            };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Records.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public IEnumerable<RecordListItem> GetRecords()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    from r in ctx.Records
                    select new RecordListItem
                    {
                        PersonnelId = r.PersonnelId,
                        ContactId = r.ContactId,
                        HousingId = r.HousingId,
                        UnitInfoId = r.UnitInfoId,
                        TeamId = r.TeamId,
                        SquadId = r.SquadId,
                        PlatoonId = r.PlatoonId,
                        CreatedBy = r.CreatedBy,
                        ModifiedBy = r.ModifiedBy,
                        CreatedUtc = r.CreatedUtc,
                        ModifiedUtc = r.ModifiedUtc
                    };
                return query.ToArray();
            }
        }
        public RecordDetail GetRecordById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var record = (
                    from entity in ctx.Records
                    where entity.Id == id
                    select new RecordDetail
                    {
                        Personnel = entity.Personnel,
                        Contact = entity.Contact,
                        Housing = entity.Housing,
                        UnitInfo = entity.UnitInfo,
                        Platoon = entity.Platoon,
                        Squad = entity.Squad,
                        Team = entity.Team,
                        CreatedBy = entity.CreatedBy,
                        ModifiedBy = entity.ModifiedBy,
                        CreatedUtc = entity.CreatedUtc,
                        ModifiedUtc = entity.ModifiedUtc
                    }
                              ).SingleOrDefault();
                return record;
            }
        }
        public bool UpdateRecord(RecordEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var u = ctx.Users.Find(_user);
                var record = (
                    from r in ctx.Records
                    where r.Id == model.Id
                    select new RecordEdit
                    {
                        PersonnelId = r.PersonnelId,
                        ContactId = r.ContactId,
                        HousingId = r.HousingId,
                        UnitInfoId = r.UnitInfoId,
                        TeamId = r.TeamId,
                        SquadId = r.SquadId,
                        PlatoonId = r.PlatoonId,
                        ModifiedBy = u,
                        ModifiedUtc = DateTimeOffset.Now.Date
                    }
                    ).SingleOrDefault();
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
