using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /*
	IdMarca INT PRIMARY KEY IDENTITY (1, 1), 
	Descripcion VARCHAR(100),
	Activo BIT DEFAULT 1,
	FechaRegistro DATETIME DEFAULT GETDATE()
     */

    public class EMarca
    {
        public int IdMarca { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }
    }
}
