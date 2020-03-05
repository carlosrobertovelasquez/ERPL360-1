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
    public class CobradorModel : IDisposable
    {


        private string Cobrador;
        private string Conjunto;
        private string Nombre;
        private string Empleado;
        private decimal Comision;
        private string Ctr_comision;
        private string Cta_comision;
        private string Correo;
        private string Activo;
        private string Telefono;
        private string UpdatedBy;
        private DateTime RecordDate;
        private string CreatedBy;
        private DateTime CreateDate;

        private ICobradorRepository cobradorRepository;
        public EntityState State { private get; set; }
        public string Cobrador1 { get => Cobrador; set => Cobrador = value; }
        public string Conjunto1 { get => Conjunto; set => Conjunto = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Empleado1 { get => Empleado; set => Empleado = value; }
        public decimal Comision1 { get => Comision; set => Comision = value; }
        public string Ctr_comision1 { get => Ctr_comision; set => Ctr_comision = value; }
        public string Cta_comision1 { get => Cta_comision; set => Cta_comision = value; }
        public string Correo1 { get => Correo; set => Correo = value; }
        public string Activo1 { get => Activo; set => Activo = value; }
        public string Telefono1 { get => Telefono; set => Telefono = value; }
        public string UpdatedBy1 { get => UpdatedBy; set => UpdatedBy = value; }
        public DateTime RecordDate1 { get => RecordDate; set => RecordDate = value; }
        public string CreatedBy1 { get => CreatedBy; set => CreatedBy = value; }
        public DateTime CreateDate1 { get => CreateDate; set => CreateDate = value; }


        public CobradorModel()
        {
            cobradorRepository = new CobradorRepository();
        }

        public string SaveChanges()
        {
            string message = null;
            try
            {
                var cobradorModel = new Cobrador();
                cobradorModel.COBRADOR = Cobrador1;
                cobradorModel.CONJUNTO = Conjunto1;
                cobradorModel.NOMBRE = Nombre1;
                cobradorModel.EMPLEADO = Empleado1;
                cobradorModel.COMISION = Comision1;
                cobradorModel.CTR_COMISION = Ctr_comision1;
                cobradorModel.CTA_COMISION = Cta_comision1;
                cobradorModel.CORREO = Correo1;
                cobradorModel.ACTIVO = Activo1;
                cobradorModel.TELEFONO = Telefono1;
                cobradorModel.UpdatedBy = UpdatedBy1;
                cobradorModel.RecordDate = RecordDate1;
                cobradorModel.CreateDate = CreateDate1;
                cobradorModel.CreatedBy = CreatedBy1;

                switch (State)
                {
                    case EntityState.Added:
                        // Ejecutar reglas comerciales /Calculos
                        cobradorRepository.Add(cobradorModel);
                        message = "Cobrador Agregado";
                        break;
                    case EntityState.Deleted:
                        cobradorRepository.Remove2(Cobrador1, Conjunto1);
                        message = "Cobrador Eliminado";
                        break;
                    case EntityState.Modified:
                        cobradorRepository.Edit(cobradorModel);
                        message = "Cobrador Editado";
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



        public List<CobradorModel> GetAll()
        {
            var cobradorDataModel = cobradorRepository.GetAll();
            var listCobrador = new List<CobradorModel>();
            foreach (Cobrador item in cobradorDataModel)
            {
                listCobrador.Add(new CobradorModel
                {
                    Cobrador1 = item.COBRADOR,
                    Conjunto1 = item.CONJUNTO,
                    Nombre1 = item.NOMBRE,
                    Empleado1 = item.EMPLEADO,
                    Comision1 = item.COMISION,
                    Ctr_comision1 = item.CTR_COMISION,
                    Cta_comision1 = item.CTA_COMISION,
                    Correo1 = item.CORREO,
                    Activo1 = item.ACTIVO,
                    Telefono1 = item.TELEFONO,
                    RecordDate1 = item.RecordDate,
                    CreateDate1 = item.CreateDate,
                    CreatedBy = item.CreatedBy,
                    UpdatedBy1 = item.UpdatedBy,
                });
            }
            return listCobrador;
        }

        public IEnumerable<CobradorModel> CobradorConjunto(string filter1)
        {
            return GetAll().FindAll(e => e.Conjunto.Equals(filter1));
        }
        public IEnumerable<CobradorModel> BuscarCobrador(string filter1, string filter2)
        {
            return GetAll().FindAll(e => e.Cobrador.Equals(filter1) && e.Conjunto.Equals(filter2));
        }

        public void borrar(string Cobrador, string Conjunto)
        {
            cobradorRepository.Remove2(Cobrador, Conjunto);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
