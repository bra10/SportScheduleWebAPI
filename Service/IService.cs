
using Models;
using Models.DTOs;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
   

    public interface IService
    {

        void CreateSportScheduleFE(sportScheduleFE entity);
        void UpdateSportScheduleFE(sportScheduleFE entity);
        League GetLeague(int id);
        sportScheduleFE GetSportScheduleFE(int moduleId);
        IEnumerable<League> GetLeagues();
        IEnumerable<Team> GetTeams(int moduleId);
        IEnumerable<Game> GetGames(int moduleId);
    }
}
