using MampoteSystem.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MampoteSystem.Datos.Interfaces
{
    public interface IUsuariosRepository : IRepository<usuario>
    {
        IEnumerable<usuario> GetList();
        usuario Login(string username, string passwd);
        int Crud(usuario entity, string option);
    }
}
