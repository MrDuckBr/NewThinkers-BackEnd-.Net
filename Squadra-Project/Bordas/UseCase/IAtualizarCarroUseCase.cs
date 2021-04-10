using Squadra_Project.DTO.Carro.AtualizarCarro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Squadra_Project.UseCase
{
    public interface IAtualizarCarroUseCase
    {
        AtualizarCarroResponse Executar(AtualizarCarroRequest request);
    }
}
