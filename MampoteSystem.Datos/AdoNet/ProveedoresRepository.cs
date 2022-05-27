using MampoteSystem.Datos.Interfaces;
using MampoteSystem.Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MampoteSystem.Datos.AdoNet
{
    public class ProveedoresRepository : Repository<proveedores>, IProveedoresRepository
    {
        public ProveedoresRepository(MampoteSystemContext mampoteSystemContext) : base(mampoteSystemContext)
        {
        }

        public int Crud(proveedores entity, string option)
        {
            try
            {
                return (int)ObjContext.ExecuteNonQuery("dbo.SpProveedorMantenimiento", System.Data.CommandType.StoredProcedure,
                                    new SqlParameter[]
                                    {
                                                    new SqlParameter("@id",entity.id),
                                                    new SqlParameter("@Razon_Social",entity.Razon_Social),
                                                    new SqlParameter("@RIF",entity.RIF),
                                                    new SqlParameter("@Telefono",entity.Telefono),
                                                    new SqlParameter("@Email",entity.Email),
                                                    new SqlParameter("@EditorUser",entity.EditorUser),
                                                    new SqlParameter("@Option",option)
                                    });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<proveedores> GetList()
        {
            return GetList("dbo.SpProveedorList");
        }

        public proveedores GetProveedor(string RIF)
        {
            proveedores obj = null;
            
            var Lista = ObjContext.ToList<proveedores>(ObjContext.GetData("dbo.SpBuscarProveedor", 
                new SqlParameter[]{
                        new SqlParameter("@RIF",RIF)}).Tables[0]);

            if (Lista.Count != 0)
            {
                obj = Lista[0];
            }

            return obj;
        }
    }
}
