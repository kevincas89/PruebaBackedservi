using AutoMapper;
using BLL.Interface;
using Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Site.Models;
using System.Threading.Tasks;

namespace Site.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        private readonly IPedidoService _pedidoService;
        private readonly IMapper _mapper;

        public PedidoController(IPedidoService pedidoService, IMapper mapper)
        {
            _pedidoService = pedidoService;
            _mapper = mapper;
        }

        [HttpPost ("Insertar")]
        public async Task<ActionResult<Pedido>> Insert(PedidoDTO pedido)
        {
            var request = await _pedidoService.Insert(_mapper.Map<Pedido>(pedido), pedido.Cod_pedido);
            return request.Error ? BadRequest(request.Message) : Ok(request.Entity);
        }

        [HttpGet ("ConsultarLista")]
        public async Task<ActionResult<Pedido>> GetAll()
        {
            var request = await _pedidoService.GetAll();
            return request.Error ? BadRequest(request.Message) : Ok(request.Entity);
        }

        [HttpGet ("Consultar/{Cod_Pedido}")]
        public async Task<ActionResult<Pedido>> GetById(int Cod_Pedido)
        {
            var request = await _pedidoService.GetById(Cod_Pedido);
            return request.Error ? BadRequest(request.Error) : Ok(request.Entity);
        }

        [HttpPut ("Actualizar/{Cod_Pedido}")]
        public async Task<ActionResult<Pedido>> Update(int Cod_Pedido, PedidoDTO pedido)
        {
            var request = await _pedidoService.Update(_mapper.Map<Pedido>(pedido),Cod_Pedido);
            return request.Error ? BadRequest(request.Message) : Ok(request.Entity);
        }

        [HttpDelete ("Eliminar/{Cod_Pedido}")]
        public async Task<ActionResult<Pedido>> Delete(int Cod_Pedido)
        {
            var request = await _pedidoService.Delete(Cod_Pedido);
            return request.Error ? BadRequest(request.Message) : Ok(request);
        }
    }
}
