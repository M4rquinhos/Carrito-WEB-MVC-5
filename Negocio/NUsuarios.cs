using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class NUsuarios
    {
        private DUsuarios datos = new DUsuarios();
        public List<EUsuario> Listar()
        {
            return datos.Listar();
        } 
    }
}
