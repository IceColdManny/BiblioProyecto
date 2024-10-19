using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database;

namespace DataInterface.Services
{
    public class DIAutores
    {
        private AutoresServices servicesAutor;

        public DIAutores()
        {
            servicesAutor = new AutoresServices();
        }

        public IList GetAll()
        {
            return servicesAutor.GetAll();
        }

        public int InsertOrUpdateAutores(int idAutor, string Nombre, string Apellido, string Nacionalidad)
        {
            return servicesAutor.InsertOrUpdateAutores(idAutor, Nombre, Apellido, Nacionalidad);
        }

        public bool DeleteAutor(int idAutor)
        {
            return servicesAutor.DeleteAutor(idAutor);
        }


    }
}
