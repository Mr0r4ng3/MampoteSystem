using MampoteSystem.Datos;
using MampoteSystem.Entidad.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MampoteSystem.Windows.Modulo.Reporte
{
    public partial class frmReporteProductosVendidos : Autonomo.Object.Registry
    {
        List<productosVendidosReport> productos;
        public frmReporteProductosVendidos()
        {
            InitializeComponent();

            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;
            btnLast7Days.Select();
            LoadData();
        }
        private void DisableCustomDates()
        {
            dtpStartDate.Enabled = false;
            dtpEndDate.Enabled = false;
            btnOkCustomDate.Visible = false;
        }
        private void LoadData()
        {
            productos = null;

            using (UnitOfWork uow = new UnitOfWork())
            {
                productos = new List<productosVendidosReport>();
                productos = uow.productos.GetProductosVendidos(dtpStartDate.Value, dtpEndDate.Value).ToList();
                FilterData();
            }
        }
        private void FilterData()
        {
            grdData.DataSource = null;
            if (productos != null && productos.Count > 0)
            {

                var newList = from o in productos
                              select new
                              {
                                  NumeroFactura = o.NumeroFactura,
                                  Tipo = o.Tipo,
                                  Codigo = o.Codigo,
                                  Nombre = o.Nombre,
                                  Cantidad = o.Cantidad,
                                  Fecha = o.Fecha
                              };

                grdData.DataSource = newList
                    .Where(o => o.Nombre.ToLower().Contains(txFilter.Text.ToLower()) || o.Codigo.ToLower().Contains(txFilter.Text.ToLower()))
                    .OrderBy(o => o.Nombre).ThenBy(o => o.Fecha)
                    .ToList();

                grdData.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);

                int total = 0;
                
                foreach(DataGridViewRow row in grdData.Rows)
                {
                    total += Convert.ToInt32(row.Cells[4].Value.ToString());
                }

                DescriptionData.Text = $"Total de productos: {total}";

            }
            else
            {
                DescriptionData.Text = "Total de productos: 0";
            }
        }
        private void btnToday_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            DisableCustomDates();
        }

        private void btnLast7Days_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            DisableCustomDates();
        }

        private void btnLast30Days_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today.AddDays(-30);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            DisableCustomDates();
        }

        private void btnThisMonth_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            DisableCustomDates();
        }

        private void btnCustomDate_Click(object sender, EventArgs e)
        {
            dtpStartDate.Enabled = true;
            dtpEndDate.Enabled = true;
            btnOkCustomDate.Visible = true;
        }

        private void btnOkCustomDate_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txFilter_TextBoxChanged(object sender, EventArgs e)
        {
            FilterData();
        }
    }
}
