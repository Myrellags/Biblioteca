using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Editora
    {
        public int EditoraID { get; set; }
        public string Nome { get; set; }
        public Morada Morada { get; set; }
        public Telefone Telefone { get; set; }
    }
}
