using airhorizon.Model;
using Microsoft.AspNetCore.Mvc;
using airhorizon.Repositorio.interfaces;

namespace airhorizon.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VoosController : ControllerBase
    {
        private readonly iVoosRepositorio _voosRepositorio;
        public VoosController(iVoosRepositorio voosRepositorio)
        {
            _voosRepositorio = voosRepositorio;
        }
        [HttpGet]
        public async Task<ActionResult<List<Voos>>> BuscarVoos()
        {
            List<Voos> voos = await _voosRepositorio.BuscarVoos();
            return Ok(voos);
        }
        [HttpGet("{IdVoos}")]
        public async Task<ActionResult<Voos>> BuscarID(int IdVoos)
        {
            Voos voos = await _voosRepositorio.BuscarId(IdVoos);
            return Ok(voos);
        }

        [HttpPost]
        public async Task<ActionResult<Voos>> Cadastrar([FromBody] Voos voos)
        {
            Voos voo = await _voosRepositorio.AddVoo(voos);
            return Ok(voo);
        }

        [HttpPut("{IdVoos}")]
        public async Task<ActionResult<Voos>> Atualozar([FromBody] Voos voos, int IdVoos)
        {
            voos.IdVoos = IdVoos;
            Voos voo = await _voosRepositorio.AttVoo(voos, IdVoos);
            return Ok(voo);
        }

        [HttpDelete("{IdVoos}")]
        public async Task<ActionResult<Voos>> Deletar(int IdVoos)
        {
            bool delet = await _voosRepositorio.DeletarVoo(IdVoos);
            return Ok(delet);
        }

    }
}