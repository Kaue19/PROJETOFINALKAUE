using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjetoFinalKaue.Models
{
    [Table("TipoColaborador")]
    public class TipoColaborador
    {
        [Column("Id")]
        [Display(Name = "Código do TipoColaborador")]
        public int Id { get; set; }

        [Column("TipoColaboradorNome")]
        [Display(Name = "Tipo do Colaborador")]
        public string TipoColaboradorNome { get; set; } = string.Empty;
    }
}

