using Bogus;
using Squadra_Project.DTO.Carro.AdicionarCarro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squadra_Project.Teste.Builder
{
    public class AdicionarCarroRequestBuilder
    {
        private readonly Faker _faker = new Faker("pt_BR");
        private readonly AdicionarCarroRequest _adicionar;
        public AdicionarCarroRequestBuilder()
        {
            _adicionar = new AdicionarCarroRequest();
            _adicionar.nome = _faker.Random.String(40);
            _adicionar.ano = _faker.Random.Int(2000, 2000);
            _adicionar.cor = _faker.Random.String(20);
            _adicionar.valor = _faker.Random.Int(30000, 30000);
        }

        public AdicionarCarroRequestBuilder verificador(int valor)
        {
            _adicionar.valor = valor;
            return this;
        }

        public AdicionarCarroRequest Build()
        {
            return _adicionar;
        }

       

    }
}
