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
    public class AccionModel : IDisposable
    {

        private string accion;
        private string nombreaccion;
        private string descripcion;
        private string nombreconstante;
        private string esmodulo;
        private string tipo;
        private string sutipo;
        private string tabla;
        private string invocacion;

        
        private IAccionRepository accionRepository;
        public EntityState State { private get; set; }


        public string Accion { get => accion; set => accion = value; }
        public string Nombreaccion { get => nombreaccion; set => nombreaccion = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Nombreconstante { get => nombreconstante; set => nombreconstante = value; }
        public string Esmodulo { get => esmodulo; set => esmodulo = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Sutipo { get => sutipo; set => sutipo = value; }
        public string Tabla { get => tabla; set => tabla = value; }
        public string Invocacion { get => invocacion; set => invocacion = value; }

        public AccionModel()
        {
            accionRepository = new AccionRepository();

        }

        public string SaveChanges()
        {
            string message = null;
            try
            {
                var accionDataModel = new Accion();
                accionDataModel.ACCION = Accion;
                accionDataModel.NOMBREACCION = Nombreaccion;
                accionDataModel.DESCRIPCION = Descripcion;
                accionDataModel.NOMBRECONSTANTE = Nombreconstante;
                accionDataModel.ESMODULO = Esmodulo;
                accionDataModel.TIPO = Tipo;
                accionDataModel.SUBTIPO = Sutipo;
                accionDataModel.TABLA = Tabla;
                accionDataModel.INVOCACION = Invocacion;

                switch (State)
                {
                    case EntityState.Added:
                        
                        break;
                    case EntityState.Deleted:
                        break;
                    case EntityState.Modified:
                        break;
                    
                    default:
                        break;
                }



            }
            catch (Exception ex)
            {

                System.Data.SqlClient.SqlException sqlEx = ex as System.Data.SqlClient.SqlException;
                if (sqlEx != null && sqlEx.Number == 2627)
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


        public List<AccionModel> GetAll()
        {
            var accionDataModel = accionRepository.GetAll();
            var listAccion = new List<AccionModel>();
            foreach (Accion item in accionDataModel)
            {
                listAccion.Add(new AccionModel
                {
                    accion=item.ACCION,
                    nombreaccion=item.NOMBREACCION,
                    descripcion=item.DESCRIPCION,
                    nombreconstante=item.NOMBRECONSTANTE,
                    esmodulo=item.ESMODULO,
                    tipo=item.TIPO,
                    sutipo=item.SUBTIPO,
                    tabla=item.TABLA,
                    invocacion=item.INVOCACION

                    
                });
            }
            return listAccion;
        }



        public IEnumerable<AccionModel> FindByAccion(string filter)
        {
            return GetAll().FindAll(e => e.Accion.Equals(filter) );
        }


        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
