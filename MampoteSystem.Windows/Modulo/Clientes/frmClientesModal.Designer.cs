namespace MampoteSystem.Windows.Modulo.Clientes
{
    partial class frmClientesModal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientesModal));
            this.txApellidos = new Autonomo.CustomControls.FlatTextBox();
            this.txTelefono = new Autonomo.CustomControls.FlatTextBox();
            this.txCedula = new Autonomo.CustomControls.FlatTextBox();
            this.txNombres = new Autonomo.CustomControls.FlatTextBox();
            this.txDireccion = new Autonomo.CustomControls.FlatTextBox();
            this.cbTipo = new Autonomo.CustomControls.FlatComboBox();
            this.Contenedor.SuspendLayout();
            this.Body.SuspendLayout();
            this.Footer.SuspendLayout();
            this.Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // Contenedor
            // 
            this.Contenedor.Size = new System.Drawing.Size(340, 604);
            // 
            // Body
            // 
            this.Body.Controls.Add(this.cbTipo);
            this.Body.Controls.Add(this.txDireccion);
            this.Body.Controls.Add(this.txApellidos);
            this.Body.Controls.Add(this.txTelefono);
            this.Body.Controls.Add(this.txCedula);
            this.Body.Controls.Add(this.txNombres);
            this.Body.Size = new System.Drawing.Size(340, 511);
            // 
            // Footer
            // 
            this.Footer.Location = new System.Drawing.Point(0, 552);
            this.Footer.Size = new System.Drawing.Size(340, 52);
            // 
            // Header
            // 
            this.Header.Size = new System.Drawing.Size(340, 41);
            // 
            // Title
            // 
            this.Title.Size = new System.Drawing.Size(299, 41);
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.TabIndex = 6;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.txApellidos.Location = new System.Drawing.Point(28, 210);
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
            this.txApellidos.TabIndex = 3;
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
            this.txTelefono.Location = new System.Drawing.Point(28, 274);
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
            this.txTelefono.TabIndex = 4;
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
            this.txCedula.Location = new System.Drawing.Point(28, 82);
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
            this.txCedula.TabIndex = 1;
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
            this.txNombres.Location = new System.Drawing.Point(28, 146);
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
            this.txNombres.TabIndex = 2;
            this.txNombres.Title = "Nombres";
            this.txNombres.VisibleIcon = true;
            this.txNombres.VisibleTitle = true;
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
            this.txDireccion.Location = new System.Drawing.Point(28, 347);
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
            this.txDireccion.TabIndex = 5;
            this.txDireccion.Title = "Dirección";
            this.txDireccion.VisibleIcon = true;
            this.txDireccion.VisibleTitle = true;
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
            this.cbTipo.Location = new System.Drawing.Point(28, 18);
            this.cbTipo.MaterialStyle = true;
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Placeholder = "Tipo de Cédula";
            this.cbTipo.SelectedIndex = -1;
            this.cbTipo.Size = new System.Drawing.Size(278, 58);
            this.cbTipo.SizeLine = 2;
            this.cbTipo.TabIndex = 0;
            this.cbTipo.Title = "Tipo de Cédula";
            this.cbTipo.ValueMember = "";
            this.cbTipo.VisibleIcon = true;
            this.cbTipo.VisibleTitle = false;
            // 
            // frmClientesModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 604);
            this.Name = "frmClientesModal";
            this.Text = "frmClientesModal";
            this.Contenedor.ResumeLayout(false);
            this.Body.ResumeLayout(false);
            this.Footer.ResumeLayout(false);
            this.Header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Autonomo.CustomControls.FlatTextBox txApellidos;
        private Autonomo.CustomControls.FlatTextBox txTelefono;
        private Autonomo.CustomControls.FlatTextBox txCedula;
        private Autonomo.CustomControls.FlatTextBox txNombres;
        private Autonomo.CustomControls.FlatTextBox txDireccion;
        private Autonomo.CustomControls.FlatComboBox cbTipo;
    }
}