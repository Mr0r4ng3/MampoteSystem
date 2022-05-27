using MampoteSystem.Datos;
using MampoteSystem.Entidad;
using MampoteSystem.Windows.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MampoteSystem.Windows.Modulo.Clientes
{
    public partial class frmClientes : Autonomo.Object.Registry
    {
        List<clientes> clientes;
        public frmClientes()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                clientes = new List<clientes>();
                clientes = uow.clientes.GetList().ToList();
                FilterData();
            }
        }
        private void FilterData()
        {
            //LinQ
            if (clientes != null && clientes.Count > 0)
            {
                var newList = from o in clientes
                              select new
                              {
                                  id = o.id,
                                  Cedula = o.Cedula,
                                  Nombres = o.Nombres,
                                  Apellidos = o.Apellidos,
                                  Telefono = o.Telefono,
                                  Direccion = o.Direccion,
                              };

                //Lambda
                grdData.DataSource = newList
                    .Where(o => o.Nombres.Contains(txFilter.Text))
                    .OrderBy(o => o.Nombres)
                    .ToList();
            }
        }
        private void LoadModal(string option, string title)
        {
            var form = new frmClientesModal();
            form.Title.Text = title;
            form.Tag = option;



            if (option == "Update")
            {

                int id = Convert.ToInt32(grdData.CurrentRow.Cells["id"].Value);
                var obj = clientes.FirstOrDefault(o => o.id == id);

                if (obj != null)
                {
                    form.LoadData(obj);
                }

            }

            Autonomo.Class.Fomulary.ShowModal(form, option, false);
            if (form.Tag.ToString() == "Get")
            {
                LoadData();
            }
            form.Dispose();

        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txFilter_TextBoxChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LoadModal("Insert", "Registrar nuevo cliente");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            LoadModal("Update", "Modificar un cliente");
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (grdData.Rows.Count > 0)
            {
                DataTable data = Tools.Models.DataGridHelper.GetDataTable(grdData);
                data.Columns.RemoveAt(0);

                string fecha = DateTime.Now.ToString("dd-MM-yyyy");

                Tools.Models.DataGridHelper.ExportToExcel(data, $"Clientes_{fecha}");
            }
            else
            {
                Mensaje.MessageBox(Enumerables.Mensajeria.Error, "No hay datos para exportar.");
            }
        }
    }
}
