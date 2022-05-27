namespace MampoteSystem.Windows.Modulo.Proveedor
{
    partial class frmProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProveedores));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txFilter = new Autonomo.CustomControls.FlatFindText();
            this.grdData = new Autonomo.CustomControls.CustomGrid();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Razon_Social = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RIF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.pnlContenedor.Size = new System.Drawing.Size(800, 450);
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.grdData);
            this.pnlGrid.Size = new System.Drawing.Size(800, 306);
            // 
            // pnlBottonControl
            // 
            this.pnlBottonControl.Location = new System.Drawing.Point(0, 418);
            // 
            // pnlTopControl
            // 
            this.pnlTopControl.Controls.Add(this.txFilter);
            this.pnlTopControl.Controls.SetChildIndex(this.TopLine, 0);
            this.pnlTopControl.Controls.SetChildIndex(this.Title, 0);
            this.pnlTopControl.Controls.SetChildIndex(this.pnlTopButton, 0);
            this.pnlTopControl.Controls.SetChildIndex(this.txFilter, 0);
            // 
            // Title
            // 
            this.Title.Size = new System.Drawing.Size(226, 18);
            this.Title.Text = "Registro de proveedores";
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
            // 
            // btnCommand2
            // 
            this.btnCommand2.FlatAppearance.BorderSize = 0;
            // 
            // btnCommand1
            // 
            this.btnCommand1.FlatAppearance.BorderSize = 0;
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
            this.txFilter.Placeholder = "Buscar por razón social";
            this.txFilter.PlaceHolderHeight = 18;
            this.txFilter.ReadOnly = false;
            this.txFilter.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txFilter.Size = new System.Drawing.Size(278, 44);
            this.txFilter.SizeLine = 2;
            this.txFilter.StringArray = null;
            this.txFilter.TabIndex = 3;
            this.txFilter.TextId = "";
            this.txFilter.Title = "Buscar por razón social";
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Razon_Social,
            this.RIF,
            this.Telefono,
            this.Email});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdData.DefaultCellStyle = dataGridViewCellStyle4;
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
            this.grdData.Size = new System.Drawing.Size(800, 306);
            this.grdData.TabIndex = 1;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // Razon_Social
            // 
            this.Razon_Social.DataPropertyName = "Razon_Social";
            this.Razon_Social.HeaderText = "Razón Social";
            this.Razon_Social.Name = "Razon_Social";
            this.Razon_Social.ReadOnly = true;
            // 
            // RIF
            // 
            this.RIF.DataPropertyName = "RIF";
            this.RIF.HeaderText = "RIF";
            this.RIF.Name = "RIF";
            this.RIF.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 200;
            // 
            // frmProveedores
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "frmProveedores";
            this.Text = "frmProveedores";
            this.Load += new System.EventHandler(this.frmProveedores_Load);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Razon_Social;
        private System.Windows.Forms.DataGridViewTextBoxColumn RIF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}