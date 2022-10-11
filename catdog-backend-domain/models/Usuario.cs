using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace catdog_backend_domain.models
{
    public class Usuario
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string cpf_cnpj { get; set; }
    }
}