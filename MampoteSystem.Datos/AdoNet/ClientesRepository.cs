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
    public class ClientesRepository : Repository<clientes>, IClientesRepository
    {
        public ClientesRepository(MampoteSystemContext mampoteSystemContext) : base(mampoteSystemContext)
        {
        }

        public int Crud(clientes entity, string option)
        {
            try
            {
                return (int)ObjContext.ExecuteNonQuery("dbo.SpClientesMantenimiento", System.Data.CommandType.StoredProcedure,
                                    new SqlParameter[]
                                    {
                                                    new SqlParameter("@id",entity.id),
                                                    new SqlParameter("@Cedula",entity.Cedula),
                                                    new SqlParameter("@Nombres",entity.Nombres),
                                                    new SqlParameter("@Apellidos",entity.Apellidos),
                                                    new SqlParameter("@Telefono",entity.Telefono),
                                                    new SqlParameter("@Direccion",entity.Direccion),
                                                    new SqlParameter("@EditorUser",entity.EditorUser),
                                                    new SqlParameter("@Option",option)
                                    });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<clientes> GetList()
        {
            return GetList("dbo.SpClientesList");
        }

        public clientes GetCliente(string Cedula) 
        {
            clientes obj = null;

            var Lista = ObjContext.ToList<clientes>(ObjContext.GetData("dbo.SpBuscarCliente",
                new SqlParameter[]{
                        new SqlParameter("@Cedula",Cedula)}).Tables[0]);

            if (Lista.Count != 0)
            {
                obj = Lista[0];
            }

            return obj;
        }

        public clientes SelectNewCliente()
        {
            clientes obj = null;

            var Lista = ObjContext.ToList<clientes>(ObjContext.GetData("dbo.SelectNewCliente").Tables[0]);

            if (Lista.Count != 0)
            {
                obj = Lista[0];
            }

            return obj;
        }

        public int ClienteTieneOrden(int idCliente)
        {
            return ObjContext.GetData($"select * from venta where idCliente = {idCliente} and Vendido = 0").Tables[0].Rows.Count;
        }
    }
}

