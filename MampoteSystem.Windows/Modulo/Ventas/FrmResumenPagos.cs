using MampoteSystem.Datos;
using MampoteSystem.Entidad.Pagos;
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
        List<pago> _pagosList;

        public FrmResumenPagos()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                _pagosList = new List<pago>();
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
                    .Where(o => o.Nota.ToLower().Contains(txFilter.Text.ToLower()));

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
                grdData.Columns[0].Visible = false;
                grdData.Columns[1].Visible = false;
                grdData.Columns[2].Visible = false;
                grdData.Columns[6].Visible = false;
                grdData.Columns[7].Visible = false;
                grdData.Columns[8].Visible = false;
                grdData.Columns[9].Visible = false;
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
                lblTasa.Visible = false;

                moneySimbol = "$.";
            }
            else
            {
                lblTasa.Visible = true;
                moneySimbol = "Bs.";

            }

            if(radEfecDolares.Checked == true || radEfectivoBs.Checked == true)
            {
                lblVuelto.Visible = true;
            }
            else
            {
                lblVuelto.Visible = false;
            }

            if (grdData.SelectedRows.Count > 0)
            {
                string nota = grdData.SelectedRows[0].Cells[8].Value.ToString();
                decimal vuelto = Convert.ToDecimal(grdData.SelectedRows[0].Cells[7].Value, new CultureInfo("en-Us"));
                decimal tasa = Convert.ToDecimal(grdData.SelectedRows[0].Cells[6].Value, new CultureInfo("en-Us"));

                txtNota.Text = nota;
                lblTasa.Text = $"Tasa  :  Bs. {tasa.ToString("F2")}";
                lblVuelto.Text = $"Vuelto  :  {moneySimbol} {vuelto.ToString("F2")}";

            }
            else
            {
                txtNota.Clear();
                lblTasa.Visible = false;
                lblVuelto.Visible = false;
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

                foreach (DataGridViewRow row in grdData.Rows)
                {
                    total += Convert.ToDecimal(row.Cells[5].Value, new CultureInfo("en-US"));
                }

                cantidadPagos = grdData.RowCount;

                DescriptionData.Text = $"Cantidad de ventas encontradas: {cantidadPagos}  | Total : {moneySymbol} {total.ToString("F2")}";
            }
            else
            {
                DescriptionData.Text = $"Cantidad de ventas encontradas: 0  | Total : {moneySymbol} 0.00";

            }
        }

        public void onLoad()
        {
            dtDesde.Value = Autonomo.Class.Obtaining.GetFirstDayMonth();
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
                data.Columns.RemoveAt(9);
                data.Columns.RemoveAt(8);
                data.Columns.RemoveAt(7);
                data.Columns.RemoveAt(6);
                data.Columns.RemoveAt(2);
                data.Columns.RemoveAt(1);
                data.Columns.RemoveAt(0);


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
