using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DetalleKnockoutASM.DAL;
using DetalleKnockoutASM.Models;

namespace DetalleKnockoutASM.Controllers
{
    public class DetalleCotizacionesController : Controller
    {
        private CotizacionesDb db = new CotizacionesDb();

        // GET: DetalleCotizaciones
        public ActionResult Index()
        {
            return View(db.DetalleCotizaciones.ToList());
        }

        // GET: DetalleCotizaciones/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DetalleCotizaciones detalleCotizaciones = db.DetalleCotizaciones.Find(id);
            if (detalleCotizaciones == null)
            {
                return HttpNotFound();
            }
            return View(detalleCotizaciones);
        }

        // GET: DetalleCotizaciones/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DetalleCotizaciones/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CotizacionDetalleId,CotizacionId,ArticuloId,Articulo,Cantidad,SubTotal")] DetalleCotizaciones detalleCotizaciones)
        {
            if (ModelState.IsValid)
            {
                db.DetalleCotizaciones.Add(detalleCotizaciones);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(detalleCotizaciones);
        }
        public JsonResult Save(List<DetalleCotizaciones> detalles)
        {
            bool resultado = BLL.DetalleCotizacionesBLL.Save(detalles);

            return Json(resultado, JsonRequestBehavior.AllowGet);
        }
        // GET: DetalleCotizaciones/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DetalleCotizaciones detalleCotizaciones = db.DetalleCotizaciones.Find(id);
            if (detalleCotizaciones == null)
            {
                return HttpNotFound();
            }
            return View(detalleCotizaciones);
        }

        // POST: DetalleCotizaciones/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CotizacionDetalleId,CotizacionId,ArticuloId,Articulo,Cantidad,SubTotal")] DetalleCotizaciones detalleCotizaciones)
        {
            if (ModelState.IsValid)
            {
                db.Entry(detalleCotizaciones).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(detalleCotizaciones);
        }

        // GET: DetalleCotizaciones/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DetalleCotizaciones detalleCotizaciones = db.DetalleCotizaciones.Find(id);
            if (detalleCotizaciones == null)
            {
                return HttpNotFound();
            }
            return View(detalleCotizaciones);
        }

        // POST: DetalleCotizaciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DetalleCotizaciones detalleCotizaciones = db.DetalleCotizaciones.Find(id);
            db.DetalleCotizaciones.Remove(detalleCotizaciones);
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
