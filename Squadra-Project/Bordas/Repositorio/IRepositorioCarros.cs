using Squadra_Project.DTO.Carro.AdicionarCarro;
using Squadra_Project.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Squadra_Project.Repositorios
{
    public interface IRepositorioCarros
    {
        public void Add(Carro request);

        public void Remove(int id);

        public bool AtualizarCarro(Carro novoCarro);

        public Carro getById(int id);

        public List<Carro> RetornarListaCarro();
        
    }
}
