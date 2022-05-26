using FelveteliFeladat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelveteliFeladat.DataAccess.Interfaces
{
    public interface ITeamRepository : IRepository<Team>
    {
        void UpdateIsPayedTheEntryFee(int id, bool newValue);
    }
}
