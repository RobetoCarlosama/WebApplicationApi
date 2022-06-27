using System.Collections.Generic;
using WebApplicationApi.Models;

namespace WebApplicationApi.Services
{
    public interface ICuentaService
    {
        void Add(Cuenta cuenta);
        IEnumerable<Cuenta> GetAll();
    }
}
