using System.Collections.Generic;
using WebApplicationApi.Models;

namespace WebApplicationApi.Services
{
    public interface IPersonaService
    {
        void Add(Persona persona);
        Persona GetByPersonaIdentificacion(string personaIdentificacion);
        IEnumerable<Persona> GetAll();

        void Remove(Persona persona);
    }
}
