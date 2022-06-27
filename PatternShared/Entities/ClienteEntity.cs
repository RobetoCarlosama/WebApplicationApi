using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternShared.Entities
{
    public class ClienteEntity
    {
        public int Id { get; set; }
        public string Identificacion { get; set; }
        public string Contrasenia { get; set; }
        public bool EstadoCliente { get; set; }

    }
}
