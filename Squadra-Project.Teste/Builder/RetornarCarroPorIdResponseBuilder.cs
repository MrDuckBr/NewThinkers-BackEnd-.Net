using Bogus;
using Squadra_Project.DTO.Carro.RetornarCarroPorId;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squadra_Project.Teste.Builder
{
   public class RetornarCarroPorIdResponseBuilder
    {
        private readonly Faker _faker = new Faker("pt_BR");
        private readonly RetornarCarroPorIdResponse _adicionar;
        public RetornarCarroPorIdResponseBuilder()
        {
            _adicionar = new RetornarCarroPorIdResponse();
           // _adicionar.nome = _faker.Random.String(40);
            //_adicionar.ano = _faker.Random.Int(2000, 2000);
           // _adicionar.cor = _faker.Random.String(20);
           // _adicionar.valor = _faker.Random.Int(30000, 30000);
        }

        public RetornarCarroPorIdResponse Build()
        {
            return _adicionar;
        }
    }


}

