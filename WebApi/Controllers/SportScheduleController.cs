

using Models;
using Models.DTOs;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace WebApi.Controllers
{
    public class SportScheduleController : ApiController
    {

        public IService _service;

        public SportScheduleController(IService service)
        {
            _service = service;
        }


        

        [Route("postSportScheduleFE")]
        public IHttpActionResult PostSportScheduleFE(sportScheduleFE entity)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _service.CreateSportScheduleFE(entity);


            return CreatedAtRoute("DefaultApi", new { controller = "SportScheduleController", id = entity.ModuleID }, entity);

        }

        [Route("putSportScheduleFE/{moduleId}")]
        public IHttpActionResult PutSportScheduleFE(int moduleId, sportScheduleFE entity)
        {


            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (moduleId != entity.ModuleID)
            {
                return BadRequest();
            }


            _service.UpdateSportScheduleFE(entity);



            return StatusCode(HttpStatusCode.NoContent);
        }

        
        [Route("sportScheduleFE/{moduleId}")  ]
        public IHttpActionResult getSportScheduleFE( int moduleId )
        {
            var sportScheduleFE = _service.GetSportScheduleFE(moduleId);
            if (sportScheduleFE == null)
            {
                return NotFound();
            }
            return Ok(sportScheduleFE);


            
        }

        [Route("league/{moduleId}")]
        public League getLeague(int moduleId)
        {
            return _service.GetLeague(moduleId);
        }

        [Route("leagues")]
        public IEnumerable<League> GetLeagues()
        {
            return _service.GetLeagues();
        }

        

        [Route("teams/{moduleId}")]
        public IEnumerable<Team> GetTeams( int moduleId )
        {
            return _service.GetTeams(moduleId);
        }

        [Route("games/{moduleId}")]
        public IEnumerable<Game> GetGames(int moduleId)
        {
            return _service.GetGames(moduleId);
        }
    }
}
