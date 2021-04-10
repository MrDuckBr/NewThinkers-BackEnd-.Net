using Squadra_Project.Bordas.Adapter;
using Squadra_Project.DTO.Carro.RetornarCarroPorId;
using Squadra_Project.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Squadra_Project.Adapter
{
    public class CarroParaResponseAdapter : ICarroParaResponseAdapter
    {
        public RetornarCarroPorIdResponse transformaCarroResponse(Carro carro)
        {
            var response = new RetornarCarroPorIdResponse();
            response.ano = carro.ano;
            response.cor = carro.cor;
            response.nome = carro.nome;
            response.valor = carro.valor;
            return response;
        }
    }
}
