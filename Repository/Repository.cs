using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Repository
{
    public class Repository<TContext> :ReadOnlyRepository<TContext> , IRepository
    where TContext : DbContext
    {
        public Repository(TContext context): base(context)
        {
        }

        public virtual void CreateSportScheduleFE(sportScheduleFE entity)
        {
            entity.CreatedDate = DateTime.UtcNow;
            context.Set<sportScheduleFE>().Add(entity);
        }

       

        public virtual void UpdateSportScheduleFE(sportScheduleFE entity)

        {
            /*
            var original = context.Set<sportScheduleFE>().Where(e => e.ModuleID == entity.ModuleID).FirstOrDefault();
            entity.CreatedDate = original.CreatedDate;
            context.Entry(original).CurrentValues.SetValues(entity);
            */

            var sportScheduleFE = context.Set<sportScheduleFE>().Where(e => e.ModuleID == entity.ModuleID).FirstOrDefault();
            sportScheduleFE.LeagueID = entity.LeagueID;

        }


    }
}