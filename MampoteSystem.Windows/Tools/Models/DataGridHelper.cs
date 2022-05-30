using Autonomo.CustomControls;
using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MampoteSystem.Windows.Tools.Enumerables;

namespace MampoteSystem.Windows.Tools.Models
{
    public class DataGridHelper
    {
        private static bool ValidateGrid(string codigo, CustomGrid grid, bool venta)
        {

                bool returnValue = false;
            if (venta)
            {
                foreach (DataGridViewRow row in grid.Rows)
                {
                    var _codigo = row.Cells[1].Value.ToString();
                    if (_codigo == codigo)
                    {
                        returnValue = true;
                        break;
                    }
                }
            }
            else
            {
                foreach (DataGridViewRow row in grid.Rows)
                {
                    var _codigo = row.Cells[0].Value.ToString();
                    if (_codigo == codigo)
                    {
                        returnValue = true;
                        break;
                    }
                }
            }
            
            return returnValue;
        }


        /// <summary>
        /// Método para agregar items a la Grilla.
        /// </summary>
        /// <param name="grid"></param>
        /// <param name="tipoModulo"></param>
        /// <param name="canastilla"></param>
        /// <returns></returns>
        public static CanastillaReturn PopulateGrid<T>(CustomGrid grid, LlenarGrilla tipoModulo, T canasta)
        {
            var returnValue = new CanastillaReturn();
            var productosCompra = new CarroCompra();
            var VentaItems = new CarroVenta();

            bool isVenta = false;
            string unico = string.Empty;
            string nombre = string.Empty;

            if (tipoModulo == LlenarGrilla.Compra)
            {
                productosCompra = (CarroCompra)Convert.ChangeType(canasta, typeof(T));
                unico = productosCompra.Codigo;
                nombre = productosCompra.Nombre;
            }

            if(tipoModulo == LlenarGrilla.Venta)
            {
                VentaItems = (CarroVenta)Convert.ChangeType(canasta, typeof(T));
                unico = VentaItems.Codigo;
                nombre = VentaItems.Nombre;
                isVenta = true;
            }

            if (!ValidateGrid(unico, grid, isVenta))
            {
                switch (tipoModulo)
                {
                    case LlenarGrilla.Compra:
                        {
                            
                            if(productosCompra.PrecioCompra == Convert.ToDecimal(0.00))
                            {
                                returnValue.Estado = false;
                                returnValue.Mensaje = $"¡Debe colocar el precio de compra en Bs de {nombre}, para que sea agregado!";
                                return returnValue;
                            }

                            if (productosCompra.PrecioVenta == Convert.ToDecimal(0.00))
                            {
                                returnValue.Estado = false;
                                returnValue.Mensaje = $"¡Debe colocar el precio de venta en $ de {nombre}, para que sea agregado!";
                                return returnValue;
                            }

                            grid.Rows.Add(productosCompra.Codigo,
                                productosCompra.Nombre,
                                productosCompra.Cantidad,
                                productosCompra.PrecioCompra,
                                productosCompra.PrecioVenta,
                                productosCompra.Subtotal
                                );
                            break;
                        }

                    case LlenarGrilla.Venta:
                        {
                            if(VentaItems.Tipo == "COMIDA" || VentaItems.Tipo == "PROMOCIONES" && VentaItems.Stock == 0)
                            {
                                grid.Rows.Add(
                                    VentaItems.Tipo,
                                    VentaItems.Codigo,
                                    VentaItems.Nombre,
                                    VentaItems.Cantidad,
                                    VentaItems.PrecioVenta,
                                    VentaItems.IVA,
                                    VentaItems.Subtotal
                                    );
                            }
                            else { 
                                if (VentaItems.Cantidad > VentaItems.Stock)
                                {
                                    returnValue.Estado = false;
                                    returnValue.Mensaje = $"¡La cantidad de {nombre} que intenta agregar supera el stock actual!";
                                    return returnValue;
                                }
                                grid.Rows.Add(
                                    VentaItems.Tipo,
                                    VentaItems.Codigo,
                                    VentaItems.Nombre,
                                    VentaItems.Cantidad,
                                    VentaItems.PrecioVenta,
                                    VentaItems.IVA,
                                    VentaItems.Subtotal
                                    );
                            }
                            break;
                        }
                }
                returnValue.Estado = true;
                returnValue.Mensaje = $"Item {nombre}, se ha adicionado correctamente.";
            }
            else
            {
                if(tipoModulo == LlenarGrilla.Venta)
                {
                    foreach(DataGridViewRow row in grid.Rows)
                    {
                        if(row.Cells[1].Value.ToString() == unico)
                        {
                            int CantidadEnCanasta = Convert.ToInt32(row.Cells[3].Value);
                            int CantidadConNuevaAdiccion = VentaItems.Cantidad + CantidadEnCanasta;

                            if (VentaItems.Stock < CantidadConNuevaAdiccion && VentaItems.Stock > 0)
                            {
                                returnValue.Estado = false;
                                returnValue.Mensaje = $"¡La cantidad de {nombre} que intenta agregar supera el stock actual!";
                                break;
                            }

                            row.Cells[3].Value = Convert.ToInt32(row.Cells[3].Value) + VentaItems.Cantidad;
                            row.Cells[6].Value = Convert.ToDecimal(row.Cells[6].Value) + VentaItems.Subtotal;

                            returnValue.Estado = true;
                            returnValue.Mensaje = $"Al Item {nombre}, se le agregaron {VentaItems.Cantidad} unidades.";
                            break;
                        }
                    }
                    return returnValue;
                }
                returnValue.Estado = false;
                returnValue.Mensaje = $"El Item {nombre}, ya se ha agregado";
            }
            return returnValue;
        }

