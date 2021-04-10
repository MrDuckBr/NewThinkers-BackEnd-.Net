using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Squadra_Project.DTO.Carro.AdicionarCarro
{
    public class AdicionarCarroRequest
    {
        public string nome { get; set; }

        public int ano { get; set; }

        public string cor { get; set; }

        public int valor { get; set; }
    }
}
