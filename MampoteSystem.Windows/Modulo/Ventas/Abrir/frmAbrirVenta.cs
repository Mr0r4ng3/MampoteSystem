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
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Autonomo.CustomControls.HelperControl;

namespace MampoteSystem.Windows.Modulo.Ventas.Abrir
{
    public partial class frmAbrirVenta : Autonomo.CustomTemplate.RegistryDouble
    {
        List<ventaReport> _ventaList;
        private String[] BUSCARPOR = { "Cliente", "Nota" };

        private string NivelAcceso = Configs.GetNivelAcceso();

        public frmAbrirVenta()
        {
            InitializeComponent();

            cbBuscarPor.DataSource = BUSCARPOR;
            cbBuscarPor.SelectedIndex = 0;
        }
        private void LoadModal(string title, bool isNuevo)
        {
            try
            {

                using(var f = new frmAbrirVentaModal())
                {

                    f.Title.Text = title;
            
                    if (isNuevo) {
                        f.NuevaVenta = true;
                    }
                    else
                    {
                        f.NuevaVenta = false;
                        if (grdData.SelectedRows.Count > 0)
                        {
                                string _idVenta = grdData.SelectedRows[0].Cells["id"].Value.ToString();
                                string ClienteName = grdData.SelectedRows[0].Cells["Cliente"].Value.ToString();
                                string Nota = grdData.SelectedRows[0].Cells["Nota"].Value.ToString();
                                decimal MontoTotal = Convert.ToDecimal(grdData.SelectedRows[0].Cells["MontoTotal"].Value, new CultureInfo("en-US"));
                                bool Comisioned = false;

                                if (Convert.ToDecimal(grdData.SelectedRows[0].Cells["Comision"].Value, new CultureInfo("en-Us")) > 0)
                                {
                                    Comisioned = true;
                                }

                            f.GetID = _idVenta;
                            f.ClienteNameInEdit = ClienteName;
                            f.Nota = Nota;
                            f.TotalOld = Convert.ToDecimal(MontoTotal, new CultureInfo("en-US"));
                            f.Comisionada = Comisioned;
                            f.DetalleVenta = grdDetalle.DataSource;
                        }
                        else
                        {
                            Mensaje.MessageBox(Enumerables.Mensajeria.Warning, "Debe seleccionar una venta primero.");
                            return;
                        }
                    }

                    Autonomo.Class.Fomulary.ShowModal(f, "", false);
                    if (f.StateFormulary)
                    {
                        LoadData();
                    }
                }
            }
            catch(Exception ex)
            {
                Mensaje.MessageBox(Enumerables.Mensajeria.Warning, "Debe seleccionar una venta primero.");
            }
        }

        private void LoadData()
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                _ventaList = new List<ventaReport>();
                _ventaList = uow.venta.GetList(dtDesde.Value, dtHasta.Value, false)
                    .OrderByDescending(o => o.Fecha).ToList();


                grdData.DataSource = null;
                grdDetalle.DataSource = null;
                grdData.Refresh();


