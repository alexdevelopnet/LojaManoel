using Microsoft.EntityFrameworkCore;
using ProductAPI.Model;
using ProductAPI.Model.Context;

namespace ProductAPI.Repository
{
    public class EmpacotamentoRepository : IEmpacotamentoRepository
    {
        private readonly AppDbContext _context;

        public EmpacotamentoRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Pedido>> ObterPedidosAsync()
        {
            return await _context.Pedidos.Include(p => p.Produtos).ThenInclude(p => p.Dimensao).ToListAsync();
        }

        public async Task AdicionarPedidoAsync(Pedido pedido)
        {
            await _context.Pedidos.AddAsync(pedido);
            await _context.SaveChangesAsync();
        }

        public async Task<List<CaixaDisponivel>> ObterCaixasDisponiveisAsync()
        {
            return await _context.CaixasDisponiveis.Include(c => c.Dimensao).ToListAsync();
        }

        public async Task<List<Produto>> ListarProdutosAsync()
        {
            return await _context.Produtos.ToListAsync();
        }

        public async Task<List<Pedido>> ListarPedidosAsync()
        {
            return await _context.Pedidos.Include(p => p.Produtos).ThenInclude(p => p.Dimensao).ToListAsync();
        }

        public async Task InserirProdutoAsync(Produto produto)
        {
            await _context.Produtos.AddAsync(produto);
            await _context.SaveChangesAsync();
        }

        public async Task InserirPedidoAsync(Pedido pedido)
        {
            await _context.Pedidos.AddAsync(pedido);
            await _context.SaveChangesAsync();
        }
    }
}