using PreCapstoneMCV5B.Models;
using PreCapstoneMCV5B.ViewModels;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace PreCapstoneMCV5B.Controllers
{
    public class SampleplotController : Controller
    {
        // GET: Sampleplot
        public ActionResult SPlot()
        {
            RestorationSite rs1 = new RestorationSite();
            rs1.RName = "Vancouver Water Resource Center";
            rs1.Latitude = 45.61362;
            rs1.Longitude = -123.6227;
            rs1.County = "Clark";
            rs1.State = "WA";

            RestorationSite rs2 = new RestorationSite();
            rs2.RName = "Jackson Frazier Wetland";
            rs2.Latitude = 44.60777;
            rs2.Longitude = -123.238989;
            rs2.County = "Benton";
            rs2.State = "OR";

            SamplePlots sp1 = new SamplePlots();

            sp1.SPlotID = 1;
            sp1.SPlotNumber = 1;
            sp1.Date = DateTime.Now;
            sp1.Latitude = 45.613620;
            sp1.Longitude = -122.622700;
            sp1.Technician = "Marshall";
            sp1.GPSDevice = "Geo-XH 2005";
            sp1.PlotSize = 706.5;
            sp1.Layer = "Herbaceous-Emergent";
            sp1.Genus = "Polygonum";
            sp1.Species = "persicaria";
            sp1.Substrate = "Silt";
            sp1.PctCover = 3;
            sp1.HtClass = 1;
            sp1.Nativity = "Native";
            sp1.MIndex = 2;
            sp1.WIndex = 1;
            sp1.PrairieCohort = false;
            sp1.RareSpecies = false;
            sp1.FocalSpecies = false;
            sp1.LayerID = 1;
            sp1.TransectID = 1;

            SamplePlots sp2 = new SamplePlots();

            sp2.SPlotID = 1;
            sp2.SPlotNumber = 1;
            sp2.Date = DateTime.Now;
            sp2.Latitude = 45.613620;
            sp2.Longitude = -122.622700;
            sp2.Technician = "Marshall";
            sp2.GPSDevice = "Geo-XH 2005";
            sp2.PlotSize = 706.5;
            sp2.Layer = "Herbaceous-Emergent";
            sp2.Genus = "Leersia";
            sp2.Species = "oryzoides";
            sp2.Substrate = "Silt";
            sp2.PctCover = 3;
            sp2.HtClass = 1;
            sp2.Nativity = "Native";
            sp2.MIndex = 1;
            sp2.WIndex = 1;
            sp2.PrairieCohort = false;
            sp2.RareSpecies = false;
            sp2.FocalSpecies = false;
            sp2.LayerID = 1;
            sp2.TransectID = 1;


            SamplePlots sp3 = new SamplePlots();

            sp3.SPlotID = 1;
            sp3.SPlotNumber = 1;
            sp3.Date = DateTime.Now;
            sp3.Latitude = 45.613620;
            sp3.Longitude = -122.622700;
            sp3.Technician = "Marshall";
            sp3.GPSDevice = "Geo-XH 2005";
            sp3.PlotSize = 706.5;
            sp3.Layer = "Herbaceous-Emergent";
            sp3.Genus = "Phalris";
            sp3.Species = "arundinacea";
            sp3.Substrate = "Silt";
            sp3.PctCover = 15;
            sp3.HtClass = 3;
            sp3.Nativity = "Non-Native Invasive";
            sp3.MIndex = 2;
            sp3.WIndex = 5;
            sp3.PrairieCohort = false;
            sp3.RareSpecies = false;
            sp3.FocalSpecies = false;
            sp3.LayerID = 1;
            sp3.TransectID = 1;

            List<SamplePlots> samplist = new List<SamplePlots>(15);
            samplist.Add(sp1);
            samplist.Add(sp2);
            samplist.Add(sp3);

            Models.AllSample_Components asc = new Models.AllSample_Components();
            asc.rSite = rs1;
            asc.listSplots = samplist;
            

            return View(asc);
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}