using System.Web;
using System.Web.Optimization;

namespace SietemaMercadoLibre
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new Bundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new Bundle("~/bundles/complementos").Include(
                   "~/Scripts/scripts.js",
                   "~/Scripts/DataTables/jquery.dataTables.js", //dataTables JQUERY
                   "~/Scripts/DataTables/dataTables.responsive.js", //dataTables JQUERY
                   "~/Scripts/fontawesome/all.min.js"));//fontawesome

            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/Scripts/jquery.validate*"));

            // Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información sobre los formularios.  De esta manera estará
            // para la producción, use la herramienta de compilación disponible en https://modernizr.com para seleccionar solo las pruebas que necesite.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));

            bundles.Add(new Bundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.bundle.js")); //bootstrap

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/DataTables/css/jquery.dataTables.css",//dataTables JQUERY - CSS
                      "~/Content/DataTables/css/responsive.dataTables.css",//dataTables JQUERY - CSS
                      "~/Content/site.css" ));  //fontawesome


        }
    }
}
