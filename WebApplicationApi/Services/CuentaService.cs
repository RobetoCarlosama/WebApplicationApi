using PatternShared.Entities;
using System.Collections.Generic;
using WebApplicationApi.Adapters;
using WebApplicationApi.Models;

namespace WebApplicationApi.Services
{
    public class CuentaService : ICuentaService
    {
        private readonly ICuentaAdapter _cuentaAdapter;
        private readonly IUnitOfWorkService _unitOfWorkService;
        public CuentaService(IUnitOfWorkService unitOfWorkService, ICuentaAdapter cuentaAdapter)
        {
            _unitOfWorkService = unitOfWorkService;
            _cuentaAdapter = cuentaAdapter;
        }
        public void Add(Cuenta cuenta)
        {
            if (Validate(cuenta))
            {
                _unitOfWorkService.Cuenta.Add(_cuentaAdapter.Adapt(cuenta));

                _unitOfWorkService.Save();
            }
        }

        public IEnumerable<Cuenta> GetAll()
        {
            List<Cuenta> listCuenta = new List<Cuenta>();
            foreach (CuentaEntity cuentaEntity in _unitOfWorkService.Cuenta.GetAll())
            {
                listCuenta.Add(_cuentaAdapter.Adapt(cuentaEntity));
            }
            return listCuenta;
        }

        public bool Validate(Cuenta cuenta)
        {
            return true;
        }
    }
}
