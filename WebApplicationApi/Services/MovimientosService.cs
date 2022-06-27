using PatternShared.Entities;
using System.Collections.Generic;
using WebApplicationApi.Adapters;
using WebApplicationApi.Models;

namespace WebApplicationApi.Services
{
    public class MovimientosService : IMovimientosService
    {
        private readonly IMovimientosAdapter _movimientoseAdapter;
        private readonly IUnitOfWorkService _unitOfWorkService;
        public MovimientosService(IUnitOfWorkService unitOfWorkService, IMovimientosAdapter movimientosAdapter)
        {
            _unitOfWorkService = unitOfWorkService;
            _movimientoseAdapter = movimientosAdapter;
        }
        public void Add(MovimientosAdd movimientosAdd)
        {
            if (Validate(movimientosAdd))
            {
                _unitOfWorkService.Movimientos.Add(_movimientoseAdapter.Adapt(movimientosAdd));

                _unitOfWorkService.Save();
            }
        }

        public IEnumerable<Movimientos> GetAll()
        {
            List<Movimientos> listMovimientos = new List<Movimientos>();
            foreach (MovimientosEntity movimientosEntity in _unitOfWorkService.Movimientos.GetAll())
            {
                listMovimientos.Add(_movimientoseAdapter.Adapt(movimientosEntity));
            }
            return listMovimientos;
        }

        public bool Validate(MovimientosAdd movimientosAdd)
        {
            return true;
        }
    }
}
