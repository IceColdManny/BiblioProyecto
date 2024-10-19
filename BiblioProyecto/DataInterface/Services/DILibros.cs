using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database;

namespace DataInterface.Services
{
    public class DILibros
    {
        private LibrosServices servicesLibro;

        public DILibros()
        {
            servicesLibro = new LibrosServices();
        }

        public IList GetAll()
        {
            return servicesLibro.GetAll();
        }

        public int InsertOrUpdateLibros(int idLibro, int idAutor, string Titulo, string Genero,  int AnioPublicacion,
            int Volumen, int Capitulo, string Editorial)
        {
            return servicesLibro.InsertOrUpdateLibros(idLibro, idAutor, Titulo, Genero,  AnioPublicacion,
            Volumen, Capitulo, Editorial);
        }

        public bool DeleteLibro(int idLibro)
        {
            return servicesLibro.DeleteLibro(idLibro);
        }

    }
}
