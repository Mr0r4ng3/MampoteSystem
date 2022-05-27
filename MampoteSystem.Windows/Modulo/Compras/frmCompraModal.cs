using Autonomo.CustomControls;
using MampoteSystem.Datos;
using MampoteSystem.Entidad;
using MampoteSystem.Entidad.Report;
using MampoteSystem.Windows.Modulo.Proveedor;
using MampoteSystem.Windows.Tools;
using MampoteSystem.Windows.Tools.Models;
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

namespace MampoteSystem.Windows.Modulo.Compras
{
    public partial class frmCompraModal : Autonomo.Object.Modal
    {
        private proveedores proveedor;
        public frmCompraModal()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var stock = uow.productos.GetListProds()
                    .Where(o => o.Nombre.ToLower().Contains(txFiltro.Text.ToLower()))
                    .ToList();

                PopulateCart(stock);
            }
        }

        private void PopulateCart(List<productosReport> stocks)
        {
            if (stocks != null)
            {
                flowCart.Controls.Clear();
                foreach (var item in stocks)
                {
                    CustomList cart = new CustomList()
                    {
                        IdProducto = item.Codigo,
                        Titulo = item.Nombre,
                        Category = item.Categoria,
                        Stock = item.Stock.ToString(),
                        PrecioVenta = item.Precio_Venta
                    };

                    cart.Agregar.Click += (sender, args)
                    => PopulateGrid(
                        new CarroCompra()
                        {
                            Codigo = item.Codigo,
                            Nombre = item.Nombre,
                            Cantidad = cart.Cantidad,
                            PrecioCompra = cart.PrecioCompra,
                            PrecioVenta = cart.PrecioVenta,
                            Subtotal = (cart.Cantidad * cart.PrecioCompra)
                        });

                    flowCart.Controls.Add(cart);
                }
            }
        }

        private void PopulateGrid(CarroCompra items)
        {
                var response = DataGridHelper.PopulateGrid(grdCanastilla,
                                Enumerables.LlenarGrilla.Compra, items);

                MostrarTotales();
                lblMessageGrid.Text = response.Mensaje;
                if (response.Estado)
                {
                    lblMessageGrid.BackColor = Color.SeaGreen;
                    return;
                }
                lblMessageGrid.BackColor = Color.Coral;
        }

        private void MostrarTotales()
        {
            lblTotals.Text = $"{grdCanastilla.Rows.Count}, Items";

            var canasta = DataGridHelper.GetTotals(grdCanastilla, Enumerables.LlenarGrilla.Compra);
            lbCantidad.Text = canasta.Cantidad.ToString();
            lbTotal.Text = canasta.Subtotal.ToString(new CultureInfo("en-US"));

            if(Convert.ToDecimal(txTasa.Text, new CultureInfo("en-US")) > 0)
            {
                string totalDolares = (Convert.ToDecimal(lbTotal.Text, new CultureInfo("en-US")) / Convert.ToDecimal(txTasa.Text, new CultureInfo("en-US"))).ToString(new CultureInfo("en-US"));
                lbTotalDolares.Text = $"${totalDolares}";
            }
            else
            {
                lbTotalDolares.Text = "$0.00";
            }
        }

        private void RemoverItem(DataGridViewCellEventArgs e)
        {
            if (grdCanastilla.SelectedRows.Count > 0)
            {
                int rowIndex = grdCanastilla.CurrentCell.RowIndex;
                DataGridHelper.RemoveRows(grdCanastilla, rowIndex);
                MostrarTotales();
            }
        }

        private void GetProveedor()
        {
            using(UnitOfWork uow = new UnitOfWork())
            {
                proveedor = uow.proveedores.GetProveedor(txProveedor.Text);

                if (proveedor != null)
                {
                    txProveedor.Text = proveedor.Razon_Social;

                    lblMessageGrid.Text = $"{proveedor.Razon_Social} seleccionado como proveedor para la compra.";
                    lblMessageGrid.BackColor = Color.SeaGreen;

                    txProveedor.ReadOnly = true;

                }
                else
                {
                    lblMessageGrid.Text = "No se encontró al proveedor.";
                    lblMessageGrid.BackColor = Color.Coral;

                    var form = new frmProveedoresModal();
                    form.Title.Text = "Registrar Nuevo Proveedor";
                    form.Tag = "Insert";

                    Autonomo.Class.Fomulary.ShowModal(form, "Insert", false);
                    if (form.Tag.ToString() == "Get")
                    {
                        txProveedor.Text = form.RIF;
                        GetProveedor();
                    }
                    form.Dispose();
                }
            }
        }

        private bool ValidateControls(out string controlsEmpty)
        {
            controlsEmpty = string.Empty;
            if (txTasa.Text == "0.00")
            {
                controlsEmpty = "No se ha colocado la tasa de cambio manejada en esta compra.";
                txTasa.Error = "Este campo es requerido";
                return false;
            }
            txTasa.Error = "";

            if (string.IsNullOrEmpty(txProveedor.Text))
            {
                controlsEmpty = "El Proveedor no ha sido seleccionado.";
                return false;
            }

            if (proveedor == null)
            {
                controlsEmpty = "El Proveedor no ha sido seleccionado.";
                return false;
            }

            if (string.IsNullOrEmpty(txNumeroFactura.Text))
            {
                controlsEmpty = "No se ha colocado un número de factura.";
                txNumeroFactura.Error = "Este campo es requerido";
                return false;
            }

            if (!DataGridHelper.ValidateEmptyGrid(grdCanastilla))
            {
                controlsEmpty = "¡No ha añadido productos!";
                lblMessageGrid.Text = "No se ha encontrado detalles, seleccionar al menos uno.";
                lblMessageGrid.BackColor = Color.Coral;
                return false;
            }

            lblMessageGrid.Text = "";
            lblMessageGrid.BackColor = Color.SeaGreen;
            return true;
        }
        // Crud

        private void SaveChange()
        {
            if (!ValidateControls(out string controlsEmpty))
            {
                Tools.Mensaje.MessageBox(Enumerables.Mensajeria.Warning,
                    $"Campos inválidos: {controlsEmpty}");
                // mensaje de  campos invalidos:: MessageBox:Personalizado
                return;
            }

            try
            {
                using (UnitOfWork uow = new UnitOfWork())
                {
                    string GetID = uow.compra.GetNewID();
                    int response = -1;

                    foreach (DataGridViewRow row in grdCanastilla.Rows)
                    {
                        string _codigoProducto = row.Cells["Codigo"].Value.ToString();

                        int _cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);

                        decimal _precioCompra = Convert.ToDecimal(row.Cells["PrecioCompra"].Value, 
                            new CultureInfo("en-US"));

                        decimal _precioVenta = Convert.ToDecimal(row.Cells["PrecioVenta"].Value,
                            new CultureInfo("en-US"));

                        decimal _subTotal = Convert.ToDecimal(row.Cells["SubTotal"].Value,
                            new CultureInfo("en-US"));

                        response += uow.compra.Crud(
                          new Entidad.compra()
                          {
                              id = GetID,
                              Usuario = "System",
                              idProveedor = proveedor.id,
                              NumeroFactura = txNumeroFactura.Text,
                              MontoTotal = Convert.ToDecimal(lbTotal.Text, new CultureInfo("en-US")),
                              Tasa = Convert.ToDecimal(txTasa.Text, new CultureInfo("en-US")),
                              EditorUser = Configs.GetEditorUser()

                          }, new Entidad.detalleCompra()
                          {
                                id = "",
                                codigoProducto = _codigoProducto,
                                Cantidad = _cantidad,
                                PrecioCompra = Convert.ToDecimal(_precioCompra, new CultureInfo("en-US")),
                                PrecioVenta = Convert.ToDecimal(_precioVenta, new CultureInfo("en-US")),
                                SubTotal = Convert.ToDecimal(_subTotal, new CultureInfo("en-US"))
                          }) ;
                    }

                    if (response > 0)
                    {
                        Tools.Mensaje.MessageBox(
                            Enumerables.Mensajeria.Succesful,
                            "Compra registrada satisfactoriamente.");
                        base.Set();
                    }
                }
            }
            catch (Exception ex)
            {
                Tools.Mensaje.MessageBox(Enumerables.Mensajeria.Error, ex);
            }
        }

        private void frmCompraModal_Load(object sender, EventArgs e)
        {
            Autonomo.Class.RoundObject.RoundButton(btnGuardar, 7, 7);
            LoadData();
        }

        private void txFiltro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                LoadData();
        }

        private void txTasa_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Autonomo.Class.Validating.OnlyDecimal(e, this.txTasa);
        }

        private void txTasa_TextBoxChanged(object sender, EventArgs e)
        {
            if(txTasa.Text == String.Empty)
            {
                txTasa.Text = "0.00";
            }

            if (Convert.ToDecimal(txTasa.Text, new CultureInfo("en-US")) > 0 &&
                Convert.ToDecimal(lbTotal.Text, new CultureInfo("en-US")) > 0)
            {
                string totalDolares = (Convert.ToDecimal(lbTotal.Text, new CultureInfo("en-US")) / Convert.ToDecimal(txTasa.Text, new CultureInfo("en-US"))).ToString("F2");
                lbTotalDolares.Text = $"${totalDolares}";
            }
            else
            {
                lbTotalDolares.Text = "$0.00";
            }
        }

        private void grdCanastilla_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            RemoverItem(e);
        }

        private void txTasa_Enter(object sender, EventArgs e)
        {
            txTasa.SelectAll();
        }

        private void txTasa_MouseClick(object sender, MouseEventArgs e)
        {
            txTasa.SelectAll();
        }

        private void txProveedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txProveedor.ReadOnly == false)
                {
                GetProveedor();
                }
            }
        }

        private void txProveedor_ButtonClick(object sender, EventArgs e)
        {
            txProveedor.ReadOnly = false;
            txProveedor.Text = "";
            this.proveedor = null;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveChange();
        }

        private void txNumeroFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            Autonomo.Class.Validating.OnlyNumber(e);
        }

        private void txProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Autonomo.Class.Validating.OnlyNumber(e);
        }
    }
}
