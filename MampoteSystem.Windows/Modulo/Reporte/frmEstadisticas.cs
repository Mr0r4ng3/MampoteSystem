using MampoteSystem.Datos.Reporte;
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
    public partial class frmEstadisticas : Autonomo.CustomTemplate.ModalOnPanel
    {
        private Estadisticas model;

        public frmEstadisticas()
        {
            InitializeComponent();
            
            //Default - Last 7 days
            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;
            btnLast7Days.Select();

            model = new Estadisticas();
            LoadData();
        }
        private void LoadData()
        {
            var refreshData = model.LoadData(dtpStartDate.Value, dtpEndDate.Value);
            if (refreshData == true)
            {
                lbPagoDivisa.Text = $"$. {model.PagoDivisas}";
                lbVuelto.Text = $"$. {model.VueltoDivisas}";
                lbPagosPunto.Text = $"Bs. {model.PagoPunto}";
                lbPagosEfectivo.Text = $"Bs. {model.PagoEfectivo}";
                lbPagosPM.Text = $"Bs. {model.PagoPM}";

                lblNumOrders.Text = model.NumOrders.ToString();
                lbTotalGanancias.Text = "Bs. " + model.TotalRevenue.ToString();

                lbTotalCliente.Text = model.NumCustomers.ToString();
                lbTotalProveedores.Text = model.NumSuppliers.ToString();
                LbTotalProductos.Text = model.NumProducts.ToString();
                lbTotalComida.Text = model.NumComida.ToString();

                chartGrossRevenue.DataSource = model.GrossRevenueList;
                chartGrossRevenue.Series[0].XValueMember = "Date";
                chartGrossRevenue.Series[0].YValueMembers = "TotalAmount";
                chartGrossRevenue.DataBind();

                chartTopProducts.DataSource = model.TopProductsList;
                chartTopProducts.Series[0].XValueMember = "Key";
                chartTopProducts.Series[0].YValueMembers = "Value";
                chartTopProducts.DataBind();

                dgvUnderstock.DataSource = model.UnderstockList;
                dgvUnderstock.Columns[0].HeaderText = "Producto";
                dgvUnderstock.Columns[1].HeaderText = "Unidades";
                Console.WriteLine("Loaded view :)");
            }
            else Console.WriteLine("View not loaded, same query");
        }

        private void DisableCustomDates()
        {
            dtpStartDate.Enabled = false;
            dtpEndDate.Enabled = false;
            btnOkCustomDate.Visible = false;
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
    }
}
