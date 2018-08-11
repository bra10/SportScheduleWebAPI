using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Models.DTOs
{
    public class League
    {
        public int ModuleID { get; set; }
        public string Title { get; set; }
        public int CreatedByUser { get; set; }
        public System.DateTime CreatedDate { get; set; }

    }
}