namespace MampoteSystem.Windows.Modulo.Compras
{
    partial class frmCompraModal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompraModal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelItems = new System.Windows.Forms.Panel();
            this.flowCart = new System.Windows.Forms.FlowLayoutPanel();
            this.pnelBuscador = new System.Windows.Forms.Panel();
            this.txFiltro = new Autonomo.CustomControls.FlatFindText();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txProveedor = new Autonomo.CustomControls.FlatFindText();
            this.panelControles = new System.Windows.Forms.Panel();
            this.txNumeroFactura = new Autonomo.CustomControls.FlatTextBox();
            this.txTasa = new Autonomo.CustomControls.FlatTextBox();
            this.btnGuardar = new Autonomo.CustomControls.CustomButton();
            this.panelCanastilla = new System.Windows.Forms.Panel();
            this.panlTotals = new System.Windows.Forms.Panel();
            this.lbTotalDolares = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMessageGrid = new System.Windows.Forms.Label();
            this.lbCantidad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lblTotals = new System.Windows.Forms.Label();
            this.grdCanastilla = new Autonomo.CustomControls.CustomGrid();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contenedor.SuspendLayout();
            this.Body.SuspendLayout();
            this.Footer.SuspendLayout();
            this.Header.SuspendLayout();
            this.panelItems.SuspendLayout();
            this.pnelBuscador.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelControles.SuspendLayout();
            this.panelCanastilla.SuspendLayout();
            this.panlTotals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCanastilla)).BeginInit();
            this.SuspendLayout();
            // 
            // Contenedor
            // 
            this.Contenedor.Size = new System.Drawing.Size(1350, 720);
            // 
            // Body
            // 
            this.Body.Controls.Add(this.panelCanastilla);
            this.Body.Controls.Add(this.panelControles);
            this.Body.Controls.Add(this.panel1);
            this.Body.Controls.Add(this.panelItems);
            this.Body.Size = new System.Drawing.Size(1350, 669);
            // 
            // Footer
            // 
            this.Footer.Location = new System.Drawing.Point(0, 710);
            this.Footer.Size = new System.Drawing.Size(1350, 10);
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
            // panelItems
            // 
            this.panelItems.Controls.Add(this.flowCart);
            this.panelItems.Controls.Add(this.pnelBuscador);
            this.panelItems.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelItems.Location = new System.Drawing.Point(0, 0);
            this.panelItems.Name = "panelItems";
            this.panelItems.Size = new System.Drawing.Size(385, 669);
            this.panelItems.TabIndex = 1;
            // 
            // flowCart
            // 
            this.flowCart.AutoScroll = true;
            this.flowCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowCart.Location = new System.Drawing.Point(0, 63);
            this.flowCart.Name = "flowCart";
            this.flowCart.Size = new System.Drawing.Size(385, 606);
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
            this.txFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.txProveedor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(385, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(965, 64);
            this.panel1.TabIndex = 2;
            // 
            // txProveedor
            // 
            this.txProveedor.AlignText = System.Windows.Forms.HorizontalAlignment.Left;
            this.txProveedor.BackColor = System.Drawing.Color.White;
            this.txProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txProveedor.ColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.txProveedor.ColorLine = System.Drawing.Color.Gray;
            this.txProveedor.ColorText = System.Drawing.SystemColors.WindowText;
            this.txProveedor.ColorTitle = System.Drawing.Color.Gray;
            this.txProveedor.DockIcon = System.Windows.Forms.DockStyle.Left;
            this.txProveedor.FontText = new System.Drawing.Font("Verdana", 10F);
            this.txProveedor.FontTitle = new System.Drawing.Font("Verdana", 9F);
            this.txProveedor.ImageIcon = ((System.Drawing.Image)(resources.GetObject("txProveedor.ImageIcon")));
            this.txProveedor.Location = new System.Drawing.Point(43, 6);
            this.txProveedor.MaterialStyle = true;
            this.txProveedor.MaxLength = 32767;
            this.txProveedor.MultiLineText = false;
            this.txProveedor.Name = "txProveedor";
            this.txProveedor.ObjectArray = null;
            this.txProveedor.PasswordChar = '\0';
            this.txProveedor.Placeholder = "Ingresa el RIF del Proveedor, pulsa enter para comprobar RIF y click en el icono " +
    "para limpiar.";
            this.txProveedor.PlaceHolderHeight = 18;
            this.txProveedor.ReadOnly = false;
            this.txProveedor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txProveedor.Size = new System.Drawing.Size(685, 44);
            this.txProveedor.SizeLine = 2;
            this.txProveedor.StringArray = null;
            this.txProveedor.TabIndex = 1;
            this.txProveedor.TextId = "";
            this.txProveedor.Title = "Ingresa el RIF del Proveedor, pulsa enter para comprobar RIF y click en el icono " +
    "para limpiar.";
            this.txProveedor.VisibleIcon = true;
            this.txProveedor.VisibleTitle = false;
            this.txProveedor.KeyDown += new System.EventHandler<System.Windows.Forms.KeyEventArgs>(this.txProveedor_KeyDown);
            this.txProveedor.KeyPress += new System.EventHandler<System.Windows.Forms.KeyPressEventArgs>(this.txProveedor_KeyPress);
            this.txProveedor.ButtonClick += new System.EventHandler(this.txProveedor_ButtonClick);
            // 
            // panelControles
            // 
            this.panelControles.Controls.Add(this.txNumeroFactura);
            this.panelControles.Controls.Add(this.txTasa);
            this.panelControles.Controls.Add(this.btnGuardar);
            this.panelControles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControles.Location = new System.Drawing.Point(385, 572);
            this.panelControles.Name = "panelControles";
            this.panelControles.Size = new System.Drawing.Size(965, 97);
            this.panelControles.TabIndex = 3;
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
            this.txNumeroFactura.Location = new System.Drawing.Point(202, 29);
            this.txNumeroFactura.MaterialStyle = true;
            this.txNumeroFactura.MaxLength = 16;
            this.txNumeroFactura.MultiLineText = false;
            this.txNumeroFactura.Name = "txNumeroFactura";
            this.txNumeroFactura.PasswordChar = '\0';
            this.txNumeroFactura.Placeholder = "Numero de Factura";
            this.txNumeroFactura.ReadOnly = false;
            this.txNumeroFactura.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txNumeroFactura.Size = new System.Drawing.Size(179, 62);
            this.txNumeroFactura.SizeLine = 2;
            this.txNumeroFactura.TabIndex = 10;
            this.txNumeroFactura.Title = "Numero de Factura";
            this.txNumeroFactura.VisibleIcon = true;
            this.txNumeroFactura.VisibleTitle = false;
            this.txNumeroFactura.KeyPress += new System.EventHandler<System.Windows.Forms.KeyPressEventArgs>(this.txNumeroFactura_KeyPress);
            // 
            // txTasa
            // 
            this.txTasa.AlignText = System.Windows.Forms.HorizontalAlignment.Right;
            this.txTasa.BackColor = System.Drawing.Color.White;
            this.txTasa.Category = '\0';
            this.txTasa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txTasa.ColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.txTasa.ColorLine = System.Drawing.Color.Gray;
            this.txTasa.ColorText = System.Drawing.SystemColors.WindowText;
            this.txTasa.ColorTitle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txTasa.DockIcon = System.Windows.Forms.DockStyle.Right;
            this.txTasa.Error = "";
            this.txTasa.FontText = new System.Drawing.Font("Verdana", 10F);
            this.txTasa.FontTitle = new System.Drawing.Font("Verdana", 9F);
            this.txTasa.FormatLogin = false;
            this.txTasa.ImageIcon = global::MampoteSystem.Windows.Properties.Resources.Us_Dollar_Circled_26px;
            this.txTasa.Info = "";
            this.txTasa.Location = new System.Drawing.Point(9, 29);
            this.txTasa.MaterialStyle = true;
            this.txTasa.MaxLength = 32767;
            this.txTasa.MultiLineText = false;
            this.txTasa.Name = "txTasa";
            this.txTasa.PasswordChar = '\0';
            this.txTasa.Placeholder = "Tasa de Cambio";
            this.txTasa.ReadOnly = false;
            this.txTasa.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txTasa.Size = new System.Drawing.Size(135, 62);
            this.txTasa.SizeLine = 2;
            this.txTasa.TabIndex = 9;
            this.txTasa.Text = "0.00";
            this.txTasa.Title = "Tasa de Cambio";
            this.txTasa.VisibleIcon = true;
            this.txTasa.VisibleTitle = true;
            this.txTasa.TextBoxChanged += new System.EventHandler(this.txTasa_TextBoxChanged);
            this.txTasa.KeyPress += new System.EventHandler<System.Windows.Forms.KeyPressEventArgs>(this.txTasa_KeyPress);
            this.txTasa.Enter += new System.EventHandler(this.txTasa_Enter);
            this.txTasa.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txTasa_MouseClick);
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
            this.btnGuardar.Location = new System.Drawing.Point(573, 40);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(168, 42);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Agregar Compra";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // panelCanastilla
            // 
            this.panelCanastilla.Controls.Add(this.panlTotals);
            this.panelCanastilla.Controls.Add(this.grdCanastilla);
            this.panelCanastilla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCanastilla.Location = new System.Drawing.Point(385, 64);
            this.panelCanastilla.Name = "panelCanastilla";
            this.panelCanastilla.Size = new System.Drawing.Size(965, 508);
            this.panelCanastilla.TabIndex = 4;
            // 
            // panlTotals
            // 
            this.panlTotals.Controls.Add(this.lbTotalDolares);
            this.panlTotals.Controls.Add(this.label2);
            this.panlTotals.Controls.Add(this.lblMessageGrid);
            this.panlTotals.Controls.Add(this.lbCantidad);
            this.panlTotals.Controls.Add(this.label1);
            this.panlTotals.Controls.Add(this.lbTotal);
            this.panlTotals.Controls.Add(this.lblTotals);
            this.panlTotals.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panlTotals.Location = new System.Drawing.Point(0, 425);
            this.panlTotals.Name = "panlTotals";
            this.panlTotals.Size = new System.Drawing.Size(965, 83);
            this.panlTotals.TabIndex = 8;
            // 
            // lbTotalDolares
            // 
            this.lbTotalDolares.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalDolares.ForeColor = System.Drawing.Color.DarkGray;
            this.lbTotalDolares.Location = new System.Drawing.Point(883, 34);
            this.lbTotalDolares.Name = "lbTotalDolares";
            this.lbTotalDolares.Size = new System.Drawing.Size(70, 16);
            this.lbTotalDolares.TabIndex = 21;
            this.lbTotalDolares.Text = "$0.00";
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
            this.lblMessageGrid.Size = new System.Drawing.Size(965, 19);
            this.lblMessageGrid.TabIndex = 18;
            this.lblMessageGrid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbCantidad
            // 
            this.lbCantidad.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCantidad.ForeColor = System.Drawing.Color.DarkGray;
            this.lbCantidad.Location = new System.Drawing.Point(481, 7);
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
            this.label1.Size = new System.Drawing.Size(965, 1);
            this.label1.TabIndex = 16;
            // 
            // lbTotal
            // 
            this.lbTotal.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbTotal.Location = new System.Drawing.Point(886, 7);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(70, 16);
            this.lbTotal.TabIndex = 15;
            this.lbTotal.Text = "0.00";
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
            // grdCanastilla
            // 
            this.grdCanastilla.AllowUserToAddRows = false;
            this.grdCanastilla.AllowUserToDeleteRows = false;
            this.grdCanastilla.AllowUserToResizeRows = false;
            this.grdCanastilla.BackgroundColor = System.Drawing.Color.White;
            this.grdCanastilla.BodyFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.Codigo,
            this.Nombre,
            this.Cantidad,
            this.PrecioCompra,
            this.PrecioVenta,
            this.SubTotal});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdCanastilla.DefaultCellStyle = dataGridViewCellStyle3;
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
            this.grdCanastilla.Size = new System.Drawing.Size(965, 508);
            this.grdCanastilla.TabIndex = 7;
            this.grdCanastilla.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCanastilla_CellContentDoubleClick);
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
            this.Nombre.HeaderText = "Producto";
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
            // PrecioCompra
            // 
            this.PrecioCompra.DataPropertyName = "PrecioCompra";
            this.PrecioCompra.HeaderText = "P. Compra";
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.ReadOnly = true;
            this.PrecioCompra.Width = 120;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.DataPropertyName = "PrecioVenta";
            this.PrecioVenta.HeaderText = "P. Venta";
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
            this.PrecioVenta.Width = 120;
            // 
            // SubTotal
            // 
            this.SubTotal.DataPropertyName = "SubTotal";
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            this.SubTotal.Width = 120;
            // 
            // frmCompraModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 720);
            this.Name = "frmCompraModal";
            this.Text = "frmCompraModal";
            this.Load += new System.EventHandler(this.frmCompraModal_Load);
            this.Contenedor.ResumeLayout(false);
            this.Body.ResumeLayout(false);
            this.Footer.ResumeLayout(false);
            this.Header.ResumeLayout(false);
            this.panelItems.ResumeLayout(false);
            this.pnelBuscador.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelControles.ResumeLayout(false);
            this.panelCanastilla.ResumeLayout(false);
            this.panlTotals.ResumeLayout(false);
            this.panlTotals.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCanastilla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelItems;
        private System.Windows.Forms.FlowLayoutPanel flowCart;
        private System.Windows.Forms.Panel pnelBuscador;
        private Autonomo.CustomControls.FlatFindText txFiltro;
        private System.Windows.Forms.Panel panelCanastilla;
        private System.Windows.Forms.Panel panlTotals;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMessageGrid;
        private System.Windows.Forms.Label lbCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lblTotals;
        private Autonomo.CustomControls.CustomGrid grdCanastilla;
        private System.Windows.Forms.Panel panelControles;
        private Autonomo.CustomControls.CustomButton btnGuardar;
        private System.Windows.Forms.Panel panel1;
        private Autonomo.CustomControls.FlatFindText txProveedor;
        private Autonomo.CustomControls.FlatTextBox txNumeroFactura;
        private Autonomo.CustomControls.FlatTextBox txTasa;
        private System.Windows.Forms.Label lbTotalDolares;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
    }
}