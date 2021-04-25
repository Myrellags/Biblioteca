using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Morada
    {
        public int MoradaID { get; set; }
        [ForeignKey("Utente")]
        public int UtenteID { get; set; }
        public Utente Utente { get; set; }
        [ForeignKey("Editora")]
        public int EditoraID { get; set; }
        public Editora Editora { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string CodigoPostal { get; set; }
        public string Bairro { get; set; }
        public string Conselho { get; set; }
        public string Pais { get; set; }
    }
}
