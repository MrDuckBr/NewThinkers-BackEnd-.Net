using Squadra_Project.DTO.Carro.AtualizarCarro;
using Squadra_Project.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Squadra_Project.Bordas.Adapter
{
   public interface IAtualizarCarroAdapter
    {
        public Carro transformaRequestEmCarro(AtualizarCarroRequest atualizar);
    }
}
