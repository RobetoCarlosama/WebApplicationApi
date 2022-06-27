using Microsoft.EntityFrameworkCore;
using PatternShared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDAL.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<PersonaEntity> Persona { get; set; }
        public DbSet<ClienteEntity> Cliente { get; set; }
        public DbSet<CuentaEntity> Cuenta { get; set; }
        public DbSet<MovimientosEntity> Movimientos { get; set; }
    }
}
