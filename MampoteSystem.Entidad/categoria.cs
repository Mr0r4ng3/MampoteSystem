using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MampoteSystem.Entidad
{
    public class categoria
    {
        public string id { get; set; }
        public int idTipo { get; set; }
        public string Nombre { get; set; }
        public string EditorUser { get; set; }
        public bool Estado { get; set; }
    }
}
