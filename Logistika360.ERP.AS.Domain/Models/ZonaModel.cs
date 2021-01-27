﻿using System;
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
        private string Nombre;
        private string UpdatedBy;
        private DateTime RecordDate;
        private string CreatedBy;
        private DateTime CreateDate;

        private IZonaRepository zonaRepository;
        public EntityState State { private get; set; }
        [Required(ErrorMessage = "Zona no puede quedar Zona")]
        [StringLength(4, ErrorMessage = "Zona es de Longitud de 4 Carateres Maximo")]
        public string Zona1 { get => Zona; set => Zona = value; }
        
        [Required(ErrorMessage = "Nombre es Obligatorio ")]
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
                        zonaRepository.Remove(Zona1);
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
                    Nombre1 = item.NOMBRE,
                    RecordDate1 = item.RecordDate,
                    CreateDate1 = item.CreateDate,
                    CreatedBy = item.CreatedBy,
                    UpdatedBy1 = item.UpdatedBy,
                });
            }
            return listZona;
        }


        public IEnumerable<ZonaModel> ZonaConjunto()
        {
            return GetAll();
        }
        public IEnumerable<ZonaModel> BuscarZona(string filter1)
        {
            return GetAll().FindAll(e => e.Zona.Equals(filter1) );
        }

        public void borrar(string Zona)
        {
            zonaRepository.Remove(Zona);
        }



        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
