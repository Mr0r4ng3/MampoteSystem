namespace MampoteSystem.Windows.Modulo.Ventas
{
    partial class frmInformeVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ventaReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detalleVentaReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detalleVentaReportBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.ventaReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleVentaReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleVentaReportBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // ventaReportBindingSource
            // 
            this.ventaReportBindingSource.DataSource = typeof(MampoteSystem.Entidad.ventaInforme);
            // 
            // detalleVentaReportBindingSource
            // 
            this.detalleVentaReportBindingSource.DataSource = typeof(MampoteSystem.Entidad.Report.detalleVentaReport);
            // 
            // detalleVentaReportBindingSource1
            // 
            this.detalleVentaReportBindingSource1.DataSource = typeof(MampoteSystem.Entidad.Report.detalleVentaReport);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "venta";
            reportDataSource1.Value = this.ventaReportBindingSource;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.detalleVentaReportBindingSource;
            reportDataSource3.Name = "promociones";
            reportDataSource3.Value = this.detalleVentaReportBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MampoteSystem.Windows.Informes.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(789, 539);
            this.reportViewer1.TabIndex = 0;
            // 
            // frmInformeVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 539);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmInformeVenta";
            this.Text = "Orden de Venta";
            this.Load += new System.EventHandler(this.frmInformeVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ventaReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleVentaReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleVentaReportBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ventaReportBindingSource;
        private System.Windows.Forms.BindingSource detalleVentaReportBindingSource;
        private System.Windows.Forms.BindingSource detalleVentaReportBindingSource1;
    }
}