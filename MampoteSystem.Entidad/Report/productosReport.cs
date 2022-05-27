using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MampoteSystem.Entidad.Report
{
    public  class productosReport
    {
        public string Codigo { get; set; }
        public string idCategoria { get; set; }
        public string Categoria { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Stock { get; set; }
        public decimal Precio_Compra { get; set; }
        public decimal Precio_Venta { get; set; }
        public decimal IVA { get; set; }
        public string EditorUser { get; set; }
        public bool Estado { get; set; }
    }
}
