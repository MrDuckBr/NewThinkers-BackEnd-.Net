using Squadra_Project.Bordas.Adapter;
using Squadra_Project.DTO.Carro.AdicionarCarro;
using Squadra_Project.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Squadra_Project.Adapter
{
    public class AdicionarCarroAdapter : IAdicionarCarroAdapter
    {
        public Carro converterRequestParaCarro(AdicionarCarroRequest request)
        {
            var novoCarro = new Carro();
            novoCarro.nome = request.nome;
            novoCarro.ano = request.ano;
            novoCarro.cor = request.cor;
            novoCarro.valor = request.valor;
            return novoCarro;
        }
    }
}
