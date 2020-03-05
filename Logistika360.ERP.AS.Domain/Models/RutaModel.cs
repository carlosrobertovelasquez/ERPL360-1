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
    public class RutaModel : IDisposable
    {

        private string Ruta;
        private string Conjunto;
        private string Nombre;
        private string UpdatedBy;
        private DateTime RecordDate;
        private string CreatedBy;
        private DateTime CreateDate;

        private IRutaRepository rutaRepository;
        public EntityState State { private get; set; }

        public string Ruta1 { get => Ruta; set => Ruta = value; }
        public string Conjunto1 { get => Conjunto; set => Conjunto = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string UpdatedBy1 { get => UpdatedBy; set => UpdatedBy = value; }
        public DateTime RecordDate1 { get => RecordDate; set => RecordDate = value; }
        public string CreatedBy1 { get => CreatedBy; set => CreatedBy = value; }
        public DateTime CreateDate1 { get => CreateDate; set => CreateDate = value; }


        public RutaModel()
        {
            rutaRepository = new RutaRepository();
        }

        public string SaveChanges()
        {
            string message = null;
            try
            {
                var rutaModel = new Ruta();
                rutaModel.RUTA = Ruta1;
                rutaModel.CONJUNTO = Conjunto1;
                rutaModel.NOMBRE = Nombre1;
                rutaModel.UpdatedBy = UpdatedBy1;
                rutaModel.RecordDate = RecordDate1;
                rutaModel.CreateDate = CreateDate1;
                rutaModel.CreatedBy = CreatedBy1;

                switch (State)
                {
                    case EntityState.Added:
                        // Ejecutar reglas comerciales /Calculos
                        rutaRepository.Add(rutaModel);
                        message = "Ruta Agregada";
                        break;
                    case EntityState.Deleted:
                        rutaRepository.Remove2(Ruta1, Conjunto1);
                        message = "Ruta Eliminado";
                        break;
                    case EntityState.Modified:
                        rutaRepository.Edit(rutaModel);
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


        public List<RutaModel> GetAll()
        {
            var rutaDataModel = rutaRepository.GetAll();
            var listRuta = new List<RutaModel>();
            foreach (Ruta item in rutaDataModel)
            {
                listRuta.Add(new RutaModel
                {
                    Ruta1 = item.RUTA,
                    Conjunto1 = item.CONJUNTO,
                    Nombre1 = item.NOMBRE,
                    RecordDate1 = item.RecordDate,
                    CreateDate1 = item.CreateDate,
                    CreatedBy = item.CreatedBy,
                    UpdatedBy1 = item.UpdatedBy,
                });
            }
            return listRuta;
        }


        public IEnumerable<RutaModel> RutaConjunto(string filter1)
        {
            return GetAll().FindAll(e => e.Conjunto.Equals(filter1));
        }
        public IEnumerable<RutaModel> BuscarRuta(string filter1, string filter2)
        {
            return GetAll().FindAll(e => e.Ruta.Equals(filter1) && e.Conjunto.Equals(filter2));
        }

        public void borrar(string Ruta, string Conjunto)
        {
            rutaRepository.Remove2(Ruta, Conjunto);
        }



        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
