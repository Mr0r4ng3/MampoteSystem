using Autonomo.CustomControls;
using MampoteSystem.Datos;
using MampoteSystem.Entidad;
using MampoteSystem.Entidad.Report;
using MampoteSystem.Windows.Home;
using MampoteSystem.Windows.Modulo.Clientes;
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

namespace MampoteSystem.Windows.Modulo.Ventas.Abrir
{
    public partial class frmAbrirVentaModal : Autonomo.Object.Modal
    {
        public bool NuevaVenta;
        public string GetID;
        public string ClienteNameInEdit;
        public decimal TotalOld;
        public bool Comisionada;
        public Object DetalleVenta;


        private decimal total;
        private clientes cliente;
        private String[] TIPOS_CEDULA = {"Venezolano","Extranjero"};

        private decimal comision;
        public frmAbrirVentaModal()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var stock = uow.productos.GetListTwo()
                    .Where(o => o.Nombre.ToLower().Contains(txFiltro.Text.ToLower()))
                    .ToList();

                PopulateCart(stock);
            }
        }
        private void PopulateCart(List<prodComi> stocks)
        {

            try
            {

                txFiltro.Enabled = false;

                if (stocks != null)
                {
                    flowCart.Controls.Clear();

                    foreach (Control control in flowCart.Controls)
                    {
                        control.Dispose();
                    }

                    foreach (var item in stocks)
                    {
                        if(item.Tipo == "COMIDA")
                        {

                            CustomListComida cart = new CustomListComida()
                            {
                                codigoComida = item.Codigo,
                                Titulo = item.Nombre,
                                Category = item.Categoria,
                                PrecioVenta = item.Precio_Venta,
                                Stock = item.Stock,
                                StockAvaible = item.Stock > 0 ? true : false
                            };

                            cart.Agregar.Click += (sender, args)
                            => PopulateGrid(
                                new CarroVenta()
                                {
                                    Tipo = item.Tipo,
                                    Codigo = item.Codigo,
                                    Nombre = item.Nombre,
                                    Stock = item.Stock,
                                    Cantidad = cart.Cantidad,
                                    IVA = item.IVA,
                                    PrecioVenta = cart.PrecioVenta,
                                    Subtotal = (cart.Cantidad * cart.PrecioVenta)
                                });

                            flowCart.Controls.Add(cart);
                        }
                        else
                        {
                            CustomListVenta cart = new CustomListVenta()
                            {
                                codigoProducto = item.Codigo,
                                Stock = item.Stock,
                                Titulo = item.Nombre,
                                Category = item.Categoria,
                                PrecioVenta = item.Precio_Venta
                            };

                            cart.Agregar.Click += (sender, args)
                            => PopulateGrid(
                                new CarroVenta()
                                {
                                    Tipo = item.Tipo,
                                    Codigo = item.Codigo,
                                    Nombre = item.Nombre,
                                    Stock = item.Stock,
                                    Cantidad = cart.Cantidad,
                                    IVA = item.IVA,
                                    PrecioVenta = cart.PrecioVenta,
                                    Subtotal = (cart.Cantidad * cart.PrecioVenta)
                                }) ;

                            flowCart.Controls.Add(cart);
                        }
                }
            }
            } 
            catch(Win32Exception ex)
            {
                Tools.Mensaje.MessageBox(Enumerables.Mensajeria.Error, ex);
            }
            finally
            {
                txFiltro.Enabled = true;
                txFiltro.Focus();
            }
        }
        private void PopulateGrid(CarroVenta items)
        {
            var response = DataGridHelper.PopulateGrid(grdCanastilla,
                            Enumerables.LlenarGrilla.Venta, items);

            MostrarTotales();
            lblMessageGrid.Text = response.Mensaje;
            if (response.Estado)
            {
                lblMessageGrid.BackColor = Color.SeaGreen;
                return;
            }
            lblMessageGrid.BackColor = Color.Coral;
        }
        private void RemoverItem(DataGridViewCellEventArgs e)
        {
            if (grdCanastilla.SelectedRows.Count > 0)
            {
                int rowIndex = grdCanastilla.CurrentCell.RowIndex;
                DataGridHelper.RemoveRows(grdCanastilla, rowIndex);
                MostrarTotales();

                lblMessageGrid.Text = "Item removido satisfactoriamente";
                lblMessageGrid.BackColor = Color.SeaGreen;
            }
        }
        private void MostrarTotales()
        {

            if (NuevaVenta)
            {

                lblTotals.Text = $"{grdCanastilla.Rows.Count}, Items";
                decimal tasa = Convert.ToDecimal(frmMenu.GetInstance().TCambio, new CultureInfo("en-US"));
                var canasta = DataGridHelper.GetTotalsVenta(grdCanastilla);
                decimal totalDivisa;

                if (chkComision.Checked)
                {
                    decimal porcentaje = Convert.ToDecimal(0.10);
                    comision = Convert.ToDecimal(canasta.Subtotal * porcentaje,new CultureInfo("en-US"));

                    total = Convert.ToDecimal((canasta.Subtotal * porcentaje) + canasta.Subtotal,
                        new CultureInfo("en-US"));

                    totalDivisa = Convert.ToDecimal(total / tasa, new CultureInfo("en-US"));

                    Comisionada = true;

                }
                else
                {
                    comision = Convert.ToDecimal(0.00);

                    total = Convert.ToDecimal(canasta.Subtotal,
                        new CultureInfo("en-US"));

                    totalDivisa = Convert.ToDecimal(total / tasa, new CultureInfo("en-US"));

                    Comisionada = false;
                }

                lbCantidad.Text = canasta.Cantidad.ToString();
                lbTotalDolares.Text = $"$ {totalDivisa.ToString("F2", new CultureInfo("en-US"))}";
                lbTotal.Text = $"Bs. {total.ToString("F2", new CultureInfo("en-US"))}";
            }
            else
            {
                lblTotals.Text = $"{grdCanastilla.Rows.Count}, Items";
                decimal tasa = Convert.ToDecimal(frmMenu.GetInstance().TCambio, new CultureInfo("en-US"));
                var canasta = DataGridHelper.GetTotalsVenta(grdCanastilla);
                decimal totalDivisa;

                if (chkComision.Checked)
                {
                    decimal porcentaje = Convert.ToDecimal(0.10);
                    comision = Convert.ToDecimal(canasta.Subtotal * porcentaje, new CultureInfo("en-US"));

                    total = Convert.ToDecimal(TotalOld + Convert.ToDecimal((canasta.Subtotal * porcentaje) + canasta.Subtotal
                        ),new CultureInfo("en-US"));

                    totalDivisa = Convert.ToDecimal(total / tasa, new CultureInfo("en-US"));

                }
                else
                {
                    comision = Convert.ToDecimal(0.00);

                    total =Convert.ToDecimal(TotalOld + Convert.ToDecimal(canasta.Subtotal
                        ),new CultureInfo("en-US"));

                    totalDivisa = Convert.ToDecimal(total / tasa, new CultureInfo("en-US"));
                }

                lbCantidad.Text = canasta.Cantidad.ToString();
                lbTotalDolares.Text = $"$ {totalDivisa.ToString("F2", new CultureInfo("en-US"))}";
                lbTotal.Text = $"Bs. {total.ToString("F2", new CultureInfo("en-US"))}";
            }
        }
        private void GetCliente(string cedula)
        {
            cliente = Tools.SearchCliente.Search(cedula, NuevaVenta);
            if(cliente != null)
            {
                txCliente.Text = cliente.Nombres + " " + cliente.Apellidos;

                lblMessageGrid.Text = $"{cliente.Nombres} {cliente.Apellidos} seleccionado como cliente para la venta.";
                lblMessageGrid.BackColor = Color.SeaGreen;
                txCliente.ReadOnly = true;
                cbCedula.Enabled = false;

            }
            else
            {
                txCliente.ReadOnly = false;
                txCliente.Focus();
                lblMessageGrid.Text = $"No se ha encontrado o seleccionado un cliente.";
                lblMessageGrid.BackColor = Color.Coral;
            }
        }
        private bool ValidateControls(out string controlsEmpty)
        {
            controlsEmpty = string.Empty;
           
            if (!DataGridHelper.ValidateEmptyGrid(grdCanastilla))
            {
                controlsEmpty = "¡No ha añadido nada a la venta!";
                lblMessageGrid.Text = "Debe añadir algo a la venta para continuar.";
                lblMessageGrid.BackColor = Color.Coral;
                return false;
            }

            if (string.IsNullOrEmpty(txCliente.Text))
            {
                controlsEmpty = "El Cliente no ha sido seleccionado.";
                lblMessageGrid.Text = "Debe seleccionar el cliente para continuar.";
                lblMessageGrid.BackColor = Color.Coral;
                return false;
            }

            if (cliente == null)
            {
                controlsEmpty = "El Cliente no ha sido seleccionado.";
                lblMessageGrid.Text = "Debe seleccionar el cliente para continuar.";
                lblMessageGrid.BackColor = Color.Coral;
                return false;
            }

            lblMessageGrid.Text = "";
            lblMessageGrid.BackColor = Color.SeaGreen;
            return true;
        }
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

                    if (NuevaVenta)
                    {
                        GetID = uow.venta.GetNewID();
                    }


                    int response = -1;

                    foreach (DataGridViewRow row in grdCanastilla.Rows)
                    {
                        string _tipo = row.Cells["Tipo"].Value.ToString();
                        
                        string _codigo = row.Cells["Codigo"].Value.ToString();

                        int _cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);

                        decimal _precioVenta = Convert.ToDecimal(row.Cells["PrecioVenta"].Value,
                            new CultureInfo("en-US"));

                        decimal _iva = Convert.ToDecimal(row.Cells["IVA"].Value,
                            new CultureInfo("en-US"));

                        decimal _subTotal = Convert.ToDecimal(row.Cells["SubTotal"].Value,
                            new CultureInfo("en-US"));

                        response += uow.venta.Crud(
                          new Entidad.venta()
                          {
                              id = GetID,
                              NumeroFactura = "SIN FACTURAR",
                              idCliente = cliente.id,
                              Comision = comision,
                              EstadoComision = comision > 0 ? "Sin Pagar" : "No Aplica",
                              MontoTotal = Convert.ToDecimal(total, new CultureInfo("en-US")),
                              Deuda = Convert.ToDecimal(total, new CultureInfo("en-US"))

                          }, new Entidad.detalleVenta()
                          {
                              Tipo = _tipo,
                              Codigo = _codigo,
                              Cantidad = _cantidad,
                              Precio_Venta = _precioVenta,
                              IVA = _iva,
                              SubTotal = _subTotal
                          }, Comisionada);
                    }

                    if (response > 0)
                    {
                        Tools.Mensaje.MessageBox(
                            Enumerables.Mensajeria.Succesful,
                            "Venta guardada satisfactoriamente.");
                        base.Set();
                    }
                    else
                    {
                        Tools.Mensaje.MessageBox(
                            Enumerables.Mensajeria.Succesful,
                            "No se guardo");
                        base.Set();
                    }
                }
            }
            catch (Exception ex)
            {
                Tools.Mensaje.MessageBox(Enumerables.Mensajeria.Error, ex);
            }
        }
        private void frmAbrirVentaModal_Load(object sender, EventArgs e)
        {
            Autonomo.Class.RoundObject.RoundButton(btnGuardar, 7, 7);
            
            decimal tasa = Convert.ToDecimal(frmMenu.GetInstance().TCambio, new CultureInfo("en-US"));

            lbTasa.Text = $"Tasa de Cambio: Bs. {tasa.ToString("F2", new CultureInfo("en-US"))}";

            if (!NuevaVenta)
            {
                chkComision.Checked = Comisionada;
                chkComision.Enabled = false;

                cliente = new clientes();
                cliente.id = 0;
                txCliente.Text = ClienteNameInEdit;
                txCliente.Enabled = false;
                cbCedula.Enabled = false;

                MostrarTotales();
                grdDetalle.DataSource = DetalleVenta;
                grdDetalle.Columns[0].Visible = false;
            }

            cbCedula.DataSource = TIPOS_CEDULA;
        }
        private void grdCanastilla_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            RemoverItem(e);
        }
        private void txCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txCliente.ReadOnly == false)
                {
                    if(cbCedula.Text == "Venezolano")
                    {
                        string cedula = "V-" + txCliente.Text;
                        GetCliente(cedula);
                    }
                    else
                    {
                        string cedula = "E-" + txCliente.Text;
                        GetCliente(cedula);
                    }
                }
            }
        }
        private void txCliente_ButtonClick(object sender, EventArgs e)
        {
            txCliente.ReadOnly = false;
            txCliente.Text = "";
            this.cliente = null;
            cbCedula.Enabled = true;
            lblMessageGrid.Text = "Se ha limpiado el cliente.";
            lblMessageGrid.BackColor = Color.Blue;
        }
        private void txCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            Autonomo.Class.Validating.OnlyNumber(e);
        }
        private void customCheck1_CheckedChanged(object sender, EventArgs e)
        {
            MostrarTotales();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveChange();
        }
        private void btnCerrarVenta_Click(object sender, EventArgs e)
        {
        }
        private void txFiltro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                LoadData();
        }
        private void chkDeudaInicial_CheckedChanged(object sender, EventArgs e)
        {
            if(chkDeudaInicial.Checked == true)
            {
                txMontoDeuda.Visible = true;
                btnAddDeuda.Visible = true;
            }
            else
            {
                txMontoDeuda.Visible = false;
                btnAddDeuda.Visible = false;
            }
        }
        private void btnAddDeuda_Click(object sender, EventArgs e)
        {
            if(txMontoDeuda.Text == "")
            {
                lblMessageGrid.Text = "Debe añadir el monto de la Deuda";
                lblMessageGrid.BackColor = Color.Coral;
                txMontoDeuda.Error = "Obligatorio";
                return;
            }

            CarroVenta Deuda = new CarroVenta();

            Deuda.Tipo = "DEUDA";
            Deuda.Cantidad = 1;
            Deuda.Stock = 1;
            Deuda.Nombre = "Deuda inicial";
            Deuda.Categoria = "Deuda";
            Deuda.IVA = 0;
            Deuda.Codigo = "DEUD000";
            Deuda.PrecioVenta = Convert.ToDecimal(txMontoDeuda.Text, new CultureInfo("en-US"));
            Deuda.Subtotal = Convert.ToDecimal(txMontoDeuda.Text, new CultureInfo("en-US"));

            PopulateGrid(Deuda);

            txMontoDeuda.Error = "";
            lblMessageGrid.Text = "";
            lblMessageGrid.BackColor = Color.SeaGreen;
        }
    }
}
