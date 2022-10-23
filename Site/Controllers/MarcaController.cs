using AutoMapper;
using BLL.Interface;
using BLL.Response;
using Entity;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Site.Models;
using System.Threading.Tasks;

namespace Site.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarcaController : ControllerBase
    {
        private readonly IMarcaService _marcaService;
        private readonly IMapper _mapper;
        

        public MarcaController(IMarcaService marcaService, IMapper mapper)
        {
            _marcaService = marcaService;
            _mapper = mapper;
        }

        [HttpPost ("Insertar")]
        public async Task<ActionResult<Marca>> Insert(MarcaDTO marca)
        {
            var request = await _marcaService.Insert(_mapper.Map<Marca>(marca),marca.Cod_Marca);
            return request.Error ? BadRequest(request.Message) : Ok(request.Entity);
        }

        [HttpGet ("ConsultarLista")]
        public async Task<ActionResult<Marca>> GetAll()
        {
            var request = await _marcaService.GetAll();
            return request.Error ? BadRequest(request.Message) : Ok(request.Entity);
        }

        [HttpGet("ConsultarId/{Cod_Marca}")]
        public async Task<ActionResult<Marca>> GetById(int Cod_Marca)
        {
            var request = await _marcaService.GetById(Cod_Marca);
            return request.Error ? BadRequest(request.Message) : Ok(request.Entity);
        }

        [HttpPut("Actualicar/{Cod_Marca}")]
        public async Task<ActionResult<Marca>> Update(int Cod_Marca, MarcaDTO marca)
        {
            var request = await _marcaService.Update(_mapper.Map<Marca>(marca),Cod_Marca);
            return request.Error ? BadRequest(request.Message) : Ok(request.Entity);
        }

        [HttpDelete ("Eliminar/{Cod_Marca}")]
        public async Task<ActionResult<Marca>> Delete(int Cod_Marca)
        {
            var request = await _marcaService.Delete(Cod_Marca);
            return request.Error ? BadRequest(request.Message) : Ok(request);
        }
    }
}
