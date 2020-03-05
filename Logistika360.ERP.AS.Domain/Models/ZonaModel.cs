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
    public class ZonaModel : IDisposable
    {
        private string Zona;
        private string Conjunto;
        private string Nombre;
        private string UpdatedBy;
        private DateTime RecordDate;
        private string CreatedBy;
        private DateTime CreateDate;

        private IZonaRepository zonaRepository;
        public EntityState State { private get; set; }
        public string Zona1 { get => Zona; set => Zona = value; }
        public string Conjunto1 { get => Conjunto; set => Conjunto = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string UpdatedBy1 { get => UpdatedBy; set => UpdatedBy = value; }
        public DateTime RecordDate1 { get => RecordDate; set => RecordDate = value; }
        public string CreatedBy1 { get => CreatedBy; set => CreatedBy = value; }
        public DateTime CreateDate1 { get => CreateDate; set => CreateDate = value; }



        public ZonaModel()
        {
            zonaRepository = new ZonaRepository();
        }

        public string SaveChanges()
        {
            string message = null;
            try
            {
                var zonaModel = new Zona();
                zonaModel.ZONA = Zona1;
                zonaModel.CONJUNTO = Conjunto1;
                zonaModel.NOMBRE = Nombre1;
                zonaModel.UpdatedBy = UpdatedBy1;
                zonaModel.RecordDate = RecordDate1;
                zonaModel.CreateDate = CreateDate1;
                zonaModel.CreatedBy = CreatedBy1;

                switch (State)
                {
                    case EntityState.Added:
                        // Ejecutar reglas comerciales /Calculos
                        zonaRepository.Add(zonaModel);
                        message = "Zona Agregado";
                        break;
                    case EntityState.Deleted:
                        zonaRepository.Remove2(Zona1, Conjunto1);
                        message = "Zona Eliminado";
                        break;
                    case EntityState.Modified:
                        zonaRepository.Edit(zonaModel);
                        message = "Zona Editado";
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



        public List<ZonaModel> GetAll()
        {
            var zonaDataModel = zonaRepository.GetAll();
            var listZona = new List<ZonaModel>();
            foreach (Zona item in zonaDataModel)
            {
                listZona.Add(new ZonaModel
                {
                    Zona1 = item.ZONA,
                    Conjunto1 = item.CONJUNTO,
                    Nombre1 = item.NOMBRE,
                    RecordDate1 = item.RecordDate,
                    CreateDate1 = item.CreateDate,
                    CreatedBy = item.CreatedBy,
                    UpdatedBy1 = item.UpdatedBy,
                });
            }
            return listZona;
        }


        public IEnumerable<ZonaModel> ZonaConjunto(string filter1)
        {
            return GetAll().FindAll(e => e.Conjunto.Equals(filter1));
        }
        public IEnumerable<ZonaModel> BuscarZona(string filter1, string filter2)
        {
            return GetAll().FindAll(e => e.Zona.Equals(filter1) && e.Conjunto.Equals(filter2));
        }

        public void borrar(string Zona, string Conjunto)
        {
            zonaRepository.Remove2(Zona, Conjunto);
        }



        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
