using PatternDAL.DbContexts;
using PatternShared.Interfaces;
using WebApplicationApi.Models;

namespace WebApplicationApi.Services
{
    public class UnitOfWorkService : IUnitOfWorkService
    {
        private readonly ApplicationDbContext _dbContext;
        public UnitOfWorkService(ApplicationDbContext dbContext, IPersonaRepository personaRepository, IClienteRepository clienteRepository, ICuentaRepository cuentaRepository, IMovimientosRepository movimientosRepository)
        {
            _dbContext = dbContext;
            Persona = personaRepository;
            Cliente = clienteRepository;
            Cuenta = cuentaRepository;
            Movimientos = movimientosRepository;
        }

        public IPersonaRepository Persona { get; set; }
        public IClienteRepository Cliente { get; set; }
        public ICuentaRepository Cuenta { get; set; }
        public IMovimientosRepository Movimientos { get; set; }

        public int Save()
        {
            return _dbContext.SaveChanges();
        }
    }
}
