namespace WebApiPaulo.Models
{
    public class Pedido
    {
        public int IdPedido { get; set; }
        public int IdCliente { get; set; }
        public PedidoItem? IdPedidoItem { get; set; }
    }

    public class PedidoItem
    {
        public int IdPedidoItem { get; set; }
        public int IdProduto { get; set; }
    }
}
