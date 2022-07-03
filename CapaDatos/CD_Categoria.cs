using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_Categoria
    {
        public List<Categoria> Listar() {

            List<Categoria> lista = new List<Categoria>();
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cn)) {
                    string query = "select IdCategoria,Descripcion  from categoria";
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader()) {
                        while (dr.Read()) {
                            lista.Add(new Categoria()
                            {
                                IdCategoria = Convert.ToInt32(dr["IdCategoria"]),
                                Descripcion = dr["Descripcion"].ToString()

                            });
         
                        }
                    }
                      
                }
            }
            catch { 
                lista = new List<Categoria>();
            }
            return lista;
        }
    }
}
