using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplicationApi.Models;
using WebApplicationApi.RptData;

namespace WebApplicationApi.Services
{
    public interface IMovimientosService
    {
        void Add(MovimientosAdd movimientosAdd);
        IEnumerable<Movimientos> GetAll();
                
    }
}
