using MampoteSystem.Datos;
using MampoteSystem.Entidad.Report;
using MampoteSystem.Windows.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MampoteSystem.Windows.Modulo.Menu
{
    public partial class frmMenuComidaModal : Autonomo.Object.Modal
    {
        private string Codigo;
        public frmMenuComidaModal()
        {
            InitializeComponent();
            this.Codigo = String.Empty;
        }
        public void ComboNoVisible()
        {
            cbCategoria.Visible = false;
            txCodigo.Visible = true;
        }

        public void LoadData(comidaReport menu)
        {
            this.Codigo = menu.Codigo;
            txCodigo.Text = this.Codigo;
            cbCategoria.SelectedValue = menu.idCategoria;
            txNombre.Text = menu.Nombre;
            txDescripcion.Text = menu.Descripcion;
            txCostoProduccion.Text = menu.Costo.ToString(new CultureInfo("en-US"));
            txPrecioVenta.Text = menu.Precio_Venta.ToString(new CultureInfo("en-US"));
        }

        public void LoadCombo()
        {
            if (this.Tag.ToString() == "Insert")
            {
                Tools.ComboBoxHelper.ComboBoxCategoria(cbCategoria, "Menu");
            }
        }

        private void SaveChanges()
        {
            if (validateInputs())
            {

                try
                {
                    using (UnitOfWork uow = new UnitOfWork())
                    {
                        string option = this.Tag.ToString();
                        var result = uow.productos.Crud(
                                new Entidad.productos()
                                {
                                    Codigo = this.Codigo,
                                    idTipo = 2,
                                    idCategoria = cbCategoria.SelectedValue.ToString(),
                                    Nombre = txNombre.Text,
                                    Descripcion = txDescripcion.Text,
                                    Precio_Compra = Convert.ToDecimal(txCostoProduccion.Text, new CultureInfo("en-US")),
                                    Precio_Venta = Convert.ToDecimal(txPrecioVenta.Text, new CultureInfo("en-US")),
                                    IVA = (Convert.ToDecimal(txPrecioVenta.Text, new CultureInfo("en-US")) * Convert.ToDecimal(0.16, new CultureInfo("en-US")))
                                }, option);
                        if (result > 0) { base.Set(); }
                    }
                }
                catch (Exception ex)
                {
                    Tools.Mensaje.MessageBox(Enumerables.Mensajeria.Error, ex);
                }
            }
            else
            {
                MessageBox.Show("Verique que los datos esten correctos",
                    "Mensaje del sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        public bool validateInputs()
        {
            if (txNombre.Text == String.Empty)
            {
                return false;
            }

            if (txCostoProduccion.Text == String.Empty)
            {
                return false;

            }

            if (txPrecioVenta.Text == String.Empty)
            {
                return false;

            }

            return true;
        }

        private void frmMenuModal_Load(object sender, EventArgs e)
        {
            base.ConfigFormulary();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void txCostoProduccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Autonomo.Class.Validating.OnlyDecimal(e, txCostoProduccion);
        }

        private void txPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Autonomo.Class.Validating.OnlyDecimal(e, txPrecioVenta);
        }

        private void txPrecioVenta_Leave(object sender, EventArgs e)
        {
            if (this.txPrecioVenta.Text == String.Empty) { this.txPrecioVenta.Text = "0.00"; }
        }

        private void txCostoProduccion_Leave(object sender, EventArgs e)
        {
            if (this.txCostoProduccion.Text == String.Empty) { this.txCostoProduccion.Text = "0.00"; }
        }

        private void txCostoProduccion_Enter(object sender, EventArgs e)
        {
            txCostoProduccion.SelectAll();
        }

        private void txPrecioVenta_Enter(object sender, EventArgs e)
        {
            txPrecioVenta.SelectAll();
        }
    }
}
