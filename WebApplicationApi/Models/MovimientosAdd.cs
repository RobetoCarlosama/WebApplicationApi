using System;

namespace WebApplicationApi.Models
{
    public class MovimientosAdd
    {
        public int Numero { get; set; }
        public bool TipoMovimiento { get; set; }
        public int Valor { get; set; }
    }
}
