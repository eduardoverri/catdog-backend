using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace catdog_backend_domain.models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf_cnpj { get; set; }
    }
}