using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternShared.Entities
{
    public class MovimientosEntity
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public DateTime Fecha { get; set; }
        public bool TipoMovimiento { get; set; }
        public int Valor { get; set; }
        public int Saldo { get; set; }
        public bool EstadoMovimiento { get; set; }

    }
}
