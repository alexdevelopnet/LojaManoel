using ProductAPI.Model;

namespace ProductAPI.Repository
{
    public interface IEmpacotamentoRepository
    {
        Task<List<Pedido>> ObterPedidosAsync();
        Task AdicionarPedidoAsync(Pedido pedido);
        Task<List<CaixaDisponivel>> ObterCaixasDisponiveisAsync();
         
        Task<List<Produto>> ListarProdutosAsync();
        Task<List<Pedido>> ListarPedidosAsync();
        Task InserirProdutoAsync(Produto produto);
        Task InserirPedidoAsync(Pedido pedido);
    }
}
