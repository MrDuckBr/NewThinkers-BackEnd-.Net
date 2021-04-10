using Squadra_Project.Bordas.Adapter;
using Squadra_Project.DTO.Carro.AtualizarCarro;
using Squadra_Project.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Squadra_Project.UseCase
{
    public class AtualizarCarroUseCase : IAtualizarCarroUseCase
    {
        private readonly IRepositorioCarros _repositorioCarros;
        private readonly IAtualizarCarroAdapter _adapter;

        public AtualizarCarroUseCase(IRepositorioCarros repositorioCarros, IAtualizarCarroAdapter adapter)
        {
            _repositorioCarros = repositorioCarros;
            _adapter = adapter;
        }

        public AtualizarCarroResponse Executar(AtualizarCarroRequest request)
        {
            var response = new AtualizarCarroResponse();

            try
            {

                var CarroAtualizar = _adapter.transformaRequestEmCarro(request);
                _repositorioCarros.AtualizarCarro(CarroAtualizar);
                response.msg = "Carro Atualizado com sucesso";
                return response;

            }
            catch
            {
                response.msg = "Erro ao Atualizar";
                return response;
            }

        }
    }
}
