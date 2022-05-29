using MampoteSystem.Datos;
using MampoteSystem.Windows.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MampoteSystem.Windows.Modulo.Menu
{
    public partial class frmCategoriaMenuModal : Autonomo.Object.Modal
    {
        private string id;
        public frmCategoriaMenuModal()
        {
            InitializeComponent();
            this.id = string.Empty;

        }
        //Metodos

        public void LoadData(string id, string nombre)
        {
            this.id = id;
            txNombre.Text = nombre;
        }
        private void SaveChanges()
        {
            try
            {
                using (UnitOfWork uow = new UnitOfWork())
                {
                    string option = this.Tag.ToString();

                    var result = uow.categoria.Crud("dbo.SpCategoriaMantenimiento",
                        new SqlParameter[]
                        {
                        new SqlParameter("@id",id),
                        new SqlParameter("@idTipo",2),
                        new SqlParameter("Nombre", txNombre.Text),
                        new SqlParameter("@Option",option)
                        });
                    if (result > 0) { base.Set(); }
                }
            }
            catch (Exception ex)
            {
                Tools.Mensaje.MessageBox(Enumerables.Mensajeria.Error, ex);
            }
        }

        private void frmCategoriaMenuModal_Load(object sender, EventArgs e)
        {
            base.ConfigFormulary();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }
    }
}
