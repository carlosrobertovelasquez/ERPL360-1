using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistika360.ERP.AS.DataAccess.Entities
{
   public class Zona
    {
        public string ZONA { get; set; }
        public string CONJUNTO { get; set; }
        public string NOMBRE { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime RecordDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
