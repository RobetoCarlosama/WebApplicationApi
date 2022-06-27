namespace WebApplicationApi.Models
{
    public class Cuenta
    {
        public string Identificacion { get; set; }
        public int Numero { get; set; }
        public string Tipo { get; set; }
        public int SaldoInicial { get; set; }
        public bool EstadoCuenta { get; set; }
    }
}
