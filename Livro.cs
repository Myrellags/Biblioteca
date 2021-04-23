using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Livro
    {
        public int LivroID { get; set; }
        public Autor AutorID { get; set; }
        public Editora EditoraID { get; set; }
        public Categoria CategoriaID { get; set; }
        public string Nome { get; set; }
        public string ISBN { get; set; }
        public string DataEdicao { get; set; }
    }
}
