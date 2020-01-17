using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logistika360.ERP.ERPADMIN.DataAccess.Contracts;
using Logistika360.ERP.ERPADMIN.DataAccess.Entities;
using Logistika360.ERP.ERPADMIN.DataAccess.Repositories;
using Logistika360.ERP.ERPADMIN.Domain.ValueObjects;
using System.ComponentModel.DataAnnotations;
using Logistika360.ERP.ERPADMIN.Common.Cache;

namespace Logistika360.ERP.ERPADMIN.Domain.Models
{
   public  class UsuarioModel:IDisposable
    {
        private string USUARIO;
        private string NOMBRE;
        private string TIPO;
        private string ACTIVO;
        private string REQ_CAMBIO_CLAVE;
        private decimal FRECUENCIA_CLAVE;
        private DateTime FECHA_ULT_CLAVE;
        private decimal MAX_INTENTOS_CONEX;
        private string CLAVE;
        private string CORREO_ELECTRONICO;
        private string TIPO_ACCESO;
        private string CELULAR;
        private string TIPO_PERSONALIZADO;

        private IUsuarioRepository usuarioRepository;
        public EntityState State { private get; set; }

        [Required (ErrorMessage ="Campo de Usuario es Requerido")]
        public string USUARIO1 { get => USUARIO; set => USUARIO = value; }
        [Required(ErrorMessage ="Campo de Nombre No puede quedar Vacio")]
        public string NOMBRE1 { get => NOMBRE; set => NOMBRE = value; }
        public string TIPO1 { get => TIPO; set => TIPO = value; }
        public string ACTIVO1 { get => ACTIVO; set => ACTIVO = value; }
      //  [Required(ErrorMessage = "Campo  No puede quedar Vacio Cambio Clave")]
      //  [RegularExpression("([0-9]+)",ErrorMessage ="Solo se pueden Digitar Numeros")]
        public string REQ_CAMBIO_CLAVE1 { get => REQ_CAMBIO_CLAVE; set => REQ_CAMBIO_CLAVE = value; }
        public decimal FRECUENCIA_CLAVE1 { get => FRECUENCIA_CLAVE; set => FRECUENCIA_CLAVE = value; }
        public DateTime FECHA_ULT_CLAVE1 { get => FECHA_ULT_CLAVE; set => FECHA_ULT_CLAVE = value; }
      //  [Required(ErrorMessage = "Campo  No puede quedar Vacio Intento Conexiones")]
        public decimal MAX_INTENTOS_CONEX1 { get => MAX_INTENTOS_CONEX; set => MAX_INTENTOS_CONEX = value; }
        public string CLAVE1 { get => CLAVE; set => CLAVE = value; }
        [Required(ErrorMessage = "Campo  No puede quedar Vacio correo")]
        [EmailAddress]
        public string CORREO_ELECTRONICO1 { get => CORREO_ELECTRONICO; set => CORREO_ELECTRONICO = value; }
        public string TIPO_ACCESO1 { get => TIPO_ACCESO; set => TIPO_ACCESO = value; }
        public string CELULAR1 { get => CELULAR; set => CELULAR = value; }
        public string TIPO_PERSONALIZADO1 { get => TIPO_PERSONALIZADO; set => TIPO_PERSONALIZADO = value; }

        public UsuarioModel()
        {
            usuarioRepository = new UsuarioRepository();
            
        }

