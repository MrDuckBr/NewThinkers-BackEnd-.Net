using FluentAssertions;
using Moq;
using Squadra_Project.Bordas.Adapter;
using Squadra_Project.DTO.Carro.AdicionarCarro;
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
    public class AdicionarCarroUseCaseTest
    {
        private readonly Mock<IRepositorioCarros> _repositorioCarros;
        
        private readonly Mock<IAdicionarCarroAdapter> _adapter;

        private readonly AdicionarCarroUseCase _adicionarCarroUseCase;

        public AdicionarCarroUseCaseTest()
        { 
            _repositorioCarros = new Mock<IRepositorioCarros>();
            _adapter = new Mock<IAdicionarCarroAdapter>();
            _adicionarCarroUseCase = new AdicionarCarroUseCase(_repositorioCarros.Object, _adapter.Object);
        }

        [Fact]
        public void Carro_AdicionarCarro_QuandoRetornarSucesso()
        {
            var request = new AdicionarCarroRequestBuilder().Build();
            Console.WriteLine(request);
            var response = new AdicionarCarroResponse();
            var carro = new Carro();

            response.msg = "Adicionado com Sucesso";


            _adapter.Setup(adapter => adapter.converterRequestParaCarro(request)).Returns(carro);
            _repositorioCarros.Setup(repositorio => repositorio.Add(carro));

            var result = _adicionarCarroUseCase.Executar(request);

            response.Should().BeEquivalentTo(result);



        }

        [Fact]
        public void Carro_AdicionarCarro_ValorMenorQueZero()
        {
            var request = new AdicionarCarroRequestBuilder().verificador(-10).Build();
            Console.WriteLine(request);
            var response = new AdicionarCarroResponse();
            var carro = new Carro();

            response.msg = "Valor Invalido";


            _adapter.Setup(adapter => adapter.converterRequestParaCarro(request)).Returns(carro);
            _repositorioCarros.Setup(repositorio => repositorio.Add(carro));

            var result = _adicionarCarroUseCase.Executar(request);

            response.Should().BeEquivalentTo(result);



        }
        

        [Fact]
        public void Carro_AdicionarCarro_QuandoRepositorioExcecao()
        {
            var request = new AdicionarCarroRequestBuilder().Build();
            Console.WriteLine(request);
            var response = new AdicionarCarroResponse();
            var carro = new Carro();

            response.msg = "Erro ao adicionar";


            _adapter.Setup(adapter => adapter.converterRequestParaCarro(request)).Throws(new Exception(""));
            _repositorioCarros.Setup(repositorio => repositorio.Add(carro));

            var result = _adicionarCarroUseCase.Executar(request);

            response.Should().BeEquivalentTo(result);



        }

    }
}
