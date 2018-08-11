using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Models;

namespace Repository
{
    public class ReadOnlyRepository<TContext> : IReadOnlyRepository
    where TContext : DbContext
    {
        protected readonly TContext context;

        public ReadOnlyRepository(TContext context)
        {
            this.context = context;
        }

      

        public virtual sportScheduleFE GetSportScheduleFE(int moduleId)
        {
            return context.Set<sportScheduleFE>().Where(e => e.ModuleID == moduleId).FirstOrDefault();
        }
        
        public virtual gra_SportSchedule GetLeague(int? moduleId )
        {
            return context.Set<gra_SportSchedule>().Where(l => l.ModuleID == moduleId).FirstOrDefault();
        }

        public IEnumerable<gra_SportSchedule> GetLeagues()
        {
            return context.Set<gra_SportSchedule>();
        }

        public IEnumerable<gra_SportScheduleEventTeams> GetTeams(int moduleId)
        {
            return context.Set<gra_SportScheduleEventTeams>().Where(e => e.ModuleID == moduleId).OrderByDescending( g => g.Points);
        }

        public IEnumerable<gra_SportScheduleGames> GetGames(int moduleId)
        {
            
            return context.Set<gra_SportScheduleGames>().Where(e => e.ModuleID == moduleId);
        }

        public IEnumerable<gra_SportScheduleLocations> GetLocations(int moduleId)
        {

            return context.Set<gra_SportScheduleLocations>().Where(e => e.ModuleID == moduleId);
        }


    }
}
