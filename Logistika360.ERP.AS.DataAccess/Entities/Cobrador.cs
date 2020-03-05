using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistika360.ERP.AS.DataAccess.Entities
{
   public class Cobrador
    {
        public string COBRADOR { get; set; }
        public string CONJUNTO { get; set; }
        public string NOMBRE { get; set; }
        public string EMPLEADO { get; set; }
        public decimal COMISION { get; set; }
        public string CTR_COMISION { get; set; }
        public string CTA_COMISION { get; set; }
        public string CORREO { get; set; }
        public string ACTIVO { get; set; }
        public string TELEFONO { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime RecordDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
