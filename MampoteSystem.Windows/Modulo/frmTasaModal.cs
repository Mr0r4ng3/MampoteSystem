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

namespace MampoteSystem.Windows.Modulo
{
    public partial class frmTasaModal : Autonomo.Object.Modal
    {
        public frmTasaModal()
        {
            InitializeComponent();
        }

        private void txTasa_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Autonomo.Class.Validating.OnlyDecimal(e, this.txTasa);
        }

        private void txTasa_TextBoxChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txTasa.Text != "0.00")
            {
                string newTasa = txTasa.Text != String.Empty ? txTasa.Text : "0.00";

                bool response = Tools.Configs.setTasa(newTasa);

                if (response)
                {
                    frmMenu Home = frmMenu.GetInstance();

                    Home.TCambio = newTasa;

                    base.Set();
                }
                else
                {
                    Tools.Mensaje.MessageBox(Tools.Enumerables.Mensajeria.Error, "Ocurrió un error al intentar fijar la tasa.");
                }
            }
            else
            {
                Tools.Mensaje.MessageBox(Tools.Enumerables.Mensajeria.Warning,
                                            "Debe colocar la tasa antes.");
            }
        }
    }
}
