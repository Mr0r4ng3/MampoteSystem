using MampoteSystem.Datos;
using MampoteSystem.Entidad.Report;
using MampoteSystem.Windows.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Autonomo.CustomControls.HelperControl;


namespace MampoteSystem.Windows.Modulo.Compras
{
    public partial class frmCompra : Autonomo.CustomTemplate.RegistryDouble
    {
        List<compraReport> _compraList;
        public frmCompra()
        {
            InitializeComponent();
        }
        private void LoadModal(string title)
        {
            var f = new frmCompraModal();
            f.Title.Text = title;
            Autonomo.Class.Fomulary.ShowModal(f, "", false);
            if (f.StateFormulary)
            {
                LoadData();
            }
        }

        private void LoadData() 
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                _compraList = new List<compraReport>();
                _compraList = uow.compra.GetList(dtDesde.Value, dtHasta.Value)
                    .OrderByDescending(o => o.Fecha).ToList();


                grdData.DataSource = null;
                grdData.Refresh();


                FilterData();
            }
        }

        private void GetDetail(string idCompra, decimal Tasa, decimal montoTotal)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var element = uow.detalleCompra.GetList(idCompra, Tasa).ToList();
                grdDetalle.DataSource = element;
                grdDetalle.Columns[0].Visible = false;
                grdDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }

            int cantidad = 0;

            foreach (DataGridViewRow row in grdDetalle.Rows)
            {
                cantidad += int.Parse(row.Cells[3].Value.ToString());
            }

            lbTotalCantidad.Text = $":  {cantidad} unidades";
            lbTotalBs.Text = $":  Bs. {montoTotal}";
            lbTasa.Text = $":  $ {Tasa}";
            lbTotalDolares.Text = $":  $ {(montoTotal / Tasa).ToString("F2")}";
        }

        private void FilterData()
        {
            if (_compraList != null && _compraList.Count > 0)
            {
                var data = _compraList
                    .Where(o => o.Proveedor.ToLower().Contains(txFilter.Text.ToLower()));

                grdData.DataSource = data.ToList();
                grdData.Columns[0].Visible = false;
                grdData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                int cantidadCompras = 0;
                decimal totalBs = 0m;
                decimal totalDolares = 0m;

                foreach (DataGridViewRow row in grdData.Rows)
                {
                    totalBs += Convert.ToDecimal(row.Cells[4].Value, new CultureInfo("en-US"));
                    totalDolares += Convert.ToDecimal(row.Cells[4].Value, new CultureInfo("en-US"))
                        / Convert.ToDecimal(row.Cells[3].Value, new CultureInfo("en-US"));
                }

                cantidadCompras = grdData.RowCount;

                DescriptionData.Text = $"Cantidad de compras encontradas: {cantidadCompras}  | Total en Bs. : Bs. {totalBs}  | Total en $ : $ {totalDolares.ToString("F2")}";
            }
            else
            {
                DescriptionData.Text = "Cantidad de compras encontradas: 0  | Total en Bs. : Bs. 0.00  | Total en $ : $ 0.00";

            }
        }
        public void onLoad()
        {
            dtDesde.Value = Autonomo.Class.Obtaining.GetFirstDayMonth();
            dtHasta.Value = DateTime.Now;
            ThemeStyle(Theme.White);
            LoadData();
        }
        private void DeleteCompra()
        {
            DialogResult respuesta = MessageBox.Show("¿Está seguro que desea eliminar la compra?", "¡Advertencia!", MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.Yes)
            {
                if (grdData.SelectedRows.Count > 0)
                {
                    string idCompra = grdData.SelectedRows[0].Cells[0].Value.ToString();

                    using (UnitOfWork uow = new UnitOfWork())
                    {
                        try
                        {
                            int response;

                            foreach (DataGridViewRow row in grdDetalle.Rows)
                            {
                                string idDetalle = row.Cells[0].Value.ToString();
                                string codigo = row.Cells[1].Value.ToString();
                                int cantidad = Convert.ToInt32(row.Cells[3].Value);

                                uow.productos.SubirBajarStock(codigo, cantidad, true);
                                uow.compra.DeleteDetalle(idDetalle);
                            }

                            response = uow.compra.DeleteCompra(idCompra);

                            if (response > 0)
                            {
                                Mensaje.MessageBox(Enumerables.Mensajeria.Succesful, "Se elimino correctamente la compra.");
                                LoadData();
                            }
                            else
                            {
                                Mensaje.MessageBox(Enumerables.Mensajeria.Warning, "No se pudo eliminar la compra.");
                            }
                        }
                        catch (Exception ex)
                        {
                            Mensaje.MessageBox(Enumerables.Mensajeria.Error, ex);
                        }

                    }
                }
            }
        }
        private void frmCompra_Load(object sender, EventArgs e)
        {
            onLoad();
        }

        private void grdData_SelectionChanged(object sender, EventArgs e)
        {
            if (grdData.SelectedRows.Count > 0)
            {
                string _idCompra = grdData.SelectedRows[0].Cells["id"].Value.ToString();
                decimal _Tasa = Convert.ToDecimal(grdData.SelectedRows[0].Cells["Tasa"].Value.ToString());
                decimal _montoTotal = Convert.ToDecimal(grdData.SelectedRows[0].Cells["MontoTotal"].Value.ToString());

                GetDetail(_idCompra, _Tasa, _montoTotal);
            }
            else
            {
                grdDetalle.DataSource = null;
                grdDetalle.Refresh();

                lbTotalCantidad.Text = ":  0 unidades";
                lbTotalBs.Text = ":  Bs. 0.00";
                lbTasa.Text = ":  $ 0.00";
                lbTotalDolares.Text = ":  $ 0.00";
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LoadModal("Generar Nueva Compra");
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txFilter_TextBoxChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (grdData.Rows.Count > 0)
            {
                DataTable data = Tools.Models.DataGridHelper.GetDataTable(grdData);
                data.Columns.RemoveAt(0);

                string fecha = DateTime.Now.ToString("dd-MM-yyyy");

                Tools.Models.DataGridHelper.ExportToExcel(data, $"Compras_{fecha}");
            }
            else
            {
                Mensaje.MessageBox(Enumerables.Mensajeria.Error, "No hay datos para exportar.");
            }
        }

        private void btnCommand1_Click(object sender, EventArgs e)
        {
            if (grdDetalle.Rows.Count == 1)
            {
                DeleteCompra();
                return;
            }
            DialogResult respuesta = MessageBox.Show("¿Está seguro que desea eliminar el producto?", "¡Advertencia!", MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.Yes)
            {
                if (grdDetalle.SelectedRows.Count > 0)
                {
                    string idDetalle = grdDetalle.SelectedRows[0].Cells[0].Value.ToString();
                    string codigo = grdDetalle.SelectedRows[0].Cells[1].Value.ToString();
                    int cantidad = Convert.ToInt32(grdDetalle.SelectedRows[0].Cells[3].Value);

                    using (UnitOfWork uow = new UnitOfWork())
                    {
                        try
                        {
                            int response;

                            response = uow.productos.SubirBajarStock(codigo, cantidad, true);

                            response = uow.compra.DeleteDetalle(idDetalle);

                            if (response > 0)
                            {
                                Mensaje.MessageBox(Enumerables.Mensajeria.Succesful, "Se elimino correctamente el producto.");
                                LoadData();
                            }
                            else
                            {
                                Mensaje.MessageBox(Enumerables.Mensajeria.Warning, "No se pudo eliminar el producto.");
                            }
                        }
                        catch (Exception ex)
                        {
                            Mensaje.MessageBox(Enumerables.Mensajeria.Error, ex);
                        }

                    }
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DeleteCompra();
        }
    }
}
