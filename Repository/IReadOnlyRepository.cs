using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IReadOnlyRepository
    {

        sportScheduleFE GetSportScheduleFE(int moduleId);
        gra_SportSchedule GetLeague(int? moduleId);
        IEnumerable<gra_SportSchedule> GetLeagues();
        IEnumerable<gra_SportScheduleEventTeams> GetTeams(int moduleId);
        IEnumerable<gra_SportScheduleGames> GetGames(int moduleId);
        IEnumerable<gra_SportScheduleLocations> GetLocations(int moduleId);


    }
}