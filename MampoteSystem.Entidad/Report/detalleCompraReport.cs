using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MampoteSystem.Entidad.Report
{
    public class detalleCompraReport
    {
        public string codigoProducto { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio_Compra { get; set; }
        public decimal SubTotal { get; set; }
    }
}
