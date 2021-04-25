using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Telefone
    {
        public int TelefoneID { get; set; }
        [ForeignKey("Utente")]
        public int UtenteID { get; set; }
        public Utente Utente{ get; set; }
        [ForeignKey("Editora")]
        public int EditoraID { get; set; }
        public Editora Editora { get; set; }
        public int Numero { get; set; }
    }
}
