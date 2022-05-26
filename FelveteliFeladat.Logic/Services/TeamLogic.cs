using FelveteliFeladat.DataAccess.Interfaces;
using FelveteliFeladat.Logic.Interfaces;
using FelveteliFeladat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelveteliFeladat.Logic.Services
{
    public class TeamLogic : ITeamLogic
    {
        ITeamRepository teamRepository;
        public TeamLogic(ITeamRepository teamRepository)
        {
            this.teamRepository = teamRepository;
        }

        public void Create(Team team)
        {
            teamRepository.Create(team);
        }

        public void Delete(int id)
        {
            teamRepository.Delete(id);
        }

        public Team Read(int id)
        {
            return teamRepository.Read(id) ?? throw new ArgumentException("Car with the specified id does not exists.");
        }

        public IEnumerable<Team> ReadAll()
        {
            return teamRepository.ReadAll();
        }

        public void Update(Team car)
        {
            teamRepository.Update(car);
        }
    }
}
