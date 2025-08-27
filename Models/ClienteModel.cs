using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiPaulo.Models
{
    [Table("Cliente")]
    public class ClienteModel
    {
        [Key]
        public int IdCliente { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
    }
}
