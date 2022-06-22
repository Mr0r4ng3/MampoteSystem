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

namespace MampoteSystem.Windows.Modulo.Almacen
{
    public partial class frmPromocionModal : Autonomo.Object.Modal
    {
        private string Codigo;
        public frmPromocionModal()
        {
            InitializeComponent();
            this.Codigo = String.Empty;
        }

        public void LoadData(productosReport productos)
        {
            this.Codigo = productos.Codigo;
            txNombre.Text = productos.Nombre;
            txPrecioVenta.Text = productos.Precio_Venta.ToString(new CultureInfo("en-US"));
        }

        public bool validateInputs()
        {
            if (txNombre.Text == String.Empty)
            {
                return false;
            }

            if (txPrecioVenta.Text == String.Empty)
            {
                return false;

            }

            return true;
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
                                    idTipo = 3,
                                    idCategoria = "CG001",
                                    Nombre = txNombre.Text,
                                    Descripcion = "",
                                    Stock = 0,
                                    Precio_Compra = 0.00m,
                                    Precio_Venta = Convert.ToDecimal(txPrecioVenta.Text, new CultureInfo("en-US")),
                                    IVA = 0.00m
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

        private void frmPromocionModal_Load(object sender, EventArgs e)
        {
            base.ConfigFormulary();
        }
        private void txPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Autonomo.Class.Validating.OnlyDecimal(e, txPrecioVenta);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }
    }
}
