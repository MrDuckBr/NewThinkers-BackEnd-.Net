using FluentAssertions;
using Moq;
using Squadra_Project.DTO.Carro.RemoverCarro;
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
    public class RemoverCarroUseCaseTest
    {
        private readonly Mock<IRepositorioCarros> _repositorioCarros;
        private readonly RemoverCarroUseCase _removerCarroUseCase;

        public RemoverCarroUseCaseTest()
        {

            _repositorioCarros =  new Mock < IRepositorioCarros >();

            _removerCarroUseCase = new RemoverCarroUseCase(_repositorioCarros.Object);
        }


        [Fact]
        public void Carro_RemoverCarro_QuandoRetornarSucesso()
        {
            var request = new RemoverCarroRequest();
            request.id = 1;
           
            var response = new RemoverCarroResponse();
            response.msg = "Removido com sucesso";
            _repositorioCarros.Setup(repositorio => repositorio.Remove(request.id));

            var result = _removerCarroUseCase.Executar(request);

            response.Should().BeEquivalentTo(result);
        }

        [Fact]
        public void Carro_RemoverCarro_QuandoRepositorioExcecao()
        {
            var request = new RemoverCarroRequest();
            request.id = 1;
            Console.WriteLine(request);
            var response = new RemoverCarroResponse();
            response.msg = "Falha ao remover o carro";
            _repositorioCarros.Setup(repositorio => repositorio.Remove(request.id)).Throws(new Exception(""));

            var result = _removerCarroUseCase.Executar(request);
        }

    }
}
