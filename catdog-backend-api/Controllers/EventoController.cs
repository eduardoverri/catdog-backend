using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using catdog_backend_domain.services;
using catdog_backend_domain.models;
using catdog_backend_domain;

namespace catdog_backend_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        private IEventoService _eventoService;

        private Context _context;

        public EventoController(IEventoService eventoService, Context context)
        {
            _eventoService = eventoService;
            _context = context;
        }

        [HttpPost]
        public IActionResult Post(Evento evento)
        {
            _eventoService.SalvarEvento(evento);

            return Ok();
        }

         [HttpGet]
        public IActionResult Get()
        {
            return Ok( _context.Evento.ToList());
        }
    }
}