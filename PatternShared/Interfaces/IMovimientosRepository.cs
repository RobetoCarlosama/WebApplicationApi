using PatternShared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternShared.Interfaces
{
    public interface IMovimientosRepository : IGenericRepository<MovimientosEntity>
    {
        MovimientosEntity GetByMovimientosNumero(string cuentaNumero);
    }
}
