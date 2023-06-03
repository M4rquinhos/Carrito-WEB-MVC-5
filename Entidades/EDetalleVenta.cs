using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EDetalleVenta
    {
        public int IdDetalleVenta { get; set; }
        public EVenta OVenta { get; set; }
        public EProducto OProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal Total { get; set; }
        public string IdTransaccion { get; set; }
    }
}
