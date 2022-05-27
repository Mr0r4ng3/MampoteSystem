﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MampoteSystem.Datos;
using MampoteSystem.Entidad;

namespace MampoteSystem.Windows.Modulo.Almacen
{
    public partial class frmCategoriaProd : Autonomo.Object.Registry
    {
        List<categoria> categorias;
        public frmCategoriaProd()
        {
            InitializeComponent();
        }

        //Metodos

        private void LoadData()
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                categorias = new List<categoria>();
                categorias = uow.categoria.GetListProds().ToList();
                LoadFilter();
            }

        }

        private void LoadFilter()
        {
            if(categorias !=null && categorias.Count() > 0)
            {

                var newList = from o in categorias
                              select new
                              {
                                  id = o.id,
                                  Nombre = o.Nombre,
                              };

                grdData.DataSource = newList
                    .Where(o => o.Nombre.Contains(txFilter.Text))
                    .ToList();
            }
        }

        private void LoadModal(string opcion, string title)
        {
            var f = new frmCategoriaProdModal();

            f.Title.Text = title;

            if(opcion == "Update")
            {
                string id = grdData.CurrentRow.Cells["id"].Value.ToString();

                var ctg = categorias.FirstOrDefault(o => o.id.Equals(id));

                if(ctg != null)
                {
                    f.LoadData(ctg.id, ctg.Nombre);
                }

            }

            Autonomo.Class.Fomulary.ShowModal(f, opcion);

            if(f.Tag.ToString() == "Get")
            {
                LoadData();
            }
        }

        private void frmCategoriaProd_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txFilter_TextBoxChanged(object sender, EventArgs e)
        {
            LoadFilter();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LoadModal("Insert", "Registrar nueva categoria");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (grdData.Rows.Count > 0)
            {
                LoadModal("Update", "Modificar una categoria");
            }
        }
    }
}
