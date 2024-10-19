using Database;
using System;
using System.Collections;
using System.Data.Entity;
using System.Linq;



namespace Database
{
    public class AutoresServices
    {
        public IList GetAll()
        {
            try
            {
                using (var conexion = new BIBLIOTECAPREntities())
                {
                    var lista = (from a in conexion.AUTORES select a).ToList();

                    return lista;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public int InsertOrUpdateAutores(int idAutor, string Nombre, string Apellido, string Nacionalidad)
        {
            try
            {
                using (var conexion = new BIBLIOTECAPREntities())
                {
                    AUTORES autor = conexion.AUTORES.Where(x => x.ID_AUTOR == idAutor).FirstOrDefault();
                    if (autor == null)
                    {
                        // Si el estado no existe, lo creamos y lo agregamos a la base de datos
                        autor = new AUTORES();
                        autor.ID_AUTOR = idAutor;
                        autor.NOMBRE = Nombre;
                        autor.APELLIDO = Apellido;
                        autor.NACIONALIDAD = Nacionalidad;
                        conexion.AUTORES.Add(autor);
                    }
                    else
                    {
                        // Si el estado existe, actualizamos sus propiedades
                        autor.NOMBRE = Nombre;
                        autor.APELLIDO = Apellido;
                        autor.NACIONALIDAD = Nacionalidad;
                        conexion.Entry(autor).State = EntityState.Modified;
                    }

                    return conexion.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error: " + ex.Message);
                return 0;
            }


        }
        public bool DeleteAutor(int idAutor)
        {
            try
            {
                using (var conexion = new BIBLIOTECAPREntities())
                {
                    var AutorToDelete = conexion.AUTORES.FirstOrDefault(m => m.ID_AUTOR == idAutor);
                    if (AutorToDelete != null)
                    {
                        conexion.AUTORES.Remove(AutorToDelete);
                        conexion.SaveChanges();
                        return true;
                    }
                    else
                    {
                        // El Estado no existe
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