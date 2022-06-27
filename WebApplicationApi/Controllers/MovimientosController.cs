using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplicationApi.Models;
using WebApplicationApi.Services;

namespace WebApplicationApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovimientosController : Controller
    {
        private readonly IMovimientosService _movimientosService;
        public MovimientosController(IMovimientosService movimientosService)
        {
            _movimientosService = movimientosService;
        }

        [HttpPost]
        [Route("movimientos")]
        public void Add([FromBody] MovimientosAdd movimientosAdd)
        {
            _movimientosService.Add(movimientosAdd);           
        }

        [HttpGet]
        public IEnumerable<Movimientos> Get()
        {
            return _movimientosService.GetAll();
        }
    }
}
