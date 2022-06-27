using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using WebApplicationApi.Adapters;
using WebApplicationApi.Models;
using WebApplicationApi.RptData;

namespace WebApplicationApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReporteController : Controller
    {
        private readonly ILogger<ReporteController> _logger;
        private readonly IReporte _reporte;

        public ReporteController(ILogger<ReporteController> logger, IReporte reporte)
        {
            this._logger = logger;
            this._reporte = reporte;
        }

        [HttpPost]
        public IEnumerable<Reporte> Reporte([FromBody] ReporteModel reporteModel)
        {
            try
            {
                var res = _reporte.ReporteMovimientos(reporteModel);
                return res;
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
    }
}
