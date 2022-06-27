using PatternShared.Entities;
using WebApplicationApi.Models;

namespace WebApplicationApi.Adapters
{
    public interface IClienteAdapter
    {
        ClienteEntity Adapt(Cliente cliente);
        Cliente Adapt(ClienteEntity clienteEntity);
    }
}
