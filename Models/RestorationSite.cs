using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PreCapstoneMCV5B.Models
{
    public class RestorationSite
    {
        public int RSiteID { get; set; }
        public string RName { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string HUC4 { get; set; }
        public string HUC5 { get; set; }
        public string County { get; set; }
        public string State { get; set; }
        public int UnitID { get; set; }

    }
}