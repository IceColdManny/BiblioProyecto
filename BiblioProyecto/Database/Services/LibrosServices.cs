using Database;
using System;
using System.Collections;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;


namespace Database
{
    public class LibrosServices
    {
        public IList GetAll()
        {
            try
            {
                using (var conexion = new BIBLIOTECAPREntities())
                {
                    var lista = (from a in conexion.LIBROS select a).ToList();

                    return lista;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public int InsertOrUpdateLibros(int idLibro, int idAutor, string Titulo, string Genero, int AnioPublicacion,
            int Volumen, int Capitulo, string Editorial)
        {
            try
            {
                using (var conexion = new BIBLIOTECAPREntities())
                {
                    LIBROS libro = conexion.LIBROS.Where(x => x.ID_LIBRO == idLibro).FirstOrDefault();
                    if (libro == null)
                    {
                        // Si el estado no existe, lo creamos y lo agregamos a la base de datos
                        libro = new LIBROS();
                        libro.ID_LIBRO = idLibro;
                        libro.ID_AUTOR = idAutor;
                        libro.TITULO = Titulo;
                        libro.GENERO = Genero;
                        libro.ANIO_PUBLICACION = AnioPublicacion;
                        libro.VOLUMEN = Volumen;
                        libro.CAPITULO = Capitulo;
                        libro.EDITORIAL = Editorial;
                        conexion.LIBROS.Add(libro);
                    }
                    else
                    {
                        // Si el estado existe, actualizamos sus propiedades
                        libro.ID_AUTOR = idAutor;
                        libro.TITULO = Titulo;
                        libro.GENERO = Genero;
                        libro.ANIO_PUBLICACION = AnioPublicacion;
                        libro.VOLUMEN = Volumen;
                        libro.CAPITULO = Capitulo;
                        libro.EDITORIAL = Editorial;
                        conexion.Entry(libro).State = EntityState.Modified;
                    }

                    return conexion.SaveChanges();
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public bool DeleteLibro(int idLibro)
        {
            try
            {
                using (var conexion = new BIBLIOTECAPREntities())
                {
                    var LibroToDelete = conexion.LIBROS.FirstOrDefault(m => m.ID_LIBRO == idLibro);
                    if (LibroToDelete != null)
                    {
                        conexion.LIBROS.Remove(LibroToDelete);
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
                return false;
            }
        }

    }
}
