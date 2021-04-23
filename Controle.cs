using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Controle
    {
        public int ControleID { get; set; }
        public Livro LivroID { get; set; }
        public Categoria CategoriaID { get; set; }
        public Editora EditoraID { get; set; }
        public Autor AutorId { get; set; }
        public Utente UtenteID { get; set; }
        public DateTime DataSaida { get; set; }
        public DateTime DataEntrada { get; set; }
    }
}
