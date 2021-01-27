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
    public class CentroCostoModel : IDisposable
    {

        private string CentroCosto;
        private string Descripcion;
        private string AceptaDatos;
        private string Tipo;
        private string UpdatedBy;
        private DateTime RecordDate;
        private string CreatedBy;
        private DateTime CreateDate;

        private ICentroCostoRepository centrocostoRepository;
        public EntityState State { private get; set; }
        [Required(ErrorMessage = "Centro Costo no puede quedar Vacia")]
        
        public string CentroCosto1 { get => CentroCosto; set => CentroCosto = value; }
      
        public string Descripcion1 { get => Descripcion; set => Descripcion = value; }
        public string AceptaDatos1 { get => AceptaDatos; set => AceptaDatos = value; }
        public string Tipo1 { get => Tipo; set => Tipo = value; }
        public string UpdatedBy1 { get => UpdatedBy; set => UpdatedBy = value; }
        public DateTime RecordDate1 { get => RecordDate; set => RecordDate = value; }
        public string CreatedBy1 { get => CreatedBy; set => CreatedBy = value; }
        public DateTime CreateDate1 { get => CreateDate; set => CreateDate = value; }



        public CentroCostoModel()
        {
            centrocostoRepository = new CentroCostoRepository();
        }


        public string SaveChanges()
        {
            string message= null;
            try
            {
                var CentroCostoModel = new CentroCosto();
                CentroCostoModel.CENTROCOSTO = CentroCosto1;
                CentroCostoModel.DESCRIPCION = Descripcion1;
                CentroCostoModel.ACEPTADATOS = AceptaDatos1;
                CentroCostoModel.TIPO = Tipo1;
                CentroCostoModel.UpdatedBy = UpdatedBy1;
                CentroCostoModel.RecordDate = RecordDate1;
                CentroCostoModel.CreateDate = CreateDate1;
                CentroCostoModel.CreatedBy = CreatedBy1;

                switch (State)
                {
                    case EntityState.Added:
                        // aqui validadremos el formato de cnetro de costo
                        centrocostoRepository.Add(CentroCostoModel);
                        message = "Centro de Costo Agregado";
                        break;
                    case EntityState.Deleted:
                        centrocostoRepository.Remove(CentroCosto1);
                        message = "Centro de Costo se Elimino Con existo";
                        break;
                    case EntityState.Modified:
                        centrocostoRepository.Edit(CentroCostoModel);
                        message = "Centro de Costo Modificado";
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
                    message = "Centro Costo Ya Existe";
                }
                else
                {
                    message = ex.ToString();
                }
            }

            return message;
        }

        public List<CentroCostoModel> GetAll()
        {
            var centrocostoDataModel = centrocostoRepository.GetAll();
            var listCentroCosto = new List<CentroCostoModel>();
            foreach (CentroCosto item in centrocostoDataModel)
            {
                listCentroCosto.Add(new CentroCostoModel
                {
                    CentroCosto1 = item.CENTROCOSTO,
                    Descripcion1 = item.DESCRIPCION,
                    AceptaDatos1=item.ACEPTADATOS,
                    Tipo1=item.TIPO,
                    RecordDate1 = item.RecordDate,
                    CreateDate1 = item.CreateDate,
                    CreatedBy = item.CreatedBy,
                    UpdatedBy1 = item.UpdatedBy,
                });
            }
            return listCentroCosto;
        }

        public IEnumerable<CentroCostoModel> CentroCostoConjunto()
        {
            return GetAll();
        }
        public IEnumerable<CentroCostoModel> BuscarCentroCosto(string filter1)
        {
            return GetAll().FindAll(e => e.CentroCosto.Equals(filter1) );
        }

        public void borrar(string CentroCosto)
        {
            
            centrocostoRepository.Remove(CentroCosto);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
