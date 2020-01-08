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
using System.Data;

namespace Logistika360.ERP.ERPADMIN.Domain.Models
{
    public class ParentescoModel : IDisposable
    {

        private string aCCION;
        private string pADRE;
        private int nUMEROHERMANO;
        private string NOMBREACCION;
        private string NOMBRECONSTANTE;

        private IParentescoRepository parentescoRepository;
        public EntityState State { private get; set; }
        public string ACCION { get => aCCION; set => aCCION = value; }
        public string PADRE { get => pADRE; set => pADRE = value; }
        public int NUMEROHERMANO { get => nUMEROHERMANO; set => nUMEROHERMANO = value; }
        public string NOMBREACCION1 { get => NOMBREACCION; set => NOMBREACCION = value; }
        public string NOMBRECONSTANTE1 { get => NOMBRECONSTANTE; set => NOMBRECONSTANTE = value; }

        public void Dispose()
        {
            throw new NotImplementedException();
        }


        public List<ParentescoModel> cargaNodos(string NodoInicio)
        {

            var parentescoDataModel = parentescoRepository.ICargaNodos(NodoInicio);

            var listNodo = new List<ParentescoModel>();
            foreach (Parentesco item in parentescoDataModel)
            {
                listNodo.Add(new ParentescoModel
                {
                    aCCION = item.ACCION,
                    pADRE=item.PADRE,
                    nUMEROHERMANO=item.NUMEROHERMANO
                    
                });
            }
            return listNodo;

        }



        public ParentescoModel()
        {
            parentescoRepository = new ParentescoRepository();

        }

        public DataTable Nodos()
        {
            DataTable   arbol = parentescoRepository.arbol();

            return arbol;
        }


    }
}
