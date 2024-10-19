using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class DOLibros
    {
        public int idLibro { get; set; }
        public int idAutor { get; set; }
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public int Anio_Publicacion { get; set; }
        public int Volumen { get; set; }
        public int Capitulo { get; set; }
        public string Editorial { get; set; }

    }
}
