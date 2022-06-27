using PatternShared.Interfaces;

namespace WebApplicationApi.Services
{
    public interface IUnitOfWorkService
    {
        int Save();
        IPersonaRepository Persona { get; set; }

        IClienteRepository Cliente { get; set; }

        ICuentaRepository Cuenta { get; set; }

        IMovimientosRepository Movimientos { get; set; }

    }
}
