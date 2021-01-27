using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logistika360.ERP.AS.DataAccess.Contracts;
using Logistika360.ERP.AS.DataAccess.Entities;
using Logistika360.ERP.AS.DataAccess.Repositories;
using Logistika360.ERP.AS.Domain.ValueObjects;
using Logistika360.ERP.ERPADMIN.Common.Cache;
using Logistika360.ERP.ERPADMIN.DataAccess.Repositories;
using System.ComponentModel.DataAnnotations;


namespace Logistika360.ERP.AS.Domain.Models
{
   public class BodegaModel:IDisposable
    {
        private string Bodega;
        private string Nombre;
        private string Tipo;
        private string Telefono;
        private string Direccion;
        private string Consec_traslados;
        private string UpdatedBy;
        private DateTime RecordDate;
        private string CreatedBy;
        private DateTime CreateDate;

        private IBodegaRepository bodegaRepository;
        public EntityState State { private get; set; }
        [Required(ErrorMessage = "Bodega no puede quedar Vacia")]
        [StringLength(4, ErrorMessage = "Bodega es de Longitud de 4 Carateres Maximo")]
        public string Bodega1 { get => Bodega; set => Bodega = value; }
        [Required(ErrorMessage = "Nombre de Bodega no puede quedar Vacia")]
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Tipo1 { get => Tipo; set => Tipo = value; }
        public string Telefono1 { get => Telefono; set => Telefono = value; }
        [StringLength(120, ErrorMessage = "Direccion con 120 Carateres Maximo")]
        public string Direccion1 { get => Direccion; set => Direccion = value; }
        public string Consec_traslados1 { get => Consec_traslados; set => Consec_traslados = value; }
        public string UpdatedBy1 { get => UpdatedBy; set => UpdatedBy = value; }
        public DateTime RecordDate1 { get => RecordDate; set => RecordDate = value; }
        public string CreatedBy1 { get => CreatedBy; set => CreatedBy = value; }
        public DateTime CreateDate1 { get => CreateDate; set => CreateDate = value; }

        public BodegaModel()
        {
            bodegaRepository = new BodegaRepository();
        }

        public string SaveChanges()
        {
            string message = null;
            try
            {
                var bodegaModel = new Bodega();
                bodegaModel.BODEGA = Bodega1;
                bodegaModel.NOMBRE = Nombre1;
                bodegaModel.TIPO = Tipo1;
                bodegaModel.TELEFONO = Telefono1;
                bodegaModel.DIRECCION = Direccion1;
                bodegaModel.CONSEC_TRASLADOS = Consec_traslados1;
                bodegaModel.UpdatedBy = UpdatedBy1;
                bodegaModel.RecordDate = RecordDate1;
                bodegaModel.CreateDate = CreateDate1;
                bodegaModel.CreatedBy = CreatedBy1;

                switch (State)
                {
                    case EntityState.Added:
                        // Ejecutar reglas comerciales /Calculos
                        bodegaRepository.Add(bodegaModel);
                        message = "Bodega Agregada";
                        break;
                    case EntityState.Deleted:
                        bodegaRepository.Remove(Bodega1);
                        message = "Bodega Eliminada";
                        break;
                    case EntityState.Modified:
                        bodegaRepository.Edit(bodegaModel);
                        message = "Bodega Editada";
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


        public List<BodegaModel> GetAll()
        {
            var bodegaDataModel = bodegaRepository.GetAll();
            var listBodega = new List<BodegaModel>();
            foreach (Bodega item in bodegaDataModel)
            {
                listBodega.Add(new BodegaModel
                {
                    Bodega1 = item.BODEGA,
                    Nombre1 = item.NOMBRE,
                    Tipo1 = item.TIPO,
                    Telefono1 = item.TELEFONO,
                    Direccion1 = item.DIRECCION,
                    Consec_traslados1 = item.CONSEC_TRASLADOS,
                    RecordDate1 = item.RecordDate,
                    CreateDate1 = item.CreateDate,
                    CreatedBy = item.CreatedBy,
                    UpdatedBy1 = item.UpdatedBy,
                });
            }
            return listBodega;
        }


        public IEnumerable<BodegaModel> BodegaConjunto()
        {
            return GetAll();
        }
        public IEnumerable<BodegaModel> BuscarBodega(string filter1)
        {
            return GetAll().FindAll(e => e.Bodega.Equals(filter1));
        }

        public void borrar(string Bodega)
        {
            bodegaRepository.Remove(Bodega);
        }



        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
