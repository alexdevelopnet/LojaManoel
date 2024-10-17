using ProductAPI.Model;
using ProductAPI.Repository;

namespace ProductAPI.Service
{
    public class EmpacotamentoService
    {
        private readonly IEmpacotamentoRepository _repository;

        public EmpacotamentoService(IEmpacotamentoRepository repository)
        {
            _repository = repository;
        }

        public async Task<PedidosSaida> ProcessarPedidosAsync(PedidosInput pedidosInput)
        {
            var pedidosSaida = new PedidosSaida { Pedidos = new List<PedidoSaida>() };
            var caixasDisponiveis = await _repository.ObterCaixasDisponiveisAsync();

            foreach (var pedido in pedidosInput.Pedidos)
            {
                var pedidoSaida = new PedidoSaida
                {
                    PedidoId = pedido.PedidoId,
                    Caixas = new List<Caixa>()
                };

                var produtosNaoEmbalados = new List<Produto>(pedido.Produtos);

                foreach (var caixaDisponivel in caixasDisponiveis)
                {
                    var caixa = new Caixa
                    {
                        CaixaId = caixaDisponivel.CaixaId,
                        Produtos = new List<string>()
                    };

                    var produtosParaEssaCaixa = produtosNaoEmbalados
                        .Where(p => ProdutoCabeNaCaixa(p.Dimensao, caixaDisponivel.Dimensao))
                        .ToList();

                    foreach (var produto in produtosParaEssaCaixa)
                    {
                        caixa.Produtos.Add(produto.ProdutoId.ToString());
                        produtosNaoEmbalados.Remove(produto);
                    }

                    if (caixa.Produtos.Count > 0)
                    {
                        pedidoSaida.Caixas.Add(caixa);
                    }
                }

                if (produtosNaoEmbalados.Count > 0)
                {
                    foreach (var produto in produtosNaoEmbalados)
                    {
                        pedidoSaida.Caixas.Add(new Caixa
                        {
                            CaixaId = null,
                            Produtos = new List<string> { produto.ProdutoId.ToString() },
                            Observacao = "Produto não cabe em nenhuma caixa disponível."
                        });
                    }
                }

                pedidosSaida.Pedidos.Add(pedidoSaida);
            }

            return pedidosSaida;
        }

        public async Task<List<Produto>> ListarProdutosAsync()
        {
            return await _repository.ListarProdutosAsync();
        }

        public async Task<List<Pedido>> ListarPedidosAsync()
        {
            return await _repository.ListarPedidosAsync();
        }

        public async Task InserirProdutoAsync(Produto produto)
        {
            await _repository.InserirProdutoAsync(produto);
        }

        public async Task InserirPedidoAsync(Pedido pedido)
        {
            await _repository.InserirPedidoAsync(pedido);
        }

        private bool ProdutoCabeNaCaixa(Dimensao produto, Dimensao caixa)
        {
            return produto.Altura <= caixa.Altura && produto.Largura <= caixa.Largura && produto.Comprimento <= caixa.Comprimento;
        }
    }
}
