namespace ProductAPI.Model
{
    public class Pedido
    {
        public int PedidoId { get; set; }
        public List<Produto> Produtos { get; set; }
    }
}
