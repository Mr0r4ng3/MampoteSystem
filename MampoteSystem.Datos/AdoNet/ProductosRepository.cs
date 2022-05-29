using MampoteSystem.Datos.Interfaces;
using MampoteSystem.Entidad;
using MampoteSystem.Entidad.Report;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MampoteSystem.Datos.AdoNet
{
    public class ProductosRepository : Repository<productos>, IProductosRepository
    {
        public ProductosRepository(MampoteSystemContext mampoteSystemContext) : base(mampoteSystemContext)
        {
        }

        public int Crud(productos entity, string option)
        {
            try
            {
                return (int)ObjContext.ExecuteNonQuery("dbo.SpProductosMantenimiento", System.Data.CommandType.StoredProcedure,
                    new SqlParameter[]
                    {
                        new SqlParameter("@Codigo",entity.Codigo),
                        new SqlParameter("@idCategoria",entity.idCategoria),
                        new SqlParameter("@idTipo",entity.idTipo),
                        new SqlParameter("@Nombre",entity.Nombre),
                        new SqlParameter("@Descripcion",entity.Descripcion),
                        new SqlParameter("@Stock",entity.Stock),
                        new SqlParameter("@Precio_Compra",entity.Precio_Compra),
                        new SqlParameter("@Precio_Venta",entity.Precio_Venta),
                        new SqlParameter("@IVA",entity.IVA),
                        new SqlParameter("@Option",option)
                    });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<productosReport> GetListProds()
        {
            return ObjContext.ToList<productosReport>(
                    ObjContext.GetData("dbo.SpProductosList").Tables[0]
                );
        }

        public IEnumerable<comidaReport> GetListComida()
        {
            return ObjContext.ToList<comidaReport>(
                    ObjContext.GetData("dbo.SpComidaList").Tables[0]
                );
        }

        public IEnumerable<prodComi> GetListTwo()
        {
            return ObjContext.ToList<prodComi>(
                    ObjContext.GetData("dbo.SpProdComiList").Tables[0]
                );
        }

        public int setStock(string codigo, int cantidad)
        {
            try
            {

                string querySql = $"update productos set Stock = {cantidad} where Codigo = '{codigo}'";
                return ObjContext.ExecuteNonQuery(querySql, System.Data.CommandType.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
