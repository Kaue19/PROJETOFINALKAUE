using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjetoFinalKaue.Models
{
    [Table("TipoProcedimento")]
    public class TipoProcedimento
    {
        [Column("Id")]
        [Display(Name = "TipoProcedimento")]
        public int Id { get; set; }

        [Column("TipoProcedimentoNome")]
        [Display(Name = "Nome do Procedimento")]
        public string TipoProcedimentoNome { get; set; } = string.Empty;
    }
}
