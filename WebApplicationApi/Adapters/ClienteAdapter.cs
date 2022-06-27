using PatternShared.Entities;
using WebApplicationApi.Models;

namespace WebApplicationApi.Adapters
{
    public class ClienteAdapter : IClienteAdapter
    {
        public ClienteEntity Adapt(Cliente cliente)
        {
            return new ClienteEntity()
            {
               Identificacion = cliente.Identificacion, 
               Contrasenia = cliente.Contrasenia,
               EstadoCliente = cliente.EstadoCliente,
            };
        }

        public Cliente Adapt(ClienteEntity clienteEntity)
        {
            return new Cliente()
            {
                Identificacion = clienteEntity.Identificacion,
                Contrasenia = clienteEntity.Contrasenia,                
                EstadoCliente = clienteEntity.EstadoCliente,               
            };
        }
    }
}
