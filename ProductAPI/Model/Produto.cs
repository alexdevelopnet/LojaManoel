namespace ProductAPI.Model
{
    public class Produto
    {
        public int ProdutoId { get; set; } // Mudei de string para int, se estiver usando IDs inteiros
        public string ProdutoNome { get; set; }
        public int PedidoId { get; set; } // Referência ao Pedido
        public int DimensaoId { get; set; } // Referência à Dimensão

        public Dimensao Dimensao { get; set; }
        public Pedido Pedido { get; set; }
      
          
    }

}
