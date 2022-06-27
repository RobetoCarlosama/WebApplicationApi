using PatternShared.Entities;
using System.Collections.Generic;
using WebApplicationApi.Adapters;
using WebApplicationApi.Models;

namespace WebApplicationApi.Services
{
    public class ClienteService: IClienteService
    {
        private readonly IClienteAdapter _clienteAdapter;
        private readonly IUnitOfWorkService _unitOfWorkService;
        public ClienteService(IUnitOfWorkService unitOfWorkService, IClienteAdapter clienteAdapter)
        {
            _unitOfWorkService = unitOfWorkService;
            _clienteAdapter = clienteAdapter;
        }
        public void Add(Cliente cliente)
        {
            if (Validate(cliente))
            {
                _unitOfWorkService.Cliente.Add(_clienteAdapter.Adapt(cliente));

                _unitOfWorkService.Save();
            }
        }

        public IEnumerable<Cliente> GetAll()
        {
            List<Cliente> listCliente = new List<Cliente>();
            foreach (ClienteEntity clienteEntity in _unitOfWorkService.Cliente.GetAll())
            {
                listCliente.Add(_clienteAdapter.Adapt(clienteEntity));
            }
            return listCliente;
        }

        public bool Validate(Cliente cliente)
        {
            return true;
        }
    }
}
