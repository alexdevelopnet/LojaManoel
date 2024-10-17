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
                        .Where(p => ProdutoCabeNaCaixa(p.Dimensoes, caixaDisponivel.Dimensoes))
                        .ToList();

                    foreach (var produto in produtosParaEssaCaixa)
                    {
                        caixa.Produtos.Add(produto.ProdutoId);
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
                            Produtos = new List<string> { produto.ProdutoId },
                            Observacao = "Produto não cabe em nenhuma caixa disponível."
                        });
                    }
                }

                pedidosSaida.Pedidos.Add(pedidoSaida);
            }

            return pedidosSaida;
        }

        private bool ProdutoCabeNaCaixa(Dimensoes produto, Dimensoes caixa)
        {
            return produto.Altura <= caixa.Altura && produto.Largura <= caixa.Largura && produto.Comprimento <= caixa.Comprimento;
        }
    }

}
