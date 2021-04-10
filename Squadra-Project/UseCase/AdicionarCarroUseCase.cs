using Squadra_Project.Bordas.Adapter;
using Squadra_Project.DTO.Carro.AdicionarCarro;
using Squadra_Project.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Squadra_Project.UseCase
{
    public class AdicionarCarroUseCase : IAdicionarCarroUseCase
    {
        private readonly IRepositorioCarros _repositorioCarros;
        private readonly IAdicionarCarroAdapter _adapter;

        public AdicionarCarroUseCase(IRepositorioCarros repositorioCarros, IAdicionarCarroAdapter adapter)
        {
            _repositorioCarros = repositorioCarros;
            _adapter = adapter;
        }

        public AdicionarCarroResponse Executar(AdicionarCarroRequest request)
        {
            var response = new AdicionarCarroResponse();
            try {
                
                var CarroAdicionar = _adapter.converterRequestParaCarro(request);
                _repositorioCarros.Add(CarroAdicionar);
                response.msg = "Adicionado com Sucesso";
                return response;
            
            } catch
            {
                response.msg = "Erro ao adicionar";
                return response;
            }
            
        }
    }
}
