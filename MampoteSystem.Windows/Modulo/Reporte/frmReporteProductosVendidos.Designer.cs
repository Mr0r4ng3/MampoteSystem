namespace MampoteSystem.Windows.Modulo.Reporte
{
    partial class frmReporteProductosVendidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteProductosVendidos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnOkCustomDate = new System.Windows.Forms.Button();
            this.btnCustomDate = new System.Windows.Forms.Button();
            this.btnToday = new System.Windows.Forms.Button();
            this.btnLast7Days = new System.Windows.Forms.Button();
            this.btnLast30Days = new System.Windows.Forms.Button();
            this.btnThisMonth = new System.Windows.Forms.Button();
            this.dtpEndDate = new Autonomo.CustomControls.FlatDateTime();
            this.dtpStartDate = new Autonomo.CustomControls.FlatDateTime();
            this.txFilter = new Autonomo.CustomControls.FlatFindText();
            this.grdData = new Autonomo.CustomControls.CustomGrid();
            this.NumeroFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlContenedor.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            this.pnlBottonControl.SuspendLayout();
            this.pnlTopControl.SuspendLayout();
            this.pnlTopButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Size = new System.Drawing.Size(1104, 523);
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.grdData);
            this.pnlGrid.Location = new System.Drawing.Point(0, 137);
            this.pnlGrid.Size = new System.Drawing.Size(1104, 354);
            // 
            // pnlBottonControl
            // 
            this.pnlBottonControl.Location = new System.Drawing.Point(0, 491);
            this.pnlBottonControl.Size = new System.Drawing.Size(1104, 32);
            // 
            // pnlTopControl
            // 
            this.pnlTopControl.Controls.Add(this.txFilter);
            this.pnlTopControl.Controls.Add(this.btnOkCustomDate);
            this.pnlTopControl.Controls.Add(this.btnCustomDate);
            this.pnlTopControl.Controls.Add(this.btnToday);
            this.pnlTopControl.Controls.Add(this.btnLast7Days);
            this.pnlTopControl.Controls.Add(this.btnLast30Days);
            this.pnlTopControl.Controls.Add(this.btnThisMonth);
            this.pnlTopControl.Controls.Add(this.dtpEndDate);
            this.pnlTopControl.Controls.Add(this.dtpStartDate);
            this.pnlTopControl.Size = new System.Drawing.Size(1104, 137);
            this.pnlTopControl.Controls.SetChildIndex(this.TopLine, 0);
            this.pnlTopControl.Controls.SetChildIndex(this.Title, 0);
            this.pnlTopControl.Controls.SetChildIndex(this.pnlTopButton, 0);
            this.pnlTopControl.Controls.SetChildIndex(this.dtpStartDate, 0);
            this.pnlTopControl.Controls.SetChildIndex(this.dtpEndDate, 0);
            this.pnlTopControl.Controls.SetChildIndex(this.btnThisMonth, 0);
            this.pnlTopControl.Controls.SetChildIndex(this.btnLast30Days, 0);
            this.pnlTopControl.Controls.SetChildIndex(this.btnLast7Days, 0);
            this.pnlTopControl.Controls.SetChildIndex(this.btnToday, 0);
            this.pnlTopControl.Controls.SetChildIndex(this.btnCustomDate, 0);
            this.pnlTopControl.Controls.SetChildIndex(this.btnOkCustomDate, 0);
            this.pnlTopControl.Controls.SetChildIndex(this.txFilter, 0);
            // 
            // pnlTopButton
            // 
            this.pnlTopButton.Location = new System.Drawing.Point(0, 107);
            this.pnlTopButton.Size = new System.Drawing.Size(1104, 28);
            // 
            // BottomLine
            // 
            this.BottomLine.Size = new System.Drawing.Size(1104, 2);
            // 
            // TopLine
            // 
            this.TopLine.Location = new System.Drawing.Point(0, 135);
            this.TopLine.Size = new System.Drawing.Size(1104, 2);
            // 
            // Title
            // 
            this.Title.Size = new System.Drawing.Size(180, 18);
            this.Title.Text = "Productos vendidos";
            // 
            // btnExportar
            // 
            this.btnExportar.FlatAppearance.BorderSize = 0;
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.Visible = false;
            // 
            // btnEditar
            // 
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.Visible = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.Visible = false;
            // 
            // btnCommand3
            // 
            this.btnCommand3.FlatAppearance.BorderSize = 0;
            // 
            // btnCommand2
            // 
            this.btnCommand2.FlatAppearance.BorderSize = 0;
            // 
            // btnCommand1
            // 
            this.btnCommand1.FlatAppearance.BorderSize = 0;
            // 
            // btnOkCustomDate
            // 
            this.btnOkCustomDate.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnOkCustomDate.FlatAppearance.BorderSize = 0;
            this.btnOkCustomDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOkCustomDate.ForeColor = System.Drawing.Color.White;
            this.btnOkCustomDate.Location = new System.Drawing.Point(550, 57);
            this.btnOkCustomDate.Margin = new System.Windows.Forms.Padding(5);
            this.btnOkCustomDate.Name = "btnOkCustomDate";
            this.btnOkCustomDate.Size = new System.Drawing.Size(33, 26);
            this.btnOkCustomDate.TabIndex = 22;
            this.btnOkCustomDate.Text = "Ok";
            this.btnOkCustomDate.UseVisualStyleBackColor = false;
            this.btnOkCustomDate.Visible = false;
            this.btnOkCustomDate.Click += new System.EventHandler(this.btnOkCustomDate_Click);
            // 
            // btnCustomDate
            // 
            this.btnCustomDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCustomDate.FlatAppearance.BorderSize = 0;
            this.btnCustomDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomDate.ForeColor = System.Drawing.Color.White;
            this.btnCustomDate.Location = new System.Drawing.Point(593, 53);
            this.btnCustomDate.Margin = new System.Windows.Forms.Padding(5);
            this.btnCustomDate.Name = "btnCustomDate";
            this.btnCustomDate.Size = new System.Drawing.Size(96, 35);
            this.btnCustomDate.TabIndex = 21;
            this.btnCustomDate.Text = "Personalizada";
            this.btnCustomDate.UseVisualStyleBackColor = false;
            this.btnCustomDate.Click += new System.EventHandler(this.btnCustomDate_Click);
            // 
            // btnToday
            // 
            this.btnToday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnToday.FlatAppearance.BorderSize = 0;
            this.btnToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToday.ForeColor = System.Drawing.Color.White;
            this.btnToday.Location = new System.Drawing.Point(699, 53);
            this.btnToday.Margin = new System.Windows.Forms.Padding(5);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(62, 35);
            this.btnToday.TabIndex = 20;
            this.btnToday.Text = "Hoy";
            this.btnToday.UseVisualStyleBackColor = false;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // btnLast7Days
            // 
            this.btnLast7Days.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLast7Days.FlatAppearance.BorderSize = 0;
            this.btnLast7Days.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast7Days.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast7Days.ForeColor = System.Drawing.Color.White;
            this.btnLast7Days.Location = new System.Drawing.Point(771, 53);
            this.btnLast7Days.Margin = new System.Windows.Forms.Padding(5);
            this.btnLast7Days.Name = "btnLast7Days";
            this.btnLast7Days.Size = new System.Drawing.Size(111, 35);
            this.btnLast7Days.TabIndex = 19;
            this.btnLast7Days.Text = "Ultimos 7 Dias";
            this.btnLast7Days.UseVisualStyleBackColor = false;
            this.btnLast7Days.Click += new System.EventHandler(this.btnLast7Days_Click);
            // 
            // btnLast30Days
            // 
            this.btnLast30Days.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLast30Days.FlatAppearance.BorderSize = 0;
            this.btnLast30Days.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast30Days.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast30Days.ForeColor = System.Drawing.Color.White;
            this.btnLast30Days.Location = new System.Drawing.Point(892, 53);
            this.btnLast30Days.Margin = new System.Windows.Forms.Padding(5);
            this.btnLast30Days.Name = "btnLast30Days";
            this.btnLast30Days.Size = new System.Drawing.Size(110, 35);
            this.btnLast30Days.TabIndex = 18;
            this.btnLast30Days.Text = "Ultimos 30 Dias";
            this.btnLast30Days.UseVisualStyleBackColor = false;
            this.btnLast30Days.Click += new System.EventHandler(this.btnLast30Days_Click);
            // 
            // btnThisMonth
            // 
            this.btnThisMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnThisMonth.FlatAppearance.BorderSize = 0;
            this.btnThisMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThisMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThisMonth.ForeColor = System.Drawing.Color.White;
            this.btnThisMonth.Location = new System.Drawing.Point(1012, 52);
            this.btnThisMonth.Margin = new System.Windows.Forms.Padding(5);
            this.btnThisMonth.Name = "btnThisMonth";
            this.btnThisMonth.Size = new System.Drawing.Size(70, 35);
            this.btnThisMonth.TabIndex = 17;
            this.btnThisMonth.Text = "Este Mes";
            this.btnThisMonth.UseVisualStyleBackColor = false;
            this.btnThisMonth.Click += new System.EventHandler(this.btnThisMonth_Click);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.BackColor = System.Drawing.Color.White;
            this.dtpEndDate.Category = '\0';
            this.dtpEndDate.ColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.dtpEndDate.ColorLine = System.Drawing.Color.Gray;
            this.dtpEndDate.ColorText = System.Drawing.SystemColors.WindowText;
            this.dtpEndDate.ColorTitle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpEndDate.DateSeparatorFormat = '/';
            this.dtpEndDate.DockIcon = System.Windows.Forms.DockStyle.Left;
            this.dtpEndDate.Enabled = false;
            this.dtpEndDate.Error = "";
            this.dtpEndDate.FontText = new System.Drawing.Font("Verdana", 10F);
            this.dtpEndDate.FontTitle = new System.Drawing.Font("Verdana", 9F);
            this.dtpEndDate.Format = Autonomo.CustomControls.HelperControl.FormatDate.Short;
            this.dtpEndDate.ImageIcon = ((System.Drawing.Image)(resources.GetObject("dtpEndDate.ImageIcon")));
            this.dtpEndDate.Info = "";
            this.dtpEndDate.Location = new System.Drawing.Point(404, 43);
            this.dtpEndDate.MaterialStyle = false;
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Placeholder = "";
            this.dtpEndDate.Size = new System.Drawing.Size(122, 58);
            this.dtpEndDate.SizeLine = 2;
            this.dtpEndDate.TabIndex = 16;
            this.dtpEndDate.Text = "26/03/2022";
            this.dtpEndDate.Title = "Fecha Fin";
            this.dtpEndDate.Value = new System.DateTime(2022, 3, 26, 21, 54, 2, 779);
            this.dtpEndDate.VisibleIcon = true;
            this.dtpEndDate.VisibleTitle = true;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.BackColor = System.Drawing.Color.White;
            this.dtpStartDate.Category = '\0';
            this.dtpStartDate.ColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.dtpStartDate.ColorLine = System.Drawing.Color.Gray;
            this.dtpStartDate.ColorText = System.Drawing.SystemColors.WindowText;
            this.dtpStartDate.ColorTitle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpStartDate.DateSeparatorFormat = '/';
            this.dtpStartDate.DockIcon = System.Windows.Forms.DockStyle.Left;
            this.dtpStartDate.Enabled = false;
            this.dtpStartDate.Error = "";
            this.dtpStartDate.FontText = new System.Drawing.Font("Verdana", 10F);
            this.dtpStartDate.FontTitle = new System.Drawing.Font("Verdana", 9F);
            this.dtpStartDate.Format = Autonomo.CustomControls.HelperControl.FormatDate.Short;
            this.dtpStartDate.ImageIcon = ((System.Drawing.Image)(resources.GetObject("dtpStartDate.ImageIcon")));
            this.dtpStartDate.Info = "";
            this.dtpStartDate.Location = new System.Drawing.Point(257, 43);
            this.dtpStartDate.MaterialStyle = false;
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Placeholder = "";
            this.dtpStartDate.Size = new System.Drawing.Size(141, 58);
            this.dtpStartDate.SizeLine = 2;
            this.dtpStartDate.TabIndex = 15;
            this.dtpStartDate.Text = "26/03/2022";
            this.dtpStartDate.Title = "Fecha Inicio";
            this.dtpStartDate.Value = new System.DateTime(2022, 3, 26, 21, 54, 2, 779);
            this.dtpStartDate.VisibleIcon = true;
            this.dtpStartDate.VisibleTitle = true;
            // 
            // txFilter
            // 
            this.txFilter.AlignText = System.Windows.Forms.HorizontalAlignment.Left;
            this.txFilter.BackColor = System.Drawing.Color.White;
            this.txFilter.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txFilter.ColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.txFilter.ColorLine = System.Drawing.Color.Gray;
            this.txFilter.ColorText = System.Drawing.SystemColors.WindowText;
            this.txFilter.ColorTitle = System.Drawing.Color.Gray;
            this.txFilter.DockIcon = System.Windows.Forms.DockStyle.Right;
            this.txFilter.FontText = new System.Drawing.Font("Verdana", 10F);
            this.txFilter.FontTitle = new System.Drawing.Font("Verdana", 9F);
            this.txFilter.ImageIcon = ((System.Drawing.Image)(resources.GetObject("txFilter.ImageIcon")));
            this.txFilter.Location = new System.Drawing.Point(27, 43);
            this.txFilter.MaterialStyle = true;
            this.txFilter.MaxLength = 32767;
            this.txFilter.MultiLineText = false;
            this.txFilter.Name = "txFilter";
            this.txFilter.ObjectArray = null;
            this.txFilter.PasswordChar = '\0';
            this.txFilter.Placeholder = "Buscar por nombre o codigo";
            this.txFilter.PlaceHolderHeight = 18;
            this.txFilter.ReadOnly = false;
            this.txFilter.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txFilter.Size = new System.Drawing.Size(223, 44);
            this.txFilter.SizeLine = 2;
            this.txFilter.StringArray = null;
            this.txFilter.TabIndex = 23;
            this.txFilter.TextId = "";
            this.txFilter.Title = "Buscar por nombre o codigo";
            this.txFilter.VisibleIcon = true;
            this.txFilter.VisibleTitle = false;
            this.txFilter.TextBoxChanged += new System.EventHandler(this.txFilter_TextBoxChanged);
            // 
            // grdData
            // 
            this.grdData.AllowUserToAddRows = false;
            this.grdData.AllowUserToDeleteRows = false;
            this.grdData.AllowUserToResizeRows = false;
            this.grdData.BackgroundColor = System.Drawing.Color.White;
            this.grdData.BodyFont = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdData.BodyForeColor = System.Drawing.SystemColors.ControlText;
            this.grdData.BodySelectColor = System.Drawing.SystemColors.Highlight;
            this.grdData.BodySelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.grdData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdData.CellStyleBackColor = System.Drawing.SystemColors.Window;
            this.grdData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroFactura,
            this.Tipo,
            this.Codigo,
            this.Nombre,
            this.Cantidad,
            this.Fecha});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdData.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdData.EnableBottomDown = false;
            this.grdData.EnableBottomLeft = false;
            this.grdData.EnableBottomRight = false;
            this.grdData.EnableBottomUp = false;
            this.grdData.EnableHeadersVisualStyles = false;
            this.grdData.HeaderColor = System.Drawing.SystemColors.Control;
            this.grdData.HeaderFont = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdData.HeaderForeColor = System.Drawing.SystemColors.WindowText;
            this.grdData.Location = new System.Drawing.Point(0, 0);
            this.grdData.MultiSelect = false;
            this.grdData.Name = "grdData";
            this.grdData.ReadOnly = true;
            this.grdData.RowHeadersVisible = false;
            this.grdData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.grdData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdData.Size = new System.Drawing.Size(1104, 354);
            this.grdData.TabIndex = 2;
            // 
            // NumeroFactura
            // 
            this.NumeroFactura.DataPropertyName = "NumeroFactura";
            this.NumeroFactura.HeaderText = "Numero de Factura";
            this.NumeroFactura.Name = "NumeroFactura";
            this.NumeroFactura.ReadOnly = true;
            this.NumeroFactura.Width = 200;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "Tipo";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // frmReporteProductosVendidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 523);
            this.Name = "frmReporteProductosVendidos";
            this.Text = "frmReporteProductosVendidos";
            this.pnlContenedor.ResumeLayout(false);
            this.pnlGrid.ResumeLayout(false);
            this.pnlBottonControl.ResumeLayout(false);
            this.pnlBottonControl.PerformLayout();
            this.pnlTopControl.ResumeLayout(false);
            this.pnlTopControl.PerformLayout();
            this.pnlTopButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOkCustomDate;
        private System.Windows.Forms.Button btnCustomDate;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.Button btnLast7Days;
        private System.Windows.Forms.Button btnLast30Days;
        private System.Windows.Forms.Button btnThisMonth;
        private Autonomo.CustomControls.FlatDateTime dtpEndDate;
        private Autonomo.CustomControls.FlatDateTime dtpStartDate;
        private Autonomo.CustomControls.FlatFindText txFilter;
        private Autonomo.CustomControls.CustomGrid grdData;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
    }
}