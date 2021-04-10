using Squadra_Project.Bordas.Adapter;
using Squadra_Project.DTO.Carro.RetornarCarroPorId;
using Squadra_Project.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Squadra_Project.UseCase
{
    public class RetornarCarroPorIdUseCase : IRetornarCarroPorIdUseCase
    {
        private readonly IRepositorioCarros _repositorioCarros;
        private readonly ICarroParaResponseAdapter _adapter;

        public RetornarCarroPorIdUseCase(IRepositorioCarros repositorioCarros, ICarroParaResponseAdapter adapter)
        {
            _repositorioCarros = repositorioCarros;
            _adapter = adapter;
        }

        public RetornarCarroPorIdResponse Executar(RetornarCarroPorIdRequest request)
        {
            var response = new RetornarCarroPorIdResponse();
            try
            {
                var carro = _repositorioCarros.getById(request.id);
                response = _adapter.transformaCarroResponse(carro);
                return response;
            }
            catch
            {
                return response;

            }
        }
    }
}
