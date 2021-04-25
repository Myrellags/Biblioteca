using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Requisicao
    {
        public int RequisicaoID { get; set; }
        [ForeignKey("Livro")]
        public int LivroID { get; set; }
        public Livro Livro { get; set; }
        [ForeignKey("Utente")]
        public int UtenteID { get; set; }
        public Utente Utente { get; set; }
        public DateTime DataSaida { get; set; }
        public DateTime DataEntrada { get; set; }
    }
}
