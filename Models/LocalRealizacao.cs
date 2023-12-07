using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjetoFinalKaue.Models
{
    [Table("LocalRealizacao")]
    public class LocalRealizacao
    {
        [Column("Id")]
        [Display(Name = "Código Local Realização")]
        public int Id { get; set; }

        [Column("LocalNome")]
        [Display(Name = "Nome do Local")]
        public string LocalNome { get; set; } = string.Empty;


        [ForeignKey("CidadeId")]

        public int CidadeId { get; set; }

        public Cidade? Cidade { get; set; }
    }
}
