using Squadra_Project.DTO.Carro.RetornarCarroPorId;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Squadra_Project.UseCase
{
    public interface IRetornarCarroPorIdUseCase
    {
        RetornarCarroPorIdResponse Executar(RetornarCarroPorIdRequest request);
    }
}
