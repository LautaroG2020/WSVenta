using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WSVenta.Models
{
    public class ClienteRequest
    {
        
        public long IdCliente { get; set; }
        public string Nombre { get; set; }

        public string Localidad { get; set; }

        public string Direccion { get; set; }

        public string Mail { get; set; }
    }
}
