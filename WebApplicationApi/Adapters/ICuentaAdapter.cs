using PatternShared.Entities;
using WebApplicationApi.Models;

namespace WebApplicationApi.Adapters
{
    public interface ICuentaAdapter
    {
        CuentaEntity Adapt(Cuenta cuenta);
        Cuenta Adapt(CuentaEntity cuentaEntity);
    }
}
