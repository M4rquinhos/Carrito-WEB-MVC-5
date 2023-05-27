using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
	/*
	IdProducto INT PRIMARY KEY IDENTITY (1, 1),
	Nombre VARCHAR(500),
	Descripcion VARCHAR(500),
	IdMarca INT, --Fk
	IdCategoria INT, --FK
	Precio DECIMAL (10, 2) DEFAULT 0,
	Stock INT,
	RutaImagen VARCHAR(100),
	NombreImagen VARCHAR(100),
	Activo BIT DEFAULT 1,
	FechaRegistro DATETIME DEFAULT GETDATE(),
     */

	public class EProducto
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int IdMarca { get; set; }
        public int IdCategoria { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public string RutaImagen { get; set; }
        public string NombreImagen { get; set; }
        public bool Activo { get; set; }
    }
}
