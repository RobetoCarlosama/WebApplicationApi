using PatternDAL.DbContexts;
using PatternShared.Entities;
using PatternShared.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDAL.Repositories
{
    public class PersonaRepository : GenericRepository<PersonaEntity>, IPersonaRepository
    {
        public PersonaRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }

        public PersonaEntity GetByPersonaIdentificacion(string personaIdentificacion)
        {
            return _dbcontext.Persona.Where(persona => persona.Identificacion.Equals(personaIdentificacion)).FirstOrDefault();
        }
    }
}
