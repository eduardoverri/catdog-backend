using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace catdog_backend_domain.models
{
    public class  Evento
    {

        public int Id { get; set; }
        
        public DateTime DataEvento { get; set; }

        public Animal Animal { get; set; }

        public TipoEvento TipoEvento { get; set; }

        public Entidade Entidade { get; set; }

        public string Legenda  { get; set; }
    }
}