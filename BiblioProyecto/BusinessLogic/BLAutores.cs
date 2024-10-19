using System;
using System.Collections.Generic;
using System.Collections;
using DataInterface.Services;

namespace BusinessLogic
{

    public static class BLAutores
    {
        private static DIAutores dataInterfaceAutores = new DIAutores();

        public static List<DOAutores> GetAll()
        {
            List<DOAutores> listaAutores = new List<DOAutores>();

            IList informacionBD = dataInterfaceAutores.GetAll();
            if (informacionBD != null)
            {
                foreach (var item in informacionBD)
                {
                    Type type = item.GetType();

                    DOAutores autor = new DOAutores();

                    autor.idAutor = Convert.ToInt32(type.GetProperty("ID_AUTOR").GetValue(item, null));
                    autor.Nombre = type.GetProperty("NOMBRE").GetValue(item, null).ToString();
                    autor.Apellido = type.GetProperty("APELLIDO").GetValue(item, null).ToString();
                    autor.Nacionalidad = type.GetProperty("NACIONALIDAD").GetValue(item, null).ToString();


                    listaAutores.Add(autor);
                }
            }
            return listaAutores;
        }

        public static int InsertOrUpdateAutores(DOAutores autor)
        {
            return dataInterfaceAutores.InsertOrUpdateAutores(autor.idAutor, autor.Nombre, autor.Apellido, autor.Nacionalidad);
        }

        public static bool DeleteAutor(int idAutor)
        {
            return dataInterfaceAutores.DeleteAutor(idAutor);
        }
    }
}




