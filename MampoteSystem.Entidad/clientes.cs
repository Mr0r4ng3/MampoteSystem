using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MampoteSystem.Entidad
{
    public class clientes
    {
        public int id { get; set; } 
        public string Cedula { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; } 
        public string Direccion { get; set; }
        public bool Estado { get; set; }
        public string EditorUser { get; set; }
    }
}
