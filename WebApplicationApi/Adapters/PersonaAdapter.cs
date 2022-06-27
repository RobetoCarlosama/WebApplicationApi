using PatternShared.Entities;
using WebApplicationApi.Models;

namespace WebApplicationApi.Adapters
{
    public class PersonaAdapter : IPersonaAdapter
    {
        public PersonaEntity Adapt(Persona persona)
        {
            return new PersonaEntity()
            {
                Nombre = (persona.Nombre).ToUpper(),
                Genero = (persona.Genero).ToUpper(),
                Edad = persona.Edad,
                Identificacion = persona.Identificacion,  
                Direccion = (persona.Direccion).ToUpper(),
                Telefono = persona.Telefono,
                Estado = true,                                
            };
        }

        public Persona Adapt(PersonaEntity personaEntity)
        {
            return new Persona()
            {
                Nombre = personaEntity.Nombre,
                Genero=personaEntity.Genero,
                Edad=personaEntity.Edad,
                Identificacion = personaEntity.Identificacion,
                Direccion=personaEntity.Direccion,
                Telefono=personaEntity.Telefono,
                //Estado=personaEntity.Estado,
            };
        }
    }
}
