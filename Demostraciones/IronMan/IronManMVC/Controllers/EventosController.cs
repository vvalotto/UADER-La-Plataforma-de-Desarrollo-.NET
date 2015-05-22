using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using IronMan.Dominio.Modelos;
using IronMan.AccesoDatos;
using IronMan.DTO;
using IronMan.Gestores;

namespace IronManMVC.Controllers
{
    public class EventosController : Controller
    {
        #region Declaración del acceso de los datos persistidos
        //El gestor corresponde al modelo en el patron MVC
        private IronManContext db = new IronManContext();
        private EventoGestor _eGestor = new EventoGestor();
        #endregion

        #region Lista de Eventos - Solo GET
        // GET: /Eventos/
        //Recupera la lista de Eventos
        public ActionResult Index()
        {
            return View(_eGestor.Listar().ToList());
        }
        #endregion

        #region Mostrar Uun evento - Solo GET
        // GET: /Eventos/Details/5
        //Muestra los detalles del evento
        public ActionResult Details(int id)
        {
            if (id == 0)
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
        #endregion

        #region Crear Evento - GET y POST
        // GET: /Eventos/Create
        //
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Eventos/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        // Crea un evento
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Id,Nombre,Fecha,Lugar,Comentario,EstaHabilitado")] EventoDTO evento)
        {
            if (ModelState.IsValid)
            {
                _eGestor.Guardar(evento);
                return RedirectToAction("Index");
            }

            return View(evento);
        }
        #endregion

        #region Modificar Evento - GET y POST
        // GET: /Eventos/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == 0)
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

        // POST: /Eventos/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        // Guarda la modificaciones del Evento
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Id,Nombre,Fecha,Lugar,Comentario,EstaHabilitado")] EventoDTO evento)
        {
            if (ModelState.IsValid)
            {
                _eGestor.Guardar(evento);
                return RedirectToAction("Index");
            }
            return View(evento);
        }
        #endregion

        #region Eliminar Evento (Dehabilitar) - GET y POST
        // GET: /Eventos/Delete/5
        public ActionResult Delete(int id)
        {
            if (id == 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            EventoDTO evento = _eGestor.Obtener(id); ;
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
            return RedirectToAction("Index");
        }
        #endregion

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
