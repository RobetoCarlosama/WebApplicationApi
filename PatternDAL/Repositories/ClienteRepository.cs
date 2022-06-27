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
    public class ClienteRepository : GenericRepository<ClienteEntity>, IClienteRepository
    {
        public ClienteRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }

        public ClienteEntity GetByClienteIdentificacion(string clienteIdentificacion)
        {
            return _dbcontext.Cliente.Where(cliente => cliente.Identificacion.Equals(clienteIdentificacion)).FirstOrDefault();
        }

        //public PersonaEntity GetByPersonaIdentificacion(string personaIdentificacion)
        //{
        //    return _dbcontext.Persona.Where(persona => persona.Identificacion.Equals(personaIdentificacion)).FirstOrDefault();
        //}
    }
}
