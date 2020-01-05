using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistika360.ERP.ERPADMIN.DataAccess.Entities
{
    public class Usuario
    {
        public string USUARIO { get; set; }
        public string NOMBRE { get; set; }
        public string TIPO { get; set; }
        public string ACTIVO { get; set; }
        public string REQ_CAMBIO_CLAVE { get; set; }
        public string FRECUENCIA_CLAVE { get; set; }
        public DateTime FECHA_ULT_CLAVE { get; set; }
        public string MAX_INTENTOS_CONEX { get; set; }
        public string CLAVE { get; set; }
        public string CORREO_ELECTRONICO { get; set; }
        public string TIPO_ACCESO { get; set; }
        public string CELULAR { get; set; }
        public string TIPO_PERSONALIZADO { get; set; }
    }
}
