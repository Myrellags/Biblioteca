using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Livro
    {
        public int LivroID { get; set; }
        [ForeignKey("Editora")]
        public int EditoraID { get; set; }
        public Editora Editora { get; set; }
        [ForeignKey("Categoria")]
        public int CategoriaID { get; set; }
        public Categoria Categoria { get; set; }
        public string Titulo { get; set; }
        public string ISBN { get; set; }
        public string Lingua { get; set; }
        public DateTime DataEdicao { get; set; }
    }
}
