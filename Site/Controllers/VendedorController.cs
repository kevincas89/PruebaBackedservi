using AutoMapper;
using BLL.Base;
using BLL.Interface;
using Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Site.Models;

namespace Site.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendedorController : ControllerBase
    {
        private readonly IVendedorService _vendedorService;
        private readonly IMapper _mapper;

        public VendedorController(IVendedorService vendedorService, IMapper mapper)
        {
            _vendedorService = vendedorService;
            _mapper = mapper;
        }


        [HttpPost("Insertar")]
        public async Task<ActionResult<Vendedor>> Insert(VendedorDTO vendedor)
        {
            var request = await _vendedorService.Insert(_mapper.Map<Vendedor>(vendedor), vendedor.Cod_Vendedor);
            return request.Error ? BadRequest(request.Message) : Ok(request.Entity);
        }

        [HttpGet ("ConsultarLista")]
        public async Task<ActionResult<Vendedor>> GetAll()
        {
            var request = await _vendedorService.GetAll();
            return request.Error ? BadRequest(request.Message) : Ok(request.Entity);
        }

        [HttpGet ("Consultar/{Cod_Vendedor}")]
        public async Task<ActionResult<Vendedor>> GetById(int Vendedor)
        {
            var request = await _vendedorService.GetById(Vendedor);
            return request.Error ? BadRequest(request.Message) : Ok(request.Entity);
        }

        [HttpPut ("Actualizar/{Cod_Vendedor}")]
        public async Task<ActionResult<Vendedor>> Update(int Cod_Vendedor, VendedorDTO vendedor)
        {
            var request = await _vendedorService.Update(_mapper.Map<Vendedor>(vendedor),Cod_Vendedor);
            return request.Error ? BadRequest(request.Message) : Ok(request.Entity);
        }

        [HttpDelete ("Eliminar/{Cod_Vendedor}")]
        public async Task<ActionResult<Vendedor>> Delete(int Cod_Vendedor)
        {
            var request = await _vendedorService.Delete(Cod_Vendedor);
            return request.Error ? BadRequest(request.Message) : Ok(request);
        }

    }
}
