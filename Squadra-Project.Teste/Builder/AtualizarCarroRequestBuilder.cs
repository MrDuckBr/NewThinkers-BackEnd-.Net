using Bogus;
using Squadra_Project.DTO.Carro.AtualizarCarro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squadra_Project.Teste.Builder
{
    class AtualizarCarroRequestBuilder
    {

        private readonly Faker _faker = new Faker("pt_BR");
        private readonly AtualizarCarroRequest _adicionar;
        public AtualizarCarroRequestBuilder()
        {
            _adicionar = new AtualizarCarroRequest();
            _adicionar.nome = _faker.Random.String(40);
            _adicionar.ano = _faker.Random.Int(2000, 2000);
            _adicionar.cor = _faker.Random.String(20);
            _adicionar.valor = _faker.Random.Int(30000, 30000);
        }
        public AtualizarCarroRequestBuilder verificador(int valor)
        {
            _adicionar.valor = valor;
            return this;
        }

        public AtualizarCarroRequest Build()
        {
            return _adicionar;
        }
    }
}
