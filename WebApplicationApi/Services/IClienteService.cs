using System.Collections.Generic;
using WebApplicationApi.Models;

namespace WebApplicationApi.Services
{
    public interface IClienteService
    {
        void Add(Cliente cliente);
        IEnumerable<Cliente> GetAll();
    }
}
