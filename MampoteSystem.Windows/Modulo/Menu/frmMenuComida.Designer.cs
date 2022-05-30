namespace MampoteSystem.Windows.Modulo.Menu
{
    partial class frmMenuComida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuComida));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txFilter = new Autonomo.CustomControls.FlatFindText();
            this.grdData = new Autonomo.CustomControls.CustomGrid();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo_Produccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totaMasIVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.pnlContenedor.Size = new System.Drawing.Size(984, 450);
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.grdData);
            this.pnlGrid.Size = new System.Drawing.Size(984, 306);
            // 
            // pnlBottonControl
            // 
            this.pnlBottonControl.Location = new System.Drawing.Point(0, 418);
            this.pnlBottonControl.Size = new System.Drawing.Size(984, 32);
            // 
            // pnlTopControl
            // 
            this.pnlTopControl.Controls.Add(this.txFilter);
            this.pnlTopControl.Size = new System.Drawing.Size(984, 112);
            this.pnlTopControl.Controls.SetChildIndex(this.TopLine, 0);
            this.pnlTopControl.Controls.SetChildIndex(this.Title, 0);
            this.pnlTopControl.Controls.SetChildIndex(this.pnlTopButton, 0);
            this.pnlTopControl.Controls.SetChildIndex(this.txFilter, 0);
            // 
            // pnlTopButton
            // 
            this.pnlTopButton.Size = new System.Drawing.Size(984, 28);
            // 
            // BottomLine
            // 
            this.BottomLine.Size = new System.Drawing.Size(984, 2);
            // 
            // TopLine
            // 
            this.TopLine.Size = new System.Drawing.Size(984, 2);
            // 
            // Title
            // 
            this.Title.Size = new System.Drawing.Size(162, 18);
            this.Title.Text = "Registro de Menu";
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
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnCommand3
            // 
            this.btnCommand3.FlatAppearance.BorderSize = 0;
            this.btnCommand3.Location = new System.Drawing.Point(630, 0);
            // 
            // btnCommand2
            // 
            this.btnCommand2.FlatAppearance.BorderSize = 0;
            this.btnCommand2.Location = new System.Drawing.Point(526, 0);
            // 
            // btnCommand1
            // 
            this.btnCommand1.FlatAppearance.BorderSize = 0;
            this.btnCommand1.Size = new System.Drawing.Size(146, 28);
            this.btnCommand1.Text = "Establecer Stock";
            this.btnCommand1.Visible = true;
            this.btnCommand1.Click += new System.EventHandler(this.btnCommand1_Click);
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
            this.txFilter.Location = new System.Drawing.Point(12, 32);
            this.txFilter.MaterialStyle = true;
            this.txFilter.MaxLength = 32767;
            this.txFilter.MultiLineText = false;
            this.txFilter.Name = "txFilter";
            this.txFilter.ObjectArray = null;
            this.txFilter.PasswordChar = '\0';
            this.txFilter.Placeholder = "Buscar por código o nombre";
            this.txFilter.PlaceHolderHeight = 18;
            this.txFilter.ReadOnly = false;
            this.txFilter.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txFilter.Size = new System.Drawing.Size(278, 44);
            this.txFilter.SizeLine = 2;
            this.txFilter.StringArray = null;
            this.txFilter.TabIndex = 4;
            this.txFilter.TextId = "";
            this.txFilter.Title = "Buscar por código o nombre";
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
            this.Codigo,
            this.Nombre,
            this.Descripcion,
            this.idCategoria,
            this.Categoria,
            this.Costo_Produccion,
            this.Precio_Venta,
            this.IVA,
            this.totaMasIVA});
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
            this.grdData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdData.Size = new System.Drawing.Size(984, 306);
            this.grdData.TabIndex = 2;
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
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // idCategoria
            // 
            this.idCategoria.DataPropertyName = "idCategoria";
            this.idCategoria.HeaderText = "idCategoria";
            this.idCategoria.Name = "idCategoria";
            this.idCategoria.ReadOnly = true;
            this.idCategoria.Visible = false;
            // 
            // Categoria
            // 
            this.Categoria.DataPropertyName = "Categoria";
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // Costo_Produccion
            // 
            this.Costo_Produccion.DataPropertyName = "Costo";
            this.Costo_Produccion.HeaderText = "Costo de Produccion";
            this.Costo_Produccion.Name = "Costo_Produccion";
            this.Costo_Produccion.ReadOnly = true;
            // 
            // Precio_Venta
            // 
            this.Precio_Venta.DataPropertyName = "Precio_Venta";
            this.Precio_Venta.HeaderText = "Precio de Venta";
            this.Precio_Venta.Name = "Precio_Venta";
            this.Precio_Venta.ReadOnly = true;
            // 
            // IVA
            // 
            this.IVA.DataPropertyName = "IVA";
            this.IVA.HeaderText = "IVA";
            this.IVA.Name = "IVA";
            this.IVA.ReadOnly = true;
            this.IVA.Visible = false;
            // 
            // totaMasIVA
            // 
            this.totaMasIVA.DataPropertyName = "totalMasIVA";
            this.totaMasIVA.HeaderText = "Total con IVA";
            this.totaMasIVA.Name = "totaMasIVA";
            this.totaMasIVA.ReadOnly = true;
            this.totaMasIVA.Visible = false;
            // 
            // frmMenuComida
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(984, 450);
            this.Name = "frmMenuComida";
            this.Text = "frmMenu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
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

        private Autonomo.CustomControls.FlatFindText txFilter;
        private Autonomo.CustomControls.CustomGrid grdData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo_Produccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn IVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn totaMasIVA;
    }
}