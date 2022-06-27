using PatternShared.Entities;
using WebApplicationApi.Models;

namespace WebApplicationApi.Adapters
{
    public class MovimientosAdapter : IMovimientosAdapter
    {        

        public MovimientosEntity Adapt(MovimientosAdd movimientosAdd)
        {
            return new MovimientosEntity()
            {
                Numero = movimientosAdd.Numero,
                Fecha = System.DateTime.Now,
                TipoMovimiento = movimientosAdd.TipoMovimiento,//1 true is Credit SUMA, 0 false is Debit RESTA
                Valor = movimientosAdd.TipoMovimiento == true ? (movimientosAdd.Valor) : (movimientosAdd.Valor) * -1,
                Saldo = 2000 + (movimientosAdd.TipoMovimiento == true ? (movimientosAdd.Valor): (movimientosAdd.Valor) * -1),
                EstadoMovimiento = true,
            };
        }

        public Movimientos Adapt(MovimientosEntity movimientosEntity)
        {
            return new Movimientos()
            {
                Numero = movimientosEntity.Numero,
                Fecha = movimientosEntity.Fecha,
                TipoMovimiento = movimientosEntity.TipoMovimiento,
                Valor = movimientosEntity.Valor,
                Saldo = movimientosEntity.Saldo,
                EstadoMovimiento = movimientosEntity.EstadoMovimiento,
            };
        }
    }
}
