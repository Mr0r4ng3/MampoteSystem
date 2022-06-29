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
        private decimal Comision;
        private decimal NuevaComision;
        private string _idVenta;
        private decimal _Tasa;
        private string lastPercent = "1";
        private decimal NuevoMonto;
        private decimal TotalDescuento;
        public frmCerrarVentaModal()
        {
            InitializeComponent();
        }
        public void CargarMontos(decimal newMontoPagar, string newIdVenta, decimal setComision, decimal Tasa)
        {
            decimal MontoPagarDolares;

            _idVenta = newIdVenta;
            MontoPagar = Convert.ToDecimal(newMontoPagar, new CultureInfo("en-US"));
            Comision = Convert.ToDecimal(setComision, new CultureInfo("en-US"));

            _Tasa = Convert.ToDecimal(Tasa, new CultureInfo("en-US"));
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

            decimal MontoPagar = txMontoPago.Text == "" ? 0m : Convert.ToDecimal(txMontoPago.Text, new CultureInfo("en-US"));
            decimal VueltoBs = txVueltoBolivares.Text == "" ? 0m : Convert.ToDecimal(txVueltoBolivares.Text, new CultureInfo("en-US"));
            decimal VueltoDivisa = txVueltoDivisa.Text == "" ? 0m : Convert.ToDecimal(txVueltoDivisa.Text, new CultureInfo("en-US"));
            decimal Propina = txPropina.Text == "" ? 0m : Convert.ToDecimal(txPropina.Text, new CultureInfo("en-US"));

            if (MayorAlMonto())
            {
                txMontoPago.Error = "";
                if (MontoPagar == 0 && VueltoBs == 0 && VueltoDivisa == 0 && Propina == 0)
                {
                    controlsEmpty = "No se ha colocado ningun monto al pago.";
                    return false;
                }

                return true;
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
            TotalDescuento = 0m;

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
                : Math.Round(Convert.ToDecimal(txMontoPago.Text, new CultureInfo("en_US")),2);

            decimal montoVueltoOrPropina = ObtenerMontoVueltoPropina();

            if (cbTiposPago.Text == "Efectivo Dolares")
            {
                total += Math.Round(Convert.ToDecimal(montoPago, new CultureInfo("en-US")) * _Tasa, 2);
            }
            else
            {
                total += Math.Round(Convert.ToDecimal(montoPago, new CultureInfo("en-US")),2);
            }

            decimal newMontoPagar = Math.Round(MontoPagar,2);

            if(chkDescuento.Checked == true)
            {
                int descuentoPorcentaje = Convert.ToInt32(txPorcentajeDescuento.Text);
                string prefijo = descuentoPorcentaje < 10 ? "0.0" : "0.";
                decimal PorcentajeDescuento = Convert.ToDecimal(prefijo + txPorcentajeDescuento.Text, new CultureInfo("en-US"));
                decimal auxMontoPagar = (MontoPagar - Comision);
                TotalDescuento = auxMontoPagar * PorcentajeDescuento;
                newMontoPagar = auxMontoPagar - TotalDescuento;
                NuevaComision = Comision != 0 ? newMontoPagar * Convert.ToDecimal(0.10, new CultureInfo("en-US"))
                    : 0;
                newMontoPagar = newMontoPagar + NuevaComision;
                NuevoMonto = newMontoPagar;
            }

            diferencia = Convert.ToDecimal(newMontoPagar - Math.Round(total - montoVueltoOrPropina,2), new CultureInfo("en-US"));
            diferencia = diferencia < 0.10m && diferencia > 0 ? 0.00m : diferencia;
            decimal diferenciaDivisa = diferencia / _Tasa;


            lbTotalPagos.Text = total.ToString("F2", new CultureInfo("en-US"));
            lbDiferencia.Text = (diferenciaDivisa).ToString("F2", new CultureInfo("en-US"));
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

            decimal MontoPagar = txMontoPago.Text == "" ? 0m : Convert.ToDecimal(txMontoPago.Text, new CultureInfo("en-US"));
            decimal VueltoBs = txVueltoBolivares.Text == "" ? 0m : Convert.ToDecimal(txVueltoBolivares.Text, new CultureInfo("en-US"));
            decimal VueltoDivisa = txVueltoDivisa.Text == "" ? 0m : Convert.ToDecimal(txVueltoDivisa.Text, new CultureInfo("en-US"));
            decimal Propina = txPropina.Text == "" ? 0m : Convert.ToDecimal(txPropina.Text, new CultureInfo("en-US"));

            NewPago.idVenta = _idVenta;
            NewPago.idTipo = Convert.ToInt32(cbTiposPago.SelectedValue);
            NewPago.Descripcion = cbTiposPago.Text;
            NewPago.Monto =MontoPagar;
            NewPago.Tasa = Convert.ToDecimal( lbTasa.Text, new CultureInfo("en-US"));
            NewPago.Vuelto_Bolivares = VueltoBs;
            NewPago.Vuelto_Divisas = VueltoDivisa;
            NewPago.Propina = Propina;

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

            decimal newDeuda = Convert.ToDecimal(lbDiferenciaBs.Text, new CultureInfo("en-US"));
            bool Vendido = (newDeuda == 0) ? true : false;
            bool ApplyDescuento = chkDescuento.Checked == true ? true : false;
            string AddDescuentoInNota = $"Aplicado un descuento de {txPorcentajeDescuento.Text}%";
            string Descuento = $"{txPorcentajeDescuento.Text}%";

            if (ApplyDescuento && newDeuda > 0)
            {
                Tools.Mensaje.MessageBox(Enumerables.Mensajeria.Warning,
                    "No puede guardar una venta con un descuento promocional sin pagar la totalidad de la factura.");

                return;
            }


            if (newDeuda < 0)
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
                          }, newDeuda, txNumeroFactura.Text, Vendido, ApplyDescuento, NuevoMonto, NuevaComision, AddDescuentoInNota, Descuento, TotalDescuento);
                        
                        AddDescuentoInNota = "";
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
                Mensaje.MessageBox(Enumerables.Mensajeria.Error, ex);
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

        private void flatTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Autonomo.Class.Validating.OnlyNumber(e);
        }

        private void txPorcentajeDescuento_TextBoxChanged(object sender, EventArgs e)
        {

            if(chkDescuento.Checked == false)
            {
                txPorcentajeDescuento.Error = "";
                return;
            }

            int newNumber = txPorcentajeDescuento.Text != String.Empty && int.TryParse(txPorcentajeDescuento.Text, out _) 
                ? Convert.ToInt32(txPorcentajeDescuento.Text) 
                : 0;

            if (newNumber > 0 && newNumber < 100)
            {
                lastPercent = newNumber.ToString();
                txPorcentajeDescuento.Error = "";
                CalcularTotal();
                return;

            }
            txPorcentajeDescuento.Text = lastPercent.ToString();

            if(newNumber > 99)
            {
                txPorcentajeDescuento.Error = "Debe ser menor a %99";
            }
            else
            {
                txPorcentajeDescuento.Error = "Debe ser mayor a %0";
            }
        }

        private void chkDescuento_CheckedChanged(object sender, EventArgs e)
        {
            if(chkDescuento.Checked == false)
            {
                lastPercent = "1";
                txPorcentajeDescuento.Text = "0";
                txPorcentajeDescuento.Visible = false;

                CalcularTotal();
                return;
            }
            txPorcentajeDescuento.Visible = true;
        }
    }
}
