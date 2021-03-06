//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PreCapstoneMCV5B.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SamplePlot
    {
        public System.Guid SPlotID { get; set; }
        public Nullable<int> SPlotNo { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<double> Latitude { get; set; }
        public Nullable<double> Longitude { get; set; }
        public string Technician { get; set; }
        public string GPSDevice { get; set; }
        public Nullable<decimal> PlotSize { get; set; }
        public string Layer { get; set; }
        public string Genus { get; set; }
        public string Species { get; set; }
        public string Substrate { get; set; }
        public Nullable<double> PctCover { get; set; }
        public Nullable<int> HtClass { get; set; }
        public string Nativity { get; set; }
        public Nullable<double> MIndex { get; set; }
        public Nullable<double> WIndex { get; set; }
        public string PrairieCohort { get; set; }
        public string RareSpecies { get; set; }
        public string FocalSpecies { get; set; }
        public string Comments { get; set; }
        public Nullable<int> LayerID { get; set; }
        public Nullable<int> TransectID { get; set; }
    }
}
