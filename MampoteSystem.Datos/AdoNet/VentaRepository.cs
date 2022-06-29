using MampoteSystem.Datos.AdoNet.Helper;
using MampoteSystem.Datos.Interfaces;
using MampoteSystem.Entidad;
using MampoteSystem.Entidad.Report;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MampoteSystem.Datos.AdoNet
{
    public class VentaRepository : Repository<venta>, IVentaRepository
    {
        IGetNewID _helper;
        public VentaRepository(MampoteSystemContext mampoteSystemContext) : base(mampoteSystemContext)
        {
            _helper = new GetNewID(mampoteSystemContext);
        }

        public int Crud(venta venta, detalleVenta detalle, bool isComision, string tasa)
        {
            try
            {
                string querySql = "dbo.SpVentaInsert";
                return ObjContext.ExecuteNonQuery(querySql, System.Data.CommandType.StoredProcedure,
                    new SqlParameter[]{

                        new SqlParameter("@idVenta",venta.id),
                        new SqlParameter("@NumeroFactura",venta.NumeroFactura),
                        new SqlParameter("@idCliente",venta.idCliente),
                        new SqlParameter("@Comision",venta.Comision),
                        new SqlParameter("@EstadoComision",venta.EstadoComision),
                        new SqlParameter("@Tasa",Convert.ToDecimal(tasa, new CultureInfo("en-US"))),
                        new SqlParameter("@MontoTotal",venta.MontoTotal),
                        new SqlParameter("@Deuda",venta.Deuda),
                        new SqlParameter("@Nota",venta.Nota),
                        new SqlParameter("@IsComision",isComision),

                      //Sección para Detale

                        new SqlParameter("@Tipo",detalle.Tipo),
                        new SqlParameter("@codigo",detalle.Codigo),
                        new SqlParameter("@Cantidad",detalle.Cantidad),
                        new SqlParameter("@Precio_Venta",detalle.Precio_Venta),
                        new SqlParameter("@IVA",detalle.IVA),
                        new SqlParameter("@SubTotal",detalle.SubTotal)
                    });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int pagarComision(string idVenta, bool cancel)
        {
            try
            {

                string querySql = $"update venta set EstadoComision = 'Pagada' where id = '{idVenta}'";
                
                if (cancel)
                {
                    querySql = $"update venta set EstadoComision = 'Sin Pagar' where id = '{idVenta}'";
                }


                return ObjContext.ExecuteNonQuery(querySql, System.Data.CommandType.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int actualizarNota(string idVenta, string Nota)
        {
            try
            {

                string querySql = $"update venta set Nota = '{Nota}' where id = '{idVenta}'";

                return ObjContext.ExecuteNonQuery(querySql, System.Data.CommandType.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<ventaReport> GetList(DateTime desde, DateTime hasta, bool Vendido)
        {
            return ObjContext.ToList<ventaReport>(
                    ObjContext.GetData("dbo.SpVentaList", new SqlParameter[]{
                                    new SqlParameter("@Desde",desde),
                                    new SqlParameter("@Hasta",hasta),
                                    new SqlParameter("@Vendido",Vendido)
                         }).Tables[0]
                        );
        }

        public string GetNewFactura()
        {
            string command = "dbo.GetNumeroFactura";
            var salida = ObjContext.ExecuteScalar(command,
                System.Data.CommandType.StoredProcedure);

            return (string)salida;
        }

        public string GetNewID()
        {
            return _helper.GetID("Venta");
        }

        public int DeleteVenta(string idVenta)
        {
            try
            {
                return ObjContext.ExecuteNonQuery($"delete from detalleVenta where idVenta = '{idVenta}' delete venta where id = '{idVenta}'", System.Data.CommandType.Text);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public int DeleteDetalle(string idDetalle)
        {
            try
            {
                return ObjContext.ExecuteNonQuery($"delete detalleVenta where id = '{idDetalle}'", System.Data.CommandType.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ventaReport GetVentaById(string idVenta)
        {
            ventaReport obj = null;

            var Lista = ObjContext.ToList<ventaReport>(ObjContext.GetData("dbo.SpBuscarVenta",
                new SqlParameter[]{
                        new SqlParameter("@idVenta",idVenta)}
                ).Tables[0]);

            if (Lista.Count != 0)
            {
                obj = Lista[0];
            }

            return obj;
        }
    }
}
