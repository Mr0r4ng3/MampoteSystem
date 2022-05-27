namespace MampoteSystem.Windows.Modulo.Clientes
{
    partial class SearchAndCreateClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchAndCreateClientes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CreatePanel = new System.Windows.Forms.Panel();
            this.cbTipo = new Autonomo.CustomControls.FlatComboBox();
            this.txDireccion = new Autonomo.CustomControls.FlatTextBox();
            this.txApellidos = new Autonomo.CustomControls.FlatTextBox();
            this.txTelefono = new Autonomo.CustomControls.FlatTextBox();
            this.txCedula = new Autonomo.CustomControls.FlatTextBox();
            this.txNombres = new Autonomo.CustomControls.FlatTextBox();
            this.SearchPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbSearchMode = new Autonomo.CustomControls.FlatComboBox();
            this.RegistrarNuevoCheck = new Autonomo.CustomControls.CustomCheck();
            this.txtSearch = new Autonomo.CustomControls.FlatFindText();
            this.grdData = new Autonomo.CustomControls.CustomGrid();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateButton = new System.Windows.Forms.Button();
            this.Contenedor.SuspendLayout();
            this.Body.SuspendLayout();
            this.Footer.SuspendLayout();
            this.Header.SuspendLayout();
            this.CreatePanel.SuspendLayout();
            this.SearchPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.SuspendLayout();
            // 
            // Contenedor
            // 
            this.Contenedor.Size = new System.Drawing.Size(862, 668);
            // 
            // Body
            // 
            this.Body.Controls.Add(this.SearchPanel);
            this.Body.Controls.Add(this.CreatePanel);
            this.Body.Size = new System.Drawing.Size(862, 575);
            // 
            // Footer
            // 
            this.Footer.Controls.Add(this.CreateButton);
            this.Footer.Location = new System.Drawing.Point(0, 616);
            this.Footer.Size = new System.Drawing.Size(862, 52);
            this.Footer.Controls.SetChildIndex(this.btnSave, 0);
            this.Footer.Controls.SetChildIndex(this.CreateButton, 0);
            // 
            // Header
            // 
            this.Header.Size = new System.Drawing.Size(862, 41);
            // 
            // Title
            // 
            this.Title.Size = new System.Drawing.Size(821, 41);
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Location = new System.Drawing.Point(179, 6);
            this.btnSave.Text = "Seleccionar Cliente";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // CreatePanel
            // 
            this.CreatePanel.Controls.Add(this.cbTipo);
            this.CreatePanel.Controls.Add(this.txDireccion);
            this.CreatePanel.Controls.Add(this.txApellidos);
            this.CreatePanel.Controls.Add(this.txTelefono);
            this.CreatePanel.Controls.Add(this.txCedula);
            this.CreatePanel.Controls.Add(this.txNombres);
            this.CreatePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.CreatePanel.Location = new System.Drawing.Point(517, 0);
            this.CreatePanel.Name = "CreatePanel";
            this.CreatePanel.Size = new System.Drawing.Size(345, 575);
            this.CreatePanel.TabIndex = 0;
            this.CreatePanel.Visible = false;
            // 
            // cbTipo
            // 
            this.cbTipo.BackColor = System.Drawing.Color.White;
            this.cbTipo.Category = '\0';
            this.cbTipo.ColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.cbTipo.ColorLine = System.Drawing.Color.Gray;
            this.cbTipo.ColorText = System.Drawing.SystemColors.WindowText;
            this.cbTipo.ColorTitle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbTipo.DisplayMember = "";
            this.cbTipo.DockIcon = System.Windows.Forms.DockStyle.Left;
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.Error = "";
            this.cbTipo.FontText = new System.Drawing.Font("Verdana", 10F);
            this.cbTipo.FontTitle = new System.Drawing.Font("Verdana", 9F);
            this.cbTipo.ImageIcon = ((System.Drawing.Image)(resources.GetObject("cbTipo.ImageIcon")));
            this.cbTipo.Info = "";
            this.cbTipo.Location = new System.Drawing.Point(21, 10);
            this.cbTipo.MaterialStyle = true;
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Placeholder = "Tipo de Cédula";
            this.cbTipo.SelectedIndex = -1;
            this.cbTipo.Size = new System.Drawing.Size(278, 58);
            this.cbTipo.SizeLine = 2;
            this.cbTipo.TabIndex = 6;
            this.cbTipo.Title = "Tipo de Cédula";
            this.cbTipo.ValueMember = "";
            this.cbTipo.VisibleIcon = true;
            this.cbTipo.VisibleTitle = false;
            // 
            // txDireccion
            // 
            this.txDireccion.AlignText = System.Windows.Forms.HorizontalAlignment.Left;
            this.txDireccion.BackColor = System.Drawing.Color.White;
            this.txDireccion.Category = '\0';
            this.txDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txDireccion.ColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.txDireccion.ColorLine = System.Drawing.Color.Gray;
            this.txDireccion.ColorText = System.Drawing.SystemColors.WindowText;
            this.txDireccion.ColorTitle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txDireccion.DockIcon = System.Windows.Forms.DockStyle.Left;
            this.txDireccion.Error = "";
            this.txDireccion.FontText = new System.Drawing.Font("Verdana", 10F);
            this.txDireccion.FontTitle = new System.Drawing.Font("Verdana", 9F);
            this.txDireccion.FormatLogin = false;
            this.txDireccion.ImageIcon = ((System.Drawing.Image)(resources.GetObject("txDireccion.ImageIcon")));
            this.txDireccion.Info = "";
            this.txDireccion.Location = new System.Drawing.Point(21, 339);
            this.txDireccion.MaterialStyle = false;
            this.txDireccion.MaxLength = 32767;
            this.txDireccion.MultiLineText = true;
            this.txDireccion.Name = "txDireccion";
            this.txDireccion.PasswordChar = '\0';
            this.txDireccion.Placeholder = "";
            this.txDireccion.ReadOnly = false;
            this.txDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txDireccion.Size = new System.Drawing.Size(278, 125);
            this.txDireccion.SizeLine = 2;
            this.txDireccion.TabIndex = 11;
            this.txDireccion.Title = "Dirección";
            this.txDireccion.VisibleIcon = true;
            this.txDireccion.VisibleTitle = true;
            // 
            // txApellidos
            // 
            this.txApellidos.AlignText = System.Windows.Forms.HorizontalAlignment.Left;
            this.txApellidos.BackColor = System.Drawing.Color.White;
            this.txApellidos.Category = '\0';
            this.txApellidos.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txApellidos.ColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.txApellidos.ColorLine = System.Drawing.Color.Gray;
            this.txApellidos.ColorText = System.Drawing.SystemColors.WindowText;
            this.txApellidos.ColorTitle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txApellidos.DockIcon = System.Windows.Forms.DockStyle.Left;
            this.txApellidos.Error = "";
            this.txApellidos.FontText = new System.Drawing.Font("Verdana", 10F);
            this.txApellidos.FontTitle = new System.Drawing.Font("Verdana", 9F);
            this.txApellidos.FormatLogin = false;
            this.txApellidos.ImageIcon = ((System.Drawing.Image)(resources.GetObject("txApellidos.ImageIcon")));
            this.txApellidos.Info = "";
            this.txApellidos.Location = new System.Drawing.Point(21, 202);
            this.txApellidos.MaterialStyle = false;
            this.txApellidos.MaxLength = 32767;
            this.txApellidos.MultiLineText = false;
            this.txApellidos.Name = "txApellidos";
            this.txApellidos.PasswordChar = '\0';
            this.txApellidos.Placeholder = "";
            this.txApellidos.ReadOnly = false;
            this.txApellidos.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txApellidos.Size = new System.Drawing.Size(278, 58);
            this.txApellidos.SizeLine = 2;
            this.txApellidos.TabIndex = 9;
            this.txApellidos.Title = "Apellidos";
            this.txApellidos.VisibleIcon = true;
            this.txApellidos.VisibleTitle = true;
            // 
            // txTelefono
            // 
            this.txTelefono.AlignText = System.Windows.Forms.HorizontalAlignment.Left;
            this.txTelefono.BackColor = System.Drawing.Color.White;
            this.txTelefono.Category = '\0';
            this.txTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txTelefono.ColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.txTelefono.ColorLine = System.Drawing.Color.Gray;
            this.txTelefono.ColorText = System.Drawing.SystemColors.WindowText;
            this.txTelefono.ColorTitle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txTelefono.DockIcon = System.Windows.Forms.DockStyle.Left;
            this.txTelefono.Error = "";
            this.txTelefono.FontText = new System.Drawing.Font("Verdana", 10F);
            this.txTelefono.FontTitle = new System.Drawing.Font("Verdana", 9F);
            this.txTelefono.FormatLogin = false;
            this.txTelefono.ImageIcon = ((System.Drawing.Image)(resources.GetObject("txTelefono.ImageIcon")));
            this.txTelefono.Info = "";
            this.txTelefono.Location = new System.Drawing.Point(21, 266);
            this.txTelefono.MaterialStyle = false;
            this.txTelefono.MaxLength = 15;
            this.txTelefono.MultiLineText = false;
            this.txTelefono.Name = "txTelefono";
            this.txTelefono.PasswordChar = '\0';
            this.txTelefono.Placeholder = "Ej. 0416-1234567";
            this.txTelefono.ReadOnly = false;
            this.txTelefono.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txTelefono.Size = new System.Drawing.Size(278, 58);
            this.txTelefono.SizeLine = 2;
            this.txTelefono.TabIndex = 10;
            this.txTelefono.Title = "Teléfono";
            this.txTelefono.VisibleIcon = true;
            this.txTelefono.VisibleTitle = true;
            this.txTelefono.KeyPress += new System.EventHandler<System.Windows.Forms.KeyPressEventArgs>(this.txTelefono_KeyPress);
            // 
            // txCedula
            // 
            this.txCedula.AlignText = System.Windows.Forms.HorizontalAlignment.Left;
            this.txCedula.BackColor = System.Drawing.Color.White;
            this.txCedula.Category = '\0';
            this.txCedula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txCedula.ColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.txCedula.ColorLine = System.Drawing.Color.Gray;
            this.txCedula.ColorText = System.Drawing.SystemColors.WindowText;
            this.txCedula.ColorTitle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txCedula.DockIcon = System.Windows.Forms.DockStyle.Left;
            this.txCedula.Error = "";
            this.txCedula.FontText = new System.Drawing.Font("Verdana", 10F);
            this.txCedula.FontTitle = new System.Drawing.Font("Verdana", 9F);
            this.txCedula.FormatLogin = false;
            this.txCedula.ImageIcon = ((System.Drawing.Image)(resources.GetObject("txCedula.ImageIcon")));
            this.txCedula.Info = "";
            this.txCedula.Location = new System.Drawing.Point(21, 74);
            this.txCedula.MaterialStyle = false;
            this.txCedula.MaxLength = 32767;
            this.txCedula.MultiLineText = false;
            this.txCedula.Name = "txCedula";
            this.txCedula.PasswordChar = '\0';
            this.txCedula.Placeholder = "Ej 12345678";
            this.txCedula.ReadOnly = false;
            this.txCedula.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txCedula.Size = new System.Drawing.Size(278, 58);
            this.txCedula.SizeLine = 2;
            this.txCedula.TabIndex = 7;
            this.txCedula.Title = "Cédula";
            this.txCedula.VisibleIcon = true;
            this.txCedula.VisibleTitle = true;
            this.txCedula.KeyPress += new System.EventHandler<System.Windows.Forms.KeyPressEventArgs>(this.txCedula_KeyPress);
            // 
            // txNombres
            // 
            this.txNombres.AlignText = System.Windows.Forms.HorizontalAlignment.Left;
            this.txNombres.BackColor = System.Drawing.Color.White;
            this.txNombres.Category = '\0';
            this.txNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txNombres.ColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.txNombres.ColorLine = System.Drawing.Color.Gray;
            this.txNombres.ColorText = System.Drawing.SystemColors.WindowText;
            this.txNombres.ColorTitle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txNombres.DockIcon = System.Windows.Forms.DockStyle.Left;
            this.txNombres.Error = "";
            this.txNombres.FontText = new System.Drawing.Font("Verdana", 10F);
            this.txNombres.FontTitle = new System.Drawing.Font("Verdana", 9F);
            this.txNombres.FormatLogin = false;
            this.txNombres.ImageIcon = ((System.Drawing.Image)(resources.GetObject("txNombres.ImageIcon")));
            this.txNombres.Info = "";
            this.txNombres.Location = new System.Drawing.Point(21, 138);
            this.txNombres.MaterialStyle = false;
            this.txNombres.MaxLength = 32767;
            this.txNombres.MultiLineText = false;
            this.txNombres.Name = "txNombres";
            this.txNombres.PasswordChar = '\0';
            this.txNombres.Placeholder = "";
            this.txNombres.ReadOnly = false;
            this.txNombres.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txNombres.Size = new System.Drawing.Size(278, 58);
            this.txNombres.SizeLine = 2;
            this.txNombres.TabIndex = 8;
            this.txNombres.Title = "Nombres";
            this.txNombres.VisibleIcon = true;
            this.txNombres.VisibleTitle = true;
            // 
            // SearchPanel
            // 
            this.SearchPanel.Controls.Add(this.panel1);
            this.SearchPanel.Controls.Add(this.grdData);
            this.SearchPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchPanel.Location = new System.Drawing.Point(0, 0);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(517, 575);
            this.SearchPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbSearchMode);
            this.panel1.Controls.Add(this.RegistrarNuevoCheck);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(508, 152);
            this.panel1.TabIndex = 0;
            // 
            // cbSearchMode
            // 
            this.cbSearchMode.BackColor = System.Drawing.Color.White;
            this.cbSearchMode.Category = '\0';
            this.cbSearchMode.ColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.cbSearchMode.ColorLine = System.Drawing.Color.Gray;
            this.cbSearchMode.ColorText = System.Drawing.SystemColors.WindowText;
            this.cbSearchMode.ColorTitle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbSearchMode.DisplayMember = "";
            this.cbSearchMode.DockIcon = System.Windows.Forms.DockStyle.Left;
            this.cbSearchMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchMode.Error = "";
            this.cbSearchMode.FontText = new System.Drawing.Font("Verdana", 10F);
            this.cbSearchMode.FontTitle = new System.Drawing.Font("Verdana", 9F);
            this.cbSearchMode.ImageIcon = ((System.Drawing.Image)(resources.GetObject("cbSearchMode.ImageIcon")));
            this.cbSearchMode.Info = "";
            this.cbSearchMode.Location = new System.Drawing.Point(9, 43);
            this.cbSearchMode.MaterialStyle = false;
            this.cbSearchMode.Name = "cbSearchMode";
            this.cbSearchMode.Placeholder = "";
            this.cbSearchMode.SelectedIndex = -1;
            this.cbSearchMode.Size = new System.Drawing.Size(176, 58);
            this.cbSearchMode.SizeLine = 2;
            this.cbSearchMode.TabIndex = 2;
            this.cbSearchMode.Title = "Buscar Por";
            this.cbSearchMode.ValueMember = "";
            this.cbSearchMode.VisibleIcon = false;
            this.cbSearchMode.VisibleTitle = true;
            this.cbSearchMode.SelectedIndexChanged += new System.EventHandler(this.cbSearchMode_SelectedIndexChanged);
            // 
            // RegistrarNuevoCheck
            // 
            this.RegistrarNuevoCheck.Appearance = System.Windows.Forms.Appearance.Button;
            this.RegistrarNuevoCheck.AutoSize = true;
            this.RegistrarNuevoCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegistrarNuevoCheck.FlatAppearance.BorderSize = 0;
            this.RegistrarNuevoCheck.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.RegistrarNuevoCheck.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.RegistrarNuevoCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegistrarNuevoCheck.Font = new System.Drawing.Font("Verdana", 10F);
            this.RegistrarNuevoCheck.Image = ((System.Drawing.Image)(resources.GetObject("RegistrarNuevoCheck.Image")));
            this.RegistrarNuevoCheck.ImageChecking = ((System.Drawing.Image)(resources.GetObject("RegistrarNuevoCheck.ImageChecking")));
            this.RegistrarNuevoCheck.ImageUnChecking = ((System.Drawing.Image)(resources.GetObject("RegistrarNuevoCheck.ImageUnChecking")));
            this.RegistrarNuevoCheck.Location = new System.Drawing.Point(144, 112);
            this.RegistrarNuevoCheck.Name = "RegistrarNuevoCheck";
            this.RegistrarNuevoCheck.Size = new System.Drawing.Size(149, 27);
            this.RegistrarNuevoCheck.TabIndex = 1;
            this.RegistrarNuevoCheck.Text = "Registrar Nuevo";
            this.RegistrarNuevoCheck.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RegistrarNuevoCheck.UseMnemonic = false;
            this.RegistrarNuevoCheck.UseVisualStyleBackColor = true;
            this.RegistrarNuevoCheck.CheckedChanged += new System.EventHandler(this.RegistrarNuevoCheck_CheckedChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.AlignText = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSearch.ColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.txtSearch.ColorLine = System.Drawing.Color.Gray;
            this.txtSearch.ColorText = System.Drawing.SystemColors.WindowText;
            this.txtSearch.ColorTitle = System.Drawing.Color.Gray;
            this.txtSearch.DockIcon = System.Windows.Forms.DockStyle.Left;
            this.txtSearch.FontText = new System.Drawing.Font("Verdana", 10F);
            this.txtSearch.FontTitle = new System.Drawing.Font("Verdana", 9F);
            this.txtSearch.ImageIcon = ((System.Drawing.Image)(resources.GetObject("txtSearch.ImageIcon")));
            this.txtSearch.Location = new System.Drawing.Point(221, 43);
            this.txtSearch.MaterialStyle = false;
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.MultiLineText = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.ObjectArray = null;
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.Placeholder = "";
            this.txtSearch.PlaceHolderHeight = 18;
            this.txtSearch.ReadOnly = false;
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.Size = new System.Drawing.Size(274, 44);
            this.txtSearch.SizeLine = 2;
            this.txtSearch.StringArray = null;
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextId = "";
            this.txtSearch.Title = "Parametro de busqueda";
            this.txtSearch.VisibleIcon = true;
            this.txtSearch.VisibleTitle = true;
            this.txtSearch.TextBoxChanged += new System.EventHandler(this.txtSearch_TextBoxChanged);
            this.txtSearch.KeyPress += new System.EventHandler<System.Windows.Forms.KeyPressEventArgs>(this.txtSearch_KeyPress);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Cedula,
            this.Nombres,
            this.Apellidos,
            this.Direccion,
            this.Telefono});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdData.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdData.EnableBottomDown = false;
            this.grdData.EnableBottomLeft = false;
            this.grdData.EnableBottomRight = false;
            this.grdData.EnableBottomUp = false;
            this.grdData.EnableHeadersVisualStyles = false;
            this.grdData.HeaderColor = System.Drawing.SystemColors.Control;
            this.grdData.HeaderFont = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdData.HeaderForeColor = System.Drawing.SystemColors.WindowText;
            this.grdData.Location = new System.Drawing.Point(3, 161);
            this.grdData.MultiSelect = false;
            this.grdData.Name = "grdData";
            this.grdData.ReadOnly = true;
            this.grdData.RowHeadersVisible = false;
            this.grdData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdData.Size = new System.Drawing.Size(508, 410);
            this.grdData.TabIndex = 3;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // Cedula
            // 
            this.Cedula.DataPropertyName = "Cedula";
            this.Cedula.HeaderText = "Cedula";
            this.Cedula.Name = "Cedula";
            this.Cedula.ReadOnly = true;
            // 
            // Nombres
            // 
            this.Nombres.DataPropertyName = "Nombres";
            this.Nombres.HeaderText = "Nombres";
            this.Nombres.Name = "Nombres";
            this.Nombres.ReadOnly = true;
            // 
            // Apellidos
            // 
            this.Apellidos.DataPropertyName = "Apellidos";
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.DataPropertyName = "Direccion";
            this.Direccion.HeaderText = "Dirección";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            this.Direccion.Width = 255;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.HeaderText = "Teléfono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // CreateButton
            // 
            this.CreateButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.CreateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateButton.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.CreateButton.ForeColor = System.Drawing.Color.White;
            this.CreateButton.Location = new System.Drawing.Point(610, 6);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(155, 36);
            this.CreateButton.TabIndex = 2;
            this.CreateButton.Text = "Crear y seleccionar";
            this.CreateButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CreateButton.UseVisualStyleBackColor = false;
            this.CreateButton.Visible = false;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // SearchAndCreateClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 668);
            this.Name = "SearchAndCreateClientes";
            this.Text = "SearchAndCreateClientes";
            this.Load += new System.EventHandler(this.SearchAndCreateClientes_Load);
            this.Contenedor.ResumeLayout(false);
            this.Body.ResumeLayout(false);
            this.Footer.ResumeLayout(false);
            this.Header.ResumeLayout(false);
            this.CreatePanel.ResumeLayout(false);
            this.SearchPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel SearchPanel;
        private System.Windows.Forms.Panel CreatePanel;
        private System.Windows.Forms.Panel panel1;
        private Autonomo.CustomControls.FlatFindText txtSearch;
        private Autonomo.CustomControls.FlatComboBox cbTipo;
        private Autonomo.CustomControls.FlatTextBox txDireccion;
        private Autonomo.CustomControls.FlatTextBox txApellidos;
        private Autonomo.CustomControls.FlatTextBox txTelefono;
        private Autonomo.CustomControls.FlatTextBox txCedula;
        private Autonomo.CustomControls.FlatTextBox txNombres;
        private System.Windows.Forms.Button CreateButton;
        private Autonomo.CustomControls.CustomCheck RegistrarNuevoCheck;
        private Autonomo.CustomControls.CustomGrid grdData;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private Autonomo.CustomControls.FlatComboBox cbSearchMode;
    }
}