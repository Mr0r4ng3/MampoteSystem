namespace MampoteSystem.Windows.Admin
{
    partial class frmUsuariosModal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuariosModal));
            this.cbTipo = new Autonomo.CustomControls.FlatComboBox();
            this.txApellidos = new Autonomo.CustomControls.FlatTextBox();
            this.txCedula = new Autonomo.CustomControls.FlatTextBox();
            this.txNombres = new Autonomo.CustomControls.FlatTextBox();
            this.txUsername = new Autonomo.CustomControls.FlatTextBox();
            this.txPassword = new Autonomo.CustomControls.FlatTextBox();
            this.txPassword2 = new Autonomo.CustomControls.FlatTextBox();
            this.cbAcceso = new Autonomo.CustomControls.FlatComboBox();
            this.chkActualizarPasswd = new Autonomo.CustomControls.CustomCheck();
            this.Contenedor.SuspendLayout();
            this.Body.SuspendLayout();
            this.Footer.SuspendLayout();
            this.Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // Contenedor
            // 
            this.Contenedor.Size = new System.Drawing.Size(654, 468);
            // 
            // Body
            // 
            this.Body.Controls.Add(this.chkActualizarPasswd);
            this.Body.Controls.Add(this.cbAcceso);
            this.Body.Controls.Add(this.txPassword2);
            this.Body.Controls.Add(this.txPassword);
            this.Body.Controls.Add(this.txUsername);
            this.Body.Controls.Add(this.cbTipo);
            this.Body.Controls.Add(this.txApellidos);
            this.Body.Controls.Add(this.txCedula);
            this.Body.Controls.Add(this.txNombres);
            this.Body.Size = new System.Drawing.Size(654, 375);
            // 
            // Footer
            // 
            this.Footer.Location = new System.Drawing.Point(0, 416);
            this.Footer.Size = new System.Drawing.Size(654, 52);
            // 
            // Header
            // 
            this.Header.Size = new System.Drawing.Size(654, 41);
            // 
            // Title
            // 
            this.Title.Size = new System.Drawing.Size(613, 41);
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Location = new System.Drawing.Point(265, 6);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.cbTipo.Location = new System.Drawing.Point(12, 35);
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
            this.txApellidos.Location = new System.Drawing.Point(12, 227);
            this.txApellidos.MaterialStyle = true;
            this.txApellidos.MaxLength = 32767;
            this.txApellidos.MultiLineText = false;
            this.txApellidos.Name = "txApellidos";
            this.txApellidos.PasswordChar = '\0';
            this.txApellidos.Placeholder = "Apellidos";
            this.txApellidos.ReadOnly = false;
            this.txApellidos.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txApellidos.Size = new System.Drawing.Size(278, 58);
            this.txApellidos.SizeLine = 2;
            this.txApellidos.TabIndex = 3;
            this.txApellidos.Title = "Apellidos";
            this.txApellidos.VisibleIcon = true;
            this.txApellidos.VisibleTitle = false;
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
            this.txCedula.Location = new System.Drawing.Point(12, 99);
            this.txCedula.MaterialStyle = false;
            this.txCedula.MaxLength = 12;
            this.txCedula.MultiLineText = false;
            this.txCedula.Name = "txCedula";
            this.txCedula.PasswordChar = '\0';
            this.txCedula.Placeholder = "Ej. 12345678";
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
            this.txNombres.Location = new System.Drawing.Point(12, 163);
            this.txNombres.MaterialStyle = true;
            this.txNombres.MaxLength = 32767;
            this.txNombres.MultiLineText = false;
            this.txNombres.Name = "txNombres";
            this.txNombres.PasswordChar = '\0';
            this.txNombres.Placeholder = "Nombres";
            this.txNombres.ReadOnly = false;
            this.txNombres.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txNombres.Size = new System.Drawing.Size(278, 58);
            this.txNombres.SizeLine = 2;
            this.txNombres.TabIndex = 2;
            this.txNombres.Title = "Nombres";
            this.txNombres.VisibleIcon = true;
            this.txNombres.VisibleTitle = false;
            // 
            // txUsername
            // 
            this.txUsername.AlignText = System.Windows.Forms.HorizontalAlignment.Left;
            this.txUsername.BackColor = System.Drawing.Color.White;
            this.txUsername.Category = '\0';
            this.txUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txUsername.ColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.txUsername.ColorLine = System.Drawing.Color.Gray;
            this.txUsername.ColorText = System.Drawing.SystemColors.WindowText;
            this.txUsername.ColorTitle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txUsername.DockIcon = System.Windows.Forms.DockStyle.Left;
            this.txUsername.Error = "";
            this.txUsername.FontText = new System.Drawing.Font("Verdana", 10F);
            this.txUsername.FontTitle = new System.Drawing.Font("Verdana", 9F);
            this.txUsername.FormatLogin = false;
            this.txUsername.ImageIcon = ((System.Drawing.Image)(resources.GetObject("txUsername.ImageIcon")));
            this.txUsername.Info = "";
            this.txUsername.Location = new System.Drawing.Point(12, 291);
            this.txUsername.MaterialStyle = true;
            this.txUsername.MaxLength = 16;
            this.txUsername.MultiLineText = false;
            this.txUsername.Name = "txUsername";
            this.txUsername.PasswordChar = '\0';
            this.txUsername.Placeholder = "Nombre de Usuario";
            this.txUsername.ReadOnly = false;
            this.txUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txUsername.Size = new System.Drawing.Size(278, 58);
            this.txUsername.SizeLine = 2;
            this.txUsername.TabIndex = 4;
            this.txUsername.Title = "Nombre de Usuario";
            this.txUsername.VisibleIcon = true;
            this.txUsername.VisibleTitle = false;
            // 
            // txPassword
            // 
            this.txPassword.AlignText = System.Windows.Forms.HorizontalAlignment.Left;
            this.txPassword.BackColor = System.Drawing.Color.White;
            this.txPassword.Category = '\0';
            this.txPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txPassword.ColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.txPassword.ColorLine = System.Drawing.Color.Gray;
            this.txPassword.ColorText = System.Drawing.SystemColors.WindowText;
            this.txPassword.ColorTitle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txPassword.DockIcon = System.Windows.Forms.DockStyle.Left;
            this.txPassword.Error = "";
            this.txPassword.FontText = new System.Drawing.Font("Verdana", 10F);
            this.txPassword.FontTitle = new System.Drawing.Font("Verdana", 9F);
            this.txPassword.FormatLogin = false;
            this.txPassword.ImageIcon = ((System.Drawing.Image)(resources.GetObject("txPassword.ImageIcon")));
            this.txPassword.Info = "";
            this.txPassword.Location = new System.Drawing.Point(345, 63);
            this.txPassword.MaterialStyle = true;
            this.txPassword.MaxLength = 16;
            this.txPassword.MultiLineText = false;
            this.txPassword.Name = "txPassword";
            this.txPassword.PasswordChar = '*';
            this.txPassword.Placeholder = "Contraseña";
            this.txPassword.ReadOnly = false;
            this.txPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txPassword.Size = new System.Drawing.Size(278, 58);
            this.txPassword.SizeLine = 2;
            this.txPassword.TabIndex = 6;
            this.txPassword.Title = "Contraseña";
            this.txPassword.VisibleIcon = true;
            this.txPassword.VisibleTitle = false;
            // 
            // txPassword2
            // 
            this.txPassword2.AlignText = System.Windows.Forms.HorizontalAlignment.Left;
            this.txPassword2.BackColor = System.Drawing.Color.White;
            this.txPassword2.Category = '\0';
            this.txPassword2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txPassword2.ColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.txPassword2.ColorLine = System.Drawing.Color.Gray;
            this.txPassword2.ColorText = System.Drawing.SystemColors.WindowText;
            this.txPassword2.ColorTitle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txPassword2.DockIcon = System.Windows.Forms.DockStyle.Left;
            this.txPassword2.Error = "";
            this.txPassword2.FontText = new System.Drawing.Font("Verdana", 10F);
            this.txPassword2.FontTitle = new System.Drawing.Font("Verdana", 9F);
            this.txPassword2.FormatLogin = false;
            this.txPassword2.ImageIcon = ((System.Drawing.Image)(resources.GetObject("txPassword2.ImageIcon")));
            this.txPassword2.Info = "";
            this.txPassword2.Location = new System.Drawing.Point(345, 127);
            this.txPassword2.MaterialStyle = true;
            this.txPassword2.MaxLength = 16;
            this.txPassword2.MultiLineText = false;
            this.txPassword2.Name = "txPassword2";
            this.txPassword2.PasswordChar = '*';
            this.txPassword2.Placeholder = "Ingrese nuevamente su contraseña";
            this.txPassword2.ReadOnly = false;
            this.txPassword2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txPassword2.Size = new System.Drawing.Size(278, 58);
            this.txPassword2.SizeLine = 2;
            this.txPassword2.TabIndex = 7;
            this.txPassword2.Title = "Ingrese nuevamente su contraseña";
            this.txPassword2.VisibleIcon = true;
            this.txPassword2.VisibleTitle = false;
            // 
            // cbAcceso
            // 
            this.cbAcceso.BackColor = System.Drawing.Color.White;
            this.cbAcceso.Category = '\0';
            this.cbAcceso.ColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.cbAcceso.ColorLine = System.Drawing.Color.Gray;
            this.cbAcceso.ColorText = System.Drawing.SystemColors.WindowText;
            this.cbAcceso.ColorTitle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbAcceso.DisplayMember = "";
            this.cbAcceso.DockIcon = System.Windows.Forms.DockStyle.Left;
            this.cbAcceso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAcceso.Error = "";
            this.cbAcceso.FontText = new System.Drawing.Font("Verdana", 10F);
            this.cbAcceso.FontTitle = new System.Drawing.Font("Verdana", 9F);
            this.cbAcceso.ImageIcon = ((System.Drawing.Image)(resources.GetObject("cbAcceso.ImageIcon")));
            this.cbAcceso.Info = "";
            this.cbAcceso.Location = new System.Drawing.Point(345, 213);
            this.cbAcceso.MaterialStyle = true;
            this.cbAcceso.Name = "cbAcceso";
            this.cbAcceso.Placeholder = "Nivel de Acceso";
            this.cbAcceso.SelectedIndex = -1;
            this.cbAcceso.Size = new System.Drawing.Size(278, 58);
            this.cbAcceso.SizeLine = 2;
            this.cbAcceso.TabIndex = 8;
            this.cbAcceso.Title = "Nivel de Acceso";
            this.cbAcceso.ValueMember = "";
            this.cbAcceso.VisibleIcon = true;
            this.cbAcceso.VisibleTitle = false;
            // 
            // chkActualizarPasswd
            // 
            this.chkActualizarPasswd.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkActualizarPasswd.AutoSize = true;
            this.chkActualizarPasswd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkActualizarPasswd.FlatAppearance.BorderSize = 0;
            this.chkActualizarPasswd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.chkActualizarPasswd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.chkActualizarPasswd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkActualizarPasswd.Font = new System.Drawing.Font("Verdana", 10F);
            this.chkActualizarPasswd.Image = ((System.Drawing.Image)(resources.GetObject("chkActualizarPasswd.Image")));
            this.chkActualizarPasswd.ImageChecking = ((System.Drawing.Image)(resources.GetObject("chkActualizarPasswd.ImageChecking")));
            this.chkActualizarPasswd.ImageUnChecking = ((System.Drawing.Image)(resources.GetObject("chkActualizarPasswd.ImageUnChecking")));
            this.chkActualizarPasswd.Location = new System.Drawing.Point(357, 30);
            this.chkActualizarPasswd.Name = "chkActualizarPasswd";
            this.chkActualizarPasswd.Size = new System.Drawing.Size(176, 27);
            this.chkActualizarPasswd.TabIndex = 9;
            this.chkActualizarPasswd.Text = "Cambiar contraseña";
            this.chkActualizarPasswd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkActualizarPasswd.UseVisualStyleBackColor = true;
            this.chkActualizarPasswd.CheckedChanged += new System.EventHandler(this.chkActualizarPasswd_CheckedChanged);
            // 
            // frmUsuariosModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 468);
            this.Name = "frmUsuariosModal";
            this.Text = "frmUsuariosModal";
            this.Load += new System.EventHandler(this.frmUsuariosModal_Load);
            this.Contenedor.ResumeLayout(false);
            this.Body.ResumeLayout(false);
            this.Body.PerformLayout();
            this.Footer.ResumeLayout(false);
            this.Header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Autonomo.CustomControls.FlatComboBox cbTipo;
        private Autonomo.CustomControls.FlatTextBox txApellidos;
        private Autonomo.CustomControls.FlatTextBox txCedula;
        private Autonomo.CustomControls.FlatTextBox txNombres;
        private Autonomo.CustomControls.FlatTextBox txPassword2;
        private Autonomo.CustomControls.FlatTextBox txPassword;
        private Autonomo.CustomControls.FlatTextBox txUsername;
        private Autonomo.CustomControls.FlatComboBox cbAcceso;
        private Autonomo.CustomControls.CustomCheck chkActualizarPasswd;
    }
}