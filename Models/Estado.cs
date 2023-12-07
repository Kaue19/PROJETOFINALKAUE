using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjetoFinalKaue.Models
{
    [Table("Estado")]
    public class Estado
    {
        [Column("Id")]
        [Display(Name = "Código do Estado")]
        public int Id { get; set; }

        [Column("EstadoNome")]
        [Display(Name = "Nome da Cidade")]
        public string EstadoNome { get; set; } = string.Empty;
    }
}