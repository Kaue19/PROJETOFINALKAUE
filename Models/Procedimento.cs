using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjetoFinalKaue.Models
{

    [Table("Procedimento")]
    public class Procedimento
    {
        [Column("Id")]
        [Display(Name = "Código do Procedimento")]
        public int Id { get; set; }

        [Column("ProcedimentoNome")]
        [Display(Name = "Nome do Procedimento")]
        public string ProcedimentoNome { get; set; } = string.Empty;

        [Column("ProcedimentoObservacao")]
        [Display(Name = "Observacao do Procedimento")]
        public string ProcedimentoObservacao { get; set; } = string.Empty;

        [ForeignKey("TipoProcedimentoId")]

        public int TipoProcedimentoId { get; set; }

        public TipoProcedimento? TipoProcedimento { get; set; }
    }
}
