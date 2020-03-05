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
    public class VendedorModel : IDisposable
    {

        private string Vendedor;
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

        private IVendedorRepository vendedorRepository;
        public EntityState State { private get; set; }

        [Required]
        public string Vendedor1 { get => Vendedor; set => Vendedor = value; }
        public string Conjunto1 { get => Conjunto; set => Conjunto = value; }
        [Required]
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Empleado1 { get => Empleado; set => Empleado = value; }
        public decimal Comision1 { get => Comision; set => Comision = value; }
        public string Ctr_comision1 { get => Ctr_comision; set => Ctr_comision = value; }
        public string Cta_comision1 { get => Cta_comision; set => Cta_comision = value; }
        [Required]
        public string Correo1 { get => Correo; set => Correo = value; }
        public string Activo1 { get => Activo; set => Activo = value; }
        public string Telefono1 { get => Telefono; set => Telefono = value; }
        public string UpdatedBy1 { get => UpdatedBy; set => UpdatedBy = value; }
        public DateTime RecordDate1 { get => RecordDate; set => RecordDate = value; }
        public string CreatedBy1 { get => CreatedBy; set => CreatedBy = value; }
        public DateTime CreateDate1 { get => CreateDate; set => CreateDate = value; }


        public VendedorModel()
        {
            vendedorRepository = new VendedorRepository();
        }


        public string SaveChanges()
        {
            string message = null;
            try
            {
                var vendedorModel = new Vendedor();
                vendedorModel.VENDEDOR = Vendedor1;
                vendedorModel.CONJUNTO = Conjunto1;
                vendedorModel.NOMBRE = Nombre1;
                vendedorModel.EMPLEADO = Empleado1;
                vendedorModel.COMISION = Comision1;
                vendedorModel.CTR_COMISION = Ctr_comision1;
                vendedorModel.CTA_COMISION = Cta_comision1;
                vendedorModel.CORREO = Correo1;
                vendedorModel.ACTIVO = Activo1;
                vendedorModel.TELEFONO = Telefono1;
                vendedorModel.UpdatedBy = UpdatedBy1;
                vendedorModel.RecordDate = RecordDate1;
                vendedorModel.CreateDate = CreateDate1;
                vendedorModel.CreatedBy = CreatedBy1;
                
                switch (State)
                {
                    case EntityState.Added:
                        // Ejecutar reglas comerciales /Calculos
                        vendedorRepository.Add(vendedorModel);
                        message = "Vendedor Agregado";
                        break;
                    case EntityState.Deleted:
                        vendedorRepository.Remove2(Vendedor1,Conjunto1);
                        message = "Vendedor Eliminado";
                        break;
                    case EntityState.Modified:
                        vendedorRepository.Edit(vendedorModel);
                        message = "Vendedor Editado";
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

        public List<VendedorModel> GetAll()
        {
            var vendedorDataModel = vendedorRepository.GetAll();
            var listVendedor = new List<VendedorModel>();
            foreach (Vendedor item in vendedorDataModel)
            {
                listVendedor.Add(new VendedorModel
                {
                    Vendedor1 = item.VENDEDOR,
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
            return listVendedor;
        }

        public IEnumerable<VendedorModel> VendedorConjunto(string filter1)
        {
            return GetAll().FindAll(e => e.Conjunto.Equals(filter1) );
        }
        public IEnumerable<VendedorModel> BuscarVendedor(string filter1,string filter2)
        {
            return GetAll().FindAll(e => e.Vendedor.Equals(filter1) && e.Conjunto.Equals(filter2));
        }

         public void borrar(string Vendedor,string Conjunto)
        {
            vendedorRepository.Remove2(Vendedor, Conjunto);
        }


        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
