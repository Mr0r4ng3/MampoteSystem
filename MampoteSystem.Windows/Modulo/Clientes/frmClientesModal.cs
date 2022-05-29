using MampoteSystem.Datos;
using MampoteSystem.Entidad;
using MampoteSystem.Windows.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MampoteSystem.Windows.Modulo.Clientes
{
    public partial class frmClientesModal : Autonomo.Object.Modal
    {
        private int id;
        private String[] TIPOS_CEDULA = {"Venezolano","Extranjero"};
        public frmClientesModal()
        {
            InitializeComponent();
            int id = 0;

            cbTipo.DataSource = TIPOS_CEDULA;
        }
        public void LoadData(clientes cliente)
        {
            this.id = cliente.id;
            if(cliente.Cedula != ""){
                if(cliente.Cedula.Substring(0,1) == "V")
                {
                    txCedula.Text = cliente.Cedula.Replace("V-","");
                    cbTipo.SelectedIndex = 0;
                }
                else
                {
                    txCedula.Text = cliente.Cedula.Replace("E-", "");
                    cbTipo.SelectedIndex = 1;
                }
            }
            else
            {
                txCedula.Text = cliente.Cedula;
            }
            txNombres.Text = cliente.Nombres;
            txApellidos.Text = cliente.Apellidos;
            txTelefono.Text = cliente.Telefono;
            txDireccion.Text = cliente.Direccion;
        }
        private void SaveChanges()
        {
            if (validateInputs())
            {

                try
                {
                    using (UnitOfWork uow = new UnitOfWork())
                    { 
                        if(cbTipo.Text == "Venezolano") 
                        {
                            string option = this.Tag.ToString();
                            var result = uow.clientes.Crud(
                                    new clientes()
                                    {
                                        id = this.id,
                                        Cedula = txCedula.Text == String.Empty ? "" : "V-" + txCedula.Text,
                                        Nombres = txNombres.Text,
                                        Apellidos = txApellidos.Text,
                                        Telefono = txTelefono.Text,
                                        Direccion = txDireccion.Text

                                    }, option);
                            if (result > 0) 
                            {
                                base.Set(); 
                            }
                        }
                        else
                        {
                            string option = this.Tag.ToString();
                            var result = uow.clientes.Crud(
                                    new clientes()
                                    {
                                        id = this.id,
                                        Cedula = txCedula.Text == String.Empty ? "" : "E-" + txCedula.Text,
                                        Nombres = txNombres.Text,
                                        Apellidos = txApellidos.Text,
                                        Telefono = txTelefono.Text,
                                        Direccion = txDireccion.Text

                                    }, option);
                            if (result > 0) 
                            { 
                                base.Set();
                            }
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

            txNombres.Error = "";
            if (txNombres.Text == String.Empty)
            {
                txNombres.Error = "Este campo es obligatorio.";
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

            return true;
        }

        private void txCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            Autonomo.Class.Validating.OnlyNumber(e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void txTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-'))
            { 
                e.Handled = true;
            }
        }
    }
}
