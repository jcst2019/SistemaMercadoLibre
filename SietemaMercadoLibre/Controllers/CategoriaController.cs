using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SietemaMercadoLibre.Controllers
{
    public class CategoriaController : Controller
    {
        // GET: Categoria
        public ActionResult Categoria()
        {
            return View();
        }
        [HttpGet]
        public JsonResult ListaCategorias()
        {

            List<Categoria> oLista = new List<Categoria>();
            oLista = new CN_Categoria().Listar();
            return Json(new { data = oLista }, JsonRequestBehavior.AllowGet);
        }
    }
}