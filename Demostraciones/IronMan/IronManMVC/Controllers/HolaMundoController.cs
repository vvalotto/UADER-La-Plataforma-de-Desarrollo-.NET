using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IronManMVC.Controllers
{
    public class HolaMundoController : Controller
    {
        //
        // GET: /HolaMundo/
        public ActionResult Index()
        {
            return View();
        }

        // GET: /HelloWorld/Welcome/ 

        public string Welcome(string nombre, int num=1)
        {
            return HttpUtility.HtmlEncode("Hola " + nombre + ", num es: " + num);
        }
	}
}