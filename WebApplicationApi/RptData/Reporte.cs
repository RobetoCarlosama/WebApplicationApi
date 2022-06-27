using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplicationApi.RptData
{
    public class Reporte
    {
        public DateTime Fecha { get; set; }
        public string Nombre { get; set; }
        public int Numero { get; set; }
        public string Tipo { get; set; }
        public int SaldoInicial { get; set; }
        public bool EstadoMovimiento { get; set; }
        public int Valor { get; set; }
        public int Saldo { get; set; }
    }
}
