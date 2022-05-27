namespace MampoteSystem.Windows.Modulo.Compras
{
    partial class frmCompra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompra));
            this.grdData = new Autonomo.CustomControls.CustomGrid();
            this.grdDetalle = new Autonomo.CustomControls.CustomGrid();
            this.codigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnProcesar = new Autonomo.CustomControls.CustomButton();
            this.txFilter = new Autonomo.CustomControls.FlatFindText();
            this.dtHasta = new Autonomo.CustomControls.FlatDateTime();
            this.dtDesde = new Autonomo.CustomControls.FlatDateTime();
            this.panelControles = new System.Windows.Forms.Panel();
            this.lbTotalCantidad = new System.Windows.Forms.Label();
            this.lbTotalDolares = new System.Windows.Forms.Label();
            this.lbTasa = new System.Windows.Forms.Label();
            this.lbTotalBs = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbIGVtext = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlContenedor.SuspendLayout();
            this.pnlBottonControl.SuspendLayout();
            this.pnlTopControl.SuspendLayout();
            this.pnlTopButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContenedorDoble)).BeginInit();
            this.ContenedorDoble.Panel1.SuspendLayout();
            this.ContenedorDoble.Panel2.SuspendLayout();
            this.ContenedorDoble.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalle)).BeginInit();
            this.panelControles.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Size = new System.Drawing.Size(930, 544);
            // 
            // pnlBottonControl
            // 
            this.pnlBottonControl.Location = new System.Drawing.Point(0, 512);
            this.pnlBottonControl.Size = new System.Drawing.Size(930, 32);
            // 
            // DescriptionData
            // 
            this.DescriptionData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionData.Location = new System.Drawing.Point(14, 7);
            this.DescriptionData.Size = new System.Drawing.Size(45, 16);
            this.DescriptionData.Text = "Datos";
            // 
            // BottomLine
            // 
            this.BottomLine.Size = new System.Drawing.Size(930, 2);
            // 
            // pnlTopControl
            // 
            this.pnlTopControl.Controls.Add(this.btnProcesar);
            this.pnlTopControl.Controls.Add(this.txFilter);
            this.pnlTopControl.Controls.Add(this.dtHasta);
            this.pnlTopControl.Controls.Add(this.dtDesde);
            this.pnlTopControl.Size = new System.Drawing.Size(930, 123);
            this.pnlTopControl.Controls.SetChildIndex(this.TopLine, 0);
            this.pnlTopControl.Controls.SetChildIndex(this.Title, 0);
            this.pnlTopControl.Controls.SetChildIndex(this.pnlTopButton, 0);
            this.pnlTopControl.Controls.SetChildIndex(this.dtDesde, 0);
            this.pnlTopControl.Controls.SetChildIndex(this.dtHasta, 0);
            this.pnlTopControl.Controls.SetChildIndex(this.txFilter, 0);
            this.pnlTopControl.Controls.SetChildIndex(this.btnProcesar, 0);
            // 
            // pnlTopButton
            // 
            this.pnlTopButton.Location = new System.Drawing.Point(0, 86);
            this.pnlTopButton.Size = new System.Drawing.Size(930, 35);
            // 
            // btnCommand3
            // 
            this.btnCommand3.FlatAppearance.BorderSize = 0;
            this.btnCommand3.Size = new System.Drawing.Size(104, 35);
            // 
            // btnCommand2
            // 
            this.btnCommand2.FlatAppearance.BorderSize = 0;
            this.btnCommand2.Size = new System.Drawing.Size(104, 35);
            // 
            // btnCommand1
            // 
            this.btnCommand1.FlatAppearance.BorderSize = 0;
            this.btnCommand1.Size = new System.Drawing.Size(104, 35);
            // 
            // btnExportar
            // 
            this.btnExportar.FlatAppearance.BorderSize = 0;
            this.btnExportar.Size = new System.Drawing.Size(104, 35);
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.Size = new System.Drawing.Size(93, 35);
            this.btnEliminar.Visible = false;
            // 
            // btnEditar
            // 
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.Size = new System.Drawing.Size(83, 35);
            this.btnEditar.Visible = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.Size = new System.Drawing.Size(83, 35);
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // Title
            // 
            this.Title.Size = new System.Drawing.Size(192, 18);
            this.Title.Text = "Registro de Compras";
            // 
            // TopLine
            // 
            this.TopLine.Location = new System.Drawing.Point(0, 121);
            this.TopLine.Size = new System.Drawing.Size(930, 2);
            // 
            // ContenedorDoble
            // 
            this.ContenedorDoble.Location = new System.Drawing.Point(0, 123);
            // 
            // ContenedorDoble.Panel1
            // 
            this.ContenedorDoble.Panel1.Controls.Add(this.grdData);
            // 
            // ContenedorDoble.Panel2
            // 
            this.ContenedorDoble.Panel2.Controls.Add(this.panelControles);
            this.ContenedorDoble.Panel2.Controls.Add(this.grdDetalle);
            this.ContenedorDoble.Size = new System.Drawing.Size(930, 389);
            this.ContenedorDoble.SplitterDistance = 423;
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
            this.grdData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.grdData.CellStyleBackColor = System.Drawing.SystemColors.Window;
            this.grdData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grdData.ColumnHeadersHeight = 34;
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdData.DefaultCellStyle = dataGridViewCellStyle6;
            this.grdData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdData.EnableBottomDown = false;
            this.grdData.EnableBottomLeft = false;
            this.grdData.EnableBottomRight = false;
            this.grdData.EnableBottomUp = false;
            this.grdData.EnableHeadersVisualStyles = false;
            this.grdData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.grdData.HeaderColor = System.Drawing.SystemColors.Control;
            this.grdData.HeaderFont = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdData.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grdData.Location = new System.Drawing.Point(0, 0);
            this.grdData.MultiSelect = false;
            this.grdData.Name = "grdData";
            this.grdData.ReadOnly = true;
            this.grdData.RowHeadersVisible = false;
            this.grdData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdData.Size = new System.Drawing.Size(423, 389);
            this.grdData.TabIndex = 7;
            this.grdData.TabStop = false;
            this.grdData.SelectionChanged += new System.EventHandler(this.grdData_SelectionChanged);
            // 
            // grdDetalle
            // 
            this.grdDetalle.AllowUserToAddRows = false;
            this.grdDetalle.AllowUserToDeleteRows = false;
            this.grdDetalle.AllowUserToResizeRows = false;
            this.grdDetalle.BackgroundColor = System.Drawing.Color.PaleGreen;
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
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.grdDetalle.ColumnHeadersHeight = 34;
            this.grdDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoProducto,
            this.Nombre,
            this.Cantidad,
            this.Precio_Compra,
            this.SubTotal});
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
            this.grdDetalle.HeaderFont = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdDetalle.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grdDetalle.Location = new System.Drawing.Point(0, 0);
            this.grdDetalle.MultiSelect = false;
            this.grdDetalle.Name = "grdDetalle";
            this.grdDetalle.ReadOnly = true;
            this.grdDetalle.RowHeadersVisible = false;
            this.grdDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDetalle.Size = new System.Drawing.Size(503, 389);
            this.grdDetalle.TabIndex = 9;
            this.grdDetalle.TabStop = false;
            // 
            // codigoProducto
            // 
            this.codigoProducto.DataPropertyName = "codigoProducto";
            this.codigoProducto.HeaderText = "Código";
            this.codigoProducto.Name = "codigoProducto";
            this.codigoProducto.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Producto";
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
            // Precio_Compra
            // 
            this.Precio_Compra.DataPropertyName = "Precio_Compra";
            this.Precio_Compra.HeaderText = "Precio de Compra Bs.";
            this.Precio_Compra.Name = "Precio_Compra";
            this.Precio_Compra.ReadOnly = true;
            // 
            // SubTotal
            // 
            this.SubTotal.DataPropertyName = "SubTotal";
            this.SubTotal.HeaderText = "Sub. Total";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            // 
            // btnProcesar
            // 
            this.btnProcesar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProcesar.FlatAppearance.BorderSize = 0;
            this.btnProcesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcesar.Font = new System.Drawing.Font("Verdana", 10F);
            this.btnProcesar.Image = ((System.Drawing.Image)(resources.GetObject("btnProcesar.Image")));
            this.btnProcesar.Location = new System.Drawing.Point(291, 30);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(56, 46);
            this.btnProcesar.TabIndex = 15;
            this.btnProcesar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // txFilter
            // 
            this.txFilter.AlignText = System.Windows.Forms.HorizontalAlignment.Left;
            this.txFilter.BackColor = System.Drawing.Color.White;
            this.txFilter.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txFilter.ColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.txFilter.ColorLine = System.Drawing.Color.Gray;
            this.txFilter.ColorText = System.Drawing.SystemColors.WindowText;
            this.txFilter.ColorTitle = System.Drawing.Color.Gray;
            this.txFilter.DockIcon = System.Windows.Forms.DockStyle.Right;
            this.txFilter.FontText = new System.Drawing.Font("Verdana", 10F);
            this.txFilter.FontTitle = new System.Drawing.Font("Verdana", 9F);
            this.txFilter.ImageIcon = null;
            this.txFilter.Location = new System.Drawing.Point(349, 32);
            this.txFilter.MaterialStyle = true;
            this.txFilter.MaxLength = 32767;
            this.txFilter.MultiLineText = false;
            this.txFilter.Name = "txFilter";
            this.txFilter.ObjectArray = null;
            this.txFilter.PasswordChar = '\0';
            this.txFilter.Placeholder = "Buscar por proveedor";
            this.txFilter.PlaceHolderHeight = 18;
            this.txFilter.ReadOnly = false;
            this.txFilter.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txFilter.Size = new System.Drawing.Size(278, 44);
            this.txFilter.SizeLine = 2;
            this.txFilter.StringArray = null;
            this.txFilter.TabIndex = 16;
            this.txFilter.TextId = "";
            this.txFilter.Title = "Buscar por proveedor";
            this.txFilter.VisibleIcon = true;
            this.txFilter.VisibleTitle = false;
            this.txFilter.TextBoxChanged += new System.EventHandler(this.txFilter_TextBoxChanged);
            // 
            // dtHasta
            // 
            this.dtHasta.BackColor = System.Drawing.Color.White;
            this.dtHasta.Category = '\0';
            this.dtHasta.ColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.dtHasta.ColorLine = System.Drawing.Color.Gray;
            this.dtHasta.ColorText = System.Drawing.SystemColors.WindowText;
            this.dtHasta.ColorTitle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtHasta.DateSeparatorFormat = '/';
            this.dtHasta.DockIcon = System.Windows.Forms.DockStyle.Left;
            this.dtHasta.Error = "";
            this.dtHasta.FontText = new System.Drawing.Font("Verdana", 10F);
            this.dtHasta.FontTitle = new System.Drawing.Font("Verdana", 9F);
            this.dtHasta.Format = Autonomo.CustomControls.HelperControl.FormatDate.Short;
            this.dtHasta.ImageIcon = null;
            this.dtHasta.Info = "";
            this.dtHasta.Location = new System.Drawing.Point(152, 34);
            this.dtHasta.MaterialStyle = false;
            this.dtHasta.Name = "dtHasta";
            this.dtHasta.Placeholder = "";
            this.dtHasta.Size = new System.Drawing.Size(133, 46);
            this.dtHasta.SizeLine = 2;
            this.dtHasta.TabIndex = 14;
            this.dtHasta.Text = "21/06/2021";
            this.dtHasta.Title = "Fecha final";
            this.dtHasta.Value = new System.DateTime(2021, 6, 21, 1, 21, 23, 610);
            this.dtHasta.VisibleIcon = false;
            this.dtHasta.VisibleTitle = true;
            // 
            // dtDesde
            // 
            this.dtDesde.BackColor = System.Drawing.Color.White;
            this.dtDesde.Category = '\0';
            this.dtDesde.ColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.dtDesde.ColorLine = System.Drawing.Color.Gray;
            this.dtDesde.ColorText = System.Drawing.SystemColors.WindowText;
            this.dtDesde.ColorTitle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtDesde.DateSeparatorFormat = '/';
            this.dtDesde.DockIcon = System.Windows.Forms.DockStyle.Left;
            this.dtDesde.Error = "";
            this.dtDesde.FontText = new System.Drawing.Font("Verdana", 10F);
            this.dtDesde.FontTitle = new System.Drawing.Font("Verdana", 9F);
            this.dtDesde.Format = Autonomo.CustomControls.HelperControl.FormatDate.Short;
            this.dtDesde.ImageIcon = null;
            this.dtDesde.Info = "";
            this.dtDesde.Location = new System.Drawing.Point(13, 34);
            this.dtDesde.MaterialStyle = false;
            this.dtDesde.Name = "dtDesde";
            this.dtDesde.Placeholder = "";
            this.dtDesde.Size = new System.Drawing.Size(133, 46);
            this.dtDesde.SizeLine = 2;
            this.dtDesde.TabIndex = 13;
            this.dtDesde.Text = "21/06/2021";
            this.dtDesde.Title = "Fecha inicial";
            this.dtDesde.Value = new System.DateTime(2021, 6, 21, 1, 21, 23, 610);
            this.dtDesde.VisibleIcon = false;
            this.dtDesde.VisibleTitle = true;
            // 
            // panelControles
            // 
            this.panelControles.BackColor = System.Drawing.Color.Gainsboro;
            this.panelControles.Controls.Add(this.lbTotalCantidad);
            this.panelControles.Controls.Add(this.lbTotalDolares);
            this.panelControles.Controls.Add(this.lbTasa);
            this.panelControles.Controls.Add(this.lbTotalBs);
            this.panelControles.Controls.Add(this.label7);
            this.panelControles.Controls.Add(this.lbIGVtext);
            this.panelControles.Controls.Add(this.label5);
            this.panelControles.Controls.Add(this.label4);
            this.panelControles.Controls.Add(this.label3);
            this.panelControles.Controls.Add(this.label2);
            this.panelControles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControles.Location = new System.Drawing.Point(0, 257);
            this.panelControles.Name = "panelControles";
            this.panelControles.Size = new System.Drawing.Size(503, 132);
            this.panelControles.TabIndex = 10;
            // 
            // lbTotalCantidad
            // 
            this.lbTotalCantidad.AutoSize = true;
            this.lbTotalCantidad.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalCantidad.Location = new System.Drawing.Point(284, 31);
            this.lbTotalCantidad.Name = "lbTotalCantidad";
            this.lbTotalCantidad.Size = new System.Drawing.Size(99, 16);
            this.lbTotalCantidad.TabIndex = 9;
            this.lbTotalCantidad.Text = ":  0 unidades";
            // 
            // lbTotalDolares
            // 
            this.lbTotalDolares.AutoSize = true;
            this.lbTotalDolares.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalDolares.Location = new System.Drawing.Point(283, 110);
            this.lbTotalDolares.Name = "lbTotalDolares";
            this.lbTotalDolares.Size = new System.Drawing.Size(65, 16);
            this.lbTotalDolares.TabIndex = 8;
            this.lbTotalDolares.Text = ":  $ 0.00";
            // 
            // lbTasa
            // 
            this.lbTasa.AutoSize = true;
            this.lbTasa.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTasa.Location = new System.Drawing.Point(284, 92);
            this.lbTasa.Name = "lbTasa";
            this.lbTasa.Size = new System.Drawing.Size(65, 16);
            this.lbTasa.TabIndex = 7;
            this.lbTasa.Text = ":  $ 0.00";
            // 
            // lbTotalBs
            // 
            this.lbTotalBs.AutoSize = true;
            this.lbTotalBs.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalBs.Location = new System.Drawing.Point(284, 74);
            this.lbTotalBs.Name = "lbTotalBs";
            this.lbTotalBs.Size = new System.Drawing.Size(79, 16);
            this.lbTotalBs.TabIndex = 6;
            this.lbTotalBs.Text = ":  Bs. 0.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(5, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(209, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Total de Productos Comprados";
            // 
            // lbIGVtext
            // 
            this.lbIGVtext.AutoSize = true;
            this.lbIGVtext.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIGVtext.ForeColor = System.Drawing.Color.DimGray;
            this.lbIGVtext.Location = new System.Drawing.Point(4, 110);
            this.lbIGVtext.Name = "lbIGVtext";
            this.lbIGVtext.Size = new System.Drawing.Size(165, 16);
            this.lbIGVtext.TabIndex = 4;
            this.lbIGVtext.Text = "Total de la Compra en $";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(5, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tasa de Cambio de la Compra $";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(5, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Total de la Compra Bs.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Resumen Facturación";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(503, 1);
            this.label2.TabIndex = 0;
            // 
            // frmCompra
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(930, 544);
            this.Name = "frmCompra";
            this.Text = "frmCompra";
            this.Load += new System.EventHandler(this.frmCompra_Load);
            this.pnlContenedor.ResumeLayout(false);
            this.pnlBottonControl.ResumeLayout(false);
            this.pnlBottonControl.PerformLayout();
            this.pnlTopControl.ResumeLayout(false);
            this.pnlTopControl.PerformLayout();
            this.pnlTopButton.ResumeLayout(false);
            this.ContenedorDoble.Panel1.ResumeLayout(false);
            this.ContenedorDoble.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ContenedorDoble)).EndInit();
            this.ContenedorDoble.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalle)).EndInit();
            this.panelControles.ResumeLayout(false);
            this.panelControles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Autonomo.CustomControls.CustomButton btnProcesar;
        private Autonomo.CustomControls.FlatFindText txFilter;
        private Autonomo.CustomControls.FlatDateTime dtHasta;
        private Autonomo.CustomControls.FlatDateTime dtDesde;
        private Autonomo.CustomControls.CustomGrid grdData;
        private Autonomo.CustomControls.CustomGrid grdDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.Panel panelControles;
        private System.Windows.Forms.Label lbTotalCantidad;
        private System.Windows.Forms.Label lbTotalDolares;
        private System.Windows.Forms.Label lbTasa;
        private System.Windows.Forms.Label lbTotalBs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbIGVtext;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}