using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplicationApi.Models;
using WebApplicationApi.RptData;

namespace WebApplicationApi.Adapters
{
    public interface IReporte
    {
        public IEnumerable<Reporte> ReporteMovimientos(ReporteModel reporteModel);
    }
}
