using BLL.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.CodeDom;
using BLL.Base;
using Entity;
using AutoMapper;
using Site.Models;
using System.Threading.Tasks;

namespace Site.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdministradorController : ControllerBase
    {

        private readonly IAdministradorService _administradorService;
        private readonly IMapper _mapper;

        public AdministradorController(IAdministradorService administradorService, IMapper mapper)
        {
            _administradorService = administradorService;
            _mapper = mapper;
        }

        [HttpPost ("Insertar")]
        public async Task<ActionResult<Administrador>> Insert(AdministradorDTO administrador)
        {
            var request = await _administradorService.Insert(_mapper.Map<Administrador>(administrador),administrador.Cod_Administrador);
            return request.Error ? BadRequest(request.Error) : Ok(request.Entity);
        }

        [HttpGet ("ConsultarLista")]
        public async Task<ActionResult<Administrador>> GetAll()
        {
            var request = await _administradorService.GetAll();
            return request.Error ? BadRequest(request.Error) : Ok(request.Entity);
        }

        [HttpGet ("Consyltar/{Cod_Administrador}")]
        public async Task<ActionResult<Administrador>> GetById(int Cod_Administrador)
        {
            var request = await _administradorService.GetById(Cod_Administrador);
            return request.Error ? BadRequest(request.Error) : Ok(request.Entity);
        }

        [HttpPut ("Actualizar/{Cod_Administrador}")]
        public async Task<ActionResult<Administrador>> Update(int Cod_Administrador, AdministradorDTO administrador)
        {
            var request = await _administradorService.Update(_mapper.Map<Administrador>(administrador),Cod_Administrador);
            return request.Error ? BadRequest(request.Error) : Ok(request.Entity);
        }

        [HttpDelete ("Eliminar/{Cod_Administrador}")]
        public async Task<ActionResult<Administrador>> Delete(int Cod_Administrador)
        {
            var request = await _administradorService.Delete(Cod_Administrador);
            return request.Error ? BadRequest(request.Error) : Ok(request.Entity);
        }


    }
}
