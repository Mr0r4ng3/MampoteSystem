﻿using MampoteSystem.Datos;
using MampoteSystem.Entidad;
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
    public partial class frmProductosModal : Autonomo.Object.Modal
    {
        private string Codigo;

        public frmProductosModal()
        {
            InitializeComponent();
            this.Codigo = String.Empty;
        }

        public void ComboNoVisible()
        {
            cbCategoria.Visible = false;
            txCodigo.Visible = true;    
        }

        public void LoadData(productosReport productos)
        {
            this.Codigo = productos.Codigo;
            txCodigo.Text = this.Codigo;
            cbCategoria.SelectedValue = productos.idCategoria;
            txNombre.Text = productos.Nombre;
            txDescripcion.Text = productos.Descripcion;
            txStock.Text = productos.Stock.ToString();
            txPrecioCompra.Text = productos.Precio_Compra.ToString(new CultureInfo("en-US"));
            txPrecioVenta.Text = productos.Precio_Venta.ToString(new CultureInfo("en-US"));
        }

        public void LoadCombo()
        {
            if(this.Tag.ToString() == "Insert") { 
                Tools.ComboBoxHelper.ComboBoxCategoria(cbCategoria, "Productos");
            }
        }

        private void SaveChanges()
        {
            if (validateInputs()) { 
            
                try
                {
                    using (UnitOfWork uow = new UnitOfWork())
                    {
                        string option = this.Tag.ToString();
                        var result = uow.productos.Crud(
                                new Entidad.productos()
                                {
                                    Codigo = this.Codigo,
                                    idTipo = 1,
                                    idCategoria = cbCategoria.SelectedValue.ToString(),
                                    Nombre = txNombre.Text,
                                    Descripcion = txDescripcion.Text,
                                    Stock = Convert.ToInt32(txStock.Text),
                                    Precio_Compra = Convert.ToDecimal(txPrecioCompra.Text, new CultureInfo("en-US")),
                                    Precio_Venta = Convert.ToDecimal(txPrecioVenta.Text, new CultureInfo("en-US")),
                                    IVA = (Convert.ToDecimal(txPrecioVenta.Text, new CultureInfo("en-US")) * Convert.ToDecimal(0.16, new CultureInfo("en-US"))),
                                    EditorUser = Configs.GetEditorUser()
                                }, option);
                        if(result > 0) { base.Set(); }
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
                    MessageBoxIcon.Exclamation) ;
            }
        }

        public bool validateInputs()
        {
            if(txNombre.Text == String.Empty)
            {
                return false;
            }

            if (txStock.Text == String.Empty)
            {
                return false;

            }

            if (txPrecioCompra.Text == String.Empty)
            {
                return false;

            }

            if (txPrecioVenta.Text == String.Empty)
            {
                return false;

            }

            return true;
        }

        private void frmProductosModal_Load(object sender, EventArgs e)
        {
            base.ConfigFormulary();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void txStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            Autonomo.Class.Validating.OnlyNumber(e);
        }

        private void txPrecioCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Autonomo.Class.Validating.OnlyDecimal(e, txPrecioCompra);
        }

        private void txPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Autonomo.Class.Validating.OnlyDecimal(e, txPrecioVenta);
        }

        private void txStock_Leave(object sender, EventArgs e)
        {
            if(this.txStock.Text == String.Empty) { this.txStock.Text = "0"; }
        }

        private void txPrecioCompra_Leave(object sender, EventArgs e)
        {
            if (this.txPrecioCompra.Text == String.Empty) { this.txPrecioCompra.Text = "0.00"; }
        }

        private void txPrecioVenta_Leave(object sender, EventArgs e)
        {
            if (this.txPrecioVenta.Text == String.Empty) { this.txPrecioVenta.Text = "0.00"; }
        }

        private void txStock_Enter(object sender, EventArgs e)
        {
            txStock.SelectAll();
        }

        private void txPrecioCompra_Enter(object sender, EventArgs e)
        {
            txPrecioCompra.SelectAll();
        }

        private void txPrecioVenta_Enter(object sender, EventArgs e)
        {
            txPrecioVenta.SelectAll();
        }
    }
}
