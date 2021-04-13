using Squadra_Project.Bordas.Adapter;
using Squadra_Project.DTO.Carro.RetornarListaDeCarro;
using Squadra_Project.Entities;
using Squadra_Project.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Squadra_Project.UseCase
{
    public class RetornarListaCarroUseCase : IRetornarListaCarroUseCase
    {
        private readonly IRepositorioCarros _repositorioCarros;
        private readonly IConverterListaCarroParaListaResponseAdapter _adater;

        public RetornarListaCarroUseCase(IRepositorioCarros repositorioCarros, IConverterListaCarroParaListaResponseAdapter adater)
        {
            _repositorioCarros = repositorioCarros;
            _adater = adater;
        }

        public List<RetornarListaCarroResponse> Executar()
        {
            var response = new List<RetornarListaCarroResponse>();
            try
            {
                var carro = _repositorioCarros.RetornarListaCarro();
                
                response = _adater.converterCarroListaParaListaResponse(carro);
                return response;
            }
            catch
            {
                throw new System.Exception("Requisição não pode ser feita");
               
            }
        }
    }
}
