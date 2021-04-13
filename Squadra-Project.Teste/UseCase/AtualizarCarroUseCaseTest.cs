using FluentAssertions;
using Moq;
using Squadra_Project.Bordas.Adapter;
using Squadra_Project.DTO.Carro.AtualizarCarro;
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
    public class AtualizarCarroUseCaseTest
    {
        private readonly Mock<IRepositorioCarros> _repositorioCarros;

        private readonly Mock<IAtualizarCarroAdapter> _adapter;

        private readonly AtualizarCarroUseCase _atualizarCarroUseCase;

        public AtualizarCarroUseCaseTest()
        {
            _repositorioCarros = new Mock<IRepositorioCarros>();
            _adapter = new Mock<IAtualizarCarroAdapter>();
            _atualizarCarroUseCase = new AtualizarCarroUseCase(_repositorioCarros.Object, _adapter.Object);
        }


        //variaveis
        [Fact]
        public void Carro_AtualizarCarro_QuandoRetornarSucesso()
        {
            var request = new AtualizarCarroRequestBuilder().Build();
            Console.WriteLine(request);
            var response = new AtualizarCarroResponse();
            var carro = new Carro();

            response.msg = "Carro Atualizado com sucesso";


            _adapter.Setup(adapter => adapter.transformaRequestEmCarro(request)).Returns(carro);
            _repositorioCarros.Setup(repositorio => repositorio.AtualizarCarro(carro));

            var result = _atualizarCarroUseCase.Executar(request);

            response.Should().BeEquivalentTo(result);



        }

        [Fact]
        public void Carro_AtualizarCarro_QuandoRetornaExcecao()
        {
            var request = new AtualizarCarroRequestBuilder().Build();
            Console.WriteLine(request);
            var response = new AtualizarCarroResponse();
            var carro = new Carro();

            response.msg = "Erro ao Atualizar";


            _adapter.Setup(adapter => adapter.transformaRequestEmCarro(request)).Throws(new Exception(""));
            _repositorioCarros.Setup(repositorio => repositorio.AtualizarCarro(carro));

            var result = _atualizarCarroUseCase.Executar(request);

            response.Should().BeEquivalentTo(result);



        }
        [Fact]
        public void Carro_Atualizar_ValorMenorQueZero()
        {
            var request = new AtualizarCarroRequestBuilder().verificador(-10).Build();
            Console.WriteLine(request);
            var response = new AtualizarCarroResponse();
            var carro = new Carro();

            response.msg = "Valor Invalido";


            _adapter.Setup(adapter => adapter.transformaRequestEmCarro(request)).Returns(carro);
            _repositorioCarros.Setup(repositorio => repositorio.Add(carro));

            var result = _atualizarCarroUseCase.Executar(request);

            response.Should().BeEquivalentTo(result);



        }


    }
}
