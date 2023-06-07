using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DUsuarios
    {
        public List<EUsuario> Listar()
        {
            List<EUsuario> lista = new List<EUsuario>();

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cn))
                {
                    SqlCommand comando = new SqlCommand("sp_Listar_Usuarios", conexion);
                    comando.CommandType = CommandType.StoredProcedure;
                    conexion.Open();
                    using (SqlDataReader dr = comando.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new EUsuario() 
                            { 
                                IdUsuario = Convert.ToInt32(dr["IdUusario"]),
                                Nombre = dr["Nombre"].ToString(),
                                Apellidos = dr["Apellidos"].ToString(),
                                Correo = dr["Correo"].ToString(),
                                Clave = dr["Clave"].ToString(),
                                Restablecer = Convert.ToBoolean(dr["Reestablecer"]),
                                Activo = Convert.ToBoolean(dr["Activo"]),
                            });
                        }
                    }
                }

            }
            catch (Exception)
            {
                lista = new List<EUsuario>();
                //throw;
            }

            return lista;
        }
    }
}
