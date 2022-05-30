using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MampoteSystem.Entidad.Report
{
    public class detalleVentaReport
    {
        public string id { get; set; }
        public DateTime Fecha { get; set; }
        public string Tipo { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio_Venta { get; set; }
        public decimal IVA { get; set; }
        public decimal SubTotal { get; set; }
    }
}
