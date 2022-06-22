using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MampoteSystem.Entidad
{
    public class venta
    {
        public string id { get; set; }
        public bool Vendido { get; set; }
        public string NumeroFactura { get; set; }
        public int idCliente { get; set; }
        public decimal Comision { get; set; }
        public string EstadoComision { get; set; }
        public string Descuento { get; set; }
        public decimal TotalDescuento { get; set; }
        public decimal MontoTotal { get; set; }
        public decimal Deuda { get; set; }
        public decimal Fecha { get; set; }
        public string Nota { get; set; }
    }
}
