namespace MampoteSystem.Windows.Modulo.Proveedor
{
    partial class frmProveedoresModal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProveedoresModal));
            this.txRazonSocial = new Autonomo.CustomControls.FlatTextBox();
            this.txRIF = new Autonomo.CustomControls.FlatTextBox();
            this.txTelefono = new Autonomo.CustomControls.FlatTextBox();
            this.txEmail = new Autonomo.CustomControls.FlatTextBox();
            this.Contenedor.SuspendLayout();
            this.Body.SuspendLayout();
            this.Footer.SuspendLayout();
            this.Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // Contenedor
            // 
            this.Contenedor.Size = new System.Drawing.Size(323, 421);
            // 
            // Body
            // 
            this.Body.Controls.Add(this.txEmail);
            this.Body.Controls.Add(this.txTelefono);
            this.Body.Controls.Add(this.txRIF);
            this.Body.Controls.Add(this.txRazonSocial);
            this.Body.Size = new System.Drawing.Size(323, 328);
            // 
            // Footer
            // 
            this.Footer.Location = new System.Drawing.Point(0, 369);
            this.Footer.Size = new System.Drawing.Size(323, 52);
            // 
            // Header
            // 
            this.Header.Size = new System.Drawing.Size(323, 41);
            // 
            // Title
            // 
            this.Title.Size = new System.Drawing.Size(282, 41);
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txRazonSocial
            // 
            this.txRazonSocial.AlignText = System.Windows.Forms.HorizontalAlignment.Left;
            this.txRazonSocial.BackColor = System.Drawing.Color.White;
            this.txRazonSocial.Category = '\0';
            this.txRazonSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txRazonSocial.ColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.txRazonSocial.ColorLine = System.Drawing.Color.Gray;
            this.txRazonSocial.ColorText = System.Drawing.SystemColors.WindowText;
            this.txRazonSocial.ColorTitle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txRazonSocial.DockIcon = System.Windows.Forms.DockStyle.Left;
            this.txRazonSocial.Error = "";
            this.txRazonSocial.FontText = new System.Drawing.Font("Verdana", 10F);
            this.txRazonSocial.FontTitle = new System.Drawing.Font("Verdana", 9F);
            this.txRazonSocial.FormatLogin = false;
            this.txRazonSocial.ImageIcon = ((System.Drawing.Image)(resources.GetObject("txRazonSocial.ImageIcon")));
            this.txRazonSocial.Info = "";
            this.txRazonSocial.Location = new System.Drawing.Point(12, 23);
            this.txRazonSocial.MaterialStyle = true;
            this.txRazonSocial.MaxLength = 32767;
            this.txRazonSocial.MultiLineText = false;
            this.txRazonSocial.Name = "txRazonSocial";
            this.txRazonSocial.PasswordChar = '\0';
            this.txRazonSocial.Placeholder = "Ej. Empresa S.A";
            this.txRazonSocial.ReadOnly = false;
            this.txRazonSocial.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txRazonSocial.Size = new System.Drawing.Size(278, 58);
            this.txRazonSocial.SizeLine = 2;
            this.txRazonSocial.TabIndex = 0;
            this.txRazonSocial.Title = "Razón Social";
            this.txRazonSocial.VisibleIcon = true;
            this.txRazonSocial.VisibleTitle = true;
            // 
            // txRIF
            // 
            this.txRIF.AlignText = System.Windows.Forms.HorizontalAlignment.Left;
            this.txRIF.BackColor = System.Drawing.Color.White;
            this.txRIF.Category = '\0';
            this.txRIF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txRIF.ColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.txRIF.ColorLine = System.Drawing.Color.Gray;
            this.txRIF.ColorText = System.Drawing.SystemColors.WindowText;
            this.txRIF.ColorTitle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txRIF.DockIcon = System.Windows.Forms.DockStyle.Left;
            this.txRIF.Error = "";
            this.txRIF.FontText = new System.Drawing.Font("Verdana", 10F);
            this.txRIF.FontTitle = new System.Drawing.Font("Verdana", 9F);
            this.txRIF.FormatLogin = false;
            this.txRIF.ImageIcon = ((System.Drawing.Image)(resources.GetObject("txRIF.ImageIcon")));
            this.txRIF.Info = "";
            this.txRIF.Location = new System.Drawing.Point(12, 87);
            this.txRIF.MaterialStyle = true;
            this.txRIF.MaxLength = 12;
            this.txRIF.MultiLineText = false;
            this.txRIF.Name = "txRIF";
            this.txRIF.PasswordChar = '\0';
            this.txRIF.Placeholder = "Ej. 123000123";
            this.txRIF.ReadOnly = false;
            this.txRIF.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txRIF.Size = new System.Drawing.Size(278, 58);
            this.txRIF.SizeLine = 2;
            this.txRIF.TabIndex = 1;
            this.txRIF.Title = "RIF";
            this.txRIF.VisibleIcon = true;
            this.txRIF.VisibleTitle = true;
            this.txRIF.KeyPress += new System.EventHandler<System.Windows.Forms.KeyPressEventArgs>(this.txRIF_KeyPress);
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
            this.txTelefono.Location = new System.Drawing.Point(12, 151);
            this.txTelefono.MaterialStyle = false;
            this.txTelefono.MaxLength = 12;
            this.txTelefono.MultiLineText = false;
            this.txTelefono.Name = "txTelefono";
            this.txTelefono.PasswordChar = '\0';
            this.txTelefono.Placeholder = "Ej. 0212-0000000";
            this.txTelefono.ReadOnly = false;
            this.txTelefono.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txTelefono.Size = new System.Drawing.Size(278, 58);
            this.txTelefono.SizeLine = 2;
            this.txTelefono.TabIndex = 2;
            this.txTelefono.Title = "Teléfono";
            this.txTelefono.VisibleIcon = true;
            this.txTelefono.VisibleTitle = true;
            this.txTelefono.KeyPress += new System.EventHandler<System.Windows.Forms.KeyPressEventArgs>(this.txTelefono_KeyPress);
            // 
            // txEmail
            // 
            this.txEmail.AlignText = System.Windows.Forms.HorizontalAlignment.Left;
            this.txEmail.BackColor = System.Drawing.Color.White;
            this.txEmail.Category = '\0';
            this.txEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txEmail.ColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.txEmail.ColorLine = System.Drawing.Color.Gray;
            this.txEmail.ColorText = System.Drawing.SystemColors.WindowText;
            this.txEmail.ColorTitle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txEmail.DockIcon = System.Windows.Forms.DockStyle.Left;
            this.txEmail.Error = "";
            this.txEmail.FontText = new System.Drawing.Font("Verdana", 10F);
            this.txEmail.FontTitle = new System.Drawing.Font("Verdana", 9F);
            this.txEmail.FormatLogin = false;
            this.txEmail.ImageIcon = ((System.Drawing.Image)(resources.GetObject("txEmail.ImageIcon")));
            this.txEmail.Info = "";
            this.txEmail.Location = new System.Drawing.Point(12, 215);
            this.txEmail.MaterialStyle = false;
            this.txEmail.MaxLength = 32767;
            this.txEmail.MultiLineText = false;
            this.txEmail.Name = "txEmail";
            this.txEmail.PasswordChar = '\0';
            this.txEmail.Placeholder = "correo@correo.com";
            this.txEmail.ReadOnly = false;
            this.txEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txEmail.Size = new System.Drawing.Size(278, 58);
            this.txEmail.SizeLine = 2;
            this.txEmail.TabIndex = 3;
            this.txEmail.Title = "Email";
            this.txEmail.VisibleIcon = true;
            this.txEmail.VisibleTitle = true;
            this.txEmail.KeyPress += new System.EventHandler<System.Windows.Forms.KeyPressEventArgs>(this.txEmail_KeyPress);
            // 
            // frmProveedoresModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 421);
            this.Name = "frmProveedoresModal";
            this.Text = "frmProveedoresModal";
            this.Load += new System.EventHandler(this.frmProveedoresModal_Load);
            this.Contenedor.ResumeLayout(false);
            this.Body.ResumeLayout(false);
            this.Footer.ResumeLayout(false);
            this.Header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Autonomo.CustomControls.FlatTextBox txRazonSocial;
        private Autonomo.CustomControls.FlatTextBox txRIF;
        private Autonomo.CustomControls.FlatTextBox txEmail;
        private Autonomo.CustomControls.FlatTextBox txTelefono;
    }
}