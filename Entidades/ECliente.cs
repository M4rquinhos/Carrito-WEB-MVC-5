using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
	/*
	IdCliente INT PRIMARY KEY IDENTITY (1, 1),
	Nombre VARCHAR(100),
	Apellidos VARCHAR(100),
	Correo VARCHAR(100),
	Clave VARCHAR(150),
	Reestablecer BIT DEFAULT 1,
	FechaRegistro DATETIME DEFAULT GETDATE()
     */
	public class ECliente
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }
        public bool Restablecer { get; set; }
    }
}
