using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EVenta
    {
        public int IdVenta { get; set; }
        public ECliente OCliente { get; set; }
        public int TotalProducto { get; set; }
        public decimal MontoTotal { get; set; }
        public string IdDistrito { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string IdTransaccion { get; set; }
        public List<EDetalleVenta> ODetalleVenta { get; set; }
    }
}
