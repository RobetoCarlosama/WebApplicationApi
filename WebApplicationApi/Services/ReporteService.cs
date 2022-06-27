using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationApi.Adapters;
using WebApplicationApi.Models;
using WebApplicationApi.RptData;

namespace WebApplicationApi.Services
{
    public class ReporteService : IReporte
    {
        private readonly ILogger _logger;
        private ApplicationDbContext1 ctx;
        public IConfiguration Configuration { get; }

        public ReporteService(ILogger<ReporteService> logger, ApplicationDbContext1 ctx, IConfiguration Configuration)
        {
            this.ctx = ctx;
            _logger = logger;
            this.Configuration = Configuration;
        }
        public IEnumerable<Reporte> ReporteMovimientos(ReporteModel reporteModel)
        {
            try
            {
                var data = ctx.Reportes.Where(r => r.Fecha >= reporteModel.FechaI && r.Fecha <= reporteModel.FechaF && r.Nombre == reporteModel.Usuario).ToList();

                var lista = new List<Reporte>();

                foreach (var item in data) 
                {
                    lista.Add(item);
                } 

                return lista;
            }
            catch (System.Exception ex)
            {

                throw;
            }
        }
    }
}
