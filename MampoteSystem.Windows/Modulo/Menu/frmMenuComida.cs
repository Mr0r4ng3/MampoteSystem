using MampoteSystem.Datos;
using MampoteSystem.Entidad.Report;
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

namespace MampoteSystem.Windows.Modulo.Menu
{
    public partial class frmMenuComida : Autonomo.Object.Registry
    {
        List<comidaReport> menu;
        public frmMenuComida()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                menu = new List<comidaReport>();
                menu = uow.productos.GetListComida().ToList();
                FilterData();
            }
        }
        private void FilterData()
        {
            //LinQ
            if (menu != null && menu.Count > 0)
            {
                var newList = from o in menu
                              select new
                              {
                                  Codigo = o.Codigo,
                                  Nombre = o.Nombre,
                                  Descripcion = o.Descripcion,
                                  idCategoria = o.idCategoria,
                                  Categoria = o.Categoria,
                                  Stock = o.Stock,
                                  Costo = o.Costo,
                                  Precio_Venta = o.Precio_Venta,
                                  IVA = o.IVA,
                                  totalMasIVA = o.Precio_Venta + o.IVA
                              };

                //Lambda
                grdData.DataSource = newList
                    .Where(o => o.Codigo.Contains(txFilter.Text))
                    .OrderBy(o => o.Categoria).ThenBy(o => o.Nombre)
                    .ToList();
            }
        }
        private void LoadModal(string option, string title)
        {
            var form = new frmMenuComidaModal();
            form.Title.Text = title;
            form.Tag = option;



            if (option == "Update")
            {
                form.ComboNoVisible();

                string codigo = grdData.CurrentRow.Cells["Codigo"].Value.ToString();
                var obj = menu.FirstOrDefault(o => o.Codigo == codigo);

                if (obj != null)
                {
                    form.LoadData(obj);
                }

            }
            else
            {
            }

            form.LoadCombo();

            Autonomo.Class.Fomulary.ShowModal(form, option, false);
            if (form.Tag.ToString() == "Get")
            {
                LoadData();
            }
            form.Dispose();

        }

        private void setStock()
        {
            if (grdData.SelectedRows.Count > 0)
            {
                string codigo = grdData.SelectedRows[0].Cells[0].Value.ToString();
                string nombre = grdData.SelectedRows[0].Cells[1].Value.ToString();


                var form = new frmSetStock();
                form.Title.Text = "Establecer Stock para " + nombre;
                form.codigo = codigo;



                Autonomo.Class.Fomulary.ShowModal(form, "SetStock" , false);
                if (form.Tag.ToString() == "Get")
                {
                    LoadData();
                }
                form.Dispose();

            }
        }


        private void frmMenu_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txFilter_TextBoxChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LoadModal("Insert", "Registrar nuevo Menu");

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (grdData.Rows.Count > 0)
            {
                LoadModal("Update", "Modificar un Menu");
            }
        }

        private void btnCommand1_Click(object sender, EventArgs e)
        {
            setStock();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (grdData.Rows.Count > 0)
            {
                DataTable data = Tools.Models.DataGridHelper.GetDataTable(grdData);
                data.Columns.RemoveAt(9);
                data.Columns.RemoveAt(8);
                data.Columns.RemoveAt(5);
                data.Columns.RemoveAt(3);

                string fecha = DateTime.Now.ToString("dd-MM-yyyy");

                Tools.Models.DataGridHelper.ExportToExcel(data, $"ComidaMenu_{fecha}");
            }
            else
            {
                Mensaje.MessageBox(Enumerables.Mensajeria.Error, "No hay datos para exportar.");
            }
        }
    }
}
