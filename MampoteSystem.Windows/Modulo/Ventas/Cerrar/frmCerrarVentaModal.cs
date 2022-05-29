using MampoteSystem.Datos;
using MampoteSystem.Entidad.Pagos;
using MampoteSystem.Windows.Home;
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

namespace MampoteSystem.Windows.Modulo.Ventas.Cerrar
{
    public partial class frmCerrarVentaModal : Autonomo.Object.Modal
    {
        private decimal MontoPagar;
        private string _idVenta;
        private decimal _Tasa;
        public frmCerrarVentaModal()
        {
            InitializeComponent();
        }
        public void CargarMontos(decimal newMontoPagar, string newIdVenta)
        {
            decimal MontoPagarDolares;

            _idVenta = newIdVenta;
            MontoPagar = Convert.ToDecimal(newMontoPagar, new CultureInfo("en-US"));
            _Tasa = Convert.ToDecimal(frmMenu.GetInstance().TCambio, new CultureInfo("en-US"));
            MontoPagarDolares = Convert.ToDecimal(MontoPagar / _Tasa, new CultureInfo("en-US"));

            lbTasa.Text = _Tasa.ToString(new CultureInfo("en-US"));
            lbMontoPagarBs.Text = "Bs. " + MontoPagar.ToString(new CultureInfo("en-US"));
            lbMontoPagarDolares.Text = "$ " + MontoPagarDolares.ToString("F2",new CultureInfo("en-US"));

        }
        private void frmCerrarVentaModal_Load(object sender, EventArgs e)
        {
            Tools.ComboBoxHelper.ComboBoxTipoPagos(cbTiposPago);

            using(UnitOfWork uow = new UnitOfWork())
            {
                txNumeroFactura.Text = uow.venta.GetNewFactura();
            }

            CalcularTotal();
        }
        private bool MayorAlMonto()
        {
            if(Convert.ToDecimal(lbDiferenciaBs.Text, new CultureInfo ("en-US")) < 0)
            {
                return true;
            }
            return false;
        }
        private bool ValidateInputPagos(out string controlsEmpty)
        {
            controlsEmpty = string.Empty;
            if(MayorAlMonto())
            {
                txMontoPago.Error = "";
                if (txMontoPago.Text == "" || Convert.ToDecimal(txMontoPago.Text, new CultureInfo("en-US")) == 0)
                {
                    controlsEmpty = "No se ha colocado el monto del Pago.";
                    txMontoPago.Error = "Este campo es requerido";
                    return false;
                }

                txVueltoBolivares.Error = "";
                if (txVueltoBolivares.Text == "")
                {
                    if (txVueltoDivisa.Text == "")
                    {
                        if (txPropina.Text == "")
                        {
                            controlsEmpty = "No se ha colocado el monto del vuelto o propina.";
                            txVueltoBolivares.Error = "Este campo es requerido";
                            return false;
                        }
                        return true;

                    }
                    return true;
                }

                return true;
            }

            txMontoPago.Error = "";
            if (txMontoPago.Text == "" || Convert.ToDecimal(txMontoPago.Text, new CultureInfo("en-US")) == 0)
            {
                controlsEmpty = "No se ha colocado el monto del Pago.";
                txMontoPago.Error = "Este campo es requerido";
                return false;
            }

            return true;
        }
        private bool ValidateSaveData(out string controlsEmpty)
        {
            controlsEmpty = string.Empty;
            if (string.IsNullOrEmpty(txNumeroFactura.Text))
            {
                controlsEmpty = "No se ha colocado un número de factura.";
                txNumeroFactura.Error = "Este campo es requerido";
                return false;
            }

            if (!DataGridHelper.ValidateEmptyGrid(grdData))
            {
                controlsEmpty = "¡No ha añadido pagos!";
                return false;
            }

            return true;
        }
        private void CalcularTotal()
        {
            decimal total = 0m;
            decimal diferencia = 0m;

            foreach (DataGridViewRow row in grdData.Rows)
            {
                string description = row.Cells["Descripcion"].Value.ToString();
                decimal monto = Convert.ToDecimal(row.Cells["Monto"].Value, new CultureInfo("en-US"));
                decimal cellTasa = Convert.ToDecimal(row.Cells["Tasa"].Value, new CultureInfo("en-US"));

                if(description == "Efectivo Dolares")
                {
                    total += Convert.ToDecimal(monto * cellTasa, new CultureInfo("en-US"));
                }
                else
                {
                    total += monto;
                }
            }

            decimal montoPago = txMontoPago.Text == "" ? Convert.ToDecimal(0.00, new CultureInfo("en_US")) 
                : Convert.ToDecimal(txMontoPago.Text, new CultureInfo("en_US"));

            decimal montoVueltoOrPropina = ObtenerMontoVueltoPropina();

            if (cbTiposPago.Text == "Efectivo Dolares")
            {
                total += Convert.ToDecimal(montoPago, new CultureInfo("en-US")) * _Tasa;
            }
            else
            {
                total += Convert.ToDecimal(montoPago, new CultureInfo("en-US"));
            }

            diferencia = Convert.ToDecimal(MontoPagar - total + montoVueltoOrPropina, new CultureInfo("en-US"));


            lbTotalPagos.Text = total.ToString("F2", new CultureInfo("en-US"));
            lbDiferencia.Text = (diferencia / _Tasa).ToString("F2", new CultureInfo("en-US"));
            lbDiferenciaBs.Text = diferencia.ToString("F2", new CultureInfo("en-US"));
        }
        private decimal ObtenerMontoVueltoPropina()
        {
            decimal montoBolivares = txVueltoBolivares.Text == "" ? Convert.ToDecimal(0.00 , new CultureInfo("en-US")) 
                : Convert.ToDecimal(txVueltoBolivares.Text, new CultureInfo("en-US"));

            decimal montoDivisas = txVueltoDivisa.Text == "" ? Convert.ToDecimal(0.00, new CultureInfo("en-US"))
                : Convert.ToDecimal(txVueltoDivisa.Text, new CultureInfo("en-US")) * _Tasa;

            decimal montoPropina = txPropina.Text == "" ? Convert.ToDecimal(0.00, new CultureInfo("en-US"))
                : Convert.ToDecimal(txPropina.Text, new CultureInfo("en-US"));

            foreach (DataGridViewRow row in grdData.Rows)
            {
                montoBolivares += Convert.ToDecimal(row.Cells["Vuelto_Bolivares"].Value, new CultureInfo("en-US"));
                montoDivisas += Convert.ToDecimal(row.Cells["Vuelto_Divisas"].Value, new CultureInfo("en-US")) * _Tasa;
                montoPropina += Convert.ToDecimal(row.Cells["Propina"].Value, new CultureInfo("en-US"));

            }

            return montoBolivares + montoDivisas + montoPropina;
        }
        private void CleanPagoInputs()
        {
            txVueltoBolivares.Text = "0.00";
            txMontoPago.Text = "0.00";
            txNota.Clear();
        }
        private void AgregarPago()
        {
            if (!ValidateInputPagos(out string controlsEmpty))
            {
                Mensaje.MessageBox(Enumerables.Mensajeria.Warning,
                    $"Campos inválidos: {controlsEmpty}");
                // mensaje de  campos invalidos:: MessageBox:Personalizado
                return;
            }

            pago NewPago = new pago();

            NewPago.idVenta = _idVenta;
            NewPago.idTipo = Convert.ToInt32(cbTiposPago.SelectedValue);
            NewPago.Descripcion = cbTiposPago.Text;
            NewPago.Monto = Convert.ToDecimal( txMontoPago.Text, new CultureInfo("en-US"));
            NewPago.Tasa = Convert.ToDecimal( lbTasa.Text, new CultureInfo("en-US"));
            NewPago.Vuelto_Bolivares = txVueltoBolivares.Text != "" ? Convert.ToDecimal( txVueltoBolivares.Text, new CultureInfo("en-US"))
                    : Convert.ToDecimal(0.00, new CultureInfo("en-US"));

            NewPago.Vuelto_Divisas = txVueltoDivisa.Text != "" ? Convert.ToDecimal( txVueltoDivisa.Text, new CultureInfo("en-US"))
                    : Convert.ToDecimal(0.00, new CultureInfo("en-US"));

            NewPago.Propina = txPropina.Text != "" ? Convert.ToDecimal( txPropina.Text, new CultureInfo("en-US"))
                    : Convert.ToDecimal(0.00, new CultureInfo("en-US"));

            NewPago.Nota = txNota.Text;

            grdData.Rows.Add(NewPago.idVenta,
                             NewPago.idTipo,
                             NewPago.Descripcion,
                             NewPago.Monto,
                             NewPago.Tasa,
                             NewPago.Vuelto_Bolivares,
                             NewPago.Vuelto_Divisas,
                             NewPago.Propina,
                             NewPago.Nota);

            CalcularTotal();
            CleanPagoInputs();
        }
        private void RemoverItem(DataGridViewCellEventArgs e)
        {
            if (grdData.SelectedRows.Count > 0)
            {
                int rowIndex = grdData.CurrentCell.RowIndex;
                DataGridHelper.RemoveRows(grdData, rowIndex);
                CalcularTotal();
            }
        }
        private void Guardar()
        {
            if (!ValidateSaveData(out string controlsEmpty))
            {
                Tools.Mensaje.MessageBox(Enumerables.Mensajeria.Warning,
                    $"Campos inválidos: {controlsEmpty}");
                // mensaje de  campos invalidos:: MessageBox:Personalizado
                return;
            }

            if(Convert.ToDecimal(lbDiferenciaBs.Text, new CultureInfo("en-US")) < 0)
            {
                DialogResult response = MessageBox.Show("La venta tiene un saldo negativo (devolucion al cliente), ¿Desea guardar de igual forma?",
                    "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if(response == DialogResult.No)
                {
                    return;
                }
            }

            try
            {
                using (UnitOfWork uow = new UnitOfWork())
                {
                    int response = -1;
                    decimal newDeuda = Convert.ToDecimal(lbDiferenciaBs.Text, new CultureInfo("en-US"));
                    bool Vendido = (newDeuda == 0) ? true : false;

                    foreach (DataGridViewRow row in grdData.Rows)
                    {

                        int _tipo = Convert.ToInt32(row.Cells["idTipo"].Value);

                        decimal _Monto = Convert.ToDecimal(row.Cells["Monto"].Value,
                            new CultureInfo("en-US"));

                        decimal _TasaPago = Convert.ToDecimal(row.Cells["Tasa"].Value,
                            new CultureInfo("en-US"));

                        decimal _Vuelto_Bolivares = Convert.ToDecimal(row.Cells["Vuelto_Bolivares"].Value,
                            new CultureInfo("en-US"));

                        decimal _Vuelto_Divisas = Convert.ToDecimal(row.Cells["Vuelto_Divisas"].Value,
                            new CultureInfo("en-US"));

                        decimal _Propina = Convert.ToDecimal(row.Cells["Propina"].Value,
                            new CultureInfo("en-US"));

                        string _Nota = row.Cells["Nota"].Value.ToString();

                        response += uow.pago.Crud(
                          new Entidad.Pagos.pago()
                          {
                              idVenta = _idVenta,
                              idTipo = _tipo,
                              Monto = _Monto,
                              Tasa = _TasaPago,
                              Vuelto_Bolivares = _Vuelto_Bolivares,
                              Vuelto_Divisas = _Vuelto_Divisas,
                              Propina = _Propina,
                              Nota = _Nota
                          }, newDeuda, txNumeroFactura.Text, Vendido);
                    }

                    if (response > 0)
                    {
                        Tools.Mensaje.MessageBox(
                            Enumerables.Mensajeria.Succesful,
                            "Pagos registrados satisfactoriamente.");
                        base.Set();
                    }
                }
            }
            catch (Exception ex)
            {
                Mensaje.MessageBox(Enumerables.Mensajeria.Error, "El numero de factura colocado ya existe en la base de datos.");
            }
        }
        private void txMontoPagar_TextBoxChanged(object sender, EventArgs e)
        {
            CalcularTotal();

            if(MayorAlMonto())
            {
                txVueltoBolivares.Visible = true;
                txVueltoDivisa.Visible = true;
                txPropina.Visible = true;
            }
            else
            {
                txVueltoBolivares.Visible = false;
                txVueltoBolivares.Text = "0.00";

                txVueltoDivisa.Visible = false;
                txVueltoDivisa.Text = "0.00";

                txPropina.Visible = false;
                txPropina.Text = "0.00";
            }
        }
        private void txMontoPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbTiposPago.Text == "Efectivo Dolares")
            {
                Autonomo.Class.Validating.OnlyNumber(e);
                return;
            }
            e.Handled = Autonomo.Class.Validating.OnlyDecimal(e, this.txMontoPago);
        }
        private void txVuelto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Autonomo.Class.Validating.OnlyDecimal(e, this.txVueltoBolivares);
        }
        private void txVuelto_TextBoxChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            AgregarPago();
        }
        private void grdData_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            RemoverItem(e);
        }
        private void btnCerrarVenta_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        private void cbTiposPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTiposPago.Text == "Efectivo Dolares")
            {
                txMontoPago.Clear();
            }
        }

        private void txVueltoDivisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Autonomo.Class.Validating.OnlyDecimal(e, this.txVueltoDivisa);
        }

        private void txPropina_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Autonomo.Class.Validating.OnlyDecimal(e, this.txPropina);
        }
    }
}
