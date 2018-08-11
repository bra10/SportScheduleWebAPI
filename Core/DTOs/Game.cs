using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Models.DTOs
{
    public class Game
    {
        
        public int GameId { get; set; }
        public Nullable<int> GameNumber { get; set; }
        public string GameType { get; set; }
        public Nullable<DateTime> GameDate { get; set; }
        public Nullable<int> GameHour { get; set; }
        public Nullable<int> GameMin { get; set; }
        public string GameAmPm { get; set; }
        public string TeamName1 { get; set; }
        public string TeamName2 { get; set; }
        public Nullable<int> TeamScore1 { get; set; }
        public Nullable<int> TeamScore2 { get; set; }
        public Nullable<int> Status { get; set; }
        public string LocationName { get; set; }
        public Nullable<System.DateTime> GameTime { get; set; }
    }
}