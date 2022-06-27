using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplicationApi.Models;
using WebApplicationApi.Services;

namespace WebApplicationApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CuentaController : Controller
    {
        private readonly ICuentaService _cuentaService;
        public CuentaController(ICuentaService clienteService)
        {
            _cuentaService = clienteService;
        }

        [HttpPost]
        [Route("cuentas")]
        public void Add([FromBody] Cuenta cuenta)
        {
            _cuentaService.Add(cuenta);
        }

        [HttpGet]
        public IEnumerable<Cuenta> Get()
        {
            return _cuentaService.GetAll();
        }
    }
}