        /// <summary>
        /// Método para obtener los totales de Precios y Cantidades || sumatoria de pagos.
        /// </summary>
        /// <param name="grid">Corresponde a la grilla "Canastilla".</param>
        /// <param name="priceItem">Variable que almacena el total de los Precios.</param>
        /// <param name="quantityItem">Variable que almacena el total de las Cantidades.</param>
        public static CarroCompra GetTotals(CustomGrid grid, LlenarGrilla tipoModulo)
        {
            var canastaCompra = new CarroCompra();
            int cantidad = 0;
            decimal Total = 0m;


            foreach (DataGridViewRow row in grid.Rows)
            {
                cantidad += int.Parse(row.Cells[2].Value.ToString());
                Total += Convert.ToDecimal(row.Cells[5].Value, new CultureInfo("en-US"));
            }

            canastaCompra.Cantidad = cantidad;
            canastaCompra.Subtotal = Total;

            return canastaCompra;
        }

        public static CarroVenta GetTotalsVenta(CustomGrid grid)
        {
            var canastaVenta = new CarroVenta();
            int cantidad = 0;
            decimal Total = 0m;

            foreach (DataGridViewRow row in grid.Rows)
            {
                if (row.Cells[0].Value.ToString() == "PROMOCIONES")
                {
                    Total -= Convert.ToDecimal(row.Cells[6].Value, new CultureInfo("en-US"));
                }
                else
                {
                    Total += Convert.ToDecimal(row.Cells[6].Value, new CultureInfo("en-US"));
                    cantidad += int.Parse(row.Cells[3].Value.ToString());
                }
            }

            canastaVenta.Cantidad = cantidad;
            canastaVenta.Subtotal = Total;
            return canastaVenta;

        }

        /// <summary>
        /// Método para Eliminar un Item de la Grilla.
        /// </summary>
        /// <param name="grid"></param>
        /// <param name="index"></param>
        public static void RemoveRows(CustomGrid grid, int rowIndex)
        {
            grid.Rows.RemoveAt(rowIndex);
        }

        /// <summary>
        /// Método para validar si la grilla está vacia.
        /// </summary>
        /// <param name="grid"></param>
        /// <returns>Retorna True si la grilla contiene valores, caso contrario retorna False.</returns>
        public static bool ValidateEmptyGrid(CustomGrid grid)
        {
            return grid.Rows.Count > 0 ? true : false;
        }

        public static DataTable GetDataTable(CustomGrid grid)
        {
            var data = new DataTable();

            foreach(DataGridViewColumn column in grid.Columns)
            {
                string name = column.Name;
                data.Columns.Add(name);
            }

            object[] cellValues = new object[grid.Columns.Count];
            foreach(DataGridViewRow row in grid.Rows)
            {
                for(int i = 0; i < row.Cells.Count; i++)
                {
                    cellValues[i] = row.Cells[i].Value;
                }
                data.Rows.Add(cellValues);
            }

            return data;
        }

        public static void ExportToExcel(DataTable data, string Name)
        {
            try
            {

                using (XLWorkbook workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add(data, Name);

                    SaveFileDialog dialog = new SaveFileDialog();
                    dialog.Filter = "excel file (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                    dialog.FileName = $"{Name}.xlsx";
                    dialog.RestoreDirectory = true;

                    worksheet.Columns().AdjustToContents();

                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        workbook.SaveAs(dialog.FileName);

                        Mensaje.MessageBox(Mensajeria.Succesful, $"Se exportaron {data.Rows.Count} registros.");
                    }

                }
            }
            catch(Exception ex)
            {
                Mensaje.MessageBox(Mensajeria.Error, "Ocurrio un error al exportar los datos.");
            }
            
        }
    }
}
