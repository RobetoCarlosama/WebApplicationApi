using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplicationApi.Models;
using WebApplicationApi.Services;

namespace WebApplicationApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : Controller
    {
        
        private readonly IClienteService _clienteService;
        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpPost]
        [Route("clientes")]
        public void Add([FromBody] Cliente cliente)
        {
            _clienteService.Add(cliente);
        }

        [HttpGet]
        public IEnumerable<Cliente> Get()
        {
            return _clienteService.GetAll();
        }

    }
}
