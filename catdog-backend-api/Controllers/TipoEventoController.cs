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
    public class TipoEventoController : ControllerBase
    {

        private Context _context;

        public TipoEventoController(Context context)
        {
            _context = context;
        }


         [HttpGet]
        public IActionResult Get()
        {
            return Ok( _context.TipoEvento.ToList());
        }
    }
}