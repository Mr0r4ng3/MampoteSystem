namespace MampoteSystem.Windows.Modulo.Almacen
{
    partial class frmPromocionModal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPromocionModal));
            this.txPrecioVenta = new Autonomo.CustomControls.FlatTextBox();
            this.txNombre = new Autonomo.CustomControls.FlatTextBox();
            this.Contenedor.SuspendLayout();
            this.Body.SuspendLayout();
            this.Footer.SuspendLayout();
            this.Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // Contenedor
            // 
            this.Contenedor.Size = new System.Drawing.Size(349, 278);
            // 
            // Body
            // 
            this.Body.Controls.Add(this.txPrecioVenta);
            this.Body.Controls.Add(this.txNombre);
            this.Body.Size = new System.Drawing.Size(349, 185);
            // 
            // Footer
            // 
            this.Footer.Location = new System.Drawing.Point(0, 226);
            this.Footer.Size = new System.Drawing.Size(349, 52);
            // 
            // Header
            // 
            this.Header.Size = new System.Drawing.Size(349, 41);
            // 
            // Title
            // 
            this.Title.Size = new System.Drawing.Size(308, 41);
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txPrecioVenta
            // 
            this.txPrecioVenta.AlignText = System.Windows.Forms.HorizontalAlignment.Left;
            this.txPrecioVenta.BackColor = System.Drawing.Color.White;
            this.txPrecioVenta.Category = '\0';
            this.txPrecioVenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txPrecioVenta.ColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.txPrecioVenta.ColorLine = System.Drawing.Color.Gray;
            this.txPrecioVenta.ColorText = System.Drawing.SystemColors.WindowText;
            this.txPrecioVenta.ColorTitle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txPrecioVenta.DockIcon = System.Windows.Forms.DockStyle.Left;
            this.txPrecioVenta.Error = "";
            this.txPrecioVenta.FontText = new System.Drawing.Font("Verdana", 10F);
            this.txPrecioVenta.FontTitle = new System.Drawing.Font("Verdana", 9F);
            this.txPrecioVenta.FormatLogin = false;
            this.txPrecioVenta.ImageIcon = ((System.Drawing.Image)(resources.GetObject("txPrecioVenta.ImageIcon")));
            this.txPrecioVenta.Info = "";
            this.txPrecioVenta.Location = new System.Drawing.Point(30, 108);
            this.txPrecioVenta.MaterialStyle = true;
            this.txPrecioVenta.MaxLength = 32767;
            this.txPrecioVenta.MultiLineText = false;
            this.txPrecioVenta.Name = "txPrecioVenta";
            this.txPrecioVenta.PasswordChar = '\0';
            this.txPrecioVenta.Placeholder = "Monto Descontado";
            this.txPrecioVenta.ReadOnly = false;
            this.txPrecioVenta.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txPrecioVenta.Size = new System.Drawing.Size(156, 58);
            this.txPrecioVenta.SizeLine = 2;
            this.txPrecioVenta.TabIndex = 8;
            this.txPrecioVenta.Text = "0.00";
            this.txPrecioVenta.Title = "Monto Descontado";
            this.txPrecioVenta.VisibleIcon = true;
            this.txPrecioVenta.VisibleTitle = true;
            this.txPrecioVenta.KeyPress += new System.EventHandler<System.Windows.Forms.KeyPressEventArgs>(this.txPrecioVenta_KeyPress);
            // 
            // txNombre
            // 
            this.txNombre.AlignText = System.Windows.Forms.HorizontalAlignment.Left;
            this.txNombre.BackColor = System.Drawing.Color.White;
            this.txNombre.Category = '\0';
            this.txNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txNombre.ColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.txNombre.ColorLine = System.Drawing.Color.Gray;
            this.txNombre.ColorText = System.Drawing.SystemColors.WindowText;
            this.txNombre.ColorTitle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txNombre.DockIcon = System.Windows.Forms.DockStyle.Left;
            this.txNombre.Error = "";
            this.txNombre.FontText = new System.Drawing.Font("Verdana", 10F);
            this.txNombre.FontTitle = new System.Drawing.Font("Verdana", 9F);
            this.txNombre.FormatLogin = false;
            this.txNombre.ImageIcon = ((System.Drawing.Image)(resources.GetObject("txNombre.ImageIcon")));
            this.txNombre.Info = "";
            this.txNombre.Location = new System.Drawing.Point(30, 44);
            this.txNombre.MaterialStyle = true;
            this.txNombre.MaxLength = 32767;
            this.txNombre.MultiLineText = false;
            this.txNombre.Name = "txNombre";
            this.txNombre.PasswordChar = '\0';
            this.txNombre.Placeholder = "Nombre";
            this.txNombre.ReadOnly = false;
            this.txNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txNombre.Size = new System.Drawing.Size(278, 58);
            this.txNombre.SizeLine = 2;
            this.txNombre.TabIndex = 7;
            this.txNombre.Title = "Nombre";
            this.txNombre.VisibleIcon = true;
            this.txNombre.VisibleTitle = false;
            // 
            // frmPromocionModal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(349, 278);
            this.Name = "frmPromocionModal";
            this.Text = "frmPromocionModal";
            this.Load += new System.EventHandler(this.frmPromocionModal_Load);
            this.Contenedor.ResumeLayout(false);
            this.Body.ResumeLayout(false);
            this.Footer.ResumeLayout(false);
            this.Header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Autonomo.CustomControls.FlatTextBox txPrecioVenta;
        private Autonomo.CustomControls.FlatTextBox txNombre;
    }
}