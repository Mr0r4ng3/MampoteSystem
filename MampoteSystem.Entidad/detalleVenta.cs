using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MampoteSystem.Entidad
{
    public class detalleVenta
    {
        public string idVenta { get; set; }
        public string Tipo { get; set; }
        public string Codigo { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio_Venta { get; set; }
        public decimal IVA { get; set; }
        public decimal SubTotal { get; set; }
        public string EditorUser { get; set; }
    }
}
