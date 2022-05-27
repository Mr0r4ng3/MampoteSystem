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

        private string NivelAcceso = Configs.GetNivelAcceso();

        public frmAbrirVenta()
        {
            InitializeComponent();
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
                                string Cedula = grdData.SelectedRows[0].Cells["Cedula"].Value.ToString();
                                decimal MontoTotal = Convert.ToDecimal(grdData.SelectedRows[0].Cells["MontoTotal"].Value, new CultureInfo("en-US"));
                                bool Comisioned = false;

                                if (Convert.ToDecimal(grdData.SelectedRows[0].Cells["Comision"].Value, new CultureInfo("en-Us")) > 0)
                                {
                                    Comisioned = true;
                                }

                            f.GetID = _idVenta;
                            f.CedulaModifiyVenta = Cedula;
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

        private void GetDetail(string idVenta, decimal montoTotal, decimal Deuda, decimal Comision, decimal Tasa)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var element = uow.detalleVenta.GetDetalles(idVenta).ToList();
                grdDetalle.DataSource = element;
                grdDetalle.Columns[0].Visible = false;
                grdDetalle.Columns[1].Visible = false;
                grdDetalle.Columns[6].Visible = false;
                grdDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }

            int cantidad = 0;

            foreach (DataGridViewRow row in grdDetalle.Rows)
            {
                cantidad += int.Parse(row.Cells[4].Value.ToString());
            }

            lbTotalCantidad.Text = $":  {cantidad} Unidades";
            lbTotal.Text = $":  Bs. {montoTotal}";
            lbComision.Text = $":  Bs. {Comision}";
            lbDeudaBs.Text = $":  Bs. {Deuda}";
            lbDeudaDolares.Text = $":  $ {(Deuda / Tasa).ToString("F2")}";
        }

        private void FilterData()
        {
            if (_ventaList != null && _ventaList.Count > 0)
            {
                var data = _ventaList
                    .Where(o => o.Cliente.ToLower().Contains(txFilter.Text.ToLower()));

                if(chkOnlyComision.Checked == true)
                {
                    if(radPagada.Checked == true)
                    {
                        data = data.Where(o => o.EstadoComision.ToLower().Equals("pagada"));
                    }
                    
                    if (radSinPagar.Checked == true)
                    {
                        data = data.Where(o => o.EstadoComision.ToLower().Equals("sin pagar"));
                    }
                    if(radOpcionAPago.Checked == true)
                    {
                        data = data.Where(o => o.EstadoComision.ToLower().Equals("sin pagar"));
                        data = data.Where(o => o.Deuda != o.MontoTotal);
                    }
                }

                grdData.DataSource = data.ToList();
                grdData.Columns[0].Visible = false;
                grdData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                if(grdData.Rows.Count > 0)
                {
                    grdData.Rows[0].Selected = true;
                }

                getEstadisticas();
            }
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
                    totalBs += Convert.ToDecimal(row.Cells[6].Value, new CultureInfo("en-US"));
                    totalDeuda += Convert.ToDecimal(row.Cells[7].Value, new CultureInfo("en-US"));
                    totalComision += Convert.ToDecimal(row.Cells[4].Value, new CultureInfo("en-US"));
                }

                cantidadVentas = grdData.RowCount;

                DescriptionData.Text = $"Cantidad de ventas encontradas: {cantidadVentas}  | Total : Bs. {totalBs.ToString("F2")}  | Total Deuda : Bs. {totalDeuda.ToString("F2")}  | Total Comision : Bs. {totalComision.ToString("F2")}";
            }
            else
            {
                DescriptionData.Text = "Cantidad de ventas encontradas: 0  | Total : Bs. 0.00  | Total Deuda : Bs. 0.00  | Total Comision : Bs. 0.00";

            }
        }

        public void onLoad()
        {
            dtDesde.Value = Autonomo.Class.Obtaining.GetFirstDayMonth();
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
                            int response = uow.venta.DeleteVenta(idVenta);

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
                decimal _Tasa = Convert.ToDecimal(frmMenu.GetInstance().TCambio, new CultureInfo("en-US"));
                decimal _montoTotal = Convert.ToDecimal(grdData.SelectedRows[0].Cells["MontoTotal"].Value.ToString());
                decimal _Comision = Convert.ToDecimal(grdData.SelectedRows[0].Cells["Comision"].Value.ToString());
                decimal _Deuda = Convert.ToDecimal(grdData.SelectedRows[0].Cells["Deuda"].Value.ToString());

                lbidVenta.Text = _idVenta;

                GetDetail(_idVenta, _montoTotal, _Deuda, _Comision, _Tasa);

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
                decimal _Total = Convert.ToDecimal(grdData.SelectedRows[0].Cells["Deuda"].Value, new CultureInfo("en-US"));

                var f = new Cerrar.frmCerrarVentaModal();
                f.Title.Text = "Cerrar venta y agregar Pagos";

                f.CargarMontos(_Total, _idVenta);

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
                    using (UnitOfWork uow = new UnitOfWork())
                    {
                        try
                        {
                            int response = uow.venta.DeleteDetalle(idDetalle);

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
    }
}
