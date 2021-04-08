using System.ComponentModel.DataAnnotations;

namespace Squadra_Project.Entities
{
    public class Carro{

        [Key]
        public int id { get; set; }

        public string nome { get; set; }

        public int ano { get; set; }

        public string cor { get; set; }

        public int valor { get; set; }







    }
}
