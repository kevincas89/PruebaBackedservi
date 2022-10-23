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
    public class RepartidorController : ControllerBase
    {
        private readonly IRepartidorService _repartidorService;
        private readonly IMapper _mapper;

        public RepartidorController(IRepartidorService repartidorService, IMapper mapper)
        {
            _repartidorService = repartidorService;
            _mapper = mapper;
        }

        [HttpPost ("Insertar")]
        public async Task<ActionResult<Repartidor>> Insert(RepartidorDTO repartidor)
        {
            var request = await _repartidorService.Insert(_mapper.Map<Repartidor>(repartidor),repartidor.Cod_Repartidor);
            return request.Error ? BadRequest(request.Message) : Ok(request.Entity);
        }

        [HttpGet ("ConsultarLista")]
        public async Task<ActionResult<Repartidor>> GetAll()
        {
            var request = await _repartidorService.GetAll();
            return request.Error ? BadRequest(request.Error) : Ok(request.Entity);
        }

        [HttpGet ("Consultar/{Cod_Repartidor}")]
        public async Task<ActionResult<Repartidor>> GetById(int Cod_Repartidor)
        {
            var request = await _repartidorService.GetById(Cod_Repartidor);
            return request.Error ? BadRequest(request.Message) : Ok(request.Entity);
        }

        [HttpPut ("Actualizar/{Cod_Repartidor}")]
        public async Task<ActionResult<Repartidor>> Update(int Cod_Repartidor, RepartidorDTO repartidor)
        {
            var request = await _repartidorService.Update(_mapper.Map<Repartidor>(repartidor),Cod_Repartidor);
            return request.Error ? BadRequest(request.Message) : Ok(request.Entity);
        }

        [HttpDelete ("Eliminar/{Cod_Repartidor}")]
        public async Task<ActionResult<Repartidor>> Delete(int Cod_Repartidor)
        {
            var request = await _repartidorService.Delete(Cod_Repartidor);
            return request.Error ? BadRequest(request.Message) : Ok(request);
        }


    }
}
