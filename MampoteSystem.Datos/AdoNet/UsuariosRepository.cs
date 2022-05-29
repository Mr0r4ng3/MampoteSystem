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
    public class UsuariosRepository : Repository<usuario>, IUsuariosRepository
    {
        public UsuariosRepository(MampoteSystemContext mampoteSystemContext) : base(mampoteSystemContext)
        {
        }

        public int Crud(usuario entity, string option)
        {
            try
            {
                return (int)ObjContext.ExecuteNonQuery("dbo.SpUsuariosMantenimiento", System.Data.CommandType.StoredProcedure,
                                    new SqlParameter[]
                                    {
                                                    new SqlParameter("@id",entity.id),
                                                    new SqlParameter("@Cedula",entity.Cedula),
                                                    new SqlParameter("@Nombres",entity.Nombres),
                                                    new SqlParameter("@Apellidos",entity.Apellidos),
                                                    new SqlParameter("@username",entity.username),
                                                    new SqlParameter("@NivelAcceso",entity.NivelAcceso),
                                                    new SqlParameter("@passwd",entity.passwd),
                                                    new SqlParameter("@Option",option)
                                    });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<usuario> GetList()
        {
            return GetList("dbo.SpUsuariosList");
        }

        public usuario Login(string username, string passwd)
        {
            var usuario = ObjContext.ToList<usuario>(ObjContext.GetData("dbo.SpLogin", new SqlParameter[]
                                    {
                                                    new SqlParameter("@username",username),
                                                    new SqlParameter("@passwd",passwd),
                                    }).Tables[0]);

            if (usuario.Count > 0) {
                return usuario[0];
            }

            return null;

        }
    }
}
