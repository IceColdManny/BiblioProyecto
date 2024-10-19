using System;
using System.Collections.Generic;
using System.Collections;
using DataInterface;
using DataInterface.Services;

namespace BusinessLogic
{
    public static class BLLibros
    {
        private static DILibros dataInterfaceLibros = new DILibros();

        public static List<DOLibros> GetAll()
        {
            List<DOLibros> listaLibros = new List<DOLibros>();

            IList informacionBD = dataInterfaceLibros.GetAll();
            if (informacionBD != null)
            {
                foreach (var item in informacionBD)
                {
                    Type type = item.GetType();

                    DOLibros libro = new DOLibros();

                    libro.idLibro = Convert.ToInt32(type.GetProperty("ID_LIBRO").GetValue(item, null));
                    libro.idAutor = Convert.ToInt32(type.GetProperty("ID_AUTOR").GetValue(item, null));
                    libro.Titulo = type.GetProperty("TITULO").GetValue(item, null).ToString();
                    libro.Genero = type.GetProperty("GENERO").GetValue(item, null).ToString();
                    libro.Anio_Publicacion = Convert.ToInt32(type.GetProperty("ANIO_PUBLICACION").GetValue(item, null));
                    libro.Volumen = Convert.ToInt32(type.GetProperty("VOLUMEN").GetValue(item, null));
                    libro.Capitulo = Convert.ToInt32(type.GetProperty("CAPITULO").GetValue(item, null));
                    libro.Editorial = type.GetProperty("EDITORIAL").GetValue(item, null).ToString();

                    listaLibros.Add(libro);
                }
            }
            return listaLibros;
        }
        public static int InsertOrUpdateLibros(DOLibros libro)
        {
            return dataInterfaceLibros.InsertOrUpdateLibros(libro.idLibro, libro.idAutor, libro.Titulo, libro.Genero, libro.Anio_Publicacion,
                libro.Volumen, libro.Capitulo, libro.Editorial);
        }

        public static bool DeleteLibro(int IdLibro)
        {
            return dataInterfaceLibros.DeleteLibro(IdLibro);
        }

    }
}
