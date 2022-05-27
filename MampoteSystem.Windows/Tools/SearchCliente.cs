using MampoteSystem.Datos;
using MampoteSystem.Entidad;
using MampoteSystem.Windows.Modulo.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MampoteSystem.Windows.Tools
{
    public class SearchCliente
    {
        public static clientes Search(string Cedula, bool isNew)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                clientes cliente = uow.clientes.GetCliente(Cedula);

                if (!isNew)
                {
                    return cliente;
                }

                if (cliente != null)
                {
                    int OrdenesSinPagar = uow.clientes.ClienteTieneOrden(cliente.id);

                    if ( OrdenesSinPagar > 0)
                    {
                       DialogResult response = MessageBox.Show($"{cliente.Nombres} {cliente.Apellidos} tiene ya una Orden de Venta sin pagar, ¿Desea continuar?", "¡Advertencia!",MessageBoxButtons.YesNo);
                        if (response == DialogResult.Yes)
                        {
                            return cliente;
                        }
                        return null;
                    }
                    
                    return cliente;

                }
                else
                {


                    var form = new SearchAndCreateClientes();
                    form.Title.Text = "Registrar o Buscar Cliente";
                    form.Tag = "Insert";
                    form.LoadCedula(Cedula);

                    Autonomo.Class.Fomulary.ShowModal(form, "Insert", false);
                    if (form.Tag.ToString() == "Get" && form.Cliente != null)
                    {
                        cliente = form.Cliente;
                        return cliente;
                    }
                    form.Dispose();
                    return null;
                }
            }
        }
    }
}