        public string SaveChanges()
        {
            string message=null;
            try
            {
                var usuarioDataModel = new Usuario();
                usuarioDataModel.USUARIO = USUARIO1;
                usuarioDataModel.NOMBRE = NOMBRE1;
                usuarioDataModel.TIPO = TIPO1;
                usuarioDataModel.ACTIVO = ACTIVO1;
                usuarioDataModel.REQ_CAMBIO_CLAVE =  REQ_CAMBIO_CLAVE1;
                usuarioDataModel.FRECUENCIA_CLAVE = FRECUENCIA_CLAVE1;
                usuarioDataModel.FECHA_ULT_CLAVE = FECHA_ULT_CLAVE1;
                usuarioDataModel.MAX_INTENTOS_CONEX = MAX_INTENTOS_CONEX1;
                usuarioDataModel.CLAVE = CLAVE1;
                usuarioDataModel.CORREO_ELECTRONICO = CORREO_ELECTRONICO1;
                usuarioDataModel.TIPO_ACCESO = TIPO_ACCESO1;
                usuarioDataModel.CELULAR = CELULAR1;
                usuarioDataModel.TIPO_PERSONALIZADO = TIPO_PERSONALIZADO1;

                switch (State)
                {
                    case EntityState.Added:
                        // Ejecutar reglas comerciales /Calculos
                        usuarioRepository.Add(usuarioDataModel);
                        message = "Usuario Agregado";
                        break;
                    case EntityState.Deleted:
                        usuarioRepository.Remove(USUARIO1);
                        message = "Usuario Eliminado";
                        break;
                    case EntityState.Modified:
                        usuarioRepository.Edit(usuarioDataModel);
                        message = "Usuario Editado";
                        break;
                   
                    default:
                        break;
                }

            }
            catch (Exception ex)
            {

                System.Data.SqlClient.SqlException sqlEx = ex as System.Data.SqlClient.SqlException;
                if ( sqlEx !=null && sqlEx.Number==2627)
                {
                    message = "Registro Ya Existe";
                }
                else
                {
                    message = ex.ToString();
                }
            }
            return message;
        }


        public List<UsuarioModel> GetAll()
        {
            var usuarioDataModel = usuarioRepository.GetAll();
            var listUsuario = new List<UsuarioModel>();
            foreach (Usuario item in usuarioDataModel)
            {
                listUsuario.Add(new UsuarioModel
                {
                    USUARIO1=item.USUARIO,
                    NOMBRE1=item.NOMBRE,
                    TIPO1=item.TIPO,
                    ACTIVO1=item.ACTIVO,
                    REQ_CAMBIO_CLAVE1=item.REQ_CAMBIO_CLAVE,
                    FRECUENCIA_CLAVE1=item.FRECUENCIA_CLAVE,
                    FECHA_ULT_CLAVE1=item.FECHA_ULT_CLAVE,
                    MAX_INTENTOS_CONEX1=item.MAX_INTENTOS_CONEX,
                    CLAVE1=item.CLAVE,
                    CORREO_ELECTRONICO1=item.CORREO_ELECTRONICO,
                    TIPO_ACCESO1=item.TIPO_ACCESO,
                    CELULAR1=item.CELULAR,
                    TIPO_PERSONALIZADO1=item.TIPO_PERSONALIZADO
                });
            }
            return listUsuario;
        }

        public IEnumerable<UsuarioModel> FindByUsuario(string filter)
        {
            return GetAll().FindAll(e => e.USUARIO.Contains(filter) || e.NOMBRE.Contains(filter));
        }

   
        public List<UsuarioModel> login(string usuario, string contrasena, string activo)
        {

            var usuarioDataModel = usuarioRepository.Login(usuario, contrasena, activo); 
            var listUsuario = new List<UsuarioModel>();
            foreach (Usuario item in usuarioDataModel)
            {
                listUsuario.Add(new UsuarioModel
                {
                    USUARIO1 = item.USUARIO,
                    NOMBRE1 = item.NOMBRE,
                    TIPO1 = item.TIPO,
                    ACTIVO1 = item.ACTIVO,
                    REQ_CAMBIO_CLAVE1 = item.REQ_CAMBIO_CLAVE,
                    FRECUENCIA_CLAVE1 = item.FRECUENCIA_CLAVE,
                    FECHA_ULT_CLAVE1 = item.FECHA_ULT_CLAVE,
                    MAX_INTENTOS_CONEX1 = item.MAX_INTENTOS_CONEX,
                    CLAVE1 = item.CLAVE,
                    CORREO_ELECTRONICO1 = item.CORREO_ELECTRONICO,
                    TIPO_ACCESO1 = item.TIPO_ACCESO,
                    CELULAR1 = item.CELULAR,
                    TIPO_PERSONALIZADO1 = item.TIPO_PERSONALIZADO
                });
            }
            return listUsuario;

        } 


        public void Dispose()
        {
          
        }
    }
}
