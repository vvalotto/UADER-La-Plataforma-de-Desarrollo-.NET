using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using IronMan.Dominio.Modelos;
using IronMan.Dominio.AccesoDatos;
using IronMan.DTO;
using IronMan.Gestores;

namespace IronManMVC.Controllers
{
    public class EventosController : Controller
    {
        private IronManContext db = new IronManContext();
        private EventoGestor _eGestor = new EventoGestor();

        // GET: /Eventos/
        public ActionResult Index()
        {
            return View(_eGestor.Listar().ToList());
        }

        // GET: /Eventos/Details/5
        public ActionResult Details(int id)
        {
            if (id == null && id == 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EventoDTO evento = _eGestor.Obtener(id);
            if (evento == null)
            {
                return HttpNotFound();
            }
            return View(evento);
        }

        // GET: /Eventos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Eventos/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Id,Nombre,Fecha,Lugar,Comentario,EstaHabilitado")] EventoDTO evento)
        {
            if (ModelState.IsValid)
            {
                //db.Eventos.Add(evento);
                _eGestor.Guardar(evento);
                //db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(evento);
        }

        // GET: /Eventos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Evento evento = db.Eventos.Find(id);
            if (evento == null)
            {
                return HttpNotFound();
            }
            return View(evento);
        }

        // POST: /Eventos/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Id,Nombre,Fecha,Lugar,Comentario,EstaHabilitado")] EventoDTO evento)
        {
            if (ModelState.IsValid)
            {
                //db.Entry(evento).State = EntityState.Modified;
                //db.SaveChanges();
                _eGestor.Guardar(evento);
                return RedirectToAction("Index");
            }
            return View(evento);
        }

        // GET: /Eventos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Evento evento = db.Eventos.Find(id);
            if (evento == null)
            {
                return HttpNotFound();
            }
            return View(evento);
        }

        // POST: /Eventos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EventoDTO evento = _eGestor.Obtener(id);
            _eGestor.Deshabilitar(evento);
            //db.SaveChanges();
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
