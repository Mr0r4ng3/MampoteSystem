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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MampoteSystem.Windows.Admin
{
    public partial class frmUsuariosModal : Autonomo.Object.Modal
    {
        private int id;
        private string passwd;
        private String[] TIPOS_CEDULA = { "Venezolano", "Extranjero" };
        private String[] NIVEL_ACCESO = { "Administrador", "Ventas","Inventario","Reportes" };

        private string EditorUser;
        public frmUsuariosModal()
        {
            InitializeComponent();

            int id = 0;
            cbTipo.DataSource = TIPOS_CEDULA;
            cbAcceso.DataSource = NIVEL_ACCESO;
            passwd = "";
        }

        public void ClearErrors()
        {
            txCedula.Error = "";
            txNombres.Error = "";
            txApellidos.Error = "";
            txUsername.Error = "";
            txPassword.Error = "";
            txPassword2.Error = "";
        }

        public bool validateInputs()
        {
            ClearErrors();
            
            if (txCedula.Text == String.Empty)
            {
                Tools.Mensaje.MessageBox(Tools.Enumerables.Mensajeria.Warning, "Debe introducir la cedula.");
                txCedula.Focus();
                txCedula.Error = "Este campo es obligatorio.";

                return false;
            }

            if (txNombres.Text == String.Empty)
            {
                Tools.Mensaje.MessageBox(Tools.Enumerables.Mensajeria.Warning, "Debe introducir los nombres.");
                txNombres.Focus();
                txNombres.Error = "Este campo es obligatorio.";

                return false;
            }

            if (txApellidos.Text == String.Empty)
            {
                Tools.Mensaje.MessageBox(Tools.Enumerables.Mensajeria.Warning, "Debe introducir los apellidos.");
                txApellidos.Focus();
                txApellidos.Error = "Este campo es obligatorio.";
                return false;
            }

            if(this.Tag.ToString() == "Insert")
            {
                if (txPassword.Text == String.Empty)
                {
                    Tools.Mensaje.MessageBox(Tools.Enumerables.Mensajeria.Warning, "Debe introducir la contraseña.");
                    txPassword.Focus();
                    txPassword.Error = "Este campo es obligatorio.";
                    return false;
                }
                
                if (txPassword2.Text == String.Empty)
                {
                    Tools.Mensaje.MessageBox(Tools.Enumerables.Mensajeria.Warning, "Debe introducir nuevamente la contraseña.");
                    txPassword2.Focus();
                    txPassword2.Error = "Este campo es obligatorio.";
                    return false;
                }

                if (txPassword.Text != txPassword2.Text)
                {
                    Tools.Mensaje.MessageBox(Tools.Enumerables.Mensajeria.Warning, "Las contraseñas no coinciden.");
                    txPassword2.Clear();
                    txPassword.Clear();
                    txPassword.Focus();
                    return false;
                }
            }

            if (this.Tag.ToString() == "Update" && chkActualizarPasswd.Checked)
            {

                if (txPassword2.Text == String.Empty)
                {
                    Tools.Mensaje.MessageBox(Tools.Enumerables.Mensajeria.Warning, "Debe introducir nuevamente la contraseña.");
                    txPassword2.Focus();
                    txPassword2.Error = "Este campo es obligatorio.";
                    return false;
                }

                if (txPassword.Text != txPassword2.Text)
                {
                    Tools.Mensaje.MessageBox(Tools.Enumerables.Mensajeria.Warning, "Las contraseñas no coinciden.");
                    txPassword2.Clear();
                    txPassword.Clear();
                    txPassword.Focus();
                    return false;
                }

                if (txPassword.Text == String.Empty)
                {
                    Tools.Mensaje.MessageBox(Tools.Enumerables.Mensajeria.Warning, "Debe introducir la contraseña.");
                    txPassword.Focus();
                    txPassword.Error = "Este campo es obligatorio.";
                    return false;
                }
            }

            return true;
        }
        public void LoadData(usuario usuario)
        {
            this.id = usuario.id;
            if (usuario.Cedula.Substring(0, 1) == "V")
            {
                txCedula.Text = usuario.Cedula.Replace("V-", "");
                cbTipo.SelectedIndex = 0;
            }
            else
            {
                txCedula.Text = usuario.Cedula.Replace("E-", "");
                cbTipo.SelectedIndex = 1;
            }

            SelectAcceso(usuario);

            txNombres.Text = usuario.Nombres;
            txApellidos.Text = usuario.Apellidos;
            txUsername.Text = usuario.username;
            passwd = usuario.passwd;
        }

        private void SelectAcceso(usuario usuario)
        {
            if(usuario.NivelAcceso == "Administrador")
            {
                cbAcceso.SelectedIndex = 0;
            }

            if (usuario.NivelAcceso == "Ventas")
            {
                cbAcceso.SelectedIndex = 1;
            }

            if (usuario.NivelAcceso == "Inventario")
            {
                cbAcceso.SelectedIndex = 2;
            }
            
            if (usuario.NivelAcceso == "Reportes")
            {
                cbAcceso.SelectedIndex = 3;
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

                        if(this.Tag.ToString() == "Update" && chkActualizarPasswd.Checked == true)
                        {
                            if (cbTipo.Text == "Venezolano")
                            {
                                string option = this.Tag.ToString();
                                var result = uow.usuarios.Crud(
                                        new usuario()
                                        {
                                            id = this.id,
                                            Cedula = "V-" + txCedula.Text,
                                            Nombres = txNombres.Text,
                                            Apellidos = txApellidos.Text,
                                            username = txUsername.Text,
                                            NivelAcceso = cbAcceso.Text,
                                            passwd = txPassword2.Text

                                        }, option); ;
                                if (result > 0) { base.Set(); }
                            }
                            else
                            {
                                string option = this.Tag.ToString();
                                var result = uow.usuarios.Crud(
                                        new usuario()
                                        {
                                            id = this.id,
                                            Cedula = "E-" + txCedula.Text,
                                            Nombres = txNombres.Text,
                                            Apellidos = txApellidos.Text,
                                            username = txUsername.Text,
                                            NivelAcceso = cbAcceso.Text,
                                            passwd = txPassword2.Text

                                        }, option);
                                if (result > 0) { base.Set(); }
                            }
                        }
                        else if(this.Tag.ToString() == "Update" && chkActualizarPasswd.Checked == false)
                        {
                            if (cbTipo.Text == "Venezolano")
                            {
                                string option = this.Tag.ToString();
                                var result = uow.usuarios.Crud(
                                        new usuario()
                                        {
                                            id = this.id,
                                            Cedula = "V-" + txCedula.Text,
                                            Nombres = txNombres.Text,
                                            Apellidos = txApellidos.Text,
                                            username = txUsername.Text,
                                            NivelAcceso = cbAcceso.Text,
                                            passwd = passwd

                                        }, option);
                                if (result > 0) { base.Set(); }
                            }
                            else
                            {
                                string option = this.Tag.ToString();
                                var result = uow.usuarios.Crud(
                                        new usuario()
                                        {
                                            id = this.id,
                                            Cedula = "E-" + txCedula.Text,
                                            Nombres = txNombres.Text,
                                            Apellidos = txApellidos.Text,
                                            username = txUsername.Text,
                                            NivelAcceso = cbAcceso.Text,
                                            passwd = passwd

                                        }, option);
                                if (result > 0) { base.Set(); }
                            }
                        }
                        else
                        {
                            if (cbTipo.Text == "Venezolano")
                            {
                                string option = this.Tag.ToString();
                                var result = uow.usuarios.Crud(
                                        new usuario()
                                        {
                                            id = this.id,
                                            Cedula = "V-" + txCedula.Text,
                                            Nombres = txNombres.Text,
                                            Apellidos = txApellidos.Text,
                                            username = txUsername.Text,
                                            NivelAcceso = cbAcceso.Text,
                                            passwd = txPassword2.Text

                                        }, option); ;
                                if (result > 0) { base.Set(); }
                            }
                            else
                            {
                                string option = this.Tag.ToString();
                                var result = uow.usuarios.Crud(
                                        new usuario()
                                        {
                                            id = this.id,
                                            Cedula = "E-" + txCedula.Text,
                                            Nombres = txNombres.Text,
                                            Apellidos = txApellidos.Text,
                                            username = txUsername.Text,
                                            NivelAcceso = cbAcceso.Text,
                                            passwd = txPassword2.Text

                                        }, option);
                                if (result > 0) { base.Set(); }
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void frmUsuariosModal_Load(object sender, EventArgs e)
        {
            if(this.Tag.ToString() == "Update")
            {
                txPassword.Enabled = false;
                txPassword2.Enabled = false;
            }
            else
            {
                chkActualizarPasswd.Visible = false;
            }
        }

        private void chkActualizarPasswd_CheckedChanged(object sender, EventArgs e)
        {
            if (chkActualizarPasswd.Checked)
            {
                txPassword.Enabled = true;
                txPassword2.Enabled = true;
            }
            else
            {
                txPassword.Enabled = false;
                txPassword2.Enabled = false;

                txPassword.Clear();
                txPassword2.Clear();
            }
        }
    }
}
