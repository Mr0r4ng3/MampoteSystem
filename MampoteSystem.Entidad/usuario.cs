using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MampoteSystem.Entidad
{
    public class usuario
    {
        public int id { get; set; }
        public string Cedula { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string username { get; set; }
        public string NivelAcceso { get; set; }
        public string passwd { get; set; }
        public bool Estado { get; set; }
        public string EditorUser { get; set; }
    }
}
