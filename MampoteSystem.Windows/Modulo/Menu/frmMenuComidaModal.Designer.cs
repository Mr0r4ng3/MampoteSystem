namespace MampoteSystem.Windows.Modulo.Menu
{
    partial class frmMenuComidaModal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuComidaModal));
            this.txPrecioVenta = new Autonomo.CustomControls.FlatTextBox();
            this.txCostoProduccion = new Autonomo.CustomControls.FlatTextBox();
            this.txDescripcion = new Autonomo.CustomControls.FlatTextBox();
            this.txNombre = new Autonomo.CustomControls.FlatTextBox();
            this.cbCategoria = new Autonomo.CustomControls.FlatComboBox();
            this.txCodigo = new Autonomo.CustomControls.FlatTextBox();
            this.Contenedor.SuspendLayout();
            this.Body.SuspendLayout();
            this.Footer.SuspendLayout();
            this.Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // Contenedor
            // 
            this.Contenedor.Size = new System.Drawing.Size(598, 431);
            // 
            // Body
            // 
            this.Body.Controls.Add(this.txPrecioVenta);
            this.Body.Controls.Add(this.txCostoProduccion);
            this.Body.Controls.Add(this.txDescripcion);
            this.Body.Controls.Add(this.txNombre);
            this.Body.Controls.Add(this.cbCategoria);
            this.Body.Controls.Add(this.txCodigo);
            this.Body.Size = new System.Drawing.Size(598, 338);
            // 
            // Footer
            // 
            this.Footer.Location = new System.Drawing.Point(0, 379);
            this.Footer.Size = new System.Drawing.Size(598, 52);
            // 
            // Header
            // 
            this.Header.Size = new System.Drawing.Size(598, 41);
            // 
            // Title
            // 
            this.Title.Size = new System.Drawing.Size(557, 41);
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
            this.txPrecioVenta.Location = new System.Drawing.Point(391, 101);
            this.txPrecioVenta.MaterialStyle = true;
            this.txPrecioVenta.MaxLength = 32767;
            this.txPrecioVenta.MultiLineText = false;
            this.txPrecioVenta.Name = "txPrecioVenta";
            this.txPrecioVenta.PasswordChar = '\0';
            this.txPrecioVenta.Placeholder = "Precio de Venta";
            this.txPrecioVenta.ReadOnly = false;
            this.txPrecioVenta.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txPrecioVenta.Size = new System.Drawing.Size(175, 58);
            this.txPrecioVenta.SizeLine = 2;
            this.txPrecioVenta.TabIndex = 12;
            this.txPrecioVenta.Text = "0.00";
            this.txPrecioVenta.Title = "Precio de Venta";
            this.txPrecioVenta.VisibleIcon = true;
            this.txPrecioVenta.VisibleTitle = true;
            this.txPrecioVenta.KeyPress += new System.EventHandler<System.Windows.Forms.KeyPressEventArgs>(this.txPrecioVenta_KeyPress);
            this.txPrecioVenta.Enter += new System.EventHandler(this.txPrecioVenta_Enter);
            this.txPrecioVenta.Leave += new System.EventHandler(this.txPrecioVenta_Leave);
            // 
            // txCostoProduccion
            // 
            this.txCostoProduccion.AlignText = System.Windows.Forms.HorizontalAlignment.Left;
            this.txCostoProduccion.BackColor = System.Drawing.Color.White;
            this.txCostoProduccion.Category = '\0';
            this.txCostoProduccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txCostoProduccion.ColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.txCostoProduccion.ColorLine = System.Drawing.Color.Gray;
            this.txCostoProduccion.ColorText = System.Drawing.SystemColors.WindowText;
            this.txCostoProduccion.ColorTitle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txCostoProduccion.DockIcon = System.Windows.Forms.DockStyle.Left;
            this.txCostoProduccion.Error = "";
            this.txCostoProduccion.FontText = new System.Drawing.Font("Verdana", 10F);
            this.txCostoProduccion.FontTitle = new System.Drawing.Font("Verdana", 9F);
            this.txCostoProduccion.FormatLogin = false;
            this.txCostoProduccion.ImageIcon = ((System.Drawing.Image)(resources.GetObject("txCostoProduccion.ImageIcon")));
            this.txCostoProduccion.Info = "";
            this.txCostoProduccion.Location = new System.Drawing.Point(391, 37);
            this.txCostoProduccion.MaterialStyle = true;
            this.txCostoProduccion.MaxLength = 32767;
            this.txCostoProduccion.MultiLineText = false;
            this.txCostoProduccion.Name = "txCostoProduccion";
            this.txCostoProduccion.PasswordChar = '\0';
            this.txCostoProduccion.Placeholder = "Costo de Producción";
            this.txCostoProduccion.ReadOnly = false;
            this.txCostoProduccion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txCostoProduccion.Size = new System.Drawing.Size(175, 58);
            this.txCostoProduccion.SizeLine = 2;
            this.txCostoProduccion.TabIndex = 11;
            this.txCostoProduccion.Text = "0.00";
            this.txCostoProduccion.Title = "Costo de Producción";
            this.txCostoProduccion.VisibleIcon = true;
            this.txCostoProduccion.VisibleTitle = true;
            this.txCostoProduccion.KeyPress += new System.EventHandler<System.Windows.Forms.KeyPressEventArgs>(this.txCostoProduccion_KeyPress);
            this.txCostoProduccion.Enter += new System.EventHandler(this.txCostoProduccion_Enter);
            this.txCostoProduccion.Leave += new System.EventHandler(this.txCostoProduccion_Leave);
            // 
            // txDescripcion
            // 
            this.txDescripcion.AlignText = System.Windows.Forms.HorizontalAlignment.Left;
            this.txDescripcion.BackColor = System.Drawing.Color.White;
            this.txDescripcion.Category = '\0';
            this.txDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txDescripcion.ColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.txDescripcion.ColorLine = System.Drawing.Color.Gray;
            this.txDescripcion.ColorText = System.Drawing.SystemColors.WindowText;
            this.txDescripcion.ColorTitle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txDescripcion.DockIcon = System.Windows.Forms.DockStyle.Left;
            this.txDescripcion.Error = "";
            this.txDescripcion.FontText = new System.Drawing.Font("Verdana", 10F);
            this.txDescripcion.FontTitle = new System.Drawing.Font("Verdana", 9F);
            this.txDescripcion.FormatLogin = false;
            this.txDescripcion.ImageIcon = ((System.Drawing.Image)(resources.GetObject("txDescripcion.ImageIcon")));
            this.txDescripcion.Info = "";
            this.txDescripcion.Location = new System.Drawing.Point(52, 198);
            this.txDescripcion.MaterialStyle = true;
            this.txDescripcion.MaxLength = 32767;
            this.txDescripcion.MultiLineText = true;
            this.txDescripcion.Name = "txDescripcion";
            this.txDescripcion.PasswordChar = '\0';
            this.txDescripcion.Placeholder = "Descripción";
            this.txDescripcion.ReadOnly = false;
            this.txDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txDescripcion.Size = new System.Drawing.Size(278, 104);
            this.txDescripcion.SizeLine = 2;
            this.txDescripcion.TabIndex = 9;
            this.txDescripcion.Title = "Descripción";
            this.txDescripcion.VisibleIcon = true;
            this.txDescripcion.VisibleTitle = false;
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
            this.txNombre.Location = new System.Drawing.Point(52, 116);
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
            this.txNombre.TabIndex = 8;
            this.txNombre.Title = "Nombre";
            this.txNombre.VisibleIcon = true;
            this.txNombre.VisibleTitle = false;
            // 
            // cbCategoria
            // 
            this.cbCategoria.BackColor = System.Drawing.Color.White;
            this.cbCategoria.Category = '\0';
            this.cbCategoria.ColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.cbCategoria.ColorLine = System.Drawing.Color.Gray;
            this.cbCategoria.ColorText = System.Drawing.SystemColors.WindowText;
            this.cbCategoria.ColorTitle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbCategoria.DisplayMember = "";
            this.cbCategoria.DockIcon = System.Windows.Forms.DockStyle.Left;
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.Error = "";
            this.cbCategoria.FontText = new System.Drawing.Font("Verdana", 10F);
            this.cbCategoria.FontTitle = new System.Drawing.Font("Verdana", 9F);
            this.cbCategoria.ImageIcon = ((System.Drawing.Image)(resources.GetObject("cbCategoria.ImageIcon")));
            this.cbCategoria.Info = "";
            this.cbCategoria.Location = new System.Drawing.Point(52, 37);
            this.cbCategoria.MaterialStyle = true;
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Placeholder = "Categoría";
            this.cbCategoria.SelectedIndex = -1;
            this.cbCategoria.Size = new System.Drawing.Size(278, 58);
            this.cbCategoria.SizeLine = 2;
            this.cbCategoria.TabIndex = 7;
            this.cbCategoria.Title = "Categoría";
            this.cbCategoria.ValueMember = "";
            this.cbCategoria.VisibleIcon = true;
            this.cbCategoria.VisibleTitle = false;
            // 
            // txCodigo
            // 
            this.txCodigo.AlignText = System.Windows.Forms.HorizontalAlignment.Left;
            this.txCodigo.BackColor = System.Drawing.Color.White;
            this.txCodigo.Category = '\0';
            this.txCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txCodigo.ColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.txCodigo.ColorLine = System.Drawing.Color.Gray;
            this.txCodigo.ColorText = System.Drawing.SystemColors.WindowText;
            this.txCodigo.ColorTitle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txCodigo.DockIcon = System.Windows.Forms.DockStyle.Left;
            this.txCodigo.Error = "";
            this.txCodigo.FontText = new System.Drawing.Font("Verdana", 10F);
            this.txCodigo.FontTitle = new System.Drawing.Font("Verdana", 9F);
            this.txCodigo.FormatLogin = false;
            this.txCodigo.ImageIcon = ((System.Drawing.Image)(resources.GetObject("txCodigo.ImageIcon")));
            this.txCodigo.Info = "";
            this.txCodigo.Location = new System.Drawing.Point(52, 37);
            this.txCodigo.MaterialStyle = true;
            this.txCodigo.MaxLength = 32767;
            this.txCodigo.MultiLineText = false;
            this.txCodigo.Name = "txCodigo";
            this.txCodigo.PasswordChar = '\0';
            this.txCodigo.Placeholder = "Código del Producto";
            this.txCodigo.ReadOnly = true;
            this.txCodigo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txCodigo.Size = new System.Drawing.Size(278, 58);
            this.txCodigo.SizeLine = 2;
            this.txCodigo.TabIndex = 10000;
            this.txCodigo.Title = "Código del Producto";
            this.txCodigo.Visible = false;
            this.txCodigo.VisibleIcon = true;
            this.txCodigo.VisibleTitle = false;
            // 
            // frmMenuModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 431);
            this.Name = "frmMenuModal";
            this.Text = "frmMenuModal";
            this.Load += new System.EventHandler(this.frmMenuModal_Load);
            this.Contenedor.ResumeLayout(false);
            this.Body.ResumeLayout(false);
            this.Footer.ResumeLayout(false);
            this.Header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Autonomo.CustomControls.FlatTextBox txPrecioVenta;
        private Autonomo.CustomControls.FlatTextBox txCostoProduccion;
        private Autonomo.CustomControls.FlatTextBox txDescripcion;
        private Autonomo.CustomControls.FlatTextBox txNombre;
        private Autonomo.CustomControls.FlatComboBox cbCategoria;
        private Autonomo.CustomControls.FlatTextBox txCodigo;
    }
}