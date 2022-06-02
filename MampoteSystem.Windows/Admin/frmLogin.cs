using MampoteSystem.Datos;
using MampoteSystem.Entidad;
using MampoteSystem.Windows.Home;
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
    public partial class frmLogin : Autonomo.CustomTemplate.CustomLogin
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        
        private void Ingresar()
        {

            using (UnitOfWork uow = new UnitOfWork())
            {
                try
                {
                    usuario user = uow.usuarios.Login(txUsuario.Text, txPassword.Text);

                    if(user != null)
                    {
                        frmMenu MenuPrincipal = frmMenu.GetInstance();

                        MenuPrincipal.EditorUser = user.username;
                        MenuPrincipal.TCambio = Tools.Configs.ReadTasa();
                        MenuPrincipal.Usuario = user.Nombres.Split()[0] + " " + user.Apellidos.Split()[0];
                        MenuPrincipal._NivelAcceso = user.NivelAcceso;

                        MenuPrincipal.Show();
                        this.Hide();
                        MenuPrincipal.FormClosing += Frm_Closing;
                    }
                    else
                    {
                        Tools.Mensaje.MessageBox(Tools.Enumerables.Mensajeria.Error, "Usuario o contraseña incorrectos.");
                        txUsuario.Clear();
                        txPassword.Clear();
                        txUsuario.Focus();
                    }
                }
                catch(Exception ex)
                {
                    throw ex;
                }
            }

        }

        private void btnAccess_Click(object sender, EventArgs e)
        {
            Ingresar();
        }
        private void Frm_Closing(object sender, FormClosingEventArgs e)
        {
            txUsuario.Clear();
            txPassword.Clear();

            txUsuario.Focus();
            this.Show();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.Title = "Formulario de ingreso";
        }

        private void txUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txPassword.Focus();
            }
        }

        private void txPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Ingresar();
            }
        }
    }
}
