using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class DOPrestamos
    {
        public int idLibro { get; set; }
        public int idPrestamo { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public string NombreUsuario { get; set; }
        public int Telefono { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
        public bool PrestamoDevuelto { get; set; }
    }
}
