using MampoteSystem.Datos;
using MampoteSystem.Entidad.Pagos;
using MampoteSystem.Entidad.Pagos.Report;
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
    public partial class FrmResumenPagos : Autonomo.CustomTemplate.RegistryDouble
    {
        List<pagoReport> _pagosList;
        public FrmResumenPagos()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                _pagosList = new List<pagoReport>();
                _pagosList = uow.pago.GetAll(dtDesde.Value, dtHasta.Value)
                    .OrderByDescending(o => o.Fecha).ToList();


                grdData.DataSource = null;
                grdData.Refresh();


                FilterData();
            }
        }

        private void FilterData()
        {
            if (_pagosList != null && _pagosList.Count > 0)
            {

                var data = _pagosList
                    .Where(o => o.Nota.ToLower().Contains(txFilter.Text.ToLower()) || o.Cliente.ToLower().Contains(txFilter.Text.ToLower()));

                if (radEfecDolares.Checked == true)
                {
                    data = data.Where(o => o.Descripcion.ToLower().Equals("efectivo dolares"));
                }

                if (radPunto.Checked == true)
                {
                    data = data.Where(o => o.Descripcion.ToLower().Equals("punto"));
                }

                if (radPM.Checked == true)
                {
                    data = data.Where(o => o.Descripcion.ToLower().Equals("pago movil"));
                }

                if (radEfectivoBs.Checked == true)
                {
                    data = data.Where(o => o.Descripcion.ToLower().Equals("efectivo bolivares"));
                }

                if (radCruceInv.Checked == true)
                {
                    data = data.Where(o => o.Descripcion.ToLower().Equals("cruce inventario"));
                }

                grdData.DataSource = data.ToList();
                grdData.Columns[7].Visible = false;
                grdData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                if (grdData.Rows.Count > 0)
                {
                    grdData.Rows[0].Selected = true;
                }

                getEstadisticas();
            }
        }

        private void GetDetail()
        {
            txtNota.Clear();

            string moneySimbol = "";

            if(radEfecDolares.Checked == true){
                moneySimbol = "$.";
            }
            else
            {
                moneySimbol = "Bs.";
            }

            if (grdData.SelectedRows.Count > 0)
            {
                string nota = grdData.SelectedRows[0].Cells[7].Value.ToString();

                txtNota.Text = nota;
            }
            else
            {
                txtNota.Clear();
            }
        }

        private void getEstadisticas()
        {
            string moneySymbol = "Bs.";

            if(radEfecDolares.Checked == true)
            {
                moneySymbol = "$.";
            }

            if (grdData.Rows.Count > 0)
            {

                int cantidadPagos = 0;
                decimal total = 0m;
                decimal vueltoBs = 0m;
                decimal vueltoDiv = 0m;
                decimal propina = 0m;

                foreach (DataGridViewRow row in grdData.Rows)
                {
                    total += Convert.ToDecimal(row.Cells[2].Value, new CultureInfo("en-US"));
                    vueltoBs += Convert.ToDecimal(row.Cells[5].Value, new CultureInfo("en-US"));
                    vueltoDiv += Convert.ToDecimal(row.Cells[4].Value, new CultureInfo("en-US"));
                    propina += Convert.ToDecimal(row.Cells[6].Value, new CultureInfo("en-US"));
                }

                cantidadPagos = grdData.RowCount;

                DescriptionData.Text = $"Cantidad de pagos encontrados: {cantidadPagos}  | Total : {moneySymbol} {total.ToString("F2")}  | Vuelto Bolivares : Bs. {vueltoBs.ToString("F2")}  | Vuelto Divisas : $. {vueltoDiv.ToString("F2")}  | Propina : Bs. {propina.ToString("F2")}";
            }
            else
            {
                DescriptionData.Text = $"Cantidad de pagos encontrados: 0  | Total : {moneySymbol} 0.00  | Vuelto Bolivares : Bs. 0.00  | Vuelto Divisas : $. 0.00  | Propina : Bs. 0.00";

            }
        }

        public void onLoad()
        {
            dtDesde.Value = DateTime.Today;
            dtHasta.Value = DateTime.Now;
            ThemeStyle(Theme.White);
            LoadData();
        }

        private void FrmResumenPagos_Load(object sender, EventArgs e)
        {
            onLoad();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txFilter_TextBoxChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void radPunto_CheckedChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void grdData_SelectionChanged(object sender, EventArgs e)
        {
            GetDetail();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (grdData.Rows.Count > 0)
            {
                DataTable data = Tools.Models.DataGridHelper.GetDataTable(grdData);


                string fecha = DateTime.Now.ToString("dd-MM-yyyy");

                Tools.Models.DataGridHelper.ExportToExcel(data, $"Pagos_{fecha}");
            }
            else
            {
                Mensaje.MessageBox(Enumerables.Mensajeria.Error, "No hay datos para exportar.");
            }
        }
    }
}
