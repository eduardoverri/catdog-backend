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
    public class AnimalController : ControllerBase
    {
        private IAnimalService _animalService;

        private Context _context;

        public AnimalController(IAnimalService animalService, Context context)
        {
            _animalService = animalService;
            _context = context;
        }

        [HttpPost]
        public IActionResult Post(Animal animal)
        {
            _animalService.SalvarAnimal(animal);

            return Ok();
        }

         [HttpGet]
        public IActionResult Get()
        {
            return Ok( _context.Animal.ToList());
        }
    }
}