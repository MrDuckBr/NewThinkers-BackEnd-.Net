using Squadra_Project.DTO.Carro.AdicionarCarro;
using Squadra_Project.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Squadra_Project.Bordas.Adapter
{
   public interface IAdicionarCarroAdapter
    {
        public Carro converterRequestParaCarro(AdicionarCarroRequest request);
    }
}
