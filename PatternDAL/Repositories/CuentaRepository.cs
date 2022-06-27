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
    public class CuentaRepository : GenericRepository<CuentaEntity>, ICuentaRepository
    {
        public CuentaRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }

        public CuentaEntity GetByCuentaIdentificacion(string cuentaIdentificacion)
        {
            return _dbcontext.Cuenta.Where(cuenta => cuenta.Identificacion.Equals(cuentaIdentificacion)).FirstOrDefault();
        }

    }
}
