using Squadra_Project.DTO.Carro.AdicionarCarro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Squadra_Project.UseCase
{
    public interface IAdicionarCarroUseCase
    {
        AdicionarCarroResponse Executar(AdicionarCarroRequest request);

    }
}
