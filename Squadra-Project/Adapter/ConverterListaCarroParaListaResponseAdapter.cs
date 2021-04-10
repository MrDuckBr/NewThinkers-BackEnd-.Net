using Squadra_Project.Bordas.Adapter;
using Squadra_Project.DTO.Carro.RetornarListaDeCarro;
using Squadra_Project.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Squadra_Project.Adapter
{
    public class ConverterListaCarroParaListaResponseAdapter : IConverterListaCarroParaListaResponseAdapter
    {
        public List<RetornarListaCarroResponse> converterCarroListaParaListaResponse(List<Carro> carros)
        {
            var retorno = new List<RetornarListaCarroResponse>();
            
            foreach(Carro c in carros)
            {
                var retornar = new RetornarListaCarroResponse();
                retornar.id = c.id;
                retornar.nome = c.nome;
                retornar.ano = c.ano;
                retornar.cor = c.cor;
                retornar.valor = c.valor;
                retorno.Add(retornar);
            }

            return retorno;
           
        }
    }
}
