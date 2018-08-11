using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Models.DTOs
{
    public class Team
    {
        public int? Id { get; set; }
        public string TeamName { get; set; }
        public int? PlayedGames { get; set; }
        public int? Wins { get; set; }
        public int? Losses { get; set; }
        public int? Ties { get; set; }
        public int? RunsFor { get; set; }
        public int? RunsAgainst { get; set; }
        public int? Points { get; set; }
    }
}