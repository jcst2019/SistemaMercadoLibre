using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Almacen
    {
        private CD_Almacen objCapaDato = new CD_Almacen();

        public List<Almacen> Listar()
        {

            return objCapaDato.Listar();
        }
    }
}
