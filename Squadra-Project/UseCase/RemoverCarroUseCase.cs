using Squadra_Project.DTO.Carro.RemoverCarro;
using Squadra_Project.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Squadra_Project.UseCase
{
    public class RemoverCarroUseCase : IRemoverCarroUseCase
    {
        private readonly IRepositorioCarros _repositorioCarros;

        public RemoverCarroUseCase(IRepositorioCarros repositorioCarros)
        {
            _repositorioCarros = repositorioCarros;
        }

        public RemoverCarroResponse Executar(RemoverCarroRequest request)
        {
            
            var response = new RemoverCarroResponse();
            try
            {
                _repositorioCarros.Remove(request.id);
                response.msg = "Removido com sucesso";
                return response;
            }
            catch
            {
                response.msg = "Falha ao remover";
                return response;
            }

        }
    }
}
