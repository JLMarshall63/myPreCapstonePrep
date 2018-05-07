using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PreCapstoneMCV5B.Models
{
    public class SamplePlots
    {
        public int SPlotID { get; set; }
        public int SPlotNumber { get; set; }
        public DateTime Date { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Technician { get; set; }
        public string GPSDevice { get; set; }
        public double PlotSize { get; set; }
        public string Layer { get; set; }
        public string Genus { get; set; }
        public string Species { get; set; }
        public string Substrate { get; set; }
        public double PctCover { get; set; }
        public int HtClass { get; set; }
        public string Nativity { get; set; }
        public double MIndex { get; set; }
        public double WIndex { get; set; }
        public bool PrairieCohort { get; set; }
        public bool RareSpecies { get; set; }
        public bool FocalSpecies { get; set; }
        public string Comments { get; set; }
        public int LayerID { get; set; }
        public int TransectID { get; set; }

    }
}