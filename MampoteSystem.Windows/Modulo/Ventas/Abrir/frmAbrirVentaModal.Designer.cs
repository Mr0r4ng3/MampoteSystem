namespace MampoteSystem.Windows.Modulo.Ventas.Abrir
{
    partial class frmAbrirVentaModal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbrirVentaModal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelCanastilla = new System.Windows.Forms.Panel();
            this.grdCanastilla = new Autonomo.CustomControls.CustomGrid();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panlTotals = new System.Windows.Forms.Panel();
            this.lbTasa = new System.Windows.Forms.Label();
            this.lbTotalDolares = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMessageGrid = new System.Windows.Forms.Label();
            this.lbCantidad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lblTotals = new System.Windows.Forms.Label();
            this.panelControles = new System.Windows.Forms.Panel();
            this.chkDeudaInicial = new Autonomo.CustomControls.CustomCheck();
            this.txMontoDeuda = new Autonomo.CustomControls.FlatTextBox();
            this.btnAddDeuda = new Autonomo.CustomControls.CustomButton();
            this.chkComision = new Autonomo.CustomControls.CustomCheck();
            this.btnGuardar = new Autonomo.CustomControls.CustomButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbCedula = new Autonomo.CustomControls.FlatComboBox();
            this.txCliente = new Autonomo.CustomControls.FlatFindText();
            this.panelItems = new System.Windows.Forms.Panel();
            this.flowCart = new System.Windows.Forms.FlowLayoutPanel();
            this.pnelBuscador = new System.Windows.Forms.Panel();
            this.txFiltro = new Autonomo.CustomControls.FlatFindText();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grdDetalle = new Autonomo.CustomControls.CustomGrid();
            this.Contenedor.SuspendLayout();
            this.Body.SuspendLayout();
            this.Footer.SuspendLayout();
            this.Header.SuspendLayout();
            this.panelCanastilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCanastilla)).BeginInit();
            this.panlTotals.SuspendLayout();
            this.panelControles.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelItems.SuspendLayout();
            this.pnelBuscador.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // Contenedor
            // 
            this.Contenedor.Size = new System.Drawing.Size(1350, 720);
            // 
            // Body
            // 
            this.Body.Controls.Add(this.tabControl1);
            this.Body.Controls.Add(this.panelControles);
            this.Body.Controls.Add(this.panel1);
            this.Body.Controls.Add(this.panelItems);
            this.Body.Size = new System.Drawing.Size(1350, 627);
            // 
            // Footer
            // 
            this.Footer.Location = new System.Drawing.Point(0, 668);
            this.Footer.Size = new System.Drawing.Size(1350, 52);
            this.Footer.Visible = false;
            // 
            // Header
            // 
            this.Header.Size = new System.Drawing.Size(1350, 41);
            // 
            // Title
            // 
            this.Title.Size = new System.Drawing.Size(1309, 41);
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Visible = false;
            // 
            // panelCanastilla
            // 
            this.panelCanastilla.Controls.Add(this.grdCanastilla);
            this.panelCanastilla.Controls.Add(this.panlTotals);
            this.panelCanastilla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCanastilla.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCanastilla.Location = new System.Drawing.Point(3, 3);
            this.panelCanastilla.Name = "panelCanastilla";
            this.panelCanastilla.Size = new System.Drawing.Size(951, 412);
            this.panelCanastilla.TabIndex = 5;
            // 
            // grdCanastilla
            // 
            this.grdCanastilla.AllowUserToAddRows = false;
            this.grdCanastilla.AllowUserToDeleteRows = false;
            this.grdCanastilla.AllowUserToResizeRows = false;
            this.grdCanastilla.BackgroundColor = System.Drawing.Color.White;
            this.grdCanastilla.BodyFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdCanastilla.BodyForeColor = System.Drawing.SystemColors.ControlText;
            this.grdCanastilla.BodySelectColor = System.Drawing.SystemColors.Highlight;
            this.grdCanastilla.BodySelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.grdCanastilla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdCanastilla.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdCanastilla.CellStyleBackColor = System.Drawing.SystemColors.Window;
            this.grdCanastilla.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdCanastilla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdCanastilla.ColumnHeadersHeight = 34;
            this.grdCanastilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdCanastilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tipo,
            this.Codigo,
            this.Nombre,
            this.Cantidad,
            this.PrecioVenta,
            this.IVA,
            this.SubTotal});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdCanastilla.DefaultCellStyle = dataGridViewCellStyle6;
            this.grdCanastilla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdCanastilla.EnableBottomDown = false;
            this.grdCanastilla.EnableBottomLeft = false;
            this.grdCanastilla.EnableBottomRight = false;
            this.grdCanastilla.EnableBottomUp = false;
            this.grdCanastilla.EnableHeadersVisualStyles = false;
            this.grdCanastilla.HeaderColor = System.Drawing.SystemColors.Control;
            this.grdCanastilla.HeaderFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdCanastilla.HeaderForeColor = System.Drawing.SystemColors.WindowText;
            this.grdCanastilla.Location = new System.Drawing.Point(0, 0);
            this.grdCanastilla.MultiSelect = false;
            this.grdCanastilla.Name = "grdCanastilla";
            this.grdCanastilla.ReadOnly = true;
            this.grdCanastilla.RowHeadersVisible = false;
            this.grdCanastilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdCanastilla.Size = new System.Drawing.Size(951, 329);
            this.grdCanastilla.TabIndex = 9;
            this.grdCanastilla.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCanastilla_CellContentDoubleClick);
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
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 200;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Info;
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle2;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 150;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.DataPropertyName = "PrecioVenta";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PrecioVenta.DefaultCellStyle = dataGridViewCellStyle3;
            this.PrecioVenta.HeaderText = "P. Venta";
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
            this.PrecioVenta.Width = 120;
            // 
            // IVA
            // 
            this.IVA.DataPropertyName = "IVA";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.IVA.DefaultCellStyle = dataGridViewCellStyle4;
            this.IVA.HeaderText = "IVA";
            this.IVA.Name = "IVA";
            this.IVA.ReadOnly = true;
            this.IVA.Visible = false;
            // 
            // SubTotal
            // 
            this.SubTotal.DataPropertyName = "SubTotal";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SubTotal.DefaultCellStyle = dataGridViewCellStyle5;
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            this.SubTotal.Width = 120;
            // 
            // panlTotals
            // 
            this.panlTotals.Controls.Add(this.lbTasa);
            this.panlTotals.Controls.Add(this.lbTotalDolares);
            this.panlTotals.Controls.Add(this.label2);
            this.panlTotals.Controls.Add(this.lblMessageGrid);
            this.panlTotals.Controls.Add(this.lbCantidad);
            this.panlTotals.Controls.Add(this.label1);
            this.panlTotals.Controls.Add(this.lbTotal);
            this.panlTotals.Controls.Add(this.lblTotals);
            this.panlTotals.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panlTotals.Location = new System.Drawing.Point(0, 329);
            this.panlTotals.Name = "panlTotals";
            this.panlTotals.Size = new System.Drawing.Size(951, 83);
            this.panlTotals.TabIndex = 8;
            // 
            // lbTasa
            // 
            this.lbTasa.AutoSize = true;
            this.lbTasa.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTasa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbTasa.Location = new System.Drawing.Point(529, 34);
            this.lbTasa.Name = "lbTasa";
            this.lbTasa.Size = new System.Drawing.Size(199, 16);
            this.lbTasa.TabIndex = 22;
            this.lbTasa.Text = "Tasa de Cambio: Bs. 00.00";
            this.lbTasa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTotalDolares
            // 
            this.lbTotalDolares.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalDolares.ForeColor = System.Drawing.Color.DarkGray;
            this.lbTotalDolares.Location = new System.Drawing.Point(870, 32);
            this.lbTotalDolares.Name = "lbTotalDolares";
            this.lbTotalDolares.Size = new System.Drawing.Size(70, 16);
            this.lbTotalDolares.TabIndex = 21;
            this.lbTotalDolares.Text = "$ 0.00";
            this.lbTotalDolares.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(6, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 14);
            this.label2.TabIndex = 19;
            this.label2.Text = "Doble Click para Retirar Item";
            // 
            // lblMessageGrid
            // 
            this.lblMessageGrid.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblMessageGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblMessageGrid.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessageGrid.ForeColor = System.Drawing.Color.White;
            this.lblMessageGrid.Location = new System.Drawing.Point(0, 64);
            this.lblMessageGrid.Name = "lblMessageGrid";
            this.lblMessageGrid.Size = new System.Drawing.Size(951, 19);
            this.lblMessageGrid.TabIndex = 18;
            this.lblMessageGrid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbCantidad
            // 
            this.lbCantidad.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCantidad.ForeColor = System.Drawing.Color.DarkGray;
            this.lbCantidad.Location = new System.Drawing.Point(579, 7);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(70, 16);
            this.lbCantidad.TabIndex = 17;
            this.lbCantidad.Text = "0";
            this.lbCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(951, 1);
            this.label1.TabIndex = 16;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbTotal.Location = new System.Drawing.Point(870, 7);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(66, 16);
            this.lbTotal.TabIndex = 15;
            this.lbTotal.Text = "Bs. 0.00";
            this.lbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotals
            // 
            this.lblTotals.AutoSize = true;
            this.lblTotals.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotals.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotals.Location = new System.Drawing.Point(6, 7);
            this.lblTotals.Name = "lblTotals";
            this.lblTotals.Size = new System.Drawing.Size(68, 16);
            this.lblTotals.TabIndex = 14;
            this.lblTotals.Text = "0, Items";
            // 
            // panelControles
            // 
            this.panelControles.Controls.Add(this.chkDeudaInicial);
            this.panelControles.Controls.Add(this.txMontoDeuda);
            this.panelControles.Controls.Add(this.btnAddDeuda);
            this.panelControles.Controls.Add(this.chkComision);
            this.panelControles.Controls.Add(this.btnGuardar);
            this.panelControles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControles.Location = new System.Drawing.Point(385, 530);
            this.panelControles.Name = "panelControles";
            this.panelControles.Size = new System.Drawing.Size(965, 97);
            this.panelControles.TabIndex = 6;
            // 
            // chkDeudaInicial
            // 
            this.chkDeudaInicial.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkDeudaInicial.AutoSize = true;
            this.chkDeudaInicial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkDeudaInicial.FlatAppearance.BorderSize = 0;
            this.chkDeudaInicial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.chkDeudaInicial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.chkDeudaInicial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkDeudaInicial.Font = new System.Drawing.Font("Verdana", 10F);
            this.chkDeudaInicial.Image = ((System.Drawing.Image)(resources.GetObject("chkDeudaInicial.Image")));
            this.chkDeudaInicial.ImageChecking = ((System.Drawing.Image)(resources.GetObject("chkDeudaInicial.ImageChecking")));
            this.chkDeudaInicial.ImageUnChecking = ((System.Drawing.Image)(resources.GetObject("chkDeudaInicial.ImageUnChecking")));
            this.chkDeudaInicial.Location = new System.Drawing.Point(4, 6);
            this.chkDeudaInicial.Name = "chkDeudaInicial";
            this.chkDeudaInicial.Size = new System.Drawing.Size(124, 27);
            this.chkDeudaInicial.TabIndex = 11;
            this.chkDeudaInicial.Text = "Deuda Inicial";
            this.chkDeudaInicial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkDeudaInicial.UseVisualStyleBackColor = true;
            this.chkDeudaInicial.CheckedChanged += new System.EventHandler(this.chkDeudaInicial_CheckedChanged);
            // 
            // txMontoDeuda
            // 
            this.txMontoDeuda.AlignText = System.Windows.Forms.HorizontalAlignment.Left;
            this.txMontoDeuda.BackColor = System.Drawing.Color.White;
            this.txMontoDeuda.Category = '\0';
            this.txMontoDeuda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txMontoDeuda.ColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.txMontoDeuda.ColorLine = System.Drawing.Color.Gray;
            this.txMontoDeuda.ColorText = System.Drawing.SystemColors.WindowText;
            this.txMontoDeuda.ColorTitle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txMontoDeuda.DockIcon = System.Windows.Forms.DockStyle.Left;
            this.txMontoDeuda.Error = "";
            this.txMontoDeuda.FontText = new System.Drawing.Font("Verdana", 10F);
            this.txMontoDeuda.FontTitle = new System.Drawing.Font("Verdana", 9F);
            this.txMontoDeuda.FormatLogin = false;
            this.txMontoDeuda.ImageIcon = null;
            this.txMontoDeuda.Info = "";
            this.txMontoDeuda.Location = new System.Drawing.Point(106, 28);
            this.txMontoDeuda.MaterialStyle = false;
            this.txMontoDeuda.MaxLength = 32767;
            this.txMontoDeuda.MultiLineText = false;
            this.txMontoDeuda.Name = "txMontoDeuda";
            this.txMontoDeuda.PasswordChar = '\0';
            this.txMontoDeuda.Placeholder = "";
            this.txMontoDeuda.ReadOnly = false;
            this.txMontoDeuda.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txMontoDeuda.Size = new System.Drawing.Size(130, 53);
            this.txMontoDeuda.SizeLine = 2;
            this.txMontoDeuda.TabIndex = 10;
            this.txMontoDeuda.Text = "00.00";
            this.txMontoDeuda.Title = "Bs.";
            this.txMontoDeuda.Visible = false;
            this.txMontoDeuda.VisibleIcon = true;
            this.txMontoDeuda.VisibleTitle = true;
            // 
            // btnAddDeuda
            // 
            this.btnAddDeuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.btnAddDeuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddDeuda.FlatAppearance.BorderSize = 0;
            this.btnAddDeuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDeuda.Font = new System.Drawing.Font("Verdana", 10F);
            this.btnAddDeuda.ForeColor = System.Drawing.Color.White;
            this.btnAddDeuda.Location = new System.Drawing.Point(242, 32);
            this.btnAddDeuda.Name = "btnAddDeuda";
            this.btnAddDeuda.Size = new System.Drawing.Size(113, 34);
            this.btnAddDeuda.TabIndex = 9;
            this.btnAddDeuda.Text = "Añadir Deuda";
            this.btnAddDeuda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddDeuda.UseVisualStyleBackColor = false;
            this.btnAddDeuda.Visible = false;
            this.btnAddDeuda.Click += new System.EventHandler(this.btnAddDeuda_Click);
            // 
            // chkComision
            // 
            this.chkComision.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkComision.AutoSize = true;
            this.chkComision.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkComision.FlatAppearance.BorderSize = 0;
            this.chkComision.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.chkComision.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.chkComision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkComision.Font = new System.Drawing.Font("Verdana", 10F);
            this.chkComision.Image = ((System.Drawing.Image)(resources.GetObject("chkComision.Image")));
            this.chkComision.ImageChecking = ((System.Drawing.Image)(resources.GetObject("chkComision.ImageChecking")));
            this.chkComision.ImageUnChecking = ((System.Drawing.Image)(resources.GetObject("chkComision.ImageUnChecking")));
            this.chkComision.Location = new System.Drawing.Point(478, 32);
            this.chkComision.Name = "chkComision";
            this.chkComision.Size = new System.Drawing.Size(100, 27);
            this.chkComision.TabIndex = 8;
            this.chkComision.Text = "Comision";
            this.chkComision.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkComision.UseVisualStyleBackColor = true;
            this.chkComision.CheckedChanged += new System.EventHandler(this.customCheck1_CheckedChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Verdana", 10F);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(598, 24);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(168, 42);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar Venta";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbCedula);
            this.panel1.Controls.Add(this.txCliente);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(385, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(965, 85);
            this.panel1.TabIndex = 7;
            // 
            // cbCedula
            // 
            this.cbCedula.BackColor = System.Drawing.Color.White;
            this.cbCedula.Category = '\0';
            this.cbCedula.ColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.cbCedula.ColorLine = System.Drawing.Color.Gray;
            this.cbCedula.ColorText = System.Drawing.SystemColors.WindowText;
            this.cbCedula.ColorTitle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbCedula.DisplayMember = "";
            this.cbCedula.DockIcon = System.Windows.Forms.DockStyle.Left;
            this.cbCedula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCedula.Error = "";
            this.cbCedula.FontText = new System.Drawing.Font("Verdana", 10F);
            this.cbCedula.FontTitle = new System.Drawing.Font("Verdana", 9F);
            this.cbCedula.ImageIcon = ((System.Drawing.Image)(resources.GetObject("cbCedula.ImageIcon")));
            this.cbCedula.Info = "";
            this.cbCedula.Location = new System.Drawing.Point(22, 9);
            this.cbCedula.MaterialStyle = true;
            this.cbCedula.Name = "cbCedula";
            this.cbCedula.Placeholder = "Tipo de cedula";
            this.cbCedula.SelectedIndex = -1;
            this.cbCedula.Size = new System.Drawing.Size(278, 68);
            this.cbCedula.SizeLine = 2;
            this.cbCedula.TabIndex = 2;
            this.cbCedula.Title = "Tipo de cedula";
            this.cbCedula.ValueMember = "";
            this.cbCedula.VisibleIcon = false;
            this.cbCedula.VisibleTitle = false;
            // 
            // txCliente
            // 
            this.txCliente.AlignText = System.Windows.Forms.HorizontalAlignment.Left;
            this.txCliente.BackColor = System.Drawing.Color.White;
            this.txCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txCliente.ColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.txCliente.ColorLine = System.Drawing.Color.Gray;
            this.txCliente.ColorText = System.Drawing.SystemColors.WindowText;
            this.txCliente.ColorTitle = System.Drawing.Color.Gray;
            this.txCliente.DockIcon = System.Windows.Forms.DockStyle.Left;
            this.txCliente.FontText = new System.Drawing.Font("Verdana", 10F);
            this.txCliente.FontTitle = new System.Drawing.Font("Verdana", 9F);
            this.txCliente.ImageIcon = ((System.Drawing.Image)(resources.GetObject("txCliente.ImageIcon")));
            this.txCliente.Location = new System.Drawing.Point(300, 19);
            this.txCliente.MaterialStyle = true;
            this.txCliente.MaxLength = 32767;
            this.txCliente.MultiLineText = false;
            this.txCliente.Name = "txCliente";
            this.txCliente.ObjectArray = null;
            this.txCliente.PasswordChar = '\0';
            this.txCliente.Placeholder = "Ingresa la Cedula del Cliente, pulsa enter para comprobarla y click en el icono p" +
    "ara limpiar.";
            this.txCliente.PlaceHolderHeight = 18;
            this.txCliente.ReadOnly = false;
            this.txCliente.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txCliente.Size = new System.Drawing.Size(653, 44);
            this.txCliente.SizeLine = 2;
            this.txCliente.StringArray = null;
            this.txCliente.TabIndex = 1;
            this.txCliente.TextId = "";
            this.txCliente.Title = "Ingresa la Cedula del Cliente, pulsa enter para comprobarla y click en el icono p" +
    "ara limpiar.";
            this.txCliente.VisibleIcon = true;
            this.txCliente.VisibleTitle = false;
            this.txCliente.KeyDown += new System.EventHandler<System.Windows.Forms.KeyEventArgs>(this.txCliente_KeyDown);
            this.txCliente.KeyPress += new System.EventHandler<System.Windows.Forms.KeyPressEventArgs>(this.txCliente_KeyPress);
            this.txCliente.ButtonClick += new System.EventHandler(this.txCliente_ButtonClick);
            // 
            // panelItems
            // 
            this.panelItems.Controls.Add(this.flowCart);
            this.panelItems.Controls.Add(this.pnelBuscador);
            this.panelItems.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelItems.Location = new System.Drawing.Point(0, 0);
            this.panelItems.Name = "panelItems";
            this.panelItems.Size = new System.Drawing.Size(385, 627);
            this.panelItems.TabIndex = 8;
            // 
            // flowCart
            // 
            this.flowCart.AutoScroll = true;
            this.flowCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowCart.Location = new System.Drawing.Point(0, 63);
            this.flowCart.Name = "flowCart";
            this.flowCart.Size = new System.Drawing.Size(385, 564);
            this.flowCart.TabIndex = 2;
            // 
            // pnelBuscador
            // 
            this.pnelBuscador.Controls.Add(this.txFiltro);
            this.pnelBuscador.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnelBuscador.Location = new System.Drawing.Point(0, 0);
            this.pnelBuscador.Name = "pnelBuscador";
            this.pnelBuscador.Size = new System.Drawing.Size(385, 63);
            this.pnelBuscador.TabIndex = 1;
            // 
            // txFiltro
            // 
            this.txFiltro.AlignText = System.Windows.Forms.HorizontalAlignment.Left;
            this.txFiltro.BackColor = System.Drawing.Color.White;
            this.txFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txFiltro.ColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.txFiltro.ColorLine = System.Drawing.Color.Gray;
            this.txFiltro.ColorText = System.Drawing.SystemColors.WindowText;
            this.txFiltro.ColorTitle = System.Drawing.Color.Gray;
            this.txFiltro.DockIcon = System.Windows.Forms.DockStyle.Right;
            this.txFiltro.FontText = new System.Drawing.Font("Verdana", 10F);
            this.txFiltro.FontTitle = new System.Drawing.Font("Verdana", 9F);
            this.txFiltro.ImageIcon = ((System.Drawing.Image)(resources.GetObject("txFiltro.ImageIcon")));
            this.txFiltro.Location = new System.Drawing.Point(12, 6);
            this.txFiltro.MaterialStyle = true;
            this.txFiltro.MaxLength = 32767;
            this.txFiltro.MultiLineText = false;
            this.txFiltro.Name = "txFiltro";
            this.txFiltro.ObjectArray = null;
            this.txFiltro.PasswordChar = '\0';
            this.txFiltro.Placeholder = "Buscar por producto...";
            this.txFiltro.PlaceHolderHeight = 18;
            this.txFiltro.ReadOnly = false;
            this.txFiltro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txFiltro.Size = new System.Drawing.Size(370, 44);
            this.txFiltro.SizeLine = 2;
            this.txFiltro.StringArray = null;
            this.txFiltro.TabIndex = 0;
            this.txFiltro.TextId = "";
            this.txFiltro.Title = "Buscar por producto...";
            this.txFiltro.VisibleIcon = true;
            this.txFiltro.VisibleTitle = false;
            this.txFiltro.KeyDown += new System.EventHandler<System.Windows.Forms.KeyEventArgs>(this.txFiltro_KeyDown);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(385, 85);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(965, 445);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panelCanastilla);
            this.tabPage1.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(957, 418);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Carro de Productos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.grdDetalle);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(0, 106);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Productos Vendidos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // grdDetalle
            // 
            this.grdDetalle.AllowUserToAddRows = false;
            this.grdDetalle.AllowUserToDeleteRows = false;
            this.grdDetalle.AllowUserToResizeRows = false;
            this.grdDetalle.BackgroundColor = System.Drawing.Color.White;
            this.grdDetalle.BodyFont = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdDetalle.BodyForeColor = System.Drawing.SystemColors.ControlText;
            this.grdDetalle.BodySelectColor = System.Drawing.Color.LimeGreen;
            this.grdDetalle.BodySelectForeColor = System.Drawing.SystemColors.ControlText;
            this.grdDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdDetalle.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.grdDetalle.CellStyleBackColor = System.Drawing.Color.ForestGreen;
            this.grdDetalle.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.grdDetalle.ColumnHeadersHeight = 34;
            this.grdDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdDetalle.DefaultCellStyle = dataGridViewCellStyle8;
            this.grdDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDetalle.EnableBottomDown = false;
            this.grdDetalle.EnableBottomLeft = false;
            this.grdDetalle.EnableBottomRight = false;
            this.grdDetalle.EnableBottomUp = false;
            this.grdDetalle.EnableHeadersVisualStyles = false;
            this.grdDetalle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.grdDetalle.HeaderColor = System.Drawing.SystemColors.Control;
            this.grdDetalle.HeaderFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdDetalle.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grdDetalle.Location = new System.Drawing.Point(3, 3);
            this.grdDetalle.MultiSelect = false;
            this.grdDetalle.Name = "grdDetalle";
            this.grdDetalle.ReadOnly = true;
            this.grdDetalle.RowHeadersVisible = false;
            this.grdDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDetalle.Size = new System.Drawing.Size(0, 100);
            this.grdDetalle.TabIndex = 14;
            this.grdDetalle.TabStop = false;
            // 
            // frmAbrirVentaModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 720);
            this.Name = "frmAbrirVentaModal";
            this.Text = "frmAbrirVentaModal";
            this.Load += new System.EventHandler(this.frmAbrirVentaModal_Load);
            this.Contenedor.ResumeLayout(false);
            this.Body.ResumeLayout(false);
            this.Footer.ResumeLayout(false);
            this.Header.ResumeLayout(false);
            this.panelCanastilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCanastilla)).EndInit();
            this.panlTotals.ResumeLayout(false);
            this.panlTotals.PerformLayout();
            this.panelControles.ResumeLayout(false);
            this.panelControles.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelItems.ResumeLayout(false);
            this.pnelBuscador.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCanastilla;
        private System.Windows.Forms.Panel panlTotals;
        private System.Windows.Forms.Label lbTotalDolares;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMessageGrid;
        private System.Windows.Forms.Label lbCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lblTotals;
        private System.Windows.Forms.Panel panelControles;
        private Autonomo.CustomControls.CustomButton btnGuardar;
        private System.Windows.Forms.Panel panel1;
        private Autonomo.CustomControls.FlatFindText txCliente;
        private System.Windows.Forms.Panel panelItems;
        private System.Windows.Forms.FlowLayoutPanel flowCart;
        private System.Windows.Forms.Panel pnelBuscador;
        private Autonomo.CustomControls.FlatFindText txFiltro;
        private Autonomo.CustomControls.CustomGrid grdCanastilla;
        private System.Windows.Forms.Label lbTasa;
        private Autonomo.CustomControls.FlatComboBox cbCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn IVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private Autonomo.CustomControls.CustomCheck chkComision;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Autonomo.CustomControls.CustomGrid grdDetalle;
        private Autonomo.CustomControls.CustomButton btnAddDeuda;
        private Autonomo.CustomControls.CustomCheck chkDeudaInicial;
        private Autonomo.CustomControls.FlatTextBox txMontoDeuda;
    }
}