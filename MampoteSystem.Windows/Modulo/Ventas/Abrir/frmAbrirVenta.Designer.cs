﻿namespace MampoteSystem.Windows.Modulo.Ventas.Abrir
{
    partial class frmAbrirVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbrirVenta));
            this.btnProcesar = new Autonomo.CustomControls.CustomButton();
            this.txFilter = new Autonomo.CustomControls.FlatFindText();
            this.dtHasta = new Autonomo.CustomControls.FlatDateTime();
            this.dtDesde = new Autonomo.CustomControls.FlatDateTime();
            this.grdData = new Autonomo.CustomControls.CustomGrid();
            this.grdDetalle = new Autonomo.CustomControls.CustomGrid();
            this.panelControles = new System.Windows.Forms.Panel();
            this.lbidVenta = new System.Windows.Forms.Label();
            this.btnPagos = new Autonomo.CustomControls.CustomButton();
            this.lbComision = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbTotalCantidad = new System.Windows.Forms.Label();
            this.lbDeudaBs = new System.Windows.Forms.Label();
            this.lbDeudaDolares = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbIGVtext = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radPagada = new Autonomo.CustomControls.CustomRadius();
            this.radSinPagar = new Autonomo.CustomControls.CustomRadius();
            this.chkOnlyComision = new Autonomo.CustomControls.CustomCheck();
            this.radOpcionAPago = new Autonomo.CustomControls.CustomRadius();
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
            this.pnlContenedor.Size = new System.Drawing.Size(1246, 589);
            // 
            // pnlBottonControl
            // 
            this.pnlBottonControl.Location = new System.Drawing.Point(0, 557);
            this.pnlBottonControl.Size = new System.Drawing.Size(1246, 32);
            // 
            // BottomLine
            // 
            this.BottomLine.Size = new System.Drawing.Size(1246, 2);
            // 
            // pnlTopControl
            // 
            this.pnlTopControl.Controls.Add(this.radOpcionAPago);
            this.pnlTopControl.Controls.Add(this.chkOnlyComision);
            this.pnlTopControl.Controls.Add(this.radSinPagar);
            this.pnlTopControl.Controls.Add(this.radPagada);
            this.pnlTopControl.Controls.Add(this.btnProcesar);
            this.pnlTopControl.Controls.Add(this.txFilter);
            this.pnlTopControl.Controls.Add(this.dtHasta);
            this.pnlTopControl.Controls.Add(this.dtDesde);
            this.pnlTopControl.Size = new System.Drawing.Size(1246, 123);
            this.pnlTopControl.Controls.SetChildIndex(this.dtDesde, 0);
            this.pnlTopControl.Controls.SetChildIndex(this.dtHasta, 0);
            this.pnlTopControl.Controls.SetChildIndex(this.txFilter, 0);
            this.pnlTopControl.Controls.SetChildIndex(this.btnProcesar, 0);
            this.pnlTopControl.Controls.SetChildIndex(this.TopLine, 0);
            this.pnlTopControl.Controls.SetChildIndex(this.Title, 0);
            this.pnlTopControl.Controls.SetChildIndex(this.pnlTopButton, 0);
            this.pnlTopControl.Controls.SetChildIndex(this.radPagada, 0);
            this.pnlTopControl.Controls.SetChildIndex(this.radSinPagar, 0);
            this.pnlTopControl.Controls.SetChildIndex(this.chkOnlyComision, 0);
            this.pnlTopControl.Controls.SetChildIndex(this.radOpcionAPago, 0);
            // 
            // pnlTopButton
            // 
            this.pnlTopButton.Location = new System.Drawing.Point(0, 86);
            this.pnlTopButton.Size = new System.Drawing.Size(1246, 35);
            // 
            // btnCommand3
            // 
            this.btnCommand3.FlatAppearance.BorderSize = 0;
            this.btnCommand3.Location = new System.Drawing.Point(735, 0);
            this.btnCommand3.Size = new System.Drawing.Size(152, 35);
            this.btnCommand3.Text = "Eliminar Producto";
            this.btnCommand3.Visible = true;
            this.btnCommand3.Click += new System.EventHandler(this.btnCommand3_Click);
            // 
            // btnCommand2
            // 
            this.btnCommand2.Enabled = false;
            this.btnCommand2.FlatAppearance.BorderSize = 0;
            this.btnCommand2.Location = new System.Drawing.Point(525, 0);
            this.btnCommand2.Size = new System.Drawing.Size(210, 35);
            this.btnCommand2.Text = "-----";
            this.btnCommand2.Click += new System.EventHandler(this.btnCommand2_Click);
            // 
            // btnCommand1
            // 
            this.btnCommand1.FlatAppearance.BorderSize = 0;
            this.btnCommand1.Location = new System.Drawing.Point(421, 0);
            this.btnCommand1.Size = new System.Drawing.Size(104, 35);
            this.btnCommand1.Text = "Agregar Pago";
            this.btnCommand1.Visible = true;
            this.btnCommand1.Click += new System.EventHandler(this.btnCommand1_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.FlatAppearance.BorderSize = 0;
            this.btnExportar.Location = new System.Drawing.Point(317, 0);
            this.btnExportar.Size = new System.Drawing.Size(104, 35);
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.Size = new System.Drawing.Size(134, 35);
            this.btnEliminar.Text = "Eliminar Venta";
            this.btnEliminar.Visible = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.Size = new System.Drawing.Size(83, 35);
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.Size = new System.Drawing.Size(83, 35);
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // Title
            // 
            this.Title.Size = new System.Drawing.Size(165, 18);
            this.Title.Text = "Ordenes de venta";
            // 
            // TopLine
            // 
            this.TopLine.Location = new System.Drawing.Point(0, 121);
            this.TopLine.Size = new System.Drawing.Size(1246, 2);
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
            this.ContenedorDoble.Size = new System.Drawing.Size(1246, 434);
            this.ContenedorDoble.SplitterDistance = 694;
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
            this.btnProcesar.TabIndex = 24;
            this.btnProcesar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
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
            this.txFilter.ImageIcon = null;
            this.txFilter.Location = new System.Drawing.Point(349, 32);
            this.txFilter.MaterialStyle = true;
            this.txFilter.MaxLength = 32767;
            this.txFilter.MultiLineText = false;
            this.txFilter.Name = "txFilter";
            this.txFilter.ObjectArray = null;
            this.txFilter.PasswordChar = '\0';
            this.txFilter.Placeholder = "Buscar por nombres y apellidos";
            this.txFilter.PlaceHolderHeight = 18;
            this.txFilter.ReadOnly = false;
            this.txFilter.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txFilter.Size = new System.Drawing.Size(242, 44);
            this.txFilter.SizeLine = 2;
            this.txFilter.StringArray = null;
            this.txFilter.TabIndex = 23;
            this.txFilter.TextId = "";
            this.txFilter.Title = "Buscar por nombres y apellidos";
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
            this.dtHasta.TabIndex = 22;
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
            this.dtDesde.TabIndex = 21;
            this.dtDesde.Text = "21/06/2021";
            this.dtDesde.Title = "Fecha inicial";
            this.dtDesde.Value = new System.DateTime(2021, 6, 21, 1, 21, 23, 610);
            this.dtDesde.VisibleIcon = false;
            this.dtDesde.VisibleTitle = true;
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
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.grdData.ColumnHeadersHeight = 34;
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdData.DefaultCellStyle = dataGridViewCellStyle18;
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
            this.grdData.Size = new System.Drawing.Size(694, 434);
            this.grdData.TabIndex = 9;
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
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.grdDetalle.ColumnHeadersHeight = 34;
            this.grdDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdDetalle.DefaultCellStyle = dataGridViewCellStyle20;
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
            this.grdDetalle.Size = new System.Drawing.Size(548, 434);
            this.grdDetalle.TabIndex = 13;
            this.grdDetalle.TabStop = false;
            // 
            // panelControles
            // 
            this.panelControles.BackColor = System.Drawing.Color.Gainsboro;
            this.panelControles.Controls.Add(this.lbidVenta);
            this.panelControles.Controls.Add(this.btnPagos);
            this.panelControles.Controls.Add(this.lbComision);
            this.panelControles.Controls.Add(this.label8);
            this.panelControles.Controls.Add(this.lbTotalCantidad);
            this.panelControles.Controls.Add(this.lbDeudaBs);
            this.panelControles.Controls.Add(this.lbDeudaDolares);
            this.panelControles.Controls.Add(this.lbTotal);
            this.panelControles.Controls.Add(this.label7);
            this.panelControles.Controls.Add(this.lbIGVtext);
            this.panelControles.Controls.Add(this.label5);
            this.panelControles.Controls.Add(this.label4);
            this.panelControles.Controls.Add(this.label3);
            this.panelControles.Controls.Add(this.label2);
            this.panelControles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControles.Location = new System.Drawing.Point(0, 228);
            this.panelControles.Name = "panelControles";
            this.panelControles.Size = new System.Drawing.Size(548, 206);
            this.panelControles.TabIndex = 14;
            // 
            // lbidVenta
            // 
            this.lbidVenta.AutoSize = true;
            this.lbidVenta.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbidVenta.ForeColor = System.Drawing.Color.DimGray;
            this.lbidVenta.Location = new System.Drawing.Point(186, 63);
            this.lbidVenta.Name = "lbidVenta";
            this.lbidVenta.Size = new System.Drawing.Size(56, 16);
            this.lbidVenta.TabIndex = 14;
            this.lbidVenta.Text = "idVenta";
            this.lbidVenta.Visible = false;
            // 
            // btnPagos
            // 
            this.btnPagos.BackColor = System.Drawing.Color.SeaGreen;
            this.btnPagos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPagos.FlatAppearance.BorderSize = 0;
            this.btnPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagos.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagos.ForeColor = System.Drawing.Color.White;
            this.btnPagos.Image = ((System.Drawing.Image)(resources.GetObject("btnPagos.Image")));
            this.btnPagos.Location = new System.Drawing.Point(57, 143);
            this.btnPagos.Name = "btnPagos";
            this.btnPagos.Size = new System.Drawing.Size(278, 52);
            this.btnPagos.TabIndex = 13;
            this.btnPagos.Text = "Ver Pagos en detalle";
            this.btnPagos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPagos.UseVisualStyleBackColor = false;
            this.btnPagos.Click += new System.EventHandler(this.btnPagos_Click);
            // 
            // lbComision
            // 
            this.lbComision.AutoSize = true;
            this.lbComision.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbComision.Location = new System.Drawing.Point(284, 63);
            this.lbComision.Name = "lbComision";
            this.lbComision.Size = new System.Drawing.Size(79, 16);
            this.lbComision.TabIndex = 11;
            this.lbComision.Text = ":  Bs. 0.00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(4, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Comision";
            // 
            // lbTotalCantidad
            // 
            this.lbTotalCantidad.AutoSize = true;
            this.lbTotalCantidad.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalCantidad.Location = new System.Drawing.Point(284, 31);
            this.lbTotalCantidad.Name = "lbTotalCantidad";
            this.lbTotalCantidad.Size = new System.Drawing.Size(100, 16);
            this.lbTotalCantidad.TabIndex = 9;
            this.lbTotalCantidad.Text = ":  0 Unidades";
            // 
            // lbDeudaBs
            // 
            this.lbDeudaBs.AutoSize = true;
            this.lbDeudaBs.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDeudaBs.Location = new System.Drawing.Point(284, 121);
            this.lbDeudaBs.Name = "lbDeudaBs";
            this.lbDeudaBs.Size = new System.Drawing.Size(79, 16);
            this.lbDeudaBs.TabIndex = 8;
            this.lbDeudaBs.Text = ":  Bs. 0.00";
            // 
            // lbDeudaDolares
            // 
            this.lbDeudaDolares.AutoSize = true;
            this.lbDeudaDolares.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDeudaDolares.Location = new System.Drawing.Point(284, 102);
            this.lbDeudaDolares.Name = "lbDeudaDolares";
            this.lbDeudaDolares.Size = new System.Drawing.Size(65, 16);
            this.lbDeudaDolares.TabIndex = 7;
            this.lbDeudaDolares.Text = ":  $ 0.00";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(284, 83);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(79, 16);
            this.lbTotal.TabIndex = 6;
            this.lbTotal.Text = ":  Bs. 0.00";
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
            this.lbIGVtext.Location = new System.Drawing.Point(4, 121);
            this.lbIGVtext.Name = "lbIGVtext";
            this.lbIGVtext.Size = new System.Drawing.Size(94, 16);
            this.lbIGVtext.TabIndex = 4;
            this.lbIGVtext.Text = "Deuda en Bs.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(5, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Deuda en $";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(4, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Total de la Venta";
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
            this.label2.Size = new System.Drawing.Size(548, 1);
            this.label2.TabIndex = 0;
            // 
            // radPagada
            // 
            this.radPagada.Appearance = System.Windows.Forms.Appearance.Button;
            this.radPagada.AutoSize = true;
            this.radPagada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radPagada.FlatAppearance.BorderSize = 0;
            this.radPagada.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.radPagada.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.radPagada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radPagada.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Italic);
            this.radPagada.Image = ((System.Drawing.Image)(resources.GetObject("radPagada.Image")));
            this.radPagada.ImageChecking = ((System.Drawing.Image)(resources.GetObject("radPagada.ImageChecking")));
            this.radPagada.ImageUnChecking = ((System.Drawing.Image)(resources.GetObject("radPagada.ImageUnChecking")));
            this.radPagada.Location = new System.Drawing.Point(901, 54);
            this.radPagada.Name = "radPagada";
            this.radPagada.Size = new System.Drawing.Size(83, 24);
            this.radPagada.TabIndex = 25;
            this.radPagada.Text = "Pagadas";
            this.radPagada.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radPagada.UseVisualStyleBackColor = true;
            this.radPagada.Visible = false;
            this.radPagada.CheckedChanged += new System.EventHandler(this.radPagada_CheckedChanged);
            // 
            // radSinPagar
            // 
            this.radSinPagar.Appearance = System.Windows.Forms.Appearance.Button;
            this.radSinPagar.AutoSize = true;
            this.radSinPagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radSinPagar.FlatAppearance.BorderSize = 0;
            this.radSinPagar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.radSinPagar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.radSinPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radSinPagar.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Italic);
            this.radSinPagar.Image = ((System.Drawing.Image)(resources.GetObject("radSinPagar.Image")));
            this.radSinPagar.ImageChecking = ((System.Drawing.Image)(resources.GetObject("radSinPagar.ImageChecking")));
            this.radSinPagar.ImageUnChecking = ((System.Drawing.Image)(resources.GetObject("radSinPagar.ImageUnChecking")));
            this.radSinPagar.Location = new System.Drawing.Point(804, 54);
            this.radSinPagar.Name = "radSinPagar";
            this.radSinPagar.Size = new System.Drawing.Size(89, 24);
            this.radSinPagar.TabIndex = 26;
            this.radSinPagar.Text = "Sin Pagar";
            this.radSinPagar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radSinPagar.UseVisualStyleBackColor = true;
            this.radSinPagar.Visible = false;
            this.radSinPagar.CheckedChanged += new System.EventHandler(this.radSinPagar_CheckedChanged);
            // 
            // chkOnlyComision
            // 
            this.chkOnlyComision.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkOnlyComision.AutoSize = true;
            this.chkOnlyComision.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkOnlyComision.FlatAppearance.BorderSize = 0;
            this.chkOnlyComision.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.chkOnlyComision.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.chkOnlyComision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkOnlyComision.Font = new System.Drawing.Font("Verdana", 10F);
            this.chkOnlyComision.Image = ((System.Drawing.Image)(resources.GetObject("chkOnlyComision.Image")));
            this.chkOnlyComision.ImageChecking = ((System.Drawing.Image)(resources.GetObject("chkOnlyComision.ImageChecking")));
            this.chkOnlyComision.ImageUnChecking = ((System.Drawing.Image)(resources.GetObject("chkOnlyComision.ImageUnChecking")));
            this.chkOnlyComision.Location = new System.Drawing.Point(706, 30);
            this.chkOnlyComision.Name = "chkOnlyComision";
            this.chkOnlyComision.Size = new System.Drawing.Size(136, 27);
            this.chkOnlyComision.TabIndex = 27;
            this.chkOnlyComision.Text = "Solo Comision";
            this.chkOnlyComision.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkOnlyComision.UseVisualStyleBackColor = true;
            this.chkOnlyComision.CheckedChanged += new System.EventHandler(this.chkOnlyComision_CheckedChanged);
            // 
            // radOpcionAPago
            // 
            this.radOpcionAPago.Appearance = System.Windows.Forms.Appearance.Button;
            this.radOpcionAPago.AutoSize = true;
            this.radOpcionAPago.Checked = true;
            this.radOpcionAPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radOpcionAPago.FlatAppearance.BorderSize = 0;
            this.radOpcionAPago.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.radOpcionAPago.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.radOpcionAPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radOpcionAPago.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Italic);
            this.radOpcionAPago.Image = ((System.Drawing.Image)(resources.GetObject("radOpcionAPago.Image")));
            this.radOpcionAPago.ImageChecking = ((System.Drawing.Image)(resources.GetObject("radOpcionAPago.ImageChecking")));
            this.radOpcionAPago.ImageUnChecking = ((System.Drawing.Image)(resources.GetObject("radOpcionAPago.ImageUnChecking")));
            this.radOpcionAPago.Location = new System.Drawing.Point(630, 54);
            this.radOpcionAPago.Name = "radOpcionAPago";
            this.radOpcionAPago.Size = new System.Drawing.Size(170, 26);
            this.radOpcionAPago.TabIndex = 28;
            this.radOpcionAPago.TabStop = true;
            this.radOpcionAPago.Text = "Sin Pagar (P. Abonado)";
            this.radOpcionAPago.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radOpcionAPago.UseVisualStyleBackColor = true;
            this.radOpcionAPago.Visible = false;
            // 
            // frmAbrirVenta
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1246, 589);
            this.Name = "frmAbrirVenta";
            this.Text = "frmAbrirVenta";
            this.Load += new System.EventHandler(this.frmAbrirVenta_Load);
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
        private System.Windows.Forms.Panel panelControles;
        private System.Windows.Forms.Label lbTotalCantidad;
        private System.Windows.Forms.Label lbDeudaBs;
        private System.Windows.Forms.Label lbDeudaDolares;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbIGVtext;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbComision;
        private System.Windows.Forms.Label label8;
        private Autonomo.CustomControls.CustomButton btnPagos;
        private System.Windows.Forms.Label lbidVenta;
        private Autonomo.CustomControls.CustomCheck chkOnlyComision;
        private Autonomo.CustomControls.CustomRadius radSinPagar;
        private Autonomo.CustomControls.CustomRadius radPagada;
        private Autonomo.CustomControls.CustomRadius radOpcionAPago;
    }
}