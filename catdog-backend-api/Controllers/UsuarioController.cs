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
    public class UsuarioController : ControllerBase
    {
        private IUsuarioService _usuarioService;

        private Context _context;

        public UsuarioController(IUsuarioService usuarioService, Context context)
        {
            _usuarioService = usuarioService;
            _context = context;
        }

        [HttpPost]
        public IActionResult Post(Usuario usuario)
        {
            _usuarioService.SalvarUsuario(usuario);

            return Ok();
        }

         [HttpGet]
        public IActionResult Get()
        {
            return Ok( _context.Usuario.ToList());
        }
    }
}