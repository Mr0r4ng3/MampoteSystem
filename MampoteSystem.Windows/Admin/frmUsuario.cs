using MampoteSystem.Datos;
using MampoteSystem.Entidad;
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
    public partial class frmUsuario : Autonomo.Object.Registry
    {
        List<usuario> usuarios;
        public frmUsuario()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                usuarios = new List<usuario>();
                usuarios = uow.usuarios.GetList().ToList();
                FilterData();
            }
        }
        private void FilterData()
        {
            //LinQ
            if (usuarios != null && usuarios.Count > 0)
            {
                var newList = from o in usuarios
                              select new
                              {
                                  id = o.id,
                                  Cedula = o.Cedula,
                                  Nombres = o.Nombres,
                                  Apellidos = o.Apellidos,
                                  username = o.username,
                                  NivelAcceso = o.NivelAcceso,
                                  passwd = o.passwd,
                              };

                //Lambda
                grdData.DataSource = newList
                    .Where(o => o.Nombres.Contains(txFilter.Text))
                    .OrderBy(o => o.Nombres)
                    .ToList();
            }
        }

        private void LoadModal(string option, string title)
        {
            var form = new frmUsuariosModal();
            form.Title.Text = title;
            form.Tag = option;



            if (option == "Update")
            {

                int id = Convert.ToInt32(grdData.CurrentRow.Cells["id"].Value);
                var obj = usuarios.FirstOrDefault(o => o.id == id);

                if (obj != null)
                {
                    form.LoadData(obj);
                }

            }

            Autonomo.Class.Fomulary.ShowModal(form, option, false);
            if (form.Tag.ToString() == "Get")
            {
                LoadData();
            }
            form.Dispose();

        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LoadModal("Insert", "Registrar nuevo usuario");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            LoadModal("Update", "Modificar un usuario");
        }

        private void txFilter_TextBoxChanged(object sender, EventArgs e)
        {
            FilterData();
        }
    }
}
