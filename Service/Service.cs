

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
    public class Service:IService
    {
        IUnitOfWork _unitOfWork;
        IRepository _repository;

        public Service(IUnitOfWork unitOfWork, IRepository repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }

        public virtual void CreateSportScheduleFE(sportScheduleFE entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            var sportScheduleFE = _repository.GetSportScheduleFE(entity.ModuleID);

            if( sportScheduleFE == null )
            {
                _repository.CreateSportScheduleFE(entity);
            }
            else
            {
                _repository.UpdateSportScheduleFE(entity);
            }

            
            _unitOfWork.Commit();
        }


        public League GetLeague( int id )
        {
            var sportScheduleFE = _repository.GetSportScheduleFE(id);

            if ( sportScheduleFE == null )
            {
                return null;
            }
            var league = _repository.GetLeague(sportScheduleFE.LeagueID);

            return new League { ModuleID = league.ModuleID , Title =  league.Title };
        }


        public IEnumerable<League> GetLeagues()
        {
            var query = _repository.GetLeagues().Select
                     (e => new League
                     {

                         ModuleID = e.ModuleID,
                         Title = e.Title,
                         CreatedByUser = e.CreatedByUser,
                         CreatedDate = e.CreatedDate
                     }
                     );

            return query;
        }

      

        public IEnumerable<Team> GetTeams(int moduleId)
        {
            var query = _repository.GetTeams(moduleId).Select
                     (gt => new Team
                     {
                         Id = gt.TeamId,
                         TeamName = gt.TeamName,
                         PlayedGames = gt.Wins + gt.Losses + gt.Ties,
                         Wins = gt.Wins,
                         Losses = gt.Losses,
                         Ties = gt.Ties,
                         RunsFor = gt.RunsFor,
                         RunsAgainst = gt.RunsAgainst,
                         Points = gt.Points
                     }
                     );

            return query;
        }

        public IEnumerable<Game> GetGames(int moduleId)
        {
            var calendarTable = _repository.GetGames(moduleId);
            var locationsTable = _repository.GetLocations(moduleId);


            var query = calendarTable.Join(locationsTable,
                calendar => calendar.LocationId,
                location => location.LocationId,
                (calendar, location) => new { calendarTable = calendar, locationsTable = location }

                ).Select
                     (c => new Game
                     {
                        
                         GameId = c.calendarTable.GameId,
                         GameNumber = c.calendarTable.GameNumber,
                         GameType = c.calendarTable.GameType,
                         GameDate = c.calendarTable.GameDate,
                         GameHour = c.calendarTable.GameHour,
                         GameMin = c.calendarTable.GameMin,
                         GameAmPm = c.calendarTable.GameAmPm,
                         TeamName1 = c.calendarTable.TeamName1,
                         TeamName2 = c.calendarTable.TeamName2,
                         TeamScore1 = c.calendarTable.TeamScore1,
                         TeamScore2 = c.calendarTable.TeamScore2,
                         GameTime = c.calendarTable.GameTime,
                         LocationName = c.locationsTable.LocationName
                     }
                     );

            return query;
        }

        public void UpdateSportScheduleFE(sportScheduleFE entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");
            _repository.UpdateSportScheduleFE(entity);
            _unitOfWork.Commit();
        }

        public sportScheduleFE GetSportScheduleFE(int moduleId)
        {
            return _repository.GetSportScheduleFE(moduleId);
        }
    }
}
