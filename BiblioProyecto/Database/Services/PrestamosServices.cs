using Database;
using System;
using System.Collections;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;


namespace Database
{
    public class PrestamosServices
    {
        public IList GetAll()
        {
            try
            {
                using (var conexion = new BIBLIOTECAPREntities())
                {
                    var lista = (from a in conexion.PRESTAMOS select a).ToList();

                    return lista;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public int InsertOrUpdatePrestamos(int idLibro, int idPrestamo, DateTime FechaPrestamo, DateTime FechaDevolucion,
            string NombreUsuario, int Telefono, string Correo, string Direccion, bool PrestamoDevuelto)
        {
            try
            {
                using (var conexion = new BIBLIOTECAPREntities())
                {
                    PRESTAMOS prestamo = conexion.PRESTAMOS.Where(x => x.ID_PRESTAMO == idPrestamo).FirstOrDefault();
                    if (prestamo == null)
                    {

                        prestamo = new PRESTAMOS();
                        prestamo.ID_PRESTAMO = idPrestamo;
                        prestamo.ID_LIBRO = idLibro;
                        prestamo.FECHA_PRESTAMO = FechaPrestamo;
                        prestamo.FECHA_DEV = FechaDevolucion;
                        prestamo.NOMBRE_USUARIO = NombreUsuario;
                        prestamo.TELEFONO = Telefono;
                        prestamo.CORREO = Correo;
                        prestamo.DIRECCION = Direccion;
                        prestamo.PRESTAMO_DEVUELTO = PrestamoDevuelto;
                        conexion.PRESTAMOS.Add(prestamo);
                    }
                    else
                    {

                        prestamo.ID_LIBRO = idLibro;
                        prestamo.FECHA_PRESTAMO = DateTime.Now;
                        prestamo.FECHA_DEV = DateTime.Now.AddDays(30);
                        prestamo.NOMBRE_USUARIO = NombreUsuario;
                        prestamo.TELEFONO = Telefono;
                        prestamo.CORREO = Correo;
                        prestamo.PRESTAMO_DEVUELTO = PrestamoDevuelto;
                        conexion.PRESTAMOS.Add(prestamo);

                        conexion.PRESTAMOS.Add(prestamo);
                        conexion.Entry(prestamo).State = EntityState.Modified;
                    }

                    return conexion.SaveChanges();
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public bool DeletePrestamo(int idPrestamo)
        {
            try
            {
                using (var conexion = new BIBLIOTECAPREntities())
                {
                    var PrestamoToDelete = conexion.PRESTAMOS.FirstOrDefault(m => m.ID_PRESTAMO == idPrestamo);
                    if (PrestamoToDelete != null)
                    {
                        conexion.PRESTAMOS.Remove(PrestamoToDelete);

                        conexion.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception)
            {
                // Manejo de excepciones
                return false;
            }
        }

        public bool MarcarDevuelto(int idPrestamo, bool PrestamoDevuelto)
        {
            try
            {
                using (var conexion = new BIBLIOTECAPREntities())
                {
                    var PrestamoToDevolver = conexion.PRESTAMOS.FirstOrDefault(m => m.ID_PRESTAMO == idPrestamo);
                    if (PrestamoToDevolver != null)
                    {
                        PrestamoToDevolver.PRESTAMO_DEVUELTO = PrestamoDevuelto;
                        conexion.SaveChanges(); // Guarda los cambios en la base de datos
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }


    }
}
