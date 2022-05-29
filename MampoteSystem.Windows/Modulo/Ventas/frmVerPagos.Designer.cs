namespace MampoteSystem.Windows.Modulo.Ventas
{
    partial class frmVerPagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerPagos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlAgregarPagos = new System.Windows.Forms.Panel();
            this.txTipoPago = new Autonomo.CustomControls.FlatTextBox();
            this.txNota = new Autonomo.CustomControls.FlatTextBox();
            this.txTasa = new Autonomo.CustomControls.FlatTextBox();
            this.txMontoPago = new Autonomo.CustomControls.FlatTextBox();
            this.pnlPagosAgregados = new System.Windows.Forms.Panel();
            this.grdData = new Autonomo.CustomControls.CustomGrid();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vuelto_Bolivares = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vuelto_Divisas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Propina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contenedor.SuspendLayout();
            this.Body.SuspendLayout();
            this.Footer.SuspendLayout();
            this.Header.SuspendLayout();
            this.pnlAgregarPagos.SuspendLayout();
            this.pnlPagosAgregados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.SuspendLayout();
            // 
            // Contenedor
            // 
            this.Contenedor.Size = new System.Drawing.Size(1002, 598);
            // 
            // Body
            // 
            this.Body.Controls.Add(this.pnlPagosAgregados);
            this.Body.Controls.Add(this.pnlAgregarPagos);
            this.Body.Size = new System.Drawing.Size(1002, 505);
            // 
            // Footer
            // 
            this.Footer.Location = new System.Drawing.Point(0, 546);
            this.Footer.Size = new System.Drawing.Size(1002, 52);
            this.Footer.Visible = false;
            // 
            // Header
            // 
            this.Header.Size = new System.Drawing.Size(1002, 41);
            // 
            // Title
            // 
            this.Title.Size = new System.Drawing.Size(961, 41);
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 0;
            // 
            // pnlAgregarPagos
            // 
            this.pnlAgregarPagos.Controls.Add(this.txTipoPago);
            this.pnlAgregarPagos.Controls.Add(this.txNota);
            this.pnlAgregarPagos.Controls.Add(this.txTasa);
            this.pnlAgregarPagos.Controls.Add(this.txMontoPago);
            this.pnlAgregarPagos.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAgregarPagos.Location = new System.Drawing.Point(0, 0);
            this.pnlAgregarPagos.Name = "pnlAgregarPagos";
            this.pnlAgregarPagos.Size = new System.Drawing.Size(400, 505);
            this.pnlAgregarPagos.TabIndex = 4;
            // 
            // txTipoPago
            // 
            this.txTipoPago.AlignText = System.Windows.Forms.HorizontalAlignment.Left;
            this.txTipoPago.BackColor = System.Drawing.Color.White;
            this.txTipoPago.Category = '\0';
            this.txTipoPago.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txTipoPago.ColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.txTipoPago.ColorLine = System.Drawing.Color.Gray;
            this.txTipoPago.ColorText = System.Drawing.SystemColors.WindowText;
            this.txTipoPago.ColorTitle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txTipoPago.DockIcon = System.Windows.Forms.DockStyle.Left;
            this.txTipoPago.Error = "";
            this.txTipoPago.FontText = new System.Drawing.Font("Verdana", 10F);
            this.txTipoPago.FontTitle = new System.Drawing.Font("Verdana", 9F);
            this.txTipoPago.FormatLogin = false;
            this.txTipoPago.ImageIcon = ((System.Drawing.Image)(resources.GetObject("txTipoPago.ImageIcon")));
            this.txTipoPago.Info = "";
            this.txTipoPago.Location = new System.Drawing.Point(12, 19);
            this.txTipoPago.MaterialStyle = false;
            this.txTipoPago.MaxLength = 32767;
            this.txTipoPago.MultiLineText = false;
            this.txTipoPago.Name = "txTipoPago";
            this.txTipoPago.PasswordChar = '\0';
            this.txTipoPago.Placeholder = "";
            this.txTipoPago.ReadOnly = true;
            this.txTipoPago.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txTipoPago.Size = new System.Drawing.Size(278, 58);
            this.txTipoPago.SizeLine = 2;
            this.txTipoPago.TabIndex = 4;
            this.txTipoPago.Title = "Tipo de Pago";
            this.txTipoPago.VisibleIcon = false;
            this.txTipoPago.VisibleTitle = true;
            // 
            // txNota
            // 
            this.txNota.AlignText = System.Windows.Forms.HorizontalAlignment.Left;
            this.txNota.BackColor = System.Drawing.Color.White;
            this.txNota.Category = '\0';
            this.txNota.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txNota.ColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.txNota.ColorLine = System.Drawing.Color.Gray;
            this.txNota.ColorText = System.Drawing.SystemColors.WindowText;
            this.txNota.ColorTitle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txNota.DockIcon = System.Windows.Forms.DockStyle.Left;
            this.txNota.Error = "";
            this.txNota.FontText = new System.Drawing.Font("Verdana", 10F);
            this.txNota.FontTitle = new System.Drawing.Font("Verdana", 9F);
            this.txNota.FormatLogin = false;
            this.txNota.ImageIcon = ((System.Drawing.Image)(resources.GetObject("txNota.ImageIcon")));
            this.txNota.Info = "";
            this.txNota.Location = new System.Drawing.Point(12, 176);
            this.txNota.MaterialStyle = false;
            this.txNota.MaxLength = 32767;
            this.txNota.MultiLineText = true;
            this.txNota.Name = "txNota";
            this.txNota.PasswordChar = '\0';
            this.txNota.Placeholder = "";
            this.txNota.ReadOnly = true;
            this.txNota.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txNota.Size = new System.Drawing.Size(278, 220);
            this.txNota.SizeLine = 2;
            this.txNota.TabIndex = 3;
            this.txNota.Title = "Nota";
            this.txNota.VisibleIcon = true;
            this.txNota.VisibleTitle = true;
            // 
            // txTasa
            // 
            this.txTasa.AlignText = System.Windows.Forms.HorizontalAlignment.Left;
            this.txTasa.BackColor = System.Drawing.Color.White;
            this.txTasa.Category = '\0';
            this.txTasa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txTasa.ColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.txTasa.ColorLine = System.Drawing.Color.Gray;
            this.txTasa.ColorText = System.Drawing.SystemColors.WindowText;
            this.txTasa.ColorTitle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txTasa.DockIcon = System.Windows.Forms.DockStyle.Left;
            this.txTasa.Error = "";
            this.txTasa.FontText = new System.Drawing.Font("Verdana", 10F);
            this.txTasa.FontTitle = new System.Drawing.Font("Verdana", 9F);
            this.txTasa.FormatLogin = false;
            this.txTasa.ImageIcon = ((System.Drawing.Image)(resources.GetObject("txTasa.ImageIcon")));
            this.txTasa.Info = "";
            this.txTasa.Location = new System.Drawing.Point(12, 402);
            this.txTasa.MaterialStyle = false;
            this.txTasa.MaxLength = 32767;
            this.txTasa.MultiLineText = false;
            this.txTasa.Name = "txTasa";
            this.txTasa.PasswordChar = '\0';
            this.txTasa.Placeholder = "";
            this.txTasa.ReadOnly = true;
            this.txTasa.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txTasa.Size = new System.Drawing.Size(278, 58);
            this.txTasa.SizeLine = 2;
            this.txTasa.TabIndex = 2;
            this.txTasa.Text = "00.00";
            this.txTasa.Title = "Tasa";
            this.txTasa.Visible = false;
            this.txTasa.VisibleIcon = true;
            this.txTasa.VisibleTitle = true;
            // 
            // txMontoPago
            // 
            this.txMontoPago.AlignText = System.Windows.Forms.HorizontalAlignment.Left;
            this.txMontoPago.BackColor = System.Drawing.Color.White;
            this.txMontoPago.Category = '\0';
            this.txMontoPago.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txMontoPago.ColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.txMontoPago.ColorLine = System.Drawing.Color.Gray;
            this.txMontoPago.ColorText = System.Drawing.SystemColors.WindowText;
            this.txMontoPago.ColorTitle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txMontoPago.DockIcon = System.Windows.Forms.DockStyle.Left;
            this.txMontoPago.Error = "";
            this.txMontoPago.FontText = new System.Drawing.Font("Verdana", 10F);
            this.txMontoPago.FontTitle = new System.Drawing.Font("Verdana", 9F);
            this.txMontoPago.FormatLogin = false;
            this.txMontoPago.ImageIcon = ((System.Drawing.Image)(resources.GetObject("txMontoPago.ImageIcon")));
            this.txMontoPago.Info = "";
            this.txMontoPago.Location = new System.Drawing.Point(12, 83);
            this.txMontoPago.MaterialStyle = false;
            this.txMontoPago.MaxLength = 32767;
            this.txMontoPago.MultiLineText = false;
            this.txMontoPago.Name = "txMontoPago";
            this.txMontoPago.PasswordChar = '\0';
            this.txMontoPago.Placeholder = "";
            this.txMontoPago.ReadOnly = true;
            this.txMontoPago.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txMontoPago.Size = new System.Drawing.Size(278, 58);
            this.txMontoPago.SizeLine = 2;
            this.txMontoPago.TabIndex = 1;
            this.txMontoPago.Text = "00.00";
            this.txMontoPago.Title = "Monto";
            this.txMontoPago.VisibleIcon = true;
            this.txMontoPago.VisibleTitle = true;
            // 
            // pnlPagosAgregados
            // 
            this.pnlPagosAgregados.Controls.Add(this.grdData);
            this.pnlPagosAgregados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPagosAgregados.Location = new System.Drawing.Point(400, 0);
            this.pnlPagosAgregados.Name = "pnlPagosAgregados";
            this.pnlPagosAgregados.Size = new System.Drawing.Size(602, 505);
            this.pnlPagosAgregados.TabIndex = 8;
            // 
            // grdData
            // 
            this.grdData.AllowUserToAddRows = false;
            this.grdData.AllowUserToDeleteRows = false;
            this.grdData.AllowUserToResizeRows = false;
            this.grdData.BackgroundColor = System.Drawing.Color.White;
            this.grdData.BodyFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdData.BodyForeColor = System.Drawing.SystemColors.ControlText;
            this.grdData.BodySelectColor = System.Drawing.SystemColors.Highlight;
            this.grdData.BodySelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.grdData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdData.CellStyleBackColor = System.Drawing.SystemColors.Window;
            this.grdData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdData.ColumnHeadersHeight = 34;
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.idVenta,
            this.idTipo,
            this.Descripcion,
            this.Monto,
            this.Tasa,
            this.Fecha,
            this.Vuelto_Bolivares,
            this.Vuelto_Divisas,
            this.Propina,
            this.Nota});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.grdData.HeaderFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdData.HeaderForeColor = System.Drawing.SystemColors.WindowText;
            this.grdData.Location = new System.Drawing.Point(0, 0);
            this.grdData.MultiSelect = false;
            this.grdData.Name = "grdData";
            this.grdData.ReadOnly = true;
            this.grdData.RowHeadersVisible = false;
            this.grdData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdData.Size = new System.Drawing.Size(602, 505);
            this.grdData.TabIndex = 0;
            this.grdData.SelectionChanged += new System.EventHandler(this.grdData_SelectionChanged);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // idVenta
            // 
            this.idVenta.DataPropertyName = "idVenta";
            this.idVenta.HeaderText = "idVenta";
            this.idVenta.Name = "idVenta";
            this.idVenta.ReadOnly = true;
            this.idVenta.Visible = false;
            // 
            // idTipo
            // 
            this.idTipo.DataPropertyName = "idTipo";
            this.idTipo.HeaderText = "idTipo";
            this.idTipo.Name = "idTipo";
            this.idTipo.ReadOnly = true;
            this.idTipo.Visible = false;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Monto
            // 
            this.Monto.DataPropertyName = "Monto";
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            // 
            // Tasa
            // 
            this.Tasa.DataPropertyName = "Tasa";
            this.Tasa.HeaderText = "Tasa";
            this.Tasa.Name = "Tasa";
            this.Tasa.ReadOnly = true;
            this.Tasa.Visible = false;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Vuelto_Bolivares
            // 
            this.Vuelto_Bolivares.DataPropertyName = "Vuelto_Bolivares";
            this.Vuelto_Bolivares.HeaderText = "Vuelto en Bolivares";
            this.Vuelto_Bolivares.Name = "Vuelto_Bolivares";
            this.Vuelto_Bolivares.ReadOnly = true;
            // 
            // Vuelto_Divisas
            // 
            this.Vuelto_Divisas.DataPropertyName = "Vuelto_Divisas";
            this.Vuelto_Divisas.HeaderText = "Vuelto en Divisas";
            this.Vuelto_Divisas.Name = "Vuelto_Divisas";
            this.Vuelto_Divisas.ReadOnly = true;
            // 
            // Propina
            // 
            this.Propina.DataPropertyName = "Propina";
            this.Propina.HeaderText = "Propina";
            this.Propina.Name = "Propina";
            this.Propina.ReadOnly = true;
            // 
            // Nota
            // 
            this.Nota.DataPropertyName = "Nota";
            this.Nota.HeaderText = "Nota";
            this.Nota.Name = "Nota";
            this.Nota.ReadOnly = true;
            this.Nota.Visible = false;
            // 
            // frmVerPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 598);
            this.Name = "frmVerPagos";
            this.Text = "frmVerPagos";
            this.Load += new System.EventHandler(this.frmVerPagos_Load);
            this.Contenedor.ResumeLayout(false);
            this.Body.ResumeLayout(false);
            this.Footer.ResumeLayout(false);
            this.Header.ResumeLayout(false);
            this.pnlAgregarPagos.ResumeLayout(false);
            this.pnlPagosAgregados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAgregarPagos;
        private Autonomo.CustomControls.FlatTextBox txNota;
        private Autonomo.CustomControls.FlatTextBox txTasa;
        private Autonomo.CustomControls.FlatTextBox txMontoPago;
        private System.Windows.Forms.Panel pnlPagosAgregados;
        private Autonomo.CustomControls.CustomGrid grdData;
        private Autonomo.CustomControls.FlatTextBox txTipoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tasa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vuelto_Bolivares;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vuelto_Divisas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Propina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota;
    }
}