using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logistika360.ERP.ERPADMIN.DataAccess.Contracts;
using Logistika360.ERP.ERPADMIN.DataAccess.Entities;
using Logistika360.ERP.ERPADMIN.DataAccess.Repositories;
using Logistika360.ERP.ERPADMIN.Domain.ValueObjects;

namespace Logistika360.ERP.ERPADMIN.Domain.Models
{
    public class PrivilegioEXModel : IDisposable
    {
        private string uSUARIO;
        private string cONJUNTO;
        private int aCCION;
        private string aCTIVO;
        private string nOMBRECONSTANTE;

        private IPrivilegioExRepository privilegioExRepository;

        public string USUARIO { get => uSUARIO; set => uSUARIO = value; }
        public string CONJUNTO { get => cONJUNTO; set => cONJUNTO = value; }
        public int ACCION { get => aCCION; set => aCCION = value; }
        public string ACTIVO { get => aCTIVO; set => aCTIVO = value; }
        public string NOMBRECONSTANTE { get => nOMBRECONSTANTE; set => nOMBRECONSTANTE = value; }

        public PrivilegioEXModel()
        {
            privilegioExRepository = new PrivilegioEXRepository();
        }

        public List<PrivilegioEXModel> GetAll()
        {
            var PrivilegioEXDataModel = privilegioExRepository.GetAll();
            var listPrivilegioex= new List<PrivilegioEXModel>();

            foreach (Privilegio_Ex item in PrivilegioEXDataModel)
            {
                listPrivilegioex.Add(new PrivilegioEXModel
                {
                    uSUARIO = item.USUARIO,
                    cONJUNTO = item.CONJUNTO,
                    aCCION = item.ACCION,
                    aCTIVO = item.ACTIVO,
                    nOMBRECONSTANTE = item.NOMBRECONSTANTE,
                    
                });
            }
            return listPrivilegioex;
        }

        public IEnumerable<PrivilegioEXModel> FindByUsuario(string filter1,string filter2,string filter3)
        {
            return GetAll().FindAll(e => e.USUARIO.Equals(filter1) && e.CONJUNTO.Equals(filter2) && e.NOMBRECONSTANTE.Equals(filter3));
        }





        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
