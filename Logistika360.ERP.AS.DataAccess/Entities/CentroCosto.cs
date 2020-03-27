using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistika360.ERP.AS.DataAccess.Entities
{
    public class CentroCosto
    {
        public string CENTROCOSTO { get; set; }
        public string CONJUNTO { get; set; }
        public string DESCRIPCION { get; set; }
        public string ACEPTADATOS { get; set; }
        public string TIPO { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime RecordDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
