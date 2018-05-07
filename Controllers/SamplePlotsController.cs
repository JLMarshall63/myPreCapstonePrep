using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PreCapstoneMCV5B.Models;

namespace PreCapstoneMCV5B.Controllers
{
    public class SamplePlotsController : Controller
    {
        private VegStructEntities db = new VegStructEntities();

        // GET: SamplePlots
        public ActionResult Index()
        {
            return View(db.SamplePlots.ToList());
        }

        // GET: SamplePlots/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SamplePlot samplePlot = db.SamplePlots.Find(id);
            if (samplePlot == null)
            {
                return HttpNotFound();
            }
            return View(samplePlot);
        }

        // GET: SamplePlots/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SamplePlots/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SPlotID,SPlotNo,Date,Latitude,Longitude,Technician,GPSDevice,PlotSize,Layer,Genus,Species,Substrate,PctCover,HtClass,Nativity,MIndex,WIndex,PrairieCohort,RareSpecies,FocalSpecies,Comments,LayerID,TransectID")] SamplePlot samplePlot)
        {
            if (ModelState.IsValid)
            {
                samplePlot.SPlotID = Guid.NewGuid();
                db.SamplePlots.Add(samplePlot);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(samplePlot);
        }

        // GET: SamplePlots/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SamplePlot samplePlot = db.SamplePlots.Find(id);
            if (samplePlot == null)
            {
                return HttpNotFound();
            }
            return View(samplePlot);
        }

        // POST: SamplePlots/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SPlotID,SPlotNo,Date,Latitude,Longitude,Technician,GPSDevice,PlotSize,Layer,Genus,Species,Substrate,PctCover,HtClass,Nativity,MIndex,WIndex,PrairieCohort,RareSpecies,FocalSpecies,Comments,LayerID,TransectID")] SamplePlot samplePlot)
        {
            if (ModelState.IsValid)
            {
                db.Entry(samplePlot).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(samplePlot);
        }

        // GET: SamplePlots/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SamplePlot samplePlot = db.SamplePlots.Find(id);
            if (samplePlot == null)
            {
                return HttpNotFound();
            }
            return View(samplePlot);
        }

        // POST: SamplePlots/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            SamplePlot samplePlot = db.SamplePlots.Find(id);
            db.SamplePlots.Remove(samplePlot);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
