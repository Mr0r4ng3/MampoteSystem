using MampoteSystem.Datos;
using MampoteSystem.Entidad;
using MampoteSystem.Windows.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MampoteSystem.Windows.Modulo.Proveedor
{
    public partial class frmProveedoresModal : Autonomo.Object.Modal
    {
        private string id;
        public string RIF;
        public frmProveedoresModal()
        {
            InitializeComponent();
            this.id = String.Empty;
        }
        public void LoadData(proveedores proveedor)
        {
            this.id = proveedor.id;
            txRazonSocial.Text = proveedor.Razon_Social;
            txRIF.Text = proveedor.RIF;
            txTelefono.Text = proveedor.Telefono;
            txEmail.Text = proveedor.Email;
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
                        var result = uow.proveedores.Crud(
                                new proveedores()
                                {
                                    id = this.id,
                                    Razon_Social = txRazonSocial.Text,
                                    RIF = txRIF.Text,
                                    Telefono = txTelefono.Text,
                                    Email = txEmail.Text

                                }, option);
                        if (result > 0) {
                            this.RIF = txRIF.Text;
                            base.Set(); 
                        }
                    }
                }
                catch (Exception ex)
                {
                    Tools.Mensaje.MessageBox(Enumerables.Mensajeria.Error, ex);
                }
            }
        }

        public bool validateInputs()
        {
            txRazonSocial.Error = "";
            if (txRazonSocial.Text == String.Empty)
            {
                txRazonSocial.Error = "Este campo es obligatorio.";
                return false;
            }

            txRIF.Error = "";
            if (txRIF.Text == String.Empty)
            {
                txRIF.Error = "Este campo es obligatorio.";
                return false;
            }

            txTelefono.Error = "";
            if (txTelefono.Text != String.Empty)
            {
                if (!Regex.Match(txTelefono.Text, @"^(\d{3,4}-\d{7})$").Success)
                {

                    txTelefono.Error = "Formato inválido.";
                    return false;
                }
            }

            txEmail.Error = "";
            if (txEmail.Text != String.Empty)
            {
                if (!new EmailAddressAttribute().IsValid(txEmail.Text))
                {
                    txEmail.Error = "Formato inválido.";
                    return false;
                }
            }

            return true;
        }

        private void frmProveedoresModal_Load(object sender, EventArgs e)
        {
            base.ConfigFormulary();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void txTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void txEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txRIF_KeyPress(object sender, KeyPressEventArgs e)
        {
            Autonomo.Class.Validating.OnlyNumber(e);
        }
    }
}
