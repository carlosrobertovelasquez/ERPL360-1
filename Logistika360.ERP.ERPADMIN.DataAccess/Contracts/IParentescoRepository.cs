using Logistika360.ERP.ERPADMIN.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Logistika360.ERP.ERPADMIN.DataAccess.Contracts
{
  public  interface IParentescoRepository:IGenericRepository<Parentesco>
    {
        List<Parentesco> ICargaNodos(string PADRE);
        DataTable arbol();
        DataTable arbolMenuPrivilegios();
        
    }
}
