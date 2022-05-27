using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MampoteSystem.Windows.Tools.Models
{
    public class CarroVenta
    {
        string tipo;
        string codigo;
        string nombre;
        string categoria;
        int stock;
        int cantidad;
        decimal iva;
        decimal precioVenta;
        decimal subtotal;

        public string Tipo { get => tipo; set => tipo = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int Stock { get => stock; set => stock = value; }
        public decimal IVA
        {
            get => Convert.ToDecimal(iva, new CultureInfo("en-US"));
            set => iva = Convert.ToDecimal(value, new CultureInfo("en-US"));
        }
        public decimal PrecioVenta
        {
            get => Convert.ToDecimal(precioVenta, new CultureInfo("en-US"));
            set => precioVenta = Convert.ToDecimal(value, new CultureInfo("en-US"));
        }
        public decimal Subtotal { get => subtotal; set => subtotal = value; }
    }
}
