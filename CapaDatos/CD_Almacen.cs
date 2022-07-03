using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Almacen
    {
        public List<Almacen> Listar()
        {

            List<Almacen> lista = new List<Almacen>();
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cn))
                {
                    string query = "select IdAlmacen,Descripcion, Activo  from almacen";
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Almacen()
                            {
                                IdAlmacen = Convert.ToInt32(dr["IdAlmacen"]),
                                Descripcion = dr["Descripcion"].ToString(),
                                Activo = Convert.ToBoolean(dr["Activo"])

                            });

                        }
                    }

                }
            }
            catch
            {
                lista = new List<Almacen>();
            }
            return lista;
        }
    }
}
