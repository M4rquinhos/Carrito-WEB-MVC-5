using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ECarrito
    {
        public int IdCarrito { get; set; }
        public ECliente OCliente { get; set; }
        public EProducto OProducto { get; set; }
        public int Cantidad { get; set; }
    }
}
