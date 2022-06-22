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
    public partial class SearchAndCreateClientes : Autonomo.Object.Modal
    {
        public clientes Cliente = new clientes();
        private String[] TIPOS_CEDULA = { "Venezolano", "Extranjero" };
        private String[] SEARCH_MODE = { "Nombre y Apellido", "Cedula" };

        List<clientes> clientes;
        public SearchAndCreateClientes()
        {
            InitializeComponent();
            cbTipo.DataSource = TIPOS_CEDULA;
            cbSearchMode.DataSource = SEARCH_MODE;
            this.Width = 517;
        }

        private void LoadData()
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                clientes = new List<clientes>();
                clientes = uow.clientes.GetList().ToList();
                FilterData();
            }
        }
        private void FilterData()
        {
            //LinQ
            if (clientes != null && clientes.Count > 0)
            {
                var newList = from o in clientes
                              select new
                              {
                                  id = o.id,
                                  Cedula = o.Cedula,
                                  Nombres = o.Nombres,
                                  Apellidos = o.Apellidos,
                                  Telefono = o.Telefono,
                                  Direccion = o.Direccion,
                              };

                //Lambda
                if(cbSearchMode.SelectedIndex == 1)
                {
                    grdData.DataSource = newList
                    .Where(o => o.Cedula.Contains(txtSearch.Text))
                    .OrderBy(o => o.Nombres)
                    .ToList();
                    return;
                }
                grdData.DataSource = newList
                    .Where(o => o.Nombres.Contains(txtSearch.Text))
                    .OrderBy(o => o.Nombres)
                    .ToList();
            }
        }
        public void LoadCedula(string cedula)
        {
            if (cedula.Substring(0, 1) == "V")
            {
                txCedula.Text = cedula.Replace("V-", "");
                cbTipo.SelectedIndex = 0;
            }
            else
            {
                txCedula.Text = cedula.Replace("E-", "");
                cbTipo.SelectedIndex = 1;
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
        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (validateInputs())
            {

                try
                {
                    using (UnitOfWork uow = new UnitOfWork())
                    {
                        if (cbTipo.Text == "Venezolano")
                        {
                            string Cedula = txCedula.Text == String.Empty ? "" : "V-" + txCedula.Text;
                            string option = this.Tag.ToString();
                            var result = uow.clientes.Crud(
                                    new clientes()
                                    {
                                        Cedula =  Cedula,
                                        Nombres = txNombres.Text,
                                        Apellidos = txApellidos.Text,
                                        Telefono = txTelefono.Text,
                                        Direccion = txDireccion.Text

                                    }, option);
                            if (result > 0)
                            {
                                Cliente = uow.clientes.SelectNewCliente();
                                base.Set();
                            }
                        }
                        else
                        {
                            string Cedula = txCedula.Text == String.Empty ? "" : "E-" + txCedula.Text;
                            string option = this.Tag.ToString();
                            var result = uow.clientes.Crud(
                                    new clientes()
                                    {
                                        Cedula = Cedula,
                                        Nombres = txNombres.Text,
                                        Apellidos = txApellidos.Text,
                                        Telefono = txTelefono.Text,
                                        Direccion = txDireccion.Text

                                    }, option);
                            if (result > 0)
                            {
                                Cliente = uow.clientes.SelectNewCliente();
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

        private void txCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            Autonomo.Class.Validating.OnlyNumber(e);
        }

        private void txTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void RegistrarNuevoCheck_CheckedChanged(object sender, EventArgs e)
        {
            if(RegistrarNuevoCheck.Checked == true)
            {
                CreatePanel.Visible = true;
                CreateButton.Visible = true;
                this.Width = 862;

                grdData.Visible = false;
                btnSave.Visible = false;
                txtSearch.Enabled = false;
                cbSearchMode.Enabled = false;

                return;
            }

            grdData.Visible = true;
            btnSave.Visible= true;
            txtSearch.Enabled = true;
            cbSearchMode.Enabled = true;

            this.Width = 517;
            CreatePanel.Visible = false;
            CreateButton.Visible = false;
        }

        private void SearchAndCreateClientes_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txtSearch_TextBoxChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cbSearchMode.SelectedIndex == 1)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void cbSearchMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (grdData.SelectedRows.Count > 0)
            {
                Cliente.id = Convert.ToInt32(grdData.SelectedRows[0].Cells[0].Value);
                Cliente.Cedula = grdData.SelectedRows[0].Cells[1].Value.ToString();
                Cliente.Nombres = grdData.SelectedRows[0].Cells[2].Value.ToString();
                Cliente.Apellidos = grdData.SelectedRows[0].Cells[3].Value.ToString();

                if (SearchCliente.haveDeuda(Cliente))
                {
                    DialogResult response = MessageBox.Show($"{Cliente.Nombres} {Cliente.Apellidos} tiene ya una Orden de Venta sin pagar, ¿Desea continuar?", "¡Advertencia!", MessageBoxButtons.YesNo);
                    if (response == DialogResult.No)
                    {
                        Cliente = new clientes();
                        return;
                    }
                }
                    
                base.Set();
            }
            else
            {
                Cliente = null;
                base.Set();
            }
        }
    }
}
