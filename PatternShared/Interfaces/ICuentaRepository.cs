using PatternShared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternShared.Interfaces
{
    public interface ICuentaRepository: IGenericRepository<CuentaEntity>
    {
        CuentaEntity GetByCuentaIdentificacion(string cuentaIdentificacion);
    }
}
