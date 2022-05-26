using FelveteliFeladat.DataAccess.Data;
using FelveteliFeladat.DataAccess.Interfaces;
using FelveteliFeladat.DataAccess.Repository;
using FelveteliFeladat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelveteliFeladat.DataAccess.Repositories
{
    public class TeamRepository : Repository<Team>, ITeamRepository
    {
        public TeamRepository(FelveteliFeladatDbContext ctx) : base(ctx)
        {
        }       

        public void UpdateIsPayedTheEntryFee(int id, bool newValue)
        {
            Team old = Read(id);
            old.IsPayedTheEntryFee = newValue;
            ctx.SaveChanges();
        }
    }
}
