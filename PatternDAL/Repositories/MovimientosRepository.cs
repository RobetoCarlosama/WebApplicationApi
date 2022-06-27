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
    public class MovimientosRepository : GenericRepository<MovimientosEntity>, IMovimientosRepository
    {
        public MovimientosRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }

        public MovimientosEntity GetByMovimientosNumero(string cuentaNumero)
        {
            return _dbcontext.Movimientos.Where(movimientos => movimientos.Numero.Equals(cuentaNumero)).FirstOrDefault();
        }
    }
}
