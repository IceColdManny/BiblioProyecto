using System;
using System.Collections.Generic;
using System.Collections;
using DataInterface;
using DataInterface.Services;

namespace BusinessLogic
{
    public static class BLPrestamos
    {
        private static DIPrestamos dataInterfacePrestamos = new DIPrestamos();

        public static List<DOPrestamos> GetAll()
        {
            List<DOPrestamos> listaPrestamos = new List<DOPrestamos>();

            IList informacionBD = dataInterfacePrestamos.GetAll();
            if (informacionBD != null)
            {
                foreach (var item in informacionBD)
                {
                    Type type = item.GetType();

                    DOPrestamos prestamo = new DOPrestamos();

                    prestamo.idLibro = Convert.ToInt32(type.GetProperty("ID_LIBRO").GetValue(item, null));
                    prestamo.idPrestamo = Convert.ToInt32(type.GetProperty("ID_PRESTAMO").GetValue(item, null));
                    prestamo.FechaPrestamo = Convert.ToDateTime(type.GetProperty("FECHA_PRESTAMO").GetValue(item, null)); //DUDA
                    prestamo.FechaDevolucion = Convert.ToDateTime(type.GetProperty("FECHA_DEV").GetValue(item, null)); //DUDA
                    prestamo.NombreUsuario = type.GetProperty("NOMBRE_USUARIO").GetValue(item, null).ToString();
                    prestamo.Telefono = Convert.ToInt32(type.GetProperty("TELEFONO").GetValue(item, null).ToString());
                    prestamo.Correo = type.GetProperty("CORREO").GetValue(item, null).ToString();
                    prestamo.Direccion = type.GetProperty("DIRECCION").GetValue(item, null).ToString();
                    prestamo.PrestamoDevuelto = Convert.ToBoolean(type.GetProperty("PRESTAMO_DEVUELTO").GetValue(item, null).GetType());

                    listaPrestamos.Add(prestamo);
                }
            }
            return listaPrestamos;
        }

        public static int InsertOrUpdatePrestamos(DOPrestamos prestamo)
        {
            return dataInterfacePrestamos.InsertOrUpdatePrestamos(prestamo.idLibro, prestamo.idPrestamo, prestamo.FechaPrestamo,
                prestamo.FechaDevolucion, prestamo.NombreUsuario, prestamo.Telefono, prestamo.Correo, prestamo.Direccion, prestamo.PrestamoDevuelto);
        }

        public static bool DeletePrestamo(int idPrestamo)
        {
            return dataInterfacePrestamos.DeletePrestamo(idPrestamo);
        }

        public static bool MarcarDevuelto(int idPrestamo, bool PrestamoDevuelto)
        {
            return dataInterfacePrestamos.MarcarDevuelto(idPrestamo, PrestamoDevuelto);
        }
    }
}


