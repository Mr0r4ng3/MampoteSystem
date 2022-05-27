using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MampoteSystem.Entidad.Report
{
    public class compraReport
    {
        public string id { get; set; }
        public string Proveedor { get; set; }
        public string NumeroFactura { get; set; }
        public decimal Tasa { get; set; }
        public decimal MontoTotal { get; set; }
        public DateTime Fecha { get; set; }
}
}
