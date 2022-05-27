using MampoteSystem.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MampoteSystem.Datos.Interfaces
{
    public interface IClientesRepository : IRepository<clientes>
    {
        IEnumerable<clientes> GetList();
        clientes GetCliente(string Cedula);
        int Crud(clientes entity, string option);
        int ClienteTieneOrden(int idCliente);
        clientes SelectNewCliente();
    }
}
