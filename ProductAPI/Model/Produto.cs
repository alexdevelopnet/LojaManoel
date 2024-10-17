namespace ProductAPI.Model
{
    public class Produto
    {
        public string ProdutoId { get; set; }
        public int PedidoId { get; set; } // Chave estrangeira
        public Dimensoes Dimensoes { get; set; }
    }

}
