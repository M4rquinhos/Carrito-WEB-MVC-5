using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Negocio;
using Entidades;

namespace PresentacionAdmin.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Usuarios()
        {
            return View();
        }

        public JsonResult ListarUsuarios()
        {
            List<EUsuario> oLista = new List<EUsuario>();
            oLista = new NUsuarios().Listar();

            return Json(oLista, JsonRequestBehavior.AllowGet);
        }
    }
}