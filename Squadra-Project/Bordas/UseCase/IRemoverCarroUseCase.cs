using Squadra_Project.DTO.Carro.RemoverCarro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Squadra_Project.UseCase
{
    public interface IRemoverCarroUseCase
    {
        RemoverCarroResponse Executar(RemoverCarroRequest request);
    }
}
