using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistika360.ERP.AS.DataAccess.Entities
{
    public class Bodega
    {
        public string BODEGA { get; set; }
        public string NOMBRE { get; set; }
        public string TIPO { get; set; }
        public string TELEFONO { get; set; }
        public string DIRECCION { get; set; }
        public string CONSEC_TRASLADOS { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime RecordDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreateDate { get; set; }
    }

}
