namespace MampoteSystem.Windows.Modulo.Ventas.Cerrar
{
    partial class frmCerrarVentaModal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCerrarVentaModal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlAgregarPagos = new System.Windows.Forms.Panel();
            this.txPropina = new Autonomo.CustomControls.FlatTextBox();
            this.txVueltoDivisa = new Autonomo.CustomControls.FlatTextBox();
            this.txNota = new Autonomo.CustomControls.FlatTextBox();
            this.txVueltoBolivares = new Autonomo.CustomControls.FlatTextBox();
            this.txMontoPago = new Autonomo.CustomControls.FlatTextBox();
            this.cbTiposPago = new Autonomo.CustomControls.FlatComboBox();
            this.pnlPagosAgregados = new System.Windows.Forms.Panel();
            this.grdData = new Autonomo.CustomControls.CustomGrid();
            this.idVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vuelto_Bolivares = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vuelto_Divisas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Propina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDiferenciaBs = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbDiferencia = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTotalPagos = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbMontoPagarBs = new System.Windows.Forms.Label();
            this.txNumeroFactura = new Autonomo.CustomControls.FlatTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTasa = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lbMontoPagarDolares = new System.Windows.Forms.Label();
            this.btnCerrarVenta = new Autonomo.CustomControls.CustomButton();
            this.Contenedor.SuspendLayout();
            this.Body.SuspendLayout();
            this.Footer.SuspendLayout();
            this.Header.SuspendLayout();
            this.pnlAgregarPagos.SuspendLayout();
            this.pnlPagosAgregados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Contenedor
            // 
            this.Contenedor.Size = new System.Drawing.Size(1077, 735);
            // 
            // Body
            // 
            this.Body.Controls.Add(this.pnlAgregarPagos);
            this.Body.Controls.Add(this.pnlPagosAgregados);
            this.Body.Controls.Add(this.panel1);
            this.Body.Size = new System.Drawing.Size(1077, 642);
            // 
            // Footer
            // 
            this.Footer.Controls.Add(this.btnCerrarVenta);
            this.Footer.Location = new System.Drawing.Point(0, 683);
            this.Footer.Size = new System.Drawing.Size(1077, 52);
            this.Footer.Controls.SetChildIndex(this.btnSave, 0);
            this.Footer.Controls.SetChildIndex(this.btnCerrarVenta, 0);
            // 
            // Header
            // 
            this.Header.Size = new System.Drawing.Size(1077, 41);
            // 
            // Title
            // 
            this.Title.Size = new System.Drawing.Size(1036, 41);
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Text = "Agregar Pago";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlAgregarPagos
            // 
            this.pnlAgregarPagos.Controls.Add(this.txPropina);
            this.pnlAgregarPagos.Controls.Add(this.txVueltoDivisa);
            this.pnlAgregarPagos.Controls.Add(this.txNota);
            this.pnlAgregarPagos.Controls.Add(this.txVueltoBolivares);
            this.pnlAgregarPagos.Controls.Add(this.txMontoPago);
            this.pnlAgregarPagos.Controls.Add(this.cbTiposPago);
            this.pnlAgregarPagos.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAgregarPagos.Location = new System.Drawing.Point(0, 62);
            this.pnlAgregarPagos.Name = "pnlAgregarPagos";
            this.pnlAgregarPagos.Size = new System.Drawing.Size(405, 580);
            this.pnlAgregarPagos.TabIndex = 0;
            // 
            // txPropina
            // 
            this.txPropina.AlignText = System.Windows.Forms.HorizontalAlignment.Left;
            this.txPropina.BackColor = System.Drawing.Color.White;
            this.txPropina.Category = '\0';
            this.txPropina.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txPropina.ColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.txPropina.ColorLine = System.Drawing.Color.Gray;
            this.txPropina.ColorText = System.Drawing.SystemColors.WindowText;
            this.txPropina.ColorTitle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txPropina.DockIcon = System.Windows.Forms.DockStyle.Left;
            this.txPropina.Error = "";
            this.txPropina.FontText = new System.Drawing.Font("Verdana", 10F);
            this.txPropina.FontTitle = new System.Drawing.Font("Verdana", 9F);
            this.txPropina.FormatLogin = false;
            this.txPropina.ImageIcon = ((System.Drawing.Image)(resources.GetObject("txPropina.ImageIcon")));
            this.txPropina.Info = "";
            this.txPropina.Location = new System.Drawing.Point(22, 500);
            this.txPropina.MaterialStyle = false;
            this.txPropina.MaxLength = 32767;
            this.txPropina.MultiLineText = false;
            this.txPropina.Name = "txPropina";
            this.txPropina.PasswordChar = '\0';
            this.txPropina.Placeholder = "";
            this.txPropina.ReadOnly = false;
            this.txPropina.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txPropina.Size = new System.Drawing.Size(278, 58);
            this.txPropina.SizeLine = 2;
            this.txPropina.TabIndex = 5;
            this.txPropina.Text = "00.00";
            this.txPropina.Title = "Propina  Bs.";
            this.txPropina.Visible = false;
            this.txPropina.VisibleIcon = true;
            this.txPropina.VisibleTitle = true;
            this.txPropina.TextBoxChanged += new System.EventHandler(this.txVuelto_TextBoxChanged);
            this.txPropina.KeyPress += new System.EventHandler<System.Windows.Forms.KeyPressEventArgs>(this.txPropina_KeyPress);
            // 
            // txVueltoDivisa
            // 
            this.txVueltoDivisa.AlignText = System.Windows.Forms.HorizontalAlignment.Left;
            this.txVueltoDivisa.BackColor = System.Drawing.Color.White;
            this.txVueltoDivisa.Category = '\0';
            this.txVueltoDivisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txVueltoDivisa.ColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.txVueltoDivisa.ColorLine = System.Drawing.Color.Gray;
            this.txVueltoDivisa.ColorText = System.Drawing.SystemColors.WindowText;
            this.txVueltoDivisa.ColorTitle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txVueltoDivisa.DockIcon = System.Windows.Forms.DockStyle.Left;
            this.txVueltoDivisa.Error = "";
            this.txVueltoDivisa.FontText = new System.Drawing.Font("Verdana", 10F);
            this.txVueltoDivisa.FontTitle = new System.Drawing.Font("Verdana", 9F);
            this.txVueltoDivisa.FormatLogin = false;
            this.txVueltoDivisa.ImageIcon = ((System.Drawing.Image)(resources.GetObject("txVueltoDivisa.ImageIcon")));
            this.txVueltoDivisa.Info = "";
            this.txVueltoDivisa.Location = new System.Drawing.Point(22, 445);
            this.txVueltoDivisa.MaterialStyle = false;
            this.txVueltoDivisa.MaxLength = 32767;
            this.txVueltoDivisa.MultiLineText = false;
            this.txVueltoDivisa.Name = "txVueltoDivisa";
            this.txVueltoDivisa.PasswordChar = '\0';
            this.txVueltoDivisa.Placeholder = "";
            this.txVueltoDivisa.ReadOnly = false;
            this.txVueltoDivisa.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txVueltoDivisa.Size = new System.Drawing.Size(278, 58);
            this.txVueltoDivisa.SizeLine = 2;
            this.txVueltoDivisa.TabIndex = 4;
            this.txVueltoDivisa.Text = "00.00";
            this.txVueltoDivisa.Title = "Vuelto en Divisas";
            this.txVueltoDivisa.Visible = false;
            this.txVueltoDivisa.VisibleIcon = true;
            this.txVueltoDivisa.VisibleTitle = true;
            this.txVueltoDivisa.TextBoxChanged += new System.EventHandler(this.txVuelto_TextBoxChanged);
            this.txVueltoDivisa.KeyPress += new System.EventHandler<System.Windows.Forms.KeyPressEventArgs>(this.txVueltoDivisa_KeyPress);
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
            this.txNota.Location = new System.Drawing.Point(12, 185);
            this.txNota.MaterialStyle = false;
            this.txNota.MaxLength = 32767;
            this.txNota.MultiLineText = true;
            this.txNota.Name = "txNota";
            this.txNota.PasswordChar = '\0';
            this.txNota.Placeholder = "";
            this.txNota.ReadOnly = false;
            this.txNota.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txNota.Size = new System.Drawing.Size(278, 163);
            this.txNota.SizeLine = 2;
            this.txNota.TabIndex = 3;
            this.txNota.Title = "Nota";
            this.txNota.VisibleIcon = true;
            this.txNota.VisibleTitle = true;
            // 
            // txVueltoBolivares
            // 
            this.txVueltoBolivares.AlignText = System.Windows.Forms.HorizontalAlignment.Left;
            this.txVueltoBolivares.BackColor = System.Drawing.Color.White;
            this.txVueltoBolivares.Category = '\0';
            this.txVueltoBolivares.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txVueltoBolivares.ColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.txVueltoBolivares.ColorLine = System.Drawing.Color.Gray;
            this.txVueltoBolivares.ColorText = System.Drawing.SystemColors.WindowText;
            this.txVueltoBolivares.ColorTitle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txVueltoBolivares.DockIcon = System.Windows.Forms.DockStyle.Left;
            this.txVueltoBolivares.Error = "";
            this.txVueltoBolivares.FontText = new System.Drawing.Font("Verdana", 10F);
            this.txVueltoBolivares.FontTitle = new System.Drawing.Font("Verdana", 9F);
            this.txVueltoBolivares.FormatLogin = false;
            this.txVueltoBolivares.ImageIcon = ((System.Drawing.Image)(resources.GetObject("txVueltoBolivares.ImageIcon")));
            this.txVueltoBolivares.Info = "";
            this.txVueltoBolivares.Location = new System.Drawing.Point(22, 381);
            this.txVueltoBolivares.MaterialStyle = false;
            this.txVueltoBolivares.MaxLength = 32767;
            this.txVueltoBolivares.MultiLineText = false;
            this.txVueltoBolivares.Name = "txVueltoBolivares";
            this.txVueltoBolivares.PasswordChar = '\0';
            this.txVueltoBolivares.Placeholder = "";
            this.txVueltoBolivares.ReadOnly = false;
            this.txVueltoBolivares.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txVueltoBolivares.Size = new System.Drawing.Size(278, 58);
            this.txVueltoBolivares.SizeLine = 2;
            this.txVueltoBolivares.TabIndex = 2;
            this.txVueltoBolivares.Text = "00.00";
            this.txVueltoBolivares.Title = "Vuelto en Bolivares";
            this.txVueltoBolivares.Visible = false;
            this.txVueltoBolivares.VisibleIcon = true;
            this.txVueltoBolivares.VisibleTitle = true;
            this.txVueltoBolivares.TextBoxChanged += new System.EventHandler(this.txVuelto_TextBoxChanged);
            this.txVueltoBolivares.KeyPress += new System.EventHandler<System.Windows.Forms.KeyPressEventArgs>(this.txVuelto_KeyPress);
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
            this.txMontoPago.Location = new System.Drawing.Point(12, 105);
            this.txMontoPago.MaterialStyle = false;
            this.txMontoPago.MaxLength = 32767;
            this.txMontoPago.MultiLineText = false;
            this.txMontoPago.Name = "txMontoPago";
            this.txMontoPago.PasswordChar = '\0';
            this.txMontoPago.Placeholder = "";
            this.txMontoPago.ReadOnly = false;
            this.txMontoPago.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txMontoPago.Size = new System.Drawing.Size(278, 58);
            this.txMontoPago.SizeLine = 2;
            this.txMontoPago.TabIndex = 1;
            this.txMontoPago.Text = "00.00";
            this.txMontoPago.Title = "Monto";
            this.txMontoPago.VisibleIcon = true;
            this.txMontoPago.VisibleTitle = true;
            this.txMontoPago.TextBoxChanged += new System.EventHandler(this.txMontoPagar_TextBoxChanged);
            this.txMontoPago.KeyPress += new System.EventHandler<System.Windows.Forms.KeyPressEventArgs>(this.txMontoPago_KeyPress);
            // 
            // cbTiposPago
            // 
            this.cbTiposPago.BackColor = System.Drawing.Color.White;
            this.cbTiposPago.Category = '\0';
            this.cbTiposPago.ColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.cbTiposPago.ColorLine = System.Drawing.Color.Gray;
            this.cbTiposPago.ColorText = System.Drawing.SystemColors.WindowText;
            this.cbTiposPago.ColorTitle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbTiposPago.DisplayMember = "";
            this.cbTiposPago.DockIcon = System.Windows.Forms.DockStyle.Left;
            this.cbTiposPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTiposPago.Error = "";
            this.cbTiposPago.FontText = new System.Drawing.Font("Verdana", 10F);
            this.cbTiposPago.FontTitle = new System.Drawing.Font("Verdana", 9F);
            this.cbTiposPago.ImageIcon = ((System.Drawing.Image)(resources.GetObject("cbTiposPago.ImageIcon")));
            this.cbTiposPago.Info = "";
            this.cbTiposPago.Location = new System.Drawing.Point(12, 26);
            this.cbTiposPago.MaterialStyle = false;
            this.cbTiposPago.Name = "cbTiposPago";
            this.cbTiposPago.Placeholder = "";
            this.cbTiposPago.SelectedIndex = -1;
            this.cbTiposPago.Size = new System.Drawing.Size(278, 58);
            this.cbTiposPago.SizeLine = 2;
            this.cbTiposPago.TabIndex = 0;
            this.cbTiposPago.Title = "Tipo de Pago";
            this.cbTiposPago.ValueMember = "";
            this.cbTiposPago.VisibleIcon = true;
            this.cbTiposPago.VisibleTitle = true;
            this.cbTiposPago.SelectedIndexChanged += new System.EventHandler(this.cbTiposPago_SelectedIndexChanged);
            // 
            // pnlPagosAgregados
            // 
            this.pnlPagosAgregados.Controls.Add(this.grdData);
            this.pnlPagosAgregados.Controls.Add(this.panel2);
            this.pnlPagosAgregados.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlPagosAgregados.Location = new System.Drawing.Point(406, 62);
            this.pnlPagosAgregados.Name = "pnlPagosAgregados";
            this.pnlPagosAgregados.Size = new System.Drawing.Size(671, 580);
            this.pnlPagosAgregados.TabIndex = 1;
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
            this.idVenta,
            this.idTipo,
            this.Descripcion,
            this.Monto,
            this.Tasa,
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
            this.grdData.Size = new System.Drawing.Size(671, 480);
            this.grdData.TabIndex = 0;
            this.grdData.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdData_CellContentDoubleClick);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lbDiferenciaBs);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lbDiferencia);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lbTotalPagos);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 480);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(671, 100);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 35;
            this.label1.Text = "Diferencia Bs.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDiferenciaBs
            // 
            this.lbDiferenciaBs.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold);
            this.lbDiferenciaBs.ForeColor = System.Drawing.Color.Black;
            this.lbDiferenciaBs.Location = new System.Drawing.Point(17, 36);
            this.lbDiferenciaBs.Name = "lbDiferenciaBs";
            this.lbDiferenciaBs.Size = new System.Drawing.Size(136, 30);
            this.lbDiferenciaBs.TabIndex = 34;
            this.lbDiferenciaBs.Text = "0.00";
            this.lbDiferenciaBs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(125, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 33;
            this.label6.Text = "Diferencia $";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDiferencia
            // 
            this.lbDiferencia.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold);
            this.lbDiferencia.ForeColor = System.Drawing.Color.Black;
            this.lbDiferencia.Location = new System.Drawing.Point(135, 36);
            this.lbDiferencia.Name = "lbDiferencia";
            this.lbDiferencia.Size = new System.Drawing.Size(136, 30);
            this.lbDiferencia.TabIndex = 32;
            this.lbDiferencia.Text = "0.00";
            this.lbDiferencia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(418, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "Total pagos Bs.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTotalPagos
            // 
            this.lbTotalPagos.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold);
            this.lbTotalPagos.ForeColor = System.Drawing.Color.Black;
            this.lbTotalPagos.Location = new System.Drawing.Point(447, 36);
            this.lbTotalPagos.Name = "lbTotalPagos";
            this.lbTotalPagos.Size = new System.Drawing.Size(136, 30);
            this.lbTotalPagos.TabIndex = 30;
            this.lbTotalPagos.Text = "0.00";
            this.lbTotalPagos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbMontoPagarBs);
            this.panel1.Controls.Add(this.txNumeroFactura);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbTasa);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.lbMontoPagarDolares);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1077, 62);
            this.panel1.TabIndex = 3;
            // 
            // lbMontoPagarBs
            // 
            this.lbMontoPagarBs.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold);
            this.lbMontoPagarBs.ForeColor = System.Drawing.Color.Red;
            this.lbMontoPagarBs.Location = new System.Drawing.Point(363, 23);
            this.lbMontoPagarBs.Name = "lbMontoPagarBs";
            this.lbMontoPagarBs.Size = new System.Drawing.Size(136, 30);
            this.lbMontoPagarBs.TabIndex = 30;
            this.lbMontoPagarBs.Text = "Bs. 0.00";
            this.lbMontoPagarBs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txNumeroFactura
            // 
            this.txNumeroFactura.AlignText = System.Windows.Forms.HorizontalAlignment.Left;
            this.txNumeroFactura.BackColor = System.Drawing.Color.White;
            this.txNumeroFactura.Category = '\0';
            this.txNumeroFactura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txNumeroFactura.ColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.txNumeroFactura.ColorLine = System.Drawing.Color.Gray;
            this.txNumeroFactura.ColorText = System.Drawing.SystemColors.WindowText;
            this.txNumeroFactura.ColorTitle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txNumeroFactura.DockIcon = System.Windows.Forms.DockStyle.Left;
            this.txNumeroFactura.Error = "";
            this.txNumeroFactura.FontText = new System.Drawing.Font("Verdana", 10F);
            this.txNumeroFactura.FontTitle = new System.Drawing.Font("Verdana", 9F);
            this.txNumeroFactura.FormatLogin = false;
            this.txNumeroFactura.ImageIcon = ((System.Drawing.Image)(resources.GetObject("txNumeroFactura.ImageIcon")));
            this.txNumeroFactura.Info = "";
            this.txNumeroFactura.Location = new System.Drawing.Point(669, 7);
            this.txNumeroFactura.MaterialStyle = false;
            this.txNumeroFactura.MaxLength = 32767;
            this.txNumeroFactura.MultiLineText = false;
            this.txNumeroFactura.Name = "txNumeroFactura";
            this.txNumeroFactura.PasswordChar = '\0';
            this.txNumeroFactura.Placeholder = "";
            this.txNumeroFactura.ReadOnly = false;
            this.txNumeroFactura.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txNumeroFactura.Size = new System.Drawing.Size(278, 52);
            this.txNumeroFactura.SizeLine = 2;
            this.txNumeroFactura.TabIndex = 2;
            this.txNumeroFactura.Text = "000000000000";
            this.txNumeroFactura.Title = "Posible Numero de Factura";
            this.txNumeroFactura.VisibleIcon = true;
            this.txNumeroFactura.VisibleTitle = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Tasa de cambio";
            // 
            // lbTasa
            // 
            this.lbTasa.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold);
            this.lbTasa.ForeColor = System.Drawing.Color.LightGray;
            this.lbTasa.Location = new System.Drawing.Point(7, 23);
            this.lbTasa.Name = "lbTasa";
            this.lbTasa.Size = new System.Drawing.Size(136, 30);
            this.lbTasa.TabIndex = 28;
            this.lbTasa.Text = "0.00";
            this.lbTasa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(207, 7);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(258, 16);
            this.label17.TabIndex = 27;
            this.label17.Text = "               Monto a Pagar                ";
            // 
            // lbMontoPagarDolares
            // 
            this.lbMontoPagarDolares.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold);
            this.lbMontoPagarDolares.ForeColor = System.Drawing.Color.Red;
            this.lbMontoPagarDolares.Location = new System.Drawing.Point(190, 23);
            this.lbMontoPagarDolares.Name = "lbMontoPagarDolares";
            this.lbMontoPagarDolares.Size = new System.Drawing.Size(136, 30);
            this.lbMontoPagarDolares.TabIndex = 26;
            this.lbMontoPagarDolares.Text = "$ 0.00";
            this.lbMontoPagarDolares.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCerrarVenta
            // 
            this.btnCerrarVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.btnCerrarVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarVenta.FlatAppearance.BorderSize = 0;
            this.btnCerrarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarVenta.Font = new System.Drawing.Font("Verdana", 10F);
            this.btnCerrarVenta.ForeColor = System.Drawing.Color.White;
            this.btnCerrarVenta.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarVenta.Image")));
            this.btnCerrarVenta.Location = new System.Drawing.Point(910, 8);
            this.btnCerrarVenta.Name = "btnCerrarVenta";
            this.btnCerrarVenta.Size = new System.Drawing.Size(155, 36);
            this.btnCerrarVenta.TabIndex = 10;
            this.btnCerrarVenta.Text = " Guardar";
            this.btnCerrarVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrarVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrarVenta.UseVisualStyleBackColor = false;
            this.btnCerrarVenta.Click += new System.EventHandler(this.btnCerrarVenta_Click);
            // 
            // frmCerrarVentaModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 735);
            this.Name = "frmCerrarVentaModal";
            this.Text = "frmCerrarVentaModal";
            this.Load += new System.EventHandler(this.frmCerrarVentaModal_Load);
            this.Contenedor.ResumeLayout(false);
            this.Body.ResumeLayout(false);
            this.Footer.ResumeLayout(false);
            this.Header.ResumeLayout(false);
            this.pnlAgregarPagos.ResumeLayout(false);
            this.pnlPagosAgregados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPagosAgregados;
        private System.Windows.Forms.Panel pnlAgregarPagos;
        private Autonomo.CustomControls.CustomGrid grdData;
        private Autonomo.CustomControls.FlatTextBox txMontoPago;
        private Autonomo.CustomControls.FlatComboBox cbTiposPago;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbMontoPagarDolares;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTasa;
        private Autonomo.CustomControls.FlatTextBox txNumeroFactura;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTotalPagos;
        private System.Windows.Forms.Label lbMontoPagarBs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbDiferencia;
        private Autonomo.CustomControls.FlatTextBox txNota;
        private Autonomo.CustomControls.FlatTextBox txVueltoBolivares;
        private Autonomo.CustomControls.CustomButton btnCerrarVenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbDiferenciaBs;
        private Autonomo.CustomControls.FlatTextBox txPropina;
        private Autonomo.CustomControls.FlatTextBox txVueltoDivisa;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tasa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vuelto_Bolivares;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vuelto_Divisas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Propina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nota;
    }
}