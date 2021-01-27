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
    public class MonedaModel : IDisposable
    {
        private string Moneda;
        private string Nombre;
        private string Codigo_iso;
        private string UpdatedBy;
        private DateTime RecordDate;
        private string CreatedBy;
        private DateTime CreateDate;

        private IMonedaRepository monedaRepository;
        public EntityState State { private get; set; }
        [Required(ErrorMessage = "Moneda no puede quedar Vacia")]
        [StringLength(4, ErrorMessage = "Moneda es de Longitud de 4 Carateres Maximo")]
        public string Moneda1 { get => Moneda; set => Moneda = value; }
        [Required(ErrorMessage = "Nombre no puede quedar Vacia")]
        [StringLength(40, ErrorMessage = "Nombre es de Longitud de 4 Carateres Maximo")]
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        [StringLength(4, ErrorMessage = "Codigo_iso es de Longitud de 4 Carateres Maximo")]
        public string Codigo_iso1 { get => Codigo_iso; set => Codigo_iso = value; }
        public string UpdatedBy1 { get => UpdatedBy; set => UpdatedBy = value; }
        public DateTime RecordDate1 { get => RecordDate; set => RecordDate = value; }
        public string CreatedBy1 { get => CreatedBy; set => CreatedBy = value; }
        public DateTime CreateDate1 { get => CreateDate; set => CreateDate = value; }


        public MonedaModel()
        {
            monedaRepository = new MonedaRepository();
        }

        public string SaveChanges()
        {
            string message = null;
            try
            {
                var monedaModel = new Moneda();
                monedaModel.MONEDA = Moneda1;
                monedaModel.NOMBRE = Nombre1;
                monedaModel.CODIGO_ISO = Codigo_iso1;
                monedaModel.UpdatedBy = UpdatedBy1;
                monedaModel.RecordDate = RecordDate1;
                monedaModel.CreateDate = CreateDate1;
                monedaModel.CreatedBy = CreatedBy1;

                switch (State)
                {
                    case EntityState.Added:
                        // Ejecutar reglas comerciales /Calculos
                        monedaRepository.Add(monedaModel);
                        message = "Ruta Agregada";
                        break;
                    case EntityState.Deleted:
                        monedaRepository.Remove(Moneda1);
                        message = "Ruta Eliminado";
                        break;
                    case EntityState.Modified:
                        monedaRepository.Edit(monedaModel);
                        message = "Ruta Editado";
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
        public List<MonedaModel> GetAll()
        {
            var monedaDataModel = monedaRepository.GetAll();
            var listMoneda = new List<MonedaModel>();
            foreach (Moneda item in monedaDataModel)
            {
                listMoneda.Add(new MonedaModel
                {
                     Moneda1= item.MONEDA,
                    Nombre1 = item.NOMBRE,
                    Codigo_iso1=item.CODIGO_ISO,
                    RecordDate1 = item.RecordDate,
                    CreateDate1 = item.CreateDate,
                    CreatedBy = item.CreatedBy,
                    UpdatedBy1 = item.UpdatedBy,
                });
            }
            return listMoneda;
        }

        public IEnumerable<MonedaModel> MonedaConjunto()
        {
            return GetAll();
        }
        public IEnumerable<MonedaModel> BuscarMoneda(string filter1)
        {
            return GetAll().FindAll(e => e.Moneda1.Equals(filter1));
        }

        public void borrar(string Moneda)
        {
            monedaRepository.Remove(Moneda);
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
