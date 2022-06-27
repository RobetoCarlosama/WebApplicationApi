using PatternShared.Entities;
using WebApplicationApi.Models;

namespace WebApplicationApi.Adapters
{
    public interface IMovimientosAdapter
    {
        MovimientosEntity Adapt(MovimientosAdd movimientosAdd);
        Movimientos Adapt(MovimientosEntity movimientosEntity);
    }
}
