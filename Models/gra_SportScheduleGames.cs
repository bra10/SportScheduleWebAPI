//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class gra_SportScheduleGames
    {
        public int ModuleID { get; set; }
        public int GameId { get; set; }
        public Nullable<int> LocationId { get; set; }
        public Nullable<int> GameNumber { get; set; }
        public string GameType { get; set; }
        public Nullable<System.DateTime> GameDate { get; set; }
        public Nullable<int> GameHour { get; set; }
        public Nullable<int> GameMin { get; set; }
        public string GameAmPm { get; set; }
        public string TeamName1 { get; set; }
        public string TeamName2 { get; set; }
        public Nullable<int> TeamScore1 { get; set; }
        public Nullable<int> TeamScore2 { get; set; }
        public string TeamId1 { get; set; }
        public string TeamId2 { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<System.DateTime> LastModified { get; set; }
        public Nullable<int> CreatedByUser { get; set; }
        public Nullable<int> ViewOrder { get; set; }
        public Nullable<System.DateTime> GameTime { get; set; }
    }
}
