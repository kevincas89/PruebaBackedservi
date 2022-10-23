using AutoMapper;
using AutoMapper.Configuration.Annotations;
using BLL.Interface;
using Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Site.Models;

namespace Site.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly IProductoService _productoService;
        private readonly IMapper _mapper;

        public ProductoController(IProductoService productoService, IMapper mapper)
        {
            _productoService = productoService;
            _mapper = mapper;
        }

        [HttpPost ("Insertar")]
        public async Task<ActionResult<Producto>> Insert(ProductoDTO producto)
        {
            var request = await _productoService.Insert(_mapper.Map<Producto>(producto), producto.Cod_Producto);
            return request.Error ? BadRequest(request.Error) : Ok(request.Entity);
        }

        [HttpGet("ConsultarLista")]
        public async Task<ActionResult<Producto>> GetAll()
        {
            var request = await _productoService.GetAll();
            return request.Error ? Ok(request.Error) : Ok(request.Entity);
        }

        [HttpGet ("Consultar/{Cod_Producto}")]
        public async Task<ActionResult<Producto>> GetById(int Cod_Producto)
        {
            var request = await _productoService.GetById(Cod_Producto);
            return request.Error ? BadRequest(request.Message) : Ok(request.Entity);
        }

        [HttpPut ("Actualizar/{Cod_Producto}")]
        public async Task<ActionResult<Producto>> Update(int Cod_Producto, ProductoDTO producto)
        {
            var request = await _productoService.Update(_mapper.Map<Producto>(producto),Cod_Producto);
            return request.Error ? BadRequest(request.Message) : Ok(request.Entity);
        }

        [HttpDelete ("Eliminar/{Cod_Producto}")]
        public async Task<ActionResult<Producto>> Delete(int Cod_Producto)
        {
            var request = await _productoService.Delete(Cod_Producto);
            return request.Error ? BadRequest(request.Message) : Ok(request);
        }






    }
}
