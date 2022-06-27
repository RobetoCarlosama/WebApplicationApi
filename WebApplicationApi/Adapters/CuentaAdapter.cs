using PatternShared.Entities;
using WebApplicationApi.Models;

namespace WebApplicationApi.Adapters
{
    public class CuentaAdapter : ICuentaAdapter
    {
        public CuentaEntity Adapt(Cuenta cuenta)
        {
            return new CuentaEntity()
            {
                Identificacion = cuenta.Identificacion,
                Numero = cuenta.Numero, 
                Tipo = (cuenta.Tipo).ToUpper(),
                SaldoInicial = cuenta.SaldoInicial,
                EstadoCuenta = cuenta.EstadoCuenta,
            };
        }

        public Cuenta Adapt(CuentaEntity cuentaEntity)
        {
            return new Cuenta()
            {
                Identificacion= cuentaEntity.Identificacion,
                Numero= cuentaEntity.Numero,
                Tipo= cuentaEntity.Tipo,
                SaldoInicial= cuentaEntity.SaldoInicial,
                EstadoCuenta =cuentaEntity.EstadoCuenta,
            };
        }
    }
}
