using Logistika360.ERP.ERPADMIN.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistika360.ERP.ERPADMIN.DataAccess.Contracts
{
     public interface IUsuarioRepository:IGenericRepository<Usuario>
    {
        //Otros metodos
         List<Usuario> Login(string USUARIO, string CONTRASENA, string ACTIVO);
    }
}
