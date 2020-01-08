using Logistika360.ERP.ERPADMIN.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistika360.ERP.ERPADMIN.DataAccess.Contracts
{
    public interface IModuloInstaladoRepository:IGenericRepository<Modulo_Instalado>
    {
        List<Modulo_Instalado> Imodulos(string CONJUNTO,String USUARIO);
    }
}
