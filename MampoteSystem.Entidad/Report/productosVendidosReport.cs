using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MampoteSystem.Entidad.Report
{
    public class productosVendidosReport
    {
       public string NumeroFactura { get; set; }
       public string Tipo { get; set; }
       public string Codigo { get; set; }
       public string Nombre { get; set; }
       public int Cantidad { get; set; }
       public DateTime Fecha { get; set; }
    }
}
