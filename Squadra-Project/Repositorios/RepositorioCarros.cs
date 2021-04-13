using Microsoft.EntityFrameworkCore;
using Squadra_Project.Context;
using Squadra_Project.DTO.Carro.AdicionarCarro;
using Squadra_Project.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Squadra_Project.Repositorios
{
    public class RepositorioCarros : IRepositorioCarros
    {

        private readonly LocalDbContext _local;

        public RepositorioCarros(LocalDbContext local)
        {
            _local = local;
        }

        public void Add(Carro request)
        {
            _local.carro.Add(request);
            _local.SaveChanges();
        }

        public void Remove(int id)
        {
            var obj = _local.carro.Where(d => d.id == id).FirstOrDefault();
            if (obj == null)
            {
                throw new System.Exception();
            }
            _local.carro.Remove(obj);
            _local.SaveChanges();
            
        }


        public bool AtualizarCarro(Carro novoCarro)
        {
            _local.carro.Attach(novoCarro);
            _local.Entry(novoCarro).State = EntityState.Modified;
            _local.SaveChanges();
            return true;
        }

        public Carro getById(int id)
        {
            return _local.carro.Where(d => d.id == id).FirstOrDefault();
        }

        public List<Carro> RetornarListaCarro()
        {

            return _local.carro.ToList();
        }
    }
}
