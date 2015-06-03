using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IronMan.Dominio.Modelos;
using IronMan.AccesoDatos;
using IronMan.DTO;
using IronMan.Gestores;

namespace IronManMVC.Controllers
{
    public class PruebasController : Controller
    {
        #region Declaración del acceso de los datos persistidos
        //El gestor corresponde al modelo en el patron MVC
        private IronManContext db = new IronManContext();
        private PruebaGestor _pGestor = new PruebaGestor();
        private EventoGestor _eGestor = new EventoGestor();
        #endregion

        class VistaPrueba
        {
            public List<PruebaDTO> pruebas {set; get; }
            public EventoDTO evento { set; get; }
        }
        // GET: Pruebas
        public ActionResult Index(int? id)
        {
            if (id == null)
            {
                return View(new VistaPrueba(){pruebas = _pGestor.Listar().ToList(), evento = null});
            }
            else
            {
                return View(new VistaPrueba() { pruebas = _pGestor.Listar(id).ToList(), evento = _eGestor.Obtener() });
            }
        }

        // GET: Pruebas/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Pruebas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pruebas/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Pruebas/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Pruebas/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Pruebas/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Pruebas/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
