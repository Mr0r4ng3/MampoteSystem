namespace MampoteSystem.Windows.Home
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.btnCategoriaProd = new Autonomo.CustomControls.LabelButton();
            this.btnProductos = new Autonomo.CustomControls.LabelButton();
            this.btnCategoriaMenu = new Autonomo.CustomControls.LabelButton();
            this.btnMenuComida = new Autonomo.CustomControls.LabelButton();
            this.btnProveedores = new Autonomo.CustomControls.LabelButton();
            this.btnClientes = new Autonomo.CustomControls.LabelButton();
            this.btnCompras = new Autonomo.CustomControls.LabelButton();
            this.btnActualizarTasa = new Autonomo.CustomControls.LabelButton();
            this.btnUsuarios = new Autonomo.CustomControls.LabelButton();
            this.btnAbrirVenta = new Autonomo.CustomControls.LabelButton();
            this.labelButton2 = new Autonomo.CustomControls.LabelButton();
            this.labelButton1 = new Autonomo.CustomControls.LabelButton();
            this.btnResumenPagos = new Autonomo.CustomControls.LabelButton();
            this.lbProductosVendidos = new Autonomo.CustomControls.LabelButton();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.PanelVenta.SuspendLayout();
            this.PanelConfiguracion.SuspendLayout();
            this.PanelCompra.SuspendLayout();
            this.PanelAlmacen.SuspendLayout();
            this.PanelReporte.SuspendLayout();
            this.PanelCliente.SuspendLayout();
            this.PanelProveedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserDisplayText
            // 
            this.UserDisplayText.Text = "Bienvenido ";
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            // 
            // PanelVenta
            // 
            this.PanelVenta.Controls.Add(this.btnResumenPagos);
            this.PanelVenta.Controls.Add(this.labelButton2);
            this.PanelVenta.Controls.Add(this.btnAbrirVenta);
            this.PanelVenta.Size = new System.Drawing.Size(212, 237);
            this.PanelVenta.Controls.SetChildIndex(this.btnAbrirVenta, 0);
            this.PanelVenta.Controls.SetChildIndex(this.labelButton2, 0);
            this.PanelVenta.Controls.SetChildIndex(this.btnResumenPagos, 0);
            // 
            // PanelConfiguracion
            // 
            this.PanelConfiguracion.Controls.Add(this.btnUsuarios);
            this.PanelConfiguracion.Controls.Add(this.btnActualizarTasa);
            this.PanelConfiguracion.Location = new System.Drawing.Point(0, 1217);
            this.PanelConfiguracion.Size = new System.Drawing.Size(212, 146);
            this.PanelConfiguracion.Controls.SetChildIndex(this.btnActualizarTasa, 0);
            this.PanelConfiguracion.Controls.SetChildIndex(this.btnUsuarios, 0);
            // 
            // PanelCompra
            // 
            this.PanelCompra.Controls.Add(this.btnCompras);
            this.PanelCompra.Location = new System.Drawing.Point(0, 474);
            this.PanelCompra.Size = new System.Drawing.Size(212, 229);
            this.PanelCompra.Controls.SetChildIndex(this.btnCompras, 0);
            // 
            // PanelAlmacen
            // 
            this.PanelAlmacen.Controls.Add(this.btnProveedores);
            this.PanelAlmacen.Controls.Add(this.btnProductos);
            this.PanelAlmacen.Controls.Add(this.btnCategoriaProd);
            this.PanelAlmacen.Location = new System.Drawing.Point(0, 886);
            this.PanelAlmacen.Size = new System.Drawing.Size(212, 184);
            this.PanelAlmacen.Controls.SetChildIndex(this.btnCategoriaProd, 0);
            this.PanelAlmacen.Controls.SetChildIndex(this.btnProductos, 0);
            this.PanelAlmacen.Controls.SetChildIndex(this.btnProveedores, 0);
            // 
            // PanelReporte
            // 
            this.PanelReporte.Controls.Add(this.lbProductosVendidos);
            this.PanelReporte.Controls.Add(this.labelButton1);
            this.PanelReporte.Location = new System.Drawing.Point(0, 1070);
            this.PanelReporte.Size = new System.Drawing.Size(212, 147);
            this.PanelReporte.Controls.SetChildIndex(this.labelButton1, 0);
            this.PanelReporte.Controls.SetChildIndex(this.lbProductosVendidos, 0);
            // 
            // PanelCliente
            // 
            this.PanelCliente.Controls.Add(this.btnClientes);
            this.PanelCliente.Location = new System.Drawing.Point(0, 289);
            this.PanelCliente.Size = new System.Drawing.Size(212, 133);
            this.PanelCliente.Controls.SetChildIndex(this.btnClientes, 0);
            // 
            // PanelProveedor
            // 
            this.PanelProveedor.Controls.Add(this.btnMenuComida);
            this.PanelProveedor.Controls.Add(this.btnCategoriaMenu);
            this.PanelProveedor.Location = new System.Drawing.Point(0, 703);
            this.PanelProveedor.Size = new System.Drawing.Size(212, 183);
            this.PanelProveedor.Controls.SetChildIndex(this.btnCategoriaMenu, 0);
            this.PanelProveedor.Controls.SetChildIndex(this.btnMenuComida, 0);
            // 
            // PanelCaja
            // 
            this.PanelCaja.Size = new System.Drawing.Size(212, 52);
            this.PanelCaja.Visible = false;
            // 
            // SubContenedor
            // 
            this.SubContenedor.Size = new System.Drawing.Size(824, 666);
            // 
            // PanelMovimiento
            // 
            this.PanelMovimiento.Location = new System.Drawing.Point(0, 422);
            this.PanelMovimiento.Size = new System.Drawing.Size(212, 52);
            this.PanelMovimiento.Visible = false;
            // 
            // btnCategoriaProd
            // 
            this.btnCategoriaProd.BackColor = System.Drawing.Color.Transparent;
            this.btnCategoriaProd.ColorDetailText = System.Drawing.Color.Gray;
            this.btnCategoriaProd.ColorText = System.Drawing.SystemColors.ControlText;
            this.btnCategoriaProd.DetailText = "Registro y Edición";
            this.btnCategoriaProd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategoriaProd.FontDetailText = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoriaProd.FontText = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoriaProd.ImageDown = ((System.Drawing.Image)(resources.GetObject("btnCategoriaProd.ImageDown")));
            this.btnCategoriaProd.Location = new System.Drawing.Point(0, 44);
            this.btnCategoriaProd.Name = "btnCategoriaProd";
            this.btnCategoriaProd.Size = new System.Drawing.Size(212, 42);
            this.btnCategoriaProd.TabIndex = 5;
            this.btnCategoriaProd.Text = "Categorías";
            this.btnCategoriaProd.ButtonClick += new System.EventHandler(this.btnCategoriaProd_ButtonClick);
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.Transparent;
            this.btnProductos.ColorDetailText = System.Drawing.Color.Gray;
            this.btnProductos.ColorText = System.Drawing.SystemColors.ControlText;
            this.btnProductos.DetailText = "Registro y Edición";
            this.btnProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductos.FontDetailText = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.FontText = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ImageDown = ((System.Drawing.Image)(resources.GetObject("btnProductos.ImageDown")));
            this.btnProductos.Location = new System.Drawing.Point(0, 86);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(212, 42);
            this.btnProductos.TabIndex = 7;
            this.btnProductos.Text = "Productos";
            this.btnProductos.ButtonClick += new System.EventHandler(this.btnProductos_ButtonClick);
            // 
            // btnCategoriaMenu
            // 
            this.btnCategoriaMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnCategoriaMenu.ColorDetailText = System.Drawing.Color.Gray;
            this.btnCategoriaMenu.ColorText = System.Drawing.SystemColors.ControlText;
            this.btnCategoriaMenu.DetailText = "del Menú";
            this.btnCategoriaMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategoriaMenu.FontDetailText = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoriaMenu.FontText = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoriaMenu.ImageDown = ((System.Drawing.Image)(resources.GetObject("btnCategoriaMenu.ImageDown")));
            this.btnCategoriaMenu.Location = new System.Drawing.Point(0, 44);
            this.btnCategoriaMenu.Name = "btnCategoriaMenu";
            this.btnCategoriaMenu.Size = new System.Drawing.Size(212, 42);
            this.btnCategoriaMenu.TabIndex = 5;
            this.btnCategoriaMenu.Text = "Categorías";
            this.btnCategoriaMenu.ButtonClick += new System.EventHandler(this.btnCategoriaMenu_ButtonClick);
            // 
            // btnMenuComida
            // 
            this.btnMenuComida.BackColor = System.Drawing.Color.Transparent;
            this.btnMenuComida.ColorDetailText = System.Drawing.Color.Gray;
            this.btnMenuComida.ColorText = System.Drawing.SystemColors.ControlText;
            this.btnMenuComida.DetailText = "Platos del Menú";
            this.btnMenuComida.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuComida.FontDetailText = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuComida.FontText = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuComida.ImageDown = ((System.Drawing.Image)(resources.GetObject("btnMenuComida.ImageDown")));
            this.btnMenuComida.Location = new System.Drawing.Point(0, 86);
            this.btnMenuComida.Name = "btnMenuComida";
            this.btnMenuComida.Size = new System.Drawing.Size(212, 42);
            this.btnMenuComida.TabIndex = 6;
            this.btnMenuComida.Text = "Menú";
            this.btnMenuComida.ButtonClick += new System.EventHandler(this.btnMenuComida_ButtonClick);
            // 
            // btnProveedores
            // 
            this.btnProveedores.BackColor = System.Drawing.Color.Transparent;
            this.btnProveedores.ColorDetailText = System.Drawing.Color.Gray;
            this.btnProveedores.ColorText = System.Drawing.SystemColors.ControlText;
            this.btnProveedores.DetailText = "Registro y Edición";
            this.btnProveedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProveedores.FontDetailText = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedores.FontText = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedores.ImageDown = ((System.Drawing.Image)(resources.GetObject("btnProveedores.ImageDown")));
            this.btnProveedores.Location = new System.Drawing.Point(0, 128);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(212, 42);
            this.btnProveedores.TabIndex = 8;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.ButtonClick += new System.EventHandler(this.btnProveedores_ButtonClick);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.Transparent;
            this.btnClientes.ColorDetailText = System.Drawing.Color.Gray;
            this.btnClientes.ColorText = System.Drawing.SystemColors.ControlText;
            this.btnClientes.DetailText = "Registro y Edición";
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FontDetailText = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.FontText = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ImageDown = ((System.Drawing.Image)(resources.GetObject("btnClientes.ImageDown")));
            this.btnClientes.Location = new System.Drawing.Point(0, 44);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(212, 42);
            this.btnClientes.TabIndex = 5;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.ButtonClick += new System.EventHandler(this.btnClientes_ButtonClick);
            // 
            // btnCompras
            // 
            this.btnCompras.BackColor = System.Drawing.Color.Transparent;
            this.btnCompras.ColorDetailText = System.Drawing.Color.Gray;
            this.btnCompras.ColorText = System.Drawing.SystemColors.ControlText;
            this.btnCompras.DetailText = "Listado && Registro";
            this.btnCompras.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCompras.FontDetailText = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompras.FontText = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompras.ImageDown = ((System.Drawing.Image)(resources.GetObject("btnCompras.ImageDown")));
            this.btnCompras.Location = new System.Drawing.Point(0, 44);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(212, 42);
            this.btnCompras.TabIndex = 7;
            this.btnCompras.Text = "Compras";
            this.btnCompras.ButtonClick += new System.EventHandler(this.btnCompras_ButtonClick);
            // 
            // btnActualizarTasa
            // 
            this.btnActualizarTasa.BackColor = System.Drawing.Color.Transparent;
            this.btnActualizarTasa.ColorDetailText = System.Drawing.Color.Gray;
            this.btnActualizarTasa.ColorText = System.Drawing.SystemColors.ControlText;
            this.btnActualizarTasa.DetailText = "Tasa de Cambio";
            this.btnActualizarTasa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnActualizarTasa.FontDetailText = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarTasa.FontText = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarTasa.ImageDown = ((System.Drawing.Image)(resources.GetObject("btnActualizarTasa.ImageDown")));
            this.btnActualizarTasa.Location = new System.Drawing.Point(0, 44);
            this.btnActualizarTasa.Name = "btnActualizarTasa";
            this.btnActualizarTasa.Size = new System.Drawing.Size(212, 42);
            this.btnActualizarTasa.TabIndex = 5;
            this.btnActualizarTasa.Text = "Actualizar Tasa";
            this.btnActualizarTasa.ButtonClick += new System.EventHandler(this.btnActualizarTasa_ButtonClick);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.btnUsuarios.ColorDetailText = System.Drawing.Color.Gray;
            this.btnUsuarios.ColorText = System.Drawing.SystemColors.ControlText;
            this.btnUsuarios.DetailText = "Registro y Edición";
            this.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuarios.FontDetailText = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.FontText = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ImageDown = ((System.Drawing.Image)(resources.GetObject("btnUsuarios.ImageDown")));
            this.btnUsuarios.Location = new System.Drawing.Point(0, 86);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(212, 42);
            this.btnUsuarios.TabIndex = 6;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.ButtonClick += new System.EventHandler(this.btnUsuarios_ButtonClick);
            // 
            // btnAbrirVenta
            // 
            this.btnAbrirVenta.BackColor = System.Drawing.Color.Transparent;
            this.btnAbrirVenta.ColorDetailText = System.Drawing.Color.Gray;
            this.btnAbrirVenta.ColorText = System.Drawing.SystemColors.ControlText;
            this.btnAbrirVenta.DetailText = "Agregar o cerrar";
            this.btnAbrirVenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAbrirVenta.FontDetailText = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirVenta.FontText = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirVenta.ImageDown = ((System.Drawing.Image)(resources.GetObject("btnAbrirVenta.ImageDown")));
            this.btnAbrirVenta.Location = new System.Drawing.Point(0, 44);
            this.btnAbrirVenta.Name = "btnAbrirVenta";
            this.btnAbrirVenta.Size = new System.Drawing.Size(212, 42);
            this.btnAbrirVenta.TabIndex = 5;
            this.btnAbrirVenta.Text = "Ordenes de Venta";
            this.btnAbrirVenta.ButtonClick += new System.EventHandler(this.btnAbrirVenta_ButtonClick);
            // 
            // labelButton2
            // 
            this.labelButton2.BackColor = System.Drawing.Color.Transparent;
            this.labelButton2.ColorDetailText = System.Drawing.Color.Gray;
            this.labelButton2.ColorText = System.Drawing.SystemColors.ControlText;
            this.labelButton2.DetailText = "Historico";
            this.labelButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelButton2.FontDetailText = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelButton2.FontText = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelButton2.ImageDown = ((System.Drawing.Image)(resources.GetObject("labelButton2.ImageDown")));
            this.labelButton2.Location = new System.Drawing.Point(0, 86);
            this.labelButton2.Name = "labelButton2";
            this.labelButton2.Size = new System.Drawing.Size(212, 42);
            this.labelButton2.TabIndex = 6;
            this.labelButton2.Text = "Ventas Facturadas";
            this.labelButton2.ButtonClick += new System.EventHandler(this.labelButton2_ButtonClick);
            // 
            // labelButton1
            // 
            this.labelButton1.BackColor = System.Drawing.Color.Transparent;
            this.labelButton1.ColorDetailText = System.Drawing.Color.Gray;
            this.labelButton1.ColorText = System.Drawing.SystemColors.ControlText;
            this.labelButton1.DetailText = "Graficas y Datos";
            this.labelButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelButton1.FontDetailText = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelButton1.FontText = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelButton1.ImageDown = ((System.Drawing.Image)(resources.GetObject("labelButton1.ImageDown")));
            this.labelButton1.Location = new System.Drawing.Point(0, 44);
            this.labelButton1.Name = "labelButton1";
            this.labelButton1.Size = new System.Drawing.Size(212, 42);
            this.labelButton1.TabIndex = 9;
            this.labelButton1.Text = "Estadisticas";
            this.labelButton1.ButtonClick += new System.EventHandler(this.labelButton1_ButtonClick);
            // 
            // btnResumenPagos
            // 
            this.btnResumenPagos.BackColor = System.Drawing.Color.Transparent;
            this.btnResumenPagos.ColorDetailText = System.Drawing.Color.Gray;
            this.btnResumenPagos.ColorText = System.Drawing.SystemColors.ControlText;
            this.btnResumenPagos.DetailText = "Historico";
            this.btnResumenPagos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnResumenPagos.FontDetailText = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResumenPagos.FontText = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResumenPagos.ImageDown = ((System.Drawing.Image)(resources.GetObject("btnResumenPagos.ImageDown")));
            this.btnResumenPagos.Location = new System.Drawing.Point(0, 128);
            this.btnResumenPagos.Name = "btnResumenPagos";
            this.btnResumenPagos.Size = new System.Drawing.Size(212, 42);
            this.btnResumenPagos.TabIndex = 7;
            this.btnResumenPagos.Text = "Resumen de Pagos";
            this.btnResumenPagos.ButtonClick += new System.EventHandler(this.btnResumenPagos_ButtonClick);
            // 
            // lbProductosVendidos
            // 
            this.lbProductosVendidos.BackColor = System.Drawing.Color.Transparent;
            this.lbProductosVendidos.ColorDetailText = System.Drawing.Color.Gray;
            this.lbProductosVendidos.ColorText = System.Drawing.SystemColors.ControlText;
            this.lbProductosVendidos.DetailText = "Listado de Vendidos";
            this.lbProductosVendidos.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbProductosVendidos.FontDetailText = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProductosVendidos.FontText = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProductosVendidos.ImageDown = ((System.Drawing.Image)(resources.GetObject("lbProductosVendidos.ImageDown")));
            this.lbProductosVendidos.Location = new System.Drawing.Point(0, 86);
            this.lbProductosVendidos.Name = "lbProductosVendidos";
            this.lbProductosVendidos.Size = new System.Drawing.Size(212, 42);
            this.lbProductosVendidos.TabIndex = 10;
            this.lbProductosVendidos.Text = "Productos";
            this.lbProductosVendidos.ButtonClick += new System.EventHandler(this.lbProductosVendidos_ButtonClick);
            // 
            // frmMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1093, 732);
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenu_FormClosing);
            this.Load += new System.EventHandler(this.frmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.PanelVenta.ResumeLayout(false);
            this.PanelConfiguracion.ResumeLayout(false);
            this.PanelCompra.ResumeLayout(false);
            this.PanelAlmacen.ResumeLayout(false);
            this.PanelReporte.ResumeLayout(false);
            this.PanelCliente.ResumeLayout(false);
            this.PanelProveedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Autonomo.CustomControls.LabelButton btnProductos;
        private Autonomo.CustomControls.LabelButton btnCategoriaProd;
        private Autonomo.CustomControls.LabelButton btnCategoriaMenu;
        private Autonomo.CustomControls.LabelButton btnMenuComida;
        private Autonomo.CustomControls.LabelButton btnProveedores;
        private Autonomo.CustomControls.LabelButton btnClientes;
        private Autonomo.CustomControls.LabelButton btnCompras;
        private Autonomo.CustomControls.LabelButton btnActualizarTasa;
        private Autonomo.CustomControls.LabelButton btnUsuarios;
        private Autonomo.CustomControls.LabelButton labelButton2;
        private Autonomo.CustomControls.LabelButton btnAbrirVenta;
        private Autonomo.CustomControls.LabelButton labelButton1;
        private Autonomo.CustomControls.LabelButton btnResumenPagos;
        private Autonomo.CustomControls.LabelButton lbProductosVendidos;
    }
}