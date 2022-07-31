using MampoteSystem.Datos;
using MampoteSystem.Entidad.Report;
using MampoteSystem.Windows.Home;
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

namespace MampoteSystem.Windows.Modulo.Ventas
{
    public partial class frmVenta : Autonomo.CustomTemplate.RegistryDouble
    {
        List<ventaReport> _ventaList;
        private String[] BUSCARPOR = { "Cliente", "Nota" };

        private string NivelAcceso = Configs.GetNivelAcceso();

        public frmVenta()
        {
            InitializeComponent();
            cbBuscarPor.DataSource = BUSCARPOR;
            cbBuscarPor.SelectedIndex = 0;
        }
        private void LoadData()
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                _ventaList = new List<ventaReport>();
                _ventaList = uow.venta.GetList(dtDesde.Value, dtHasta.Value, true)
                    .OrderByDescending(o => o.Fecha).ToList();


                grdData.DataSource = null;
                grdDetalle.DataSource = null;
                grdData.Refresh();


                FilterData();
            }
        }

        private void GetDetail(string idVenta, decimal montoTotal, decimal Deuda, decimal Comision, string Nota)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var element = uow.detalleVenta.GetDetalles(idVenta).ToList();
                grdDetalle.DataSource = element;
                grdDetalle.Columns[0].Visible = false;
                grdDetalle.Columns[2].Visible = false;
                grdDetalle.Columns[7].Visible = false;
                grdDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }

            int cantidad = 0;

            foreach (DataGridViewRow row in grdDetalle.Rows)
            {
                if (row.Cells[2].Value.ToString() == "PROMOCIONES")
                {
                    continue;
                }
                cantidad += int.Parse(row.Cells[5].Value.ToString());
            }

            lbTotalCantidad.Text = $":  {cantidad} Unidades";
            lbTotal.Text = $":  Bs. {montoTotal}";
            lbComision.Text = $":  Bs. {Comision}";
            txNota.Text = Nota;
        }
        private void FilterData()
        {
            if (_ventaList != null && _ventaList.Count > 0)
            {

                if (cbBuscarPor.SelectedIndex == 0)
                {
                    var data = _ventaList
                     .Where(o => o.Cliente.ToLower().Contains(txFilter.Text.ToLower()));

                    if (chkOnlyComision.Checked == true)
                    {
                        if (radPagada.Checked == true)
                        {
                            data = data.Where(o => o.EstadoComision.ToLower().Equals("pagada"));
                        }

                        if (radSinPagar.Checked == true)
                        {
                            data = data.Where(o => o.EstadoComision.ToLower().Equals("sin pagar"));
                        }
                    }

                    grdData.DataSource = data.OrderBy(o => o.NumeroFactura).ToList();
                    grdData.Columns[0].Visible = false;
                    grdData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    if (grdData.Rows.Count > 0)
                    {
                        grdData.Rows[0].Selected = true;
                    }

                }
                else
                {
                    var data = _ventaList
                         .Where(o => o.Nota.ToLower().Contains(txFilter.Text.ToLower()));

                    if (chkOnlyComision.Checked == true)
                    {
                        if (radPagada.Checked == true)
                        {
                            data = data.Where(o => o.EstadoComision.ToLower().Equals("pagada"));
                        }

                        if (radSinPagar.Checked == true)
                        {
                            data = data.Where(o => o.EstadoComision.ToLower().Equals("sin pagar"));
                        }
                    }

                    grdData.DataSource = data.OrderBy(o => o.NumeroFactura).ToList();
                    grdData.Columns[0].Visible = false;
                    grdData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    if (grdData.Rows.Count > 0)
                    {
                        grdData.Rows[0].Selected = true;
                    }

                }
            }
            getEstadisticas();
        }
        private void getEstadisticas()
        {
            if (grdData.Rows.Count > 0)
            {

                int cantidadVentas = 0;
                decimal totalBs = 0m;
                decimal totalDeuda = 0m;
                decimal totalComision = 0m;

                foreach (DataGridViewRow row in grdData.Rows)
                {
                    totalBs += Convert.ToDecimal(row.Cells[8].Value, new CultureInfo("en-US"));
                    totalDeuda += Convert.ToDecimal(row.Cells[9].Value, new CultureInfo("en-US"));
                    totalComision += Convert.ToDecimal(row.Cells[4].Value, new CultureInfo("en-US"));
                }

                cantidadVentas = grdData.RowCount;

                DescriptionData.Text = $"Cantidad de ventas encontradas: {cantidadVentas}  | Total : Bs. {totalBs.ToString("F2")}  | Total Deuda : Bs. {totalDeuda.ToString("F2")}  | Total Comision : Bs. {totalComision.ToString("F2")}";
                return;
            }
           DescriptionData.Text = "Cantidad de ventas encontradas: 0  | Total : Bs. 0.00  | Total Deuda : Bs. 0.00  | Total Comision : Bs. 0.00";
        }

        public void onLoad()
        {
            dtDesde.Value = new DateTime(DateTime.Today.Year, 1, 1);
            dtHasta.Value = DateTime.Now;
            ThemeStyle(Theme.White);
            LoadData();
        }
        private void LoadModal(string title, string _idVenta)
        {
            var form = new frmVerPagos();
            form.Title.Text = title;
            form._idVenta = _idVenta;

            Autonomo.Class.Fomulary.ShowModal(form, "", false);
            if (form.Tag.ToString() == "Get")
            {
                LoadData();
            }
            form.Dispose();

        }


        private void grdData_SelectionChanged(object sender, EventArgs e)
        {
            if (grdData.SelectedRows.Count > 0)
            {
                string _idVenta = grdData.SelectedRows[0].Cells["id"].Value.ToString();
                lbidVenta.Text = _idVenta;
                decimal _montoTotal = Convert.ToDecimal(grdData.SelectedRows[0].Cells["MontoTotal"].Value.ToString());
                decimal _Comision = Convert.ToDecimal(grdData.SelectedRows[0].Cells["Comision"].Value.ToString());
                decimal _Deuda = Convert.ToDecimal(grdData.SelectedRows[0].Cells["Deuda"].Value.ToString());
                string _Nota = grdData.SelectedRows[0].Cells["Nota"].Value.ToString();


                GetDetail(_idVenta, _montoTotal, _Deuda, _Comision, _Nota);

                string _estadoComision = grdData.SelectedRows[0].Cells["EstadoComision"].Value.ToString();

                if (!_estadoComision.Equals("No aplica"))
                {
                    if (_estadoComision == "Sin Pagar")
                    {
                        btnCommand2.Enabled = true;
                        btnCommand2.Text = "Pagar Comision";
                    }
                    else
                    {
                        btnCommand2.Enabled = true;
                        btnCommand2.Text = "Cancelar Pago Comision";
                    }
                }
                else
                {
                    btnCommand2.Enabled = false;
                    btnCommand2.Text = "-----";
                }
            }
            else
            {
                grdDetalle.DataSource = null;
                grdDetalle.Refresh();

                lbidVenta.Text = "No";

                lbTotalCantidad.Text = ":  0 Unidades";
                lbTotal.Text = ":  Bs. 0.00";
                lbComision.Text = ":  $ 0.00";
                btnCommand2.Enabled = false;
                btnCommand2.Text = "-----";
                txNota.Clear();
            }
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txFilter_TextBoxChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void frmVenta_Load(object sender, EventArgs e)
        {
            onLoad();
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            if (lbidVenta.Text != "No")
            {

                LoadModal("Pagos", lbidVenta.Text);
            }
        }

        private void chkOnlyComision_CheckedChanged(object sender, EventArgs e)
        {

            if (chkOnlyComision.Checked == true)
            {
                radPagada.Visible = true;
                radSinPagar.Visible = true;

                if (NivelAcceso == "Administrador")
                {
                    btnCommand2.Visible = true;
                }
            }
            else
            {
                radPagada.Visible = false;
                radSinPagar.Visible = false;

                if (NivelAcceso == "Administrador")
                {
                    btnCommand2.Visible = false;
                }
            }

            FilterData();
        }

        private void radSinPagar_CheckedChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void radPagada_CheckedChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void btnCommand2_Click(object sender, EventArgs e)
        {
            if (grdData.Rows.Count > 0 && grdData.SelectedRows.Count > 0)
            {

                string idVenta = grdData.SelectedRows[0].Cells[0].Value.ToString();

                using (UnitOfWork uow = new UnitOfWork())
                {
                    try
                    {
                        int response;

                        if (btnCommand2.Text == "Pagar Comision")
                        {
                            response = uow.venta.pagarComision(idVenta, false);
                        }
                        else
                        {
                            response = uow.venta.pagarComision(idVenta, true);
                        }

                        if (response > 0)
                        {
                            LoadData();
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }

                }
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (grdData.Rows.Count > 0)
            {
                DataTable data = Tools.Models.DataGridHelper.GetDataTable(grdData);
                data.Columns.RemoveAt(0);

                string fecha = DateTime.Now.ToString("dd-MM-yyyy");

                Tools.Models.DataGridHelper.ExportToExcel(data, $"VentasFacturadas_{fecha}");
            }
            else
            {
                Mensaje.MessageBox(Enumerables.Mensajeria.Error, "No hay datos para exportar.");
            }
        }

        private void cbBuscarPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            if (grdData.SelectedRows.Count > 0)
            {
                string idVenta = grdData.SelectedRows[0].Cells["id"].Value.ToString();

                using (UnitOfWork uow = new UnitOfWork())
                {
                    List<detalleVentaReport> promociones = uow.detalleVenta.GetDetallesReport(idVenta).Where(
                        o => o.Tipo == "PROMOCIONES").ToList();

                    List<detalleVentaReport> items = uow.detalleVenta.GetDetallesReport(idVenta).Where(
                        o => o.Tipo != "PROMOCIONES").ToList();

                    ventaReport venta = uow.venta.GetVentaById(idVenta);
                    Entidad.ventaInforme ventaInforme = new Entidad.ventaInforme();
                    ventaInforme.NumeroFactura = venta.NumeroFactura;
                    ventaInforme.Cliente = venta.Cliente;
                    ventaInforme.Fecha = venta.Fecha.ToShortDateString();
                    ventaInforme.TotalDescuento = venta.TotalDescuento;
                    ventaInforme.Comision = venta.Comision;
                    ventaInforme.MontoTotal = venta.MontoTotal;
                    ventaInforme.Deuda = venta.Deuda;
                    ventaInforme.TotalAbonado = venta.MontoTotal - venta.Deuda;
                    ventaInforme.DeudaDolares = venta.Deuda != 0 ? Decimal.Round(venta.Deuda / venta.Tasa, 2) : venta.Deuda;

                    frmInformeVenta frm = new frmInformeVenta();
                    frm.LoadData(ventaInforme, items, promociones);
                    frm.Show();
                }
            }
        }
    }
}
