using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MampoteSystem.Entidad.Report;

namespace MampoteSystem.Windows.Modulo.Ventas
{
    public partial class frmInformeVenta : Form
    {
        public frmInformeVenta()
        {
            InitializeComponent();
        }

        private void frmInformeVenta_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        public void LoadData(ventaReport venta, List<detalleVentaReport> items, List<detalleVentaReport> promociones)
        {
            ventaReportBindingSource.DataSource = venta;
            detalleVentaReportBindingSource.DataSource = items;
            detalleVentaReportBindingSource1.DataSource = promociones;

        }
    }
}
