using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplicationApi.Models;
using WebApplicationApi.Services;

namespace WebApplicationApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        private readonly IPersonaService _personaService;
        public PersonaController(IPersonaService personaService)
        {
            _personaService = personaService;
        }

        [HttpPost]
        [Route("persona")]
        public void Add([FromBody] Persona persona)
        {
            _personaService.Add(persona);
        }

        [HttpGet]
        public IEnumerable<Persona> Get()
        {
            return _personaService.GetAll();
        }

        [HttpGet("{personaIdentificacion}")]
        public  Persona GetByPersonaIdentificacion(string personaIdentificacion)
        {
            return _personaService.GetByPersonaIdentificacion(personaIdentificacion);
        }
        
        [HttpDelete("{Id}")]
        public void Remove(Persona persona)
        {
            _personaService.Remove(persona);
        }
    }
}
