using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MampoteSystem.Entidad
{
    public class detallesPromocion
    {
        public int id { get; set; }
        public string codigo_promocion { get; set;}
        public string codigo_producto { get; set; }
        public int cantidad { get; set; }
    }
}
