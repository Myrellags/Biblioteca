using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Utente
    {
        public int UtenteID { get; set; }
        public string Nome { get; set; }
        public string Telemovel { get; set; }
        public string Morada { get; set; }
        public int QtdEmprestimos { get; set; }
        public DateTime UltimoEmprestimo{ get; set; }
        public bool LivrosDevolver { get; set; }
    }
}
