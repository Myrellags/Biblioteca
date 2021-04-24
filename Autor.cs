using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Autor
    {
        public int AutorID { get; set; }
        [ForeignKey("Livro")] 
        public int LivroID { get; set; }
        public Livro Livro{ get; set; }
        public string Nome { get; set; }
        public string Nacionalidade { get; set; }
        public string TipoGeneroAutor { get; set; }
    }
}
