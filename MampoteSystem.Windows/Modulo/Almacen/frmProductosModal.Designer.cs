namespace MampoteSystem.Windows.Modulo.Almacen
{
    partial class frmProductosModal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductosModal));
            this.cbCategoria = new Autonomo.CustomControls.FlatComboBox();
            this.txCodigo = new Autonomo.CustomControls.FlatTextBox();
            this.txNombre = new Autonomo.CustomControls.FlatTextBox();
            this.txDescripcion = new Autonomo.CustomControls.FlatTextBox();
            this.txStock = new Autonomo.CustomControls.FlatTextBox();
            this.txPrecioCompra = new Autonomo.CustomControls.FlatTextBox();
            this.txPrecioVenta = new Autonomo.CustomControls.FlatTextBox();
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
            this.Body.Controls.Add(this.txPrecioCompra);
            this.Body.Controls.Add(this.txStock);
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
            this.btnSave.TabIndex = 7;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.cbCategoria.Location = new System.Drawing.Point(72, 34);
            this.cbCategoria.MaterialStyle = true;
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Placeholder = "Categoría";
            this.cbCategoria.SelectedIndex = -1;
            this.cbCategoria.Size = new System.Drawing.Size(278, 58);
            this.cbCategoria.SizeLine = 2;
            this.cbCategoria.TabIndex = 0;
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
            this.txCodigo.Location = new System.Drawing.Point(72, 34);
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
            this.txCodigo.TabIndex = 9999;
            this.txCodigo.Title = "Código del Producto";
            this.txCodigo.Visible = false;
            this.txCodigo.VisibleIcon = true;
            this.txCodigo.VisibleTitle = false;
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
            this.txNombre.Location = new System.Drawing.Point(72, 113);
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
            this.txNombre.TabIndex = 1;
            this.txNombre.Title = "Nombre";
            this.txNombre.VisibleIcon = true;
            this.txNombre.VisibleTitle = false;
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
            this.txDescripcion.Location = new System.Drawing.Point(72, 195);
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
            this.txDescripcion.TabIndex = 2;
            this.txDescripcion.Title = "Descripción";
            this.txDescripcion.VisibleIcon = true;
            this.txDescripcion.VisibleTitle = false;
            // 
            // txStock
            // 
            this.txStock.AlignText = System.Windows.Forms.HorizontalAlignment.Left;
            this.txStock.BackColor = System.Drawing.Color.White;
            this.txStock.Category = '\0';
            this.txStock.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txStock.ColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.txStock.ColorLine = System.Drawing.Color.Gray;
            this.txStock.ColorText = System.Drawing.SystemColors.WindowText;
            this.txStock.ColorTitle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txStock.DockIcon = System.Windows.Forms.DockStyle.Left;
            this.txStock.Error = "";
            this.txStock.FontText = new System.Drawing.Font("Verdana", 10F);
            this.txStock.FontTitle = new System.Drawing.Font("Verdana", 9F);
            this.txStock.FormatLogin = false;
            this.txStock.ImageIcon = global::MampoteSystem.Windows.Properties.Resources.counter_26px;
            this.txStock.Info = "";
            this.txStock.Location = new System.Drawing.Point(411, 34);
            this.txStock.MaterialStyle = true;
            this.txStock.MaxLength = 32767;
            this.txStock.MultiLineText = false;
            this.txStock.Name = "txStock";
            this.txStock.PasswordChar = '\0';
            this.txStock.Placeholder = "Stock";
            this.txStock.ReadOnly = false;
            this.txStock.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txStock.Size = new System.Drawing.Size(113, 58);
            this.txStock.SizeLine = 2;
            this.txStock.TabIndex = 4;
            this.txStock.Text = "0";
            this.txStock.Title = "Stock";
            this.txStock.VisibleIcon = true;
            this.txStock.VisibleTitle = true;
            this.txStock.KeyPress += new System.EventHandler<System.Windows.Forms.KeyPressEventArgs>(this.txStock_KeyPress);
            this.txStock.Enter += new System.EventHandler(this.txStock_Enter);
            this.txStock.Leave += new System.EventHandler(this.txStock_Leave);
            // 
            // txPrecioCompra
            // 
            this.txPrecioCompra.AlignText = System.Windows.Forms.HorizontalAlignment.Left;
            this.txPrecioCompra.BackColor = System.Drawing.Color.White;
            this.txPrecioCompra.Category = '\0';
            this.txPrecioCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txPrecioCompra.ColorFocus = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.txPrecioCompra.ColorLine = System.Drawing.Color.Gray;
            this.txPrecioCompra.ColorText = System.Drawing.SystemColors.WindowText;
            this.txPrecioCompra.ColorTitle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txPrecioCompra.DockIcon = System.Windows.Forms.DockStyle.Left;
            this.txPrecioCompra.Error = "";
            this.txPrecioCompra.FontText = new System.Drawing.Font("Verdana", 10F);
            this.txPrecioCompra.FontTitle = new System.Drawing.Font("Verdana", 9F);
            this.txPrecioCompra.FormatLogin = false;
            this.txPrecioCompra.ImageIcon = ((System.Drawing.Image)(resources.GetObject("txPrecioCompra.ImageIcon")));
            this.txPrecioCompra.Info = "";
            this.txPrecioCompra.Location = new System.Drawing.Point(411, 98);
            this.txPrecioCompra.MaterialStyle = true;
            this.txPrecioCompra.MaxLength = 32767;
            this.txPrecioCompra.MultiLineText = false;
            this.txPrecioCompra.Name = "txPrecioCompra";
            this.txPrecioCompra.PasswordChar = '\0';
            this.txPrecioCompra.Placeholder = "Precio de Compra";
            this.txPrecioCompra.ReadOnly = false;
            this.txPrecioCompra.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txPrecioCompra.Size = new System.Drawing.Size(156, 58);
            this.txPrecioCompra.SizeLine = 2;
            this.txPrecioCompra.TabIndex = 5;
            this.txPrecioCompra.Text = "0.00";
            this.txPrecioCompra.Title = "Precio de Compra";
            this.txPrecioCompra.VisibleIcon = true;
            this.txPrecioCompra.VisibleTitle = true;
            this.txPrecioCompra.KeyPress += new System.EventHandler<System.Windows.Forms.KeyPressEventArgs>(this.txPrecioCompra_KeyPress);
            this.txPrecioCompra.Enter += new System.EventHandler(this.txPrecioCompra_Enter);
            this.txPrecioCompra.Leave += new System.EventHandler(this.txPrecioCompra_Leave);
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
            this.txPrecioVenta.Location = new System.Drawing.Point(411, 162);
            this.txPrecioVenta.MaterialStyle = true;
            this.txPrecioVenta.MaxLength = 32767;
            this.txPrecioVenta.MultiLineText = false;
            this.txPrecioVenta.Name = "txPrecioVenta";
            this.txPrecioVenta.PasswordChar = '\0';
            this.txPrecioVenta.Placeholder = "Precio de Venta";
            this.txPrecioVenta.ReadOnly = false;
            this.txPrecioVenta.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txPrecioVenta.Size = new System.Drawing.Size(156, 58);
            this.txPrecioVenta.SizeLine = 2;
            this.txPrecioVenta.TabIndex = 6;
            this.txPrecioVenta.Text = "0.00";
            this.txPrecioVenta.Title = "Precio de Venta";
            this.txPrecioVenta.VisibleIcon = true;
            this.txPrecioVenta.VisibleTitle = true;
            this.txPrecioVenta.KeyPress += new System.EventHandler<System.Windows.Forms.KeyPressEventArgs>(this.txPrecioVenta_KeyPress);
            this.txPrecioVenta.Enter += new System.EventHandler(this.txPrecioVenta_Enter);
            this.txPrecioVenta.Leave += new System.EventHandler(this.txPrecioVenta_Leave);
            // 
            // frmProductosModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 431);
            this.Name = "frmProductosModal";
            this.Text = "frmProductosModal";
            this.Load += new System.EventHandler(this.frmProductosModal_Load);
            this.Contenedor.ResumeLayout(false);
            this.Body.ResumeLayout(false);
            this.Footer.ResumeLayout(false);
            this.Header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Autonomo.CustomControls.FlatTextBox txPrecioVenta;
        private Autonomo.CustomControls.FlatTextBox txPrecioCompra;
        private Autonomo.CustomControls.FlatTextBox txStock;
        private Autonomo.CustomControls.FlatTextBox txDescripcion;
        private Autonomo.CustomControls.FlatTextBox txNombre;
        private Autonomo.CustomControls.FlatComboBox cbCategoria;
        private Autonomo.CustomControls.FlatTextBox txCodigo;
    }
}