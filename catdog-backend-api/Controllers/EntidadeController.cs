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
    public class EntidadeController : ControllerBase
    {
        private IEntidadeService _entidadeService;

        private Context _context;

        public EntidadeController(IEntidadeService entidadeService, Context context)
        {
            _entidadeService = entidadeService;
            _context = context;
        }

        [HttpPost]
        public IActionResult Post(Entidade entidade)
        {
            _entidadeService.SalvarEntidade(entidade);

            return Ok();
        }

         [HttpGet]
        public IActionResult Get()
        {
            return Ok( _context.Entidade.ToList());
        }
    }
}