using FelveteliFeladat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelveteliFeladat.Logic.Interfaces
{
    public interface ITeamLogic
    {
        void Create(Team team);
        void Delete(int id);
        IEnumerable<Team> ReadAll();
        Team Read(int id);
        void Update(Team car);
    }
}
