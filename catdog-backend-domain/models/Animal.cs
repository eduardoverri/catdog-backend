using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace catdog_backend_domain.models
{
    public class Animal
    {

        public int Id { get; set; }
        
        public string Nome { get; set; }

        public string Raca { get; set; }

        public string Peso { get; set; }

        public DateTime DataNascimento { get; set; }
        
    }
}