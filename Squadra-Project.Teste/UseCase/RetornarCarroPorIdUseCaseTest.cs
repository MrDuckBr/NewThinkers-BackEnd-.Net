using FluentAssertions;
using Moq;
using Squadra_Project.Bordas.Adapter;
using Squadra_Project.DTO.Carro.RetornarCarroPorId;
using Squadra_Project.Entities;
using Squadra_Project.Repositorios;
using Squadra_Project.Teste.Builder;
using Squadra_Project.UseCase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Squadra_Project.Teste.UseCase
{
   public class RetornarCarroPorIdUseCaseTest
    {
        private readonly Mock<IRepositorioCarros> _repositorioCarros;

        private readonly Mock<ICarroParaResponseAdapter> _adapter;

        private readonly RetornarCarroPorIdUseCase _retornaPorIdUseCase;

        public RetornarCarroPorIdUseCaseTest()
        {
            _repositorioCarros = new Mock<IRepositorioCarros>();
            _adapter = new Mock<ICarroParaResponseAdapter>();
            _retornaPorIdUseCase = new RetornarCarroPorIdUseCase(_repositorioCarros.Object, _adapter.Object);

        }

        [Fact]
        public void Carro_RetornarPorId_QuandoRetornarSucesso()
        {
            var request = new RetornarCarroPorIdRequest();
            request.id = 1;
            var response = new RetornarCarroPorIdResponseBuilder().Build();

           // var response = new RetornarCarroPorIdResponse();
            var carro = new Carro();

            _adapter.Setup(adapter => adapter.transformaCarroResponse(carro)).Returns(response);
            _repositorioCarros.Setup(repositorio => repositorio.getById(request.id)).Returns(carro);

            var result = _retornaPorIdUseCase.Executar(request);

            response.Should().BeEquivalentTo(result);



        }


        [Fact]
        public void Carro_RetornarPorId_QuandoRetornarExcessao()
        {
            var request = new RetornarCarroPorIdRequest();
            var response = new RetornarCarroPorIdResponseBuilder().Build();

            var carro = new Carro();

            _adapter.Setup(adapter => adapter.transformaCarroResponse(carro)).Returns(response);
            _repositorioCarros.Setup(repositorio => repositorio.getById(request.id)).Throws(new Exception(""));

            var result = _retornaPorIdUseCase.Executar(request);

            response.Should().BeEquivalentTo(result);



        }
    }
}
