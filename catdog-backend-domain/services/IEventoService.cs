using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using catdog_backend_domain.models;

namespace catdog_backend_domain.services
{
    public interface IEventoService
    {

        public void SalvarEvento(Evento evento);
        
    }
}