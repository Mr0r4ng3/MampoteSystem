using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MampoteSystem.Entidad
{
    public class compra
    {
        public string id { get; set; }
        public string Usuario { get; set; }
        public string idProveedor { get; set; }
        public string NumeroFactura { get; set; }
        public decimal MontoTotal { get; set; }
        public decimal Tasa { get; set; }
        public DateTime Fecha { get; set; }
}
}
