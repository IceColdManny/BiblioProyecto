using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database;

namespace DataInterface.Services
{
    public class DIPrestamos
    {
        private PrestamosServices servicesPrestamo;

        public DIPrestamos()
        {
            servicesPrestamo = new PrestamosServices();
        }

        public IList GetAll()
        {
            return servicesPrestamo.GetAll();
        }

        public int InsertOrUpdatePrestamos(int idLibro, int idPrestamo, DateTime FechaPrestamo, DateTime FechaDevolucion,
            string NombreUsuario, int Telefono, string Correo, string Direccion, bool PrestamoDevuelto)
        {
            return servicesPrestamo.InsertOrUpdatePrestamos(idLibro, idPrestamo, FechaPrestamo,
                FechaDevolucion, NombreUsuario, Telefono, Correo, Direccion, PrestamoDevuelto);
        }

        public bool DeletePrestamo(int idPrestamo)
        {
            return servicesPrestamo.DeletePrestamo(idPrestamo);
        }

        public bool MarcarDevuelto(int idPrestamo, bool PrestamoDevuelto)
        {
            return servicesPrestamo.MarcarDevuelto(idPrestamo, PrestamoDevuelto);
        }

    }
}
