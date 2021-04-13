using FluentAssertions;
using Moq;
using Squadra_Project.Bordas.Adapter;
using Squadra_Project.DTO.Carro.RetornarListaDeCarro;
using Squadra_Project.Entities;
using Squadra_Project.Repositorios;
using Squadra_Project.UseCase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Squadra_Project.Teste.UseCase
{
    public class RetornarListaCarroUseCaseTest
    {
        private readonly Mock<IRepositorioCarros> _repositorioCarros;

        private readonly Mock<IConverterListaCarroParaListaResponseAdapter> _adapter;

        private readonly RetornarListaCarroUseCase _retornarListaUseCase;

        public RetornarListaCarroUseCaseTest()
        {
            _repositorioCarros = new Mock<IRepositorioCarros>();
            _adapter = new Mock<IConverterListaCarroParaListaResponseAdapter>();
            _retornarListaUseCase = new RetornarListaCarroUseCase(_repositorioCarros.Object, _adapter.Object);

        }

        [Fact]
        public void Carro_RetornarListaCarro_QuandoGeraSucesso()
        {
           // var request = new AdicionarCarroRequestBuilder().Build();
            
           
            var listaCarroResponse = new List<RetornarListaCarroResponse>();
            var listaCarro = new List<Carro>();

           // response.msg = "Erro ao adicionar";


            _adapter.Setup(adapter => adapter.converterCarroListaParaListaResponse(listaCarro)).Returns(listaCarroResponse);
            _repositorioCarros.Setup(repositorio => repositorio.RetornarListaCarro()).Returns(listaCarro);

            var result = _retornarListaUseCase.Executar();

            listaCarroResponse.Should().BeEquivalentTo(result);



        }

        [Fact]
        public void Carro_RetornarListaCarro_QuandoRetornaExcessao()
        {
            


            var listaCarroResponse = new List<RetornarListaCarroResponse>();
            var listaCarro = new List<Carro>();

            


            _adapter.Setup(adapter => adapter.converterCarroListaParaListaResponse(listaCarro)).Returns(listaCarroResponse);
            _repositorioCarros.Setup(repositorio => repositorio.RetornarListaCarro()).Throws(new Exception(""));

            var result = _retornarListaUseCase.Executar();

            listaCarroResponse.Should().BeEquivalentTo(result);



        }


    }
}
