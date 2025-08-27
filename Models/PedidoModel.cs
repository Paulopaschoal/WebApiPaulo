using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiPaulo.Models
{
    [Table("Pedido")]
    public class PedidoModel
    {
        [Key]
        public int IdPedido { get; set; }
        public int IdCliente { get; set; }

        public int? IdProduto { get; set; }
        //public PedidoItem? IdPedidoItem { get; set; }
    }

    public class PedidoItem
    {
        public int? IdPedidoItem { get; set; }
        public int? IdProduto { get; set; }
    }
}
