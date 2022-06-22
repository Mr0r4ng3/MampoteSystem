namespace MampoteSystem.Windows.Modulo.Ventas
{
    partial class FrmResumenPagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmResumenPagos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtNota = new Autonomo.CustomControls.FlatTextBox();
            this.btnProcesar = new Autonomo.CustomControls.CustomButton();
            this.txFilter = new Autonomo.CustomControls.FlatFindText();
            this.dtHasta = new Autonomo.CustomControls.FlatDateTime();
            this.dtDesde = new Autonomo.CustomControls.FlatDateTime();
            this.radEfecDolares = new Autonomo.CustomControls.CustomRadius();
            this.radEfectivoBs = new Autonomo.CustomControls.CustomRadius();
            this.radPM = new Autonomo.CustomControls.CustomRadius();
            this.radPunto = new Autonomo.CustomControls.CustomRadius();
            this.radCruceInv = new Autonomo.CustomControls.CustomRadius();
            this.grdData = new Autonomo.CustomControls.CustomGrid();
            this.pnlContenedor.SuspendLayout();
            this.pnlBottonControl.SuspendLayout();
            this.pnlTopControl.SuspendLayout();
            this.pnlTopButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContenedorDoble)).BeginInit();
            this.ContenedorDoble.Panel1.SuspendLayout();
            this.ContenedorDoble.Panel2.SuspendLayout();
            this.ContenedorDoble.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Size = new System.Drawing.Size(1236, 667);
            // 
            // pnlBottonControl
            // 
            this.pnlBottonControl.Location = new System.Drawing.Point(0, 635);
            this.pnlBottonControl.Size = new System.Drawing.Size(1236, 32);
            // 
            // BottomLine
            // 
            this.BottomLine.Size = new System.Drawing.Size(1236, 2);
            // 
            // pnlTopControl
            // 
            this.pnlTopControl.Controls.Add(this.radCruceInv);
            this.pnlTopControl.Controls.Add(this.radPM);
            this.pnlTopControl.Controls.Add(this.radPunto);
            this.pnlTopControl.Controls.Add(this.radEfectivoBs);
            this.pnlTopControl.Controls.Add(this.radEfecDolares);
            this.pnlTopControl.Controls.Add(this.btnProcesar);
            this.pnlTopControl.Controls.Add(this.txFilter);
            this.pnlTopControl.Controls.Add(this.dtHasta);
            this.pnlTopControl.Controls.Add(this.dtDesde);
            this.pnlTopControl.Size = new System.Drawing.Size(1236, 139);
            this.pnlTopControl.Controls.SetChildIndex(this.TopLine, 0);
            this.pnlTopControl.Controls.SetChildIndex(this.Title, 0);
            this.pnlTopControl.Controls.SetChildIndex(this.pnlTopButton, 0);
            this.pnlTopControl.Controls.SetChildIndex(this.dtDesde, 0);
            this.pnlTopControl.Controls.SetChildIndex(this.dtHasta, 0);
            this.pnlTopControl.Controls.SetChildIndex(this.txFilter, 0);
            this.pnlTopControl.Controls.SetChildIndex(this.btnProcesar, 0);
            this.pnlTopControl.Controls.SetChildIndex(this.radEfecDolares, 0);
            this.pnlTopControl.Controls.SetChildIndex(this.radEfectivoBs, 0);
            this.pnlTopControl.Controls.SetChildIndex(this.radPunto, 0);
            this.pnlTopControl.Controls.SetChildIndex(this.radPM, 0);
            this.pnlTopControl.Controls.SetChildIndex(this.radCruceInv, 0);
            // 
            // pnlTopButton
            // 
            this.pnlTopButton.Location = new System.Drawing.Point(0, 109);
            this.pnlTopButton.Size = new System.Drawing.Size(1236, 28);
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
            // btnExportar
            // 
            this.btnExportar.FlatAppearance.BorderSize = 0;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
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
            // Title
            // 
            this.Title.Size = new System.Drawing.Size(176, 18);
            this.Title.Text = "Resumen de Pagos";
            // 
            // TopLine
            // 
            this.TopLine.Location = new System.Drawing.Point(0, 137);
            this.TopLine.Size = new System.Drawing.Size(1236, 2);
            // 
            // ContenedorDoble
            // 
            this.ContenedorDoble.Location = new System.Drawing.Point(0, 139);
            // 
            // ContenedorDoble.Panel1
            // 
            this.ContenedorDoble.Panel1.Controls.Add(this.grdData);
            // 
            // ContenedorDoble.Panel2
            // 
            this.ContenedorDoble.Panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.ContenedorDoble.Panel2.Controls.Add(this.txtNota);
            this.ContenedorDoble.Size = new System.Drawing.Size(1236, 496);
            this.ContenedorDoble.SplitterDistance = 992;
            // 
            // txtNota
            // 
            this.txtNota.AlignText = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNota.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNota.Category = '\0';
            this.txtNota.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNota.ColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.txtNota.ColorLine = System.Drawing.Color.SeaGreen;
            this.txtNota.ColorText = System.Drawing.SystemColors.WindowText;
            this.txtNota.ColorTitle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNota.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNota.DockIcon = System.Windows.Forms.DockStyle.Left;
            this.txtNota.Error = "";
            this.txtNota.FontText = new System.Drawing.Font("Verdana", 10F);
            this.txtNota.FontTitle = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota.FormatLogin = false;
            this.txtNota.ImageIcon = ((System.Drawing.Image)(resources.GetObject("txtNota.ImageIcon")));
            this.txtNota.Info = "";
            this.txtNota.Location = new System.Drawing.Point(0, 0);
            this.txtNota.MaterialStyle = false;
            this.txtNota.MaxLength = 32767;
            this.txtNota.MultiLineText = true;
            this.txtNota.Name = "txtNota";
            this.txtNota.PasswordChar = '\0';
            this.txtNota.Placeholder = "";
            this.txtNota.ReadOnly = true;
            this.txtNota.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNota.Size = new System.Drawing.Size(240, 496);
            this.txtNota.SizeLine = 2;
            this.txtNota.TabIndex = 0;
            this.txtNota.Title = "Nota";
            this.txtNota.VisibleIcon = false;
            this.txtNota.VisibleTitle = true;
            // 
            // btnProcesar
            // 
            this.btnProcesar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProcesar.FlatAppearance.BorderSize = 0;
            this.btnProcesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcesar.Font = new System.Drawing.Font("Verdana", 10F);
            this.btnProcesar.Image = ((System.Drawing.Image)(resources.GetObject("btnProcesar.Image")));
            this.btnProcesar.Location = new System.Drawing.Point(295, 38);
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
            this.txFilter.Location = new System.Drawing.Point(357, 45);
            this.txFilter.MaterialStyle = true;
            this.txFilter.MaxLength = 32767;
            this.txFilter.MultiLineText = false;
            this.txFilter.Name = "txFilter";
            this.txFilter.ObjectArray = null;
            this.txFilter.PasswordChar = '\0';
            this.txFilter.Placeholder = "Buscar en la nota o por cliente";
            this.txFilter.PlaceHolderHeight = 18;
            this.txFilter.ReadOnly = false;
            this.txFilter.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txFilter.Size = new System.Drawing.Size(241, 39);
            this.txFilter.SizeLine = 2;
            this.txFilter.StringArray = null;
            this.txFilter.TabIndex = 23;
            this.txFilter.TextId = "";
            this.txFilter.Title = "Buscar en la nota o por cliente";
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
            this.dtHasta.Location = new System.Drawing.Point(156, 42);
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
            this.dtDesde.Location = new System.Drawing.Point(17, 42);
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
            // radEfecDolares
            // 
            this.radEfecDolares.Appearance = System.Windows.Forms.Appearance.Button;
            this.radEfecDolares.AutoSize = true;
            this.radEfecDolares.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radEfecDolares.FlatAppearance.BorderSize = 0;
            this.radEfecDolares.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.radEfecDolares.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.radEfecDolares.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radEfecDolares.Font = new System.Drawing.Font("Verdana", 10F);
            this.radEfecDolares.Image = ((System.Drawing.Image)(resources.GetObject("radEfecDolares.Image")));
            this.radEfecDolares.ImageChecking = ((System.Drawing.Image)(resources.GetObject("radEfecDolares.ImageChecking")));
            this.radEfecDolares.ImageUnChecking = ((System.Drawing.Image)(resources.GetObject("radEfecDolares.ImageUnChecking")));
            this.radEfecDolares.Location = new System.Drawing.Point(604, 71);
            this.radEfecDolares.Name = "radEfecDolares";
            this.radEfecDolares.Size = new System.Drawing.Size(149, 27);
            this.radEfecDolares.TabIndex = 25;
            this.radEfecDolares.Text = "Efectivo Dolares";
            this.radEfecDolares.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radEfecDolares.UseVisualStyleBackColor = true;
            this.radEfecDolares.CheckedChanged += new System.EventHandler(this.radPunto_CheckedChanged);
            // 
            // radEfectivoBs
            // 
            this.radEfectivoBs.Appearance = System.Windows.Forms.Appearance.Button;
            this.radEfectivoBs.AutoSize = true;
            this.radEfectivoBs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radEfectivoBs.FlatAppearance.BorderSize = 0;
            this.radEfectivoBs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.radEfectivoBs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.radEfectivoBs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radEfectivoBs.Font = new System.Drawing.Font("Verdana", 10F);
            this.radEfectivoBs.Image = ((System.Drawing.Image)(resources.GetObject("radEfectivoBs.Image")));
            this.radEfectivoBs.ImageChecking = ((System.Drawing.Image)(resources.GetObject("radEfectivoBs.ImageChecking")));
            this.radEfectivoBs.ImageUnChecking = ((System.Drawing.Image)(resources.GetObject("radEfectivoBs.ImageUnChecking")));
            this.radEfectivoBs.Location = new System.Drawing.Point(754, 71);
            this.radEfectivoBs.Name = "radEfectivoBs";
            this.radEfectivoBs.Size = new System.Drawing.Size(159, 27);
            this.radEfectivoBs.TabIndex = 26;
            this.radEfectivoBs.Text = "Efectivo Bolivares";
            this.radEfectivoBs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radEfectivoBs.UseVisualStyleBackColor = true;
            this.radEfectivoBs.CheckedChanged += new System.EventHandler(this.radPunto_CheckedChanged);
            // 
            // radPM
            // 
            this.radPM.Appearance = System.Windows.Forms.Appearance.Button;
            this.radPM.AutoSize = true;
            this.radPM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radPM.FlatAppearance.BorderSize = 0;
            this.radPM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.radPM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.radPM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radPM.Font = new System.Drawing.Font("Verdana", 10F);
            this.radPM.Image = ((System.Drawing.Image)(resources.GetObject("radPM.Image")));
            this.radPM.ImageChecking = ((System.Drawing.Image)(resources.GetObject("radPM.ImageChecking")));
            this.radPM.ImageUnChecking = ((System.Drawing.Image)(resources.GetObject("radPM.ImageUnChecking")));
            this.radPM.Location = new System.Drawing.Point(754, 38);
            this.radPM.Name = "radPM";
            this.radPM.Size = new System.Drawing.Size(109, 27);
            this.radPM.TabIndex = 28;
            this.radPM.Text = "Pago Movil";
            this.radPM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radPM.UseVisualStyleBackColor = true;
            this.radPM.CheckedChanged += new System.EventHandler(this.radPunto_CheckedChanged);
            // 
            // radPunto
            // 
            this.radPunto.Appearance = System.Windows.Forms.Appearance.Button;
            this.radPunto.AutoSize = true;
            this.radPunto.Checked = true;
            this.radPunto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radPunto.FlatAppearance.BorderSize = 0;
            this.radPunto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.radPunto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.radPunto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radPunto.Font = new System.Drawing.Font("Verdana", 10F);
            this.radPunto.Image = ((System.Drawing.Image)(resources.GetObject("radPunto.Image")));
            this.radPunto.ImageChecking = ((System.Drawing.Image)(resources.GetObject("radPunto.ImageChecking")));
            this.radPunto.ImageUnChecking = ((System.Drawing.Image)(resources.GetObject("radPunto.ImageUnChecking")));
            this.radPunto.Location = new System.Drawing.Point(604, 38);
            this.radPunto.Name = "radPunto";
            this.radPunto.Size = new System.Drawing.Size(79, 27);
            this.radPunto.TabIndex = 27;
            this.radPunto.TabStop = true;
            this.radPunto.Text = "Punto";
            this.radPunto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radPunto.UseVisualStyleBackColor = true;
            this.radPunto.CheckedChanged += new System.EventHandler(this.radPunto_CheckedChanged);
            // 
            // radCruceInv
            // 
            this.radCruceInv.Appearance = System.Windows.Forms.Appearance.Button;
            this.radCruceInv.AutoSize = true;
            this.radCruceInv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radCruceInv.FlatAppearance.BorderSize = 0;
            this.radCruceInv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.radCruceInv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.radCruceInv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radCruceInv.Font = new System.Drawing.Font("Verdana", 10F);
            this.radCruceInv.Image = ((System.Drawing.Image)(resources.GetObject("radCruceInv.Image")));
            this.radCruceInv.ImageChecking = ((System.Drawing.Image)(resources.GetObject("radCruceInv.ImageChecking")));
            this.radCruceInv.ImageUnChecking = ((System.Drawing.Image)(resources.GetObject("radCruceInv.ImageUnChecking")));
            this.radCruceInv.Location = new System.Drawing.Point(913, 38);
            this.radCruceInv.Name = "radCruceInv";
            this.radCruceInv.Size = new System.Drawing.Size(152, 27);
            this.radCruceInv.TabIndex = 29;
            this.radCruceInv.Text = "Cruce Inventario";
            this.radCruceInv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radCruceInv.UseVisualStyleBackColor = true;
            this.radCruceInv.CheckedChanged += new System.EventHandler(this.radPunto_CheckedChanged);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdData.ColumnHeadersHeight = 34;
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
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
            this.grdData.Size = new System.Drawing.Size(992, 496);
            this.grdData.TabIndex = 9;
            this.grdData.TabStop = false;
            this.grdData.SelectionChanged += new System.EventHandler(this.grdData_SelectionChanged);
            // 
            // FrmResumenPagos
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1236, 667);
            this.Name = "FrmResumenPagos";
            this.Text = "FrmResumenPagos";
            this.Load += new System.EventHandler(this.FrmResumenPagos_Load);
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
            this.ResumeLayout(false);

        }

        #endregion
        private Autonomo.CustomControls.FlatTextBox txtNota;
        private Autonomo.CustomControls.CustomButton btnProcesar;
        private Autonomo.CustomControls.FlatFindText txFilter;
        private Autonomo.CustomControls.FlatDateTime dtHasta;
        private Autonomo.CustomControls.FlatDateTime dtDesde;
        private Autonomo.CustomControls.CustomRadius radCruceInv;
        private Autonomo.CustomControls.CustomRadius radPM;
        private Autonomo.CustomControls.CustomRadius radPunto;
        private Autonomo.CustomControls.CustomRadius radEfectivoBs;
        private Autonomo.CustomControls.CustomRadius radEfecDolares;
        private Autonomo.CustomControls.CustomGrid grdData;
    }
}