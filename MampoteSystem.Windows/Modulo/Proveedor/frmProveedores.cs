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

namespace MampoteSystem.Windows.Modulo.Proveedor
{
    public partial class frmProveedores : Autonomo.Object.Registry
    {
        List<proveedores> proveedores;
        public frmProveedores()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                proveedores = new List<proveedores>();
                proveedores = uow.proveedores.GetList().ToList();
                FilterData();
            }
        }
        private void FilterData()
        {
            //LinQ
            if (proveedores != null && proveedores.Count > 0)
            {
                var newList = from o in proveedores
                              select new
                              {
                                  id = o.id,
                                  Razon_Social = o.Razon_Social,
                                  RIF = o.RIF,
                                  Telefono = o.Telefono,
                                  Email = o.Email,
                              };

                //Lambda
                grdData.DataSource = newList
                    .Where(o => o.Razon_Social.Contains(txFilter.Text))
                    .OrderBy(o => o.Razon_Social)
                    .ToList();

                grdData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }
        private void LoadModal(string option, string title)
        {
            var form = new frmProveedoresModal();
            form.Title.Text = title;
            form.Tag = option;



            if (option == "Update")
            {

                string id = grdData.CurrentRow.Cells["id"].Value.ToString();
                var obj = proveedores.FirstOrDefault(o => o.id == id);

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

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txFilter_TextBoxChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LoadModal("Insert", "Registrar nuevo proveedor");

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            LoadModal("Update", "Modificar un proveedor");

        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (grdData.Rows.Count > 0)
            {
                DataTable data = Tools.Models.DataGridHelper.GetDataTable(grdData);
                data.Columns.RemoveAt(0);

                string fecha = DateTime.Now.ToString("dd-MM-yyyy");

                Tools.Models.DataGridHelper.ExportToExcel(data, $"Proveedores_{fecha}");
            }
            else
            {
                Mensaje.MessageBox(Enumerables.Mensajeria.Error, "No hay datos para exportar.");
            }
        }
    }
}
