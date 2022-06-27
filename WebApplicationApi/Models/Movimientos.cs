using System;

namespace WebApplicationApi.Models
{
    public class Movimientos
    {
        public int Numero { get; set; }
        public DateTime Fecha { get; set; }
        public bool TipoMovimiento { get; set; }
        public int Valor { get; set; }
        public int Saldo { get; set; }
        public bool EstadoMovimiento { get; set; }
    }
}
