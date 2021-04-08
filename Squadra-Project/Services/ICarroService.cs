using Squadra_Project.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Squadra_Project.Services
{
    public interface ICarroService
    {

        bool AdicionarCarro(Carro carro);
        List<Carro> RetornarListaCarro();

        Carro RetornarCarroPorId(int id);

        bool AtualizarCarro(Carro carro);

        bool DeletarCarro(int id);







    }
}
