
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Squadra_Project.DTO.Carro.AdicionarCarro;
using Squadra_Project.DTO.Carro.AtualizarCarro;
using Squadra_Project.DTO.Carro.RemoverCarro;
using Squadra_Project.Entities;
using Squadra_Project.Services;
using Squadra_Project.UseCase;

namespace Aula2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarroController : ControllerBase
    {

        private readonly ILogger<CarroController> _logger;
        private readonly ICarroService _carro;
        private readonly IAdicionarCarroUseCase _adicionarCarroUseCase;
        private readonly IRemoverCarroUseCase _removerCarroUseCase;
        private readonly IAtualizarCarroUseCase _atualizarCarroUseCase;
        public CarroController(ILogger<CarroController> logger, ICarroService carro, IAdicionarCarroUseCase adicionarCarroUseCase, IRemoverCarroUseCase removerCarroUseCase, IAtualizarCarroUseCase atualizarCarroUseCase)
        {
            _logger = logger;
            _carro = carro;
            _adicionarCarroUseCase = adicionarCarroUseCase;
            _removerCarroUseCase = removerCarroUseCase;
            _atualizarCarroUseCase = atualizarCarroUseCase;
        }

        [HttpGet]
        public IActionResult TodosCarros()
        {
            return Ok(_carro.RetornarListaCarro());
        }

        [HttpGet("{id}")]
        public IActionResult carro(int id)
        {
            return Ok(_carro.RetornarCarroPorId(id));
        }

        [HttpPost]
        public IActionResult carroAdd([FromBody] AdicionarCarroRequest novoCarro)
        {
            return Ok(_adicionarCarroUseCase.Executar(novoCarro));
        }

        [HttpPut]
        public IActionResult carroUpdate([FromBody] AtualizarCarroRequest request)
        {
            
            return Ok(_atualizarCarroUseCase.Executar(request));
            
        }


        [HttpDelete("{id}")]
        public IActionResult carroDelete(int id)
        {

            var request = new RemoverCarroRequest();
            request.id = id;
            return Ok(_removerCarroUseCase.Executar(request));
        }



    }
}