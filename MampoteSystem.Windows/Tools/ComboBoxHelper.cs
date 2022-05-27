using MampoteSystem.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MampoteSystem.Windows.Tools
{
    public class ComboBoxHelper
    {
        public static void ComboBoxCategoria(Autonomo.CustomControls.FlatComboBox box, string tipo)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                if(tipo == "Productos") { 
                    var element = uow.categoria.GetListProds();
                    if(element != null && element.Count() > 0)
                    {
                        box.DataSource = element.ToList();
                        box.DisplayMember = "Nombre";
                        box.ValueMember = "id";
                    }
                }

                if (tipo == "Menu")
                {
                    var element = uow.categoria.GetListComida();
                    if (element != null && element.Count() > 0)
                    {
                        box.DataSource = element.ToList();
                        box.DisplayMember = "Nombre";
                        box.ValueMember = "id";
                    }
                }
            }
        }
        public static void ComboBoxTipoPagos(Autonomo.CustomControls.FlatComboBox box)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                    var element = uow.tipoPagos.GetList();
                    if (element != null && element.Count() > 0)
                    {
                        box.DataSource = element.ToList();
                        box.DisplayMember = "Descripcion";
                        box.ValueMember = "id";
                    }
            }
        }

    }
}
