using Squadra_Project.DTO.Carro.RetornarCarroPorId;
using Squadra_Project.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Squadra_Project.Bordas.Adapter
{
    public interface ICarroParaResponseAdapter
    {
        public RetornarCarroPorIdResponse transformaCarroResponse(Carro carro);
    }
}
