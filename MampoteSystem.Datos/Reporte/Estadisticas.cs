using MampoteSystem.Datos.AdoNet;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MampoteSystem.Datos.Reporte
{
    public struct RevenueByDate
    {
        public string Date { get; set; }
        public decimal TotalAmount { get; set; }
    }
    public class Estadisticas : DbConn
    {
        //Fields & Properties
        private DateTime startDate;
        private DateTime endDate;
        private int numberDays;

        public decimal PagoDivisas { get; private set; }
        public decimal VueltoDivisas { get; private set; }
        public decimal PagoPunto { get; private set; }
        public decimal PagoEfectivo { get; private set; }
        public decimal PagoPM { get; private set; }
        public int NumCustomers { get; private set; }
        public int NumSuppliers { get; private set; }
        public int NumProducts { get; private set; }
        public int NumComida { get; private set; }
        public List<KeyValuePair<string, int>> TopProductsList { get; private set; }
        public List<KeyValuePair<string, int>> UnderstockList { get; private set; }
        public List<RevenueByDate> GrossRevenueList { get; private set; }
        public int NumOrders { get; set; }
        public decimal TotalRevenue { get; set; }

        //Constructor
        public Estadisticas()
        {

        }

        //Private methods
        private void GetNumberItems()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    //Get Total Number of Customers
                    command.CommandText = "select COUNT(id) from clientes where Estado = 1";
                    NumCustomers = (int)command.ExecuteScalar();

                    //Get Total Number of Suppliers
                    command.CommandText = "select COUNT(id) from proveedores where Estado = 1";
                    NumSuppliers = (int)command.ExecuteScalar();

                    //Get Total Number of Products
                    command.CommandText = "select COUNT(Codigo) from productos where idTipo = 1 and Estado = 1";
                    NumProducts = (int)command.ExecuteScalar();

                    //Get Total Number of Comida
                    command.CommandText = "select COUNT(Codigo) from productos where idTipo = 2 and Estado = 1";
                    NumComida = (int)command.ExecuteScalar();

                    //Get Total Number of Orders
                    command.CommandText = @"select count(id) from venta " +
                                            "where venta.Vendido = @Uno and Fecha between @fromDate and @toDate and Estado = 1";
                    command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = startDate;
                    command.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = endDate;
                    command.Parameters.Add("@Uno", System.Data.SqlDbType.Int).Value = 1;

                    NumOrders = (int)command.ExecuteScalar();

                    //Get Total Pago Divisa
                    command.CommandText = @"select SUM(Monto) from pagos " +
                                            "where idTipo = @Uno and Fecha between @fromDate and @toDate";

                    var temp = command.ExecuteScalar();
                    PagoDivisas = temp != DBNull.Value ? Convert.ToDecimal(temp, new CultureInfo("en-US")) : Convert.ToDecimal(0.00, new CultureInfo("en-US"));


                    //Get Total Vuelto Divisa
                    command.CommandText = @"select SUM(Vuelto) from pagos " +
                                            "where idTipo = @Uno and Fecha between @fromDate and @toDate";

                    temp = command.ExecuteScalar();
                    VueltoDivisas = temp != DBNull.Value ? Convert.ToDecimal(temp, new CultureInfo("en-US")) : Convert.ToDecimal(0.00, new CultureInfo("en-US"));

                    //Get Total Pago Punto
                    command.CommandText = @"select SUM(Monto) from pagos " +
                                            "where idTipo = @Dos and Fecha between  @fromDate and @toDate";
                    command.Parameters.Add("@Dos", System.Data.SqlDbType.Int).Value = 2;

                    temp = command.ExecuteScalar();
                    PagoPunto = temp != DBNull.Value ? Convert.ToDecimal(temp, new CultureInfo("en-US")) : Convert.ToDecimal(0.00, new CultureInfo("en-US"));

                    //Get Total Pago Efectivo
                    command.CommandText = @"select SUM(Monto) from pagos " +
                                            "where idTipo = @Tres and Fecha between  @fromDate and @toDate";
                    command.Parameters.Add("@Tres", System.Data.SqlDbType.Int).Value = 3;
                    
                    temp = command.ExecuteScalar();
                    PagoEfectivo = temp != DBNull.Value ? Convert.ToDecimal(temp, new CultureInfo("en-US")) : Convert.ToDecimal(0.00, new CultureInfo("en-US"));

                    //Get Total Pago PM
                    command.CommandText = @"select SUM(Monto) from pagos " +
                                            "where idTipo = @Cuatro and Fecha between  @fromDate and @toDate";
                    command.Parameters.Add("@Cuatro", System.Data.SqlDbType.Int).Value = 4;
                    temp = command.ExecuteScalar();
                    PagoPM = temp != DBNull.Value ? Convert.ToDecimal(temp, new CultureInfo("en-US")) : Convert.ToDecimal(0.00, new CultureInfo("en-US"));
                }
            }
        }
        private void GetProductAnalisys()
        {
            TopProductsList = new List<KeyValuePair<string, int>>();
            UnderstockList = new List<KeyValuePair<string, int>>();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    SqlDataReader reader;
                    command.Connection = connection;
                    //Get Top 5 products
                    command.CommandText = @"select p.Nombre, SUM(detalleVenta.Cantidad) as Q
                                            from detalleVenta
	                                        join productos p on p.Codigo = detalleVenta.Codigo
	                                        join venta v on v.id = detalleVenta.idVenta
                                            where v.Fecha between @fromDate and @toDate
	                                        group by p.Nombre
	                                        order by Q desc ";
                    command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = startDate;
                    command.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = endDate;
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        TopProductsList.Add(
                            new KeyValuePair<string, int>(reader[0].ToString(), (int)reader[1]));
                    }
                    reader.Close();

                    //Get Understock
                    command.CommandText = @"select Nombre, Stock
                                            from productos
                                            where Stock <= 6 and idTipo = 1 and Estado = 1";
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        UnderstockList.Add(
                            new KeyValuePair<string, int>(reader[0].ToString(), (int)reader[1]));
                    }
                    reader.Close();
                }
            }
        }
        private void GetOrderAnalisys()
        {
            GrossRevenueList = new List<RevenueByDate>();
            TotalRevenue = 0;

            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"select Fecha, SUM(MontoTotal)
                                            from venta 
                                            where Vendido = @Uno and Fecha between @fromDate and @toDate and Estado = 1
                                            group by Fecha";
                    command.Parameters.Add("@fromDate", System.Data.SqlDbType.DateTime).Value = startDate;
                    command.Parameters.Add("@toDate", System.Data.SqlDbType.DateTime).Value = endDate;
                    command.Parameters.Add("@Uno", System.Data.SqlDbType.Int).Value = 1;
                    var reader = command.ExecuteReader();
                    var resultTable = new List<KeyValuePair<DateTime, decimal>>();
                    while (reader.Read())
                    {
                        resultTable.Add(
                            new KeyValuePair<DateTime, decimal>((DateTime)reader[0], (decimal)reader[1])
                            );
                        TotalRevenue += (decimal)reader[1];
                    }
                    reader.Close();

                    //Group by Days
                    if (numberDays <= 30)
                    {
                        GrossRevenueList = (from orderList in resultTable
                                            group orderList by orderList.Key.ToString("dd MMM")
                                           into order
                                            select new RevenueByDate
                                            {
                                                Date = order.Key,
                                                TotalAmount = order.Sum(amount => amount.Value)
                                            }).ToList();
                    }

                    //Group by Weeks
                    else if (numberDays <= 92)
                    {
                        GrossRevenueList = (from orderList in resultTable
                                            group orderList by CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                                                orderList.Key, CalendarWeekRule.FirstDay, DayOfWeek.Monday)
                                           into order
                                            select new RevenueByDate
                                            {
                                                Date = "Week " + order.Key.ToString(),
                                                TotalAmount = order.Sum(amount => amount.Value)
                                            }).ToList();
                    }

                    //Group by Months
                    else if (numberDays <= (365 * 2))
                    {
                        bool isYear = numberDays <= 365 ? true : false;
                        GrossRevenueList = (from orderList in resultTable
                                            group orderList by orderList.Key.ToString("MMM yyyy")
                                           into order
                                            select new RevenueByDate
                                            {
                                                Date = isYear ? order.Key.Substring(0, order.Key.IndexOf(" ")) : order.Key,
                                                TotalAmount = order.Sum(amount => amount.Value)
                                            }).ToList();
                    }

                    //Group by Years
                    else
                    {
                        GrossRevenueList = (from orderList in resultTable
                                            group orderList by orderList.Key.ToString("yyyy")
                                           into order
                                            select new RevenueByDate
                                            {
                                                Date = order.Key,
                                                TotalAmount = order.Sum(amount => amount.Value)
                                            }).ToList();
                    }
                }
            }
        }

        //Public methods
        public bool LoadData(DateTime startDate, DateTime endDate)
        {
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day);
            if (startDate != this.startDate || endDate != this.endDate)
            {
                this.startDate = startDate;
                this.endDate = endDate;
                this.numberDays = (endDate - startDate).Days;

                GetNumberItems();
                GetProductAnalisys();
                GetOrderAnalisys();
                Console.WriteLine("Refreshed data: {0} - {1}", startDate.ToString(), endDate.ToString());
                return true;
            }
            else
            {
                Console.WriteLine("Data not refreshed, same query: {0} - {1}", startDate.ToString(), endDate.ToString());
                return false;
            }
        }
    }
}
