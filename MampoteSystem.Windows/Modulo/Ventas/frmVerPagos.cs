using MampoteSystem.Datos;
using MampoteSystem.Entidad.Pagos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MampoteSystem.Windows.Modulo.Ventas
{
    public partial class frmVerPagos : Autonomo.Object.Modal
    {
        public string _idVenta;
        List<pago> _pagosList;

        public frmVerPagos()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                _pagosList = new List<pago>();
                _pagosList = uow.pago.GetList(_idVenta)
                    .OrderByDescending(o => o.Fecha).ToList();


                grdData.DataSource = null;
                grdData.Refresh();

                if (_pagosList != null && _pagosList.Count > 0)
                {
                    grdData.DataSource = _pagosList;
                    grdData.Rows[0].Selected = true;
                }
            }
        }

        private void frmVerPagos_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void grdData_SelectionChanged(object sender, EventArgs e)
        {
            if (grdData.SelectedRows.Count > 0)
            {
                string descripcion = grdData.CurrentRow.Cells["Descripcion"].Value.ToString();

                txTipoPago.Text = descripcion;

                txNota.Text = grdData.CurrentRow.Cells["Nota"].Value.ToString();

                txMontoPago.Text = Convert.ToDecimal(grdData.CurrentRow.Cells["Monto"].Value, new CultureInfo("en-Us"))
                    .ToString("F2", new CultureInfo("en-US"));
                txTasa.Text = Convert.ToDecimal(grdData.CurrentRow.Cells["Tasa"].Value, new CultureInfo("en-Us"))
                    .ToString("F2", new CultureInfo("en-US"));
                txTasa.Visible = true;
            }
            else
            {
                txTasa.Visible = false;
                txNota.Clear();
                txMontoPago.Text = "0.00";
                txTasa.Text = "0.00";
            }
        }
    }
}
