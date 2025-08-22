namespace WebApiPaulo.Models
{
    public class Produtos
    {
        public int IdProduto { get; set; }
        public string? Nome { get; set; }
        public decimal Preco { get; set; }
        public int Estoque { get; set; }
    }
}
