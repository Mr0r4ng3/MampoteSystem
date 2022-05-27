using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MampoteSystem.Windows.Tools.Models
{
    public class CarroCompra
    {
        string codigo;
        string nombre;
        string categoria;
        int cantidad;
        decimal precioCompra;
        decimal precioVenta;
        decimal subtotal;

        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public decimal PrecioCompra { get => Convert.ToDecimal(precioCompra, new CultureInfo("en-US")); 
            set => precioCompra = Convert.ToDecimal(value, new CultureInfo("en-US")); }
        public decimal PrecioVenta { get => Convert.ToDecimal(precioVenta, new CultureInfo("en-US")); 
            set => precioVenta = Convert.ToDecimal(value, new CultureInfo("en-US")); }
        public decimal Subtotal { get => subtotal; set => subtotal = value; }
    }
}
