using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistika360.ERP.ERPADMIN.DataAccess.Contracts
{
   public  interface IGenericRepository<Entity> where Entity:class
    {
        int Add(Entity entity);
        int Edit(Entity entity);
        int Remove(string valor);
        IEnumerable<Entity> GetAll();
    }
}