                FilterData();
            }
        }

        private void GetDetail(string idVenta, decimal montoTotal, decimal Deuda, decimal Comision, decimal Tasa, string Nota)
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
            lbDeudaBs.Text = $":  Bs. {Deuda}";
            lbDeudaDolares.Text = $":  $ {(Deuda / Tasa).ToString("F2")}";
            txNota.Text = Nota;
        }

        private void FilterData()
        {
            if (_ventaList != null && _ventaList.Count > 0)
            {

                if(cbBuscarPor.SelectedIndex == 0)
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
                        if (radOpcionAPago.Checked == true)
                        {
                            data = data.Where(o => o.EstadoComision.ToLower().Equals("sin pagar"));
                            data = data.Where(o => o.Deuda != o.MontoTotal);
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
                   var  data = _ventaList
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
                        if (radOpcionAPago.Checked == true)
                        {
                            data = data.Where(o => o.EstadoComision.ToLower().Equals("sin pagar"));
                            data = data.Where(o => o.Deuda != o.MontoTotal);
                        }
                    }

                    grdData.DataSource = data.ToList();
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

        private void LoadPagos(string title, string _idVenta)
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

        private void DeleteVenta()
        {
            DialogResult respuesta = MessageBox.Show("¿Está seguro que desea eliminar la venta?", "¡Advertencia!", MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.Yes)
            {
                if (grdData.SelectedRows.Count > 0)
                {
                    string idVenta = grdData.SelectedRows[0].Cells[0].Value.ToString();

                    using (UnitOfWork uow = new UnitOfWork())
                    {
                        try
                        {
                            int response;

                            foreach(DataGridViewRow row in grdDetalle.Rows)
                            {
                                string idDetalle = row.Cells[0].Value.ToString();
                                string codigo = row.Cells[3].Value.ToString();
                                string tipo = row.Cells[2].Value.ToString();
                                int cantidad = Convert.ToInt32(row.Cells[5].Value);

                                if(tipo == "PRODUCTO")
                                {
                                    uow.productos.SubirBajarStock(codigo, cantidad, false);
                                }
                                uow.venta.DeleteDetalle(idDetalle);
                            }

                            response = uow.venta.DeleteVenta(idVenta);

                            if (response > 0)
                            {
                                Mensaje.MessageBox(Enumerables.Mensajeria.Succesful, "Se elimino correctamente la venta.");
                                LoadData();
                            }
                            else
                            {
                                Mensaje.MessageBox(Enumerables.Mensajeria.Warning, "No se pudo eliminar la venta.");
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
        private void frmAbrirVenta_Load(object sender, EventArgs e)
        {
            onLoad();

            if(Configs.GetNivelAcceso() == "Administrador")
            {
                btnEliminar.Visible = true;
            }
        }

        private void grdData_SelectionChanged(object sender, EventArgs e)
        {
            if (grdData.SelectedRows.Count > 0)
            {
                string _idVenta = grdData.SelectedRows[0].Cells["id"].Value.ToString();
                string _Nota = grdData.SelectedRows[0].Cells["Nota"].Value.ToString();
                decimal _Tasa = Convert.ToDecimal(grdData.SelectedRows[0].Cells["Tasa"].Value, new CultureInfo("en-US"));
                decimal _montoTotal = Convert.ToDecimal(grdData.SelectedRows[0].Cells["MontoTotal"].Value.ToString());
                decimal _Comision = Convert.ToDecimal(grdData.SelectedRows[0].Cells["Comision"].Value.ToString());
                decimal _Deuda = Convert.ToDecimal(grdData.SelectedRows[0].Cells["Deuda"].Value.ToString());

                lbidVenta.Text = _idVenta;

                GetDetail(_idVenta, _montoTotal, _Deuda, _Comision, _Tasa, _Nota);

                string _estadoComision = grdData.SelectedRows[0].Cells["EstadoComision"].Value.ToString();

                if(!_estadoComision.Equals("No aplica"))
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

                lbTotalCantidad.Text = ":  0 Unidades";
                lbTotal.Text = ":  Bs. 0.00";
                lbComision.Text = ":  $ 0.00";
                lbDeudaDolares.Text = ":  $ 0.00";
                lbDeudaBs.Text = ":  Bs. 0.00";
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LoadModal("Generar Nueva Venta",true);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
             LoadModal("Agregar detalles a una venta", false);
        }

        private void btnCommand1_Click(object sender, EventArgs e)
        {
            if (grdData.SelectedRows.Count > 0)
            {
                string _idVenta = grdData.SelectedRows[0].Cells["id"].Value.ToString();
                decimal _Tasa = Convert.ToDecimal(grdData.SelectedRows[0].Cells["Tasa"].Value, new CultureInfo("en-US"));
                decimal _Total = Convert.ToDecimal(grdData.SelectedRows[0].Cells["Deuda"].Value, new CultureInfo("en-US"));
                decimal _Comision = Convert.ToDecimal(grdData.SelectedRows[0].Cells["Comision"].Value, new CultureInfo("en-US"));

                var f = new Cerrar.frmCerrarVentaModal();
                f.Title.Text = "Cerrar venta y agregar Pagos";

                f.CargarMontos(_Total, _idVenta, _Comision, _Tasa);

                Autonomo.Class.Fomulary.ShowModal(f, "", false);

                if (f.StateFormulary)
                {
                    LoadData();
                }

            }
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            if (lbidVenta.Text != "No")
            {

                LoadPagos("Pagos", lbidVenta.Text);
            }
        }

        private void chkOnlyComision_CheckedChanged(object sender, EventArgs e)
        {

            if(chkOnlyComision.Checked == true)
            {
                radPagada.Visible = true;
                radSinPagar.Visible = true;
                radOpcionAPago.Visible = true;

                if(NivelAcceso == "Administrador")
                {
                    btnCommand2.Visible = true;
                }
            }
            else
            {
                radPagada.Visible = false;
                radSinPagar.Visible = false;
                radOpcionAPago.Visible = false;

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
                    catch(Exception ex)
                    {
                        Mensaje.MessageBox(Enumerables.Mensajeria.Error, ex);
                    }

                }
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if(grdData.Rows.Count > 0)
            {
                DataTable data = Tools.Models.DataGridHelper.GetDataTable(grdData);
                data.Columns.RemoveAt(0);

                string fecha = DateTime.Now.ToString("dd-MM-yyyy");

                Tools.Models.DataGridHelper.ExportToExcel(data, $"OrdenesVentas_{fecha}");
            }
            else
            {
                Mensaje.MessageBox(Enumerables.Mensajeria.Error, "No hay datos para exportar.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DeleteVenta();
        }

        private void btnCommand3_Click(object sender, EventArgs e)
        {

            if (grdDetalle.Rows.Count == 1)
            {
                DeleteVenta();
                return;
            }
            DialogResult respuesta = MessageBox.Show("¿Está seguro que desea eliminar el producto?", "¡Advertencia!", MessageBoxButtons.YesNo);

            if (respuesta == DialogResult.Yes)
            {
                if (grdDetalle.SelectedRows.Count > 0)
                {
                    string idDetalle = grdDetalle.SelectedRows[0].Cells[0].Value.ToString();
                    string codigo = grdDetalle.SelectedRows[0].Cells[3].Value.ToString();
                    string tipo = grdDetalle.SelectedRows[0].Cells[2].Value.ToString();
                    int cantidad = Convert.ToInt32(grdDetalle.SelectedRows[0].Cells[5].Value);

                    using (UnitOfWork uow = new UnitOfWork())
                    {
                        try
                        {
                            int response;

                            if(tipo == "PRODUCTO")
                            {
                                response = uow.productos.SubirBajarStock(codigo, cantidad, false);
                            }

                            response = uow.venta.DeleteDetalle(idDetalle);

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
                    List<detalleVentaReport> promociones = uow.detalleVenta.GetDetalles(idVenta).Where(
                        o => o.Tipo == "PROMOCIONES").ToList();

                    List<detalleVentaReport> items = uow.detalleVenta.GetDetalles(idVenta).Where(
                        o => o.Tipo != "PROMOCIONES").ToList();

                    ventaReport venta = uow.venta.GetVentaById(idVenta);

                    frmInformeVenta frm = new frmInformeVenta();
                    Entidad.ventaInforme ventaInforme = new Entidad.ventaInforme();
                    ventaInforme.NumeroFactura = venta.NumeroFactura;
                    ventaInforme.Cliente = venta.Cliente;
                    ventaInforme.Fecha = venta.Fecha.ToShortDateString();
                    ventaInforme.TotalDescuento = venta.TotalDescuento;
                    ventaInforme.Comision = venta.Comision;
                    ventaInforme.MontoTotal = venta.MontoTotal;
                    ventaInforme.Deuda = venta.Deuda;
                    ventaInforme.TotalAbonado = venta.MontoTotal - venta.Deuda;

                    frm.LoadData(ventaInforme, items, promociones);
                    frm.Show();
                }
            }
        }
    }
}
