using System;
using System.Collections.Generic;

namespace WSVenta.Models
{
    public partial class Usuario
    {
        public long IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Password { get; set; }
        public string Mail { get; set; }
    }
}
