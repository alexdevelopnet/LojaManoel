using Microsoft.AspNetCore.Mvc;
using ProductAPI.Model;
using ProductAPI.Service;

namespace ProductAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PedidosController : ControllerBase
    {
        private readonly EmpacotamentoService _empacotamentoService;

        public PedidosController(EmpacotamentoService empacotamentoService)
        {
            _empacotamentoService = empacotamentoService;
        }

        [HttpPost("processar")]
        public async Task<IActionResult> ProcessarPedidos([FromBody] PedidosInput pedidosInput)
        {
            var resultado = await _empacotamentoService.ProcessarPedidosAsync(pedidosInput);
            return Ok(resultado);
        }

        [HttpGet("listar-produtos")]
        public async Task<IActionResult> ListarProdutos()
        {
            var produtos = await _empacotamentoService.ListarProdutosAsync();
            return Ok(produtos);
        }

        [HttpGet("listar-pedidos")]
        public async Task<IActionResult> ListarPedidos()
        {
            var pedidos = await _empacotamentoService.ListarPedidosAsync();
            return Ok(pedidos);
        }

        [HttpPost("inserir-produto")]
        public async Task<IActionResult> InserirProduto([FromBody] Produto produto)
        {
            await _empacotamentoService.InserirProdutoAsync(produto);
            return Ok("Produto inserido com sucesso");
        }

        [HttpPost("inserir-pedido")]
        public async Task<IActionResult> InserirPedido([FromBody] Pedido pedido)
        {
            await _empacotamentoService.InserirPedidoAsync(pedido);
            return Ok("Pedido inserido com sucesso");
        }

    }
}
