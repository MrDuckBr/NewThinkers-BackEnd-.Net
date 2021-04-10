using Squadra_Project.DTO.Carro.RetornarListaDeCarro;
using Squadra_Project.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Squadra_Project.Bordas.Adapter
{
    public interface IConverterListaCarroParaListaResponseAdapter
    {
        public List<RetornarListaCarroResponse> converterCarroListaParaListaResponse(List<Carro> carros);
    }
}
