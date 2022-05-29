using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MampoteSystem.Entidad.Pagos
{
    public class pago
    {
        public int id { get; set; }
        public string idVenta { get; set; }
        public int idTipo { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Monto { get; set; }
        public decimal Tasa { get; set; }
        public decimal Vuelto_Divisas { get; set; }
        public decimal Vuelto_Bolivares { get; set; }
        public decimal Propina { get; set; }
        public string Nota { get; set; }
    }
}
