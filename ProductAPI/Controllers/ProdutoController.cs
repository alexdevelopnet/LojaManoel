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
    }

}
