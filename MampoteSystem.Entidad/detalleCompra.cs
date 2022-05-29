using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MampoteSystem.Entidad
{
    public class detalleCompra
    {
        public string id { get; set; }
        public string idCompra { get; set; }
        public string codigoProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal SubTotal { get; set; }
    }
}
