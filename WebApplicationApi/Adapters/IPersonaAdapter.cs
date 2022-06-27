using PatternShared.Entities;
using WebApplicationApi.Models;

namespace WebApplicationApi.Adapters
{
    public interface IPersonaAdapter
    {
        PersonaEntity Adapt(Persona persona);

        Persona Adapt(PersonaEntity personaEntity);
    }
}
