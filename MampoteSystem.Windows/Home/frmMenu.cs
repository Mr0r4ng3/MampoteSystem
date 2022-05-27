using MampoteSystem.Windows.Modulo;
using MampoteSystem.Windows.Modulo.Compras;
using MampoteSystem.Windows.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MampoteSystem.Windows.Home
{
    public partial class frmMenu : Autonomo.Object.MenuLeftPanel
    {

        private static frmMenu _instance;
        public string _NivelAcceso;
        public string EditorUser;

        private frmMenu()
        {
            InitializeComponent();
            EditorUser = "System";
        }

        private static void ShowFormInPanelAndReload(Form fHijo, Panel panel)
        {
            foreach (Form openForm in panel.Controls)
            {
                openForm.Close();
                openForm.Dispose();
            }

            fHijo.TopLevel = false;
            fHijo.Dock = DockStyle.Fill;
            panel.Controls.Add(fHijo);
            fHijo.Show();
            fHijo.BringToFront();
        }

        private void ControlAcceso()
        {
            if (_NivelAcceso == "Ventas")
            {
                this.PanelCompra.Visible = false;
                this.PanelAlmacen.Visible = false;
                this.PanelProveedor.Visible = false;
                this.PanelReporte.Visible = false;
                this.PanelConfiguracion.Visible = false;

            }
            if (_NivelAcceso == "Inventario")
            {
                this.PanelVenta.Visible = false;
                this.PanelCliente.Visible = false;
                this.PanelReporte.Visible = false;
                this.PanelConfiguracion.Visible = false;

            }
            if (_NivelAcceso == "Reportes")
            {
                this.PanelVenta.Visible = false;
                this.PanelCliente.Visible = false;
                this.PanelConfiguracion.Visible = false;
                this.PanelAlmacen.Visible = false;
                this.PanelProveedor.Visible = false;
                this.PanelCompra.Visible = false;
            }
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            ControlAcceso();
        }

        public static frmMenu GetInstance()
        {
            if (_instance != null) return _instance;
            
            return _instance = new frmMenu();
        }

        private void btnCategoriaProd_ButtonClick(object sender, EventArgs e)
        {
            var form = new Modulo.Almacen.frmCategoriaProd();
            ShowFormInPanelAndReload(form, SubContenedor);
        }

        private void btnCategoriaMenu_ButtonClick(object sender, EventArgs e)
        {
            var form = new Modulo.Menu.frmCategoriaMenu();
            ShowFormInPanelAndReload(form, SubContenedor);
        }

        private void btnProductos_ButtonClick(object sender, EventArgs e)
        {
            var form = new Modulo.Almacen.frmProductos();
            ShowFormInPanelAndReload(form, SubContenedor);
        }

        private void btnMenuComida_ButtonClick(object sender, EventArgs e)
        {
            var form = new Modulo.Menu.frmMenuComida();
            ShowFormInPanelAndReload(form, SubContenedor);
        }

        private void btnProveedores_ButtonClick(object sender, EventArgs e)
        {
            var form = new Modulo.Proveedor.frmProveedores();
            ShowFormInPanelAndReload(form, SubContenedor);
        }

        private void btnClientes_ButtonClick(object sender, EventArgs e)
        {
            var form = new Modulo.Clientes.frmClientes();
            ShowFormInPanelAndReload(form, SubContenedor);
        }

        private void btnCompras_ButtonClick(object sender, EventArgs e)
        {
            var form = new Modulo.Compras.frmCompra();
            form.onLoad();
            ShowFormInPanelAndReload(form, SubContenedor);
        }

        private void btnActualizarTasa_ButtonClick(object sender, EventArgs e)
        {
            var f = new frmTasaModal();
            f.Title.Text = "Actualizar Tasa";
            Autonomo.Class.Fomulary.ShowModal(f, "");
            if (f.StateFormulary)
            {
                Mensaje.MessageBox(
                                    Enumerables.Mensajeria.Succesful,
                                    "Tasa de cambio actualizada satisfactoriamente.");
            }
        }

        private void btnUsuarios_ButtonClick(object sender, EventArgs e)
        {
            var form = new Admin.frmUsuario();
            ShowFormInPanelAndReload(form, SubContenedor);
        }

        private void btnAbrirVenta_ButtonClick(object sender, EventArgs e)
        {
            var form = new Modulo.Ventas.Abrir.frmAbrirVenta();
            form.onLoad();
            ShowFormInPanelAndReload(form, SubContenedor);
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            _instance.Dispose();
            _instance = null;
        }

        private void labelButton2_ButtonClick(object sender, EventArgs e)
        {
            var form = new Modulo.Ventas.frmVenta();
            form.onLoad();
            ShowFormInPanelAndReload(form, SubContenedor);
        }

        private void labelButton1_ButtonClick(object sender, EventArgs e)
        {
            var form = new Modulo.Reporte.frmEstadisticas();
            ShowFormInPanelAndReload(form, SubContenedor);
        }

        private void btnResumenPagos_ButtonClick(object sender, EventArgs e)
        {
            var form = new Modulo.Ventas.FrmResumenPagos();
            ShowFormInPanelAndReload(form, SubContenedor);
        }
    }
}
