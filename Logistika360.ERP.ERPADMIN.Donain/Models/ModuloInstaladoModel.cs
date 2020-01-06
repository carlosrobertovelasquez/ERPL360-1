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
   public class ModuloInstaladoModel:IDisposable
    {
        private string cONJUNTO;
        private string aCCION;
        private string nOMBREACCION;


        private IModuloInstaladoRepository ModuloInstaladoRepository;
        public EntityState State { private get; set; }
        public string CONJUNTO { get => cONJUNTO; set => cONJUNTO = value; }
        public string ACCION { get => aCCION; set => aCCION = value; }
        public string NOMBREACCION { get => nOMBREACCION; set => nOMBREACCION = value; }


        public ModuloInstaladoModel()
        {
            ModuloInstaladoRepository = new ModuloInstaladoRepository();


        }
        public string SaveChanges()
        {
            string message = null;
            try
            {

                var moduloinstalado = new Modulo_Instalado();

                moduloinstalado.ACCION = ACCION;
                moduloinstalado.CONJUNTO = CONJUNTO;
                moduloinstalado.NOMBREACCION = NOMBREACCION;

                switch (State)
                {
                    case EntityState.Added:
                        break;
                    case EntityState.Deleted:
                        break;
                    case EntityState.Modified:
                        break;
                    case EntityState.Login:
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

        public List<ModuloInstaladoModel> modulos(string conjunto)
        {


            var modulosinstaladoModel = ModuloInstaladoRepository.Imodulos(conjunto);
            var listModuloinstalado = new List<ModuloInstaladoModel>();
            foreach (Modulo_Instalado item in  modulosinstaladoModel)
            {
                listModuloinstalado.Add(new ModuloInstaladoModel
                {
                    ACCION = item.ACCION,
                    CONJUNTO = item.CONJUNTO,
                NOMBREACCION = item.NOMBREACCION
                
                });
            }
                                    
            return listModuloinstalado;

        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
