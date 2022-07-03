using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SietemaMercadoLibre.Controllers
{
    public class AlmacenController : Controller
    {
        // GET: Almacen
        public ActionResult Almacen()
        {
            return View();
        }

        [HttpGet]
        public JsonResult ListaAlmacenes()
        {

            List<Almacen> oLista = new List<Almacen>();
            oLista = new CN_Almacen().Listar();
            return Json(new { data = oLista }, JsonRequestBehavior.AllowGet);
        }
    }
}