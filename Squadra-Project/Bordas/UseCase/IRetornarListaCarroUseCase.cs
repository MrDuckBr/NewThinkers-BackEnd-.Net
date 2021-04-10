using Squadra_Project.DTO.Carro.RetornarListaDeCarro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Squadra_Project.UseCase
{
    public interface IRetornarListaCarroUseCase
    {
        RetornarListaCarroResponse Executar(RetornarListaCarroRequest request);
    }
}
