using Squadra_Project.Bordas.Adapter;
using Squadra_Project.DTO.Carro.AtualizarCarro;
using Squadra_Project.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Squadra_Project.Adapter
{
    public class AtualizarCarroAdapter : IAtualizarCarroAdapter
    {
        public Carro transformaRequestEmCarro(AtualizarCarroRequest atualizar)
        {
            var novoCarro = new Carro();
            novoCarro.nome = atualizar.nome;
            novoCarro.ano = atualizar.ano;
            novoCarro.cor = atualizar.cor;
            novoCarro.valor = atualizar.valor;
            return novoCarro;
        }
    }
}
