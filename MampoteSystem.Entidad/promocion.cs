using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MampoteSystem.Entidad
{
    public class promocion
    {
        public int idtipo { get; set; }
        public string Codigo { get; set; }
        public string idCategoria { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio_Venta { get; set; }
        public decimal IVA { get; set; }

    }
}
