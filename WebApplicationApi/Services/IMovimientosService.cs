using System.Collections.Generic;
using WebApplicationApi.Models;

namespace WebApplicationApi.Services
{
    public interface IMovimientosService
    {
        void Add(MovimientosAdd movimientosAdd);
        IEnumerable<Movimientos> GetAll();
    }
}
