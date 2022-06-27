using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternShared.Entities
{
    public class CuentaEntity
    {
        public int Id { get; set; }
        public string Identificacion { get; set; }
        public int Numero { get; set; }
        public string Tipo { get; set; }
        public int SaldoInicial { get; set; }
        public bool EstadoCuenta { get; set; }
    }
}
