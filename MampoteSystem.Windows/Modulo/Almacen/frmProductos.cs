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

namespace MampoteSystem.Windows.Modulo.Almacen
{
    public partial class frmProductos : Autonomo.Object.Registry
    {
        List<productosReport> productos;
        public frmProductos()
        {
            InitializeComponent();
        }

        public void LoadData() 
        {
            productos = null;
            using (UnitOfWork uow = new UnitOfWork())
            {
                productos = new List<productosReport>();
                productos = uow.productos.GetListProds().ToList();
                FilterData();
            }
        }
        private void FilterData()
        {
            //LinQ
            if(productos != null && productos.Count > 0){
                var newList = from o in productos
                              select new
                              {
                                  Codigo = o.Codigo,
                                  Nombre = o.Nombre,
                                  Descripcion = o.Descripcion,
                                  idCategoria = o.idCategoria,
                                  Categoria = o.Categoria,
                                  Stock = o.Stock,
                                  Precio_Compra = o.Precio_Compra,
                                  Precio_Venta = o.Precio_Venta,
                                  IVA = o.IVA,
                                  totalMasIVA = o.Precio_Venta + o.IVA
                              };

                //Lambda
                if (chkPromociones.Checked == false)
                {
                    grdData.DataSource = newList
                        .Where(o => o.Codigo.ToLower().Contains(txFilter.Text.ToLower()) || o.Nombre.ToLower().Contains(txFilter.Text.ToLower()) && o.idCategoria != "CG001")
                        .OrderBy(o => o.Categoria).ThenBy(o => o.Nombre)
                        .ToList();
                    grdData.Columns[2].Visible = true;
                    grdData.Columns[5].Visible = true;
                    grdData.Columns[6].Visible = true;
                }
                else
                {
                    grdData.DataSource = newList
                        .Where(o => o.Codigo.ToLower().Contains(txFilter.Text.ToLower()) || o.Nombre.ToLower().Contains(txFilter.Text.ToLower()) && o.idCategoria == "CG001")
                        .OrderBy(o => o.Categoria).ThenBy(o => o.Nombre)
                        .ToList();

                    grdData.Columns[2].Visible = false;
                    grdData.Columns[5].Visible = false;
                    grdData.Columns[6].Visible = false;
                }
            }
        }
        private void LoadModal(string option, string title)
        {
            if(chkPromociones.Checked == false)
            {
                var form = new frmProductosModal();
                form.Title.Text = title;
                form.Tag = option;

                if (option == "Update")
                {
                    form.ComboNoVisible();

                    string codigo = grdData.CurrentRow.Cells["Codigo"].Value.ToString();
                    var obj = productos.FirstOrDefault(o => o.Codigo == codigo);

                    if(obj != null) 
                    {
                        form.LoadData(obj);
                    }
                
                }
                else
                {
                }
            
                form.LoadCombo();

                Autonomo.Class.Fomulary.ShowModal(form, option, false);
                if(form.Tag.ToString() == "Get")
                {
                    LoadData();
                }
                form.Dispose();

            }
            else
            {
                var form = new frmPromocionModal();
                form.Title.Text = title;
                form.Tag = option;


                if (option == "Update")
                {

                    string codigo = grdData.CurrentRow.Cells["Codigo"].Value.ToString();
                    var obj = productos.FirstOrDefault(o => o.Codigo == codigo);

                    if (obj != null)
                    {
                        form.LoadData(obj);
                    }

                }
                else
                {
                }

                Autonomo.Class.Fomulary.ShowModal(form, option, false);
                if (form.Tag.ToString() == "Get")
                {
                    LoadData();
                }
                form.Dispose();

            }
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txFilter_TextBoxChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LoadModal("Insert", "Registrar nuevo producto");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (grdData.Rows.Count > 0)
            {
                LoadModal("Update", "Modificar un producto");
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (grdData.Rows.Count > 0)
            {
                DataTable data = Tools.Models.DataGridHelper.GetDataTable(grdData);
                data.Columns.RemoveAt(9);
                data.Columns.RemoveAt(8);
                data.Columns.RemoveAt(3);

                string fecha = DateTime.Now.ToString("dd-MM-yyyy");

                Tools.Models.DataGridHelper.ExportToExcel(data, $"Productos_{fecha}");
            }
            else
            {
                Mensaje.MessageBox(Enumerables.Mensajeria.Error, "No hay datos para exportar.");
            }
        }

        private void frmProductos_Activated(object sender, EventArgs e)
        {
            LoadData();
        }

        private void chkPromociones_CheckedChanged(object sender, EventArgs e)
        {
            FilterData();
        }
    }
}
