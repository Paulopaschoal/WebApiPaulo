using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiPaulo.Models
{
    [Table("Produtos")]
    public class ProdutosModel
    {
        [Key]
        public int IdProduto { get; set; }
        public string? Nome { get; set; }
        public decimal Preco { get; set; }
        public int Estoque { get; set; }
    }
}
