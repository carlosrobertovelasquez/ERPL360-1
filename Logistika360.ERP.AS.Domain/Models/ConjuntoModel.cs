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
    public class ConjuntoModel : IDisposable
    {
        private string CONJUNTO;
        private string NOMBRE;
        private string DIREC1;
        private string DIREC2;
        private string TELEFONO;
        private string LOGO;
        private string DOBLE_MONEDA;
        private string DOBLE_CONTABILIDAD;
        private string USA_LOTES;
        private string USAR_CENTROS_COSTO;
        private string CONSOLIDA;
        private string CONSOLIDADORA;
        private string BD_CIA_CONSOLIDAD;
        private string CONTA_A_CONSOLID;
        private string MISMO_CUADRO_CTB;
        private string USUARIO_ULT_MOD;
        private DateTime FCH_HORA_ULT_MOD;
        private string NOTAS;
        private string USA_UNIDADES;
        private string UNIDAD_OMISION;
        private string MONEDA_CONSOLIDA;
        private string VERSION_BD;
        private string USUARIO_MODIF_BD;
        private DateTime FCH_HORA_MODIF_BD;
        private string VERSION_INSTALAC;
        private string NIT;
        private string PAIS;
        private string GLN;
        private string UBICACION;
        private string IDIOMA;
        private string USA_SUCURSAL;
        private string MASCARA_SUCURSAL;
        private string DIRECCION_WEB1;
        private string DIRECCION_WEB2;
        private string NOMBRE_WEB1;
        private string NOMBRE_WEB2;
        private string DIRECCION_PAG_WEB;
        private string EMAIL_DOC_ELECTRONICO;
        private string PAIS_DIVISION;
        private string DIVISION_GEOGRAFICA1;
        private string DIVISION_GEOGRAFICA2;
        private string LOGO_CIA;
        private string NUMERO_REGISTRO;
        private string DIREC3;
        private string COD_POSTAL;
        private string DIVISION_GEOGRAFICA3;
        private string DIVISION_GEOGRAFICA4;
        private string REGIMEN_FISCAL;
        private string INVENTARIO_DOLAR;
        private DateTime RecordDate;
        private string CreatedBy;
        private string UpdatedBy;
        private DateTime CreateDate;

        private  IConjuntoRepository    conjuntoRepository;
        public EntityState State { private get; set; }

        [Required(ErrorMessage = "Campo de Compania es Requerido")]
        public string CONJUNTO1 { get => CONJUNTO; set => CONJUNTO = value; }
        [Required(ErrorMessage = "Campo de Nombre de Compania es Requerido")]
        public string NOMBRE1 { get => NOMBRE; set => NOMBRE = value; }
        [Required(ErrorMessage = "Campo de Direccion es  Requerido")]
        public string DIREC11 { get => DIREC1; set => DIREC1 = value; }
        public string DIREC21 { get => DIREC2; set => DIREC2 = value; }
        [Required(ErrorMessage = "Campo de Telefono  es Requerido")]
        public string TELEFONO1 { get => TELEFONO; set => TELEFONO = value; }
        public string LOGO1 { get => LOGO; set => LOGO = value; }
        public string DOBLE_MONEDA1 { get => DOBLE_MONEDA; set => DOBLE_MONEDA = value; }
        public string DOBLE_CONTABILIDAD1 { get => DOBLE_CONTABILIDAD; set => DOBLE_CONTABILIDAD = value; }
        public string USA_LOTES1 { get => USA_LOTES; set => USA_LOTES = value; }
        public string USAR_CENTROS_COSTO1 { get => USAR_CENTROS_COSTO; set => USAR_CENTROS_COSTO = value; }
        public string CONSOLIDA1 { get => CONSOLIDA; set => CONSOLIDA = value; }
        public string CONSOLIDADORA1 { get => CONSOLIDADORA; set => CONSOLIDADORA = value; }
        public string BD_CIA_CONSOLIDAD1 { get => BD_CIA_CONSOLIDAD; set => BD_CIA_CONSOLIDAD = value; }
        public string CONTA_A_CONSOLID1 { get => CONTA_A_CONSOLID; set => CONTA_A_CONSOLID = value; }
        public string MISMO_CUADRO_CTB1 { get => MISMO_CUADRO_CTB; set => MISMO_CUADRO_CTB = value; }
        public string USUARIO_ULT_MOD1 { get => USUARIO_ULT_MOD; set => USUARIO_ULT_MOD = value; }
        public DateTime FCH_HORA_ULT_MOD1 { get => FCH_HORA_ULT_MOD; set => FCH_HORA_ULT_MOD = value; }
        public string NOTAS1 { get => NOTAS; set => NOTAS = value; }
        public string USA_UNIDADES1 { get => USA_UNIDADES; set => USA_UNIDADES = value; }
        public string UNIDAD_OMISION1 { get => UNIDAD_OMISION; set => UNIDAD_OMISION = value; }
        public string MONEDA_CONSOLIDA1 { get => MONEDA_CONSOLIDA; set => MONEDA_CONSOLIDA = value; }
        public string VERSION_BD1 { get => VERSION_BD; set => VERSION_BD = value; }
        public string USUARIO_MODIF_BD1 { get => USUARIO_MODIF_BD; set => USUARIO_MODIF_BD = value; }
        public DateTime FCH_HORA_MODIF_BD1 { get => FCH_HORA_MODIF_BD; set => FCH_HORA_MODIF_BD = value; }
        public string VERSION_INSTALAC1 { get => VERSION_INSTALAC; set => VERSION_INSTALAC = value; }
        [Required(ErrorMessage = "Campo de NIT es Requerido")]
        public string NIT1 { get => NIT; set => NIT = value; }
        [Required(ErrorMessage = "Campo de Pais es Requerido")]
        public string PAIS1 { get => PAIS; set => PAIS = value; }
        public string GLN1 { get => GLN; set => GLN = value; }
        public string UBICACION1 { get => UBICACION; set => UBICACION = value; }
        public string IDIOMA1 { get => IDIOMA; set => IDIOMA = value; }
        public string USA_SUCURSAL1 { get => USA_SUCURSAL; set => USA_SUCURSAL = value; }
        public string MASCARA_SUCURSAL1 { get => MASCARA_SUCURSAL; set => MASCARA_SUCURSAL = value; }
        public string DIRECCION_WEB11 { get => DIRECCION_WEB1; set => DIRECCION_WEB1 = value; }
        public string DIRECCION_WEB21 { get => DIRECCION_WEB2; set => DIRECCION_WEB2 = value; }
        public string NOMBRE_WEB11 { get => NOMBRE_WEB1; set => NOMBRE_WEB1 = value; }
        public string NOMBRE_WEB21 { get => NOMBRE_WEB2; set => NOMBRE_WEB2 = value; }
        public string DIRECCION_PAG_WEB1 { get => DIRECCION_PAG_WEB; set => DIRECCION_PAG_WEB = value; }
       // [EmailAddress]
        public string EMAIL_DOC_ELECTRONICO1 { get => EMAIL_DOC_ELECTRONICO; set => EMAIL_DOC_ELECTRONICO = value; }
        public string PAIS_DIVISION1 { get => PAIS_DIVISION; set => PAIS_DIVISION = value; }
        public string DIVISION_GEOGRAFICA11 { get => DIVISION_GEOGRAFICA1; set => DIVISION_GEOGRAFICA1 = value; }
        public string DIVISION_GEOGRAFICA21 { get => DIVISION_GEOGRAFICA2; set => DIVISION_GEOGRAFICA2 = value; }
        public string LOGO_CIA1 { get => LOGO_CIA; set => LOGO_CIA = value; }
        [Required(ErrorMessage = "Requiere Registro")]
        public string NUMERO_REGISTRO1 { get => NUMERO_REGISTRO; set => NUMERO_REGISTRO = value; }
        public string DIREC31 { get => DIREC3; set => DIREC3 = value; }
        public string COD_POSTAL1 { get => COD_POSTAL; set => COD_POSTAL = value; }
        public string DIVISION_GEOGRAFICA31 { get => DIVISION_GEOGRAFICA3; set => DIVISION_GEOGRAFICA3 = value; }
        public string DIVISION_GEOGRAFICA41 { get => DIVISION_GEOGRAFICA4; set => DIVISION_GEOGRAFICA4 = value; }
        public string REGIMEN_FISCAL1 { get => REGIMEN_FISCAL; set => REGIMEN_FISCAL = value; }
        public string INVENTARIO_DOLAR1 { get => INVENTARIO_DOLAR; set => INVENTARIO_DOLAR = value; }
        public DateTime RecordDate1 { get => RecordDate; set => RecordDate = value; }
        public string CreatedBy1 { get => CreatedBy; set => CreatedBy = value; }
        public string UpdatedBy1 { get => UpdatedBy; set => UpdatedBy = value; }
        public DateTime CreateDate1 { get => CreateDate; set => CreateDate = value; }

        public ConjuntoModel()
        {
            conjuntoRepository = new ConjuntoRepository();
        }

        public string SaveChanges()
        {
            string message = null;
            try
            {
                var conjuntoModel = new Conjunto();
                conjuntoModel.CONJUNTO=CONJUNTO1;
                conjuntoModel.NOMBRE=NOMBRE1;
                conjuntoModel.DIREC1=DIREC11;
                conjuntoModel.DIREC2=DIREC21;
                conjuntoModel.TELEFONO=TELEFONO1;
                //conjuntoModel.LOGO=LOGO1;
                conjuntoModel.DOBLE_MONEDA=DOBLE_MONEDA1;
                conjuntoModel.DOBLE_CONTABILIDAD=DOBLE_CONTABILIDAD1;
                conjuntoModel.USA_LOTES=USA_LOTES1;
                conjuntoModel.USAR_CENTROS_COSTO=USAR_CENTROS_COSTO1;
                conjuntoModel.CONSOLIDA=CONSOLIDA1;
                conjuntoModel.CONSOLIDADORA=CONSOLIDADORA1;
                conjuntoModel.BD_CIA_CONSOLIDAD=BD_CIA_CONSOLIDAD1;
                conjuntoModel.CONTA_A_CONSOLID=CONTA_A_CONSOLID1;
                conjuntoModel.MISMO_CUADRO_CTB=MISMO_CUADRO_CTB1;
                conjuntoModel.USUARIO_ULT_MOD=USUARIO_MODIF_BD1;
                conjuntoModel.FCH_HORA_ULT_MOD=FCH_HORA_ULT_MOD1;
                conjuntoModel.NOTAS=NOTAS1;
                conjuntoModel.USA_UNIDADES=USA_UNIDADES1;
                conjuntoModel.UNIDAD_OMISION=UNIDAD_OMISION1;
                conjuntoModel.MONEDA_CONSOLIDA=MONEDA_CONSOLIDA1;
                conjuntoModel.VERSION_BD=VERSION_BD1;
                conjuntoModel.USUARIO_MODIF_BD=USUARIO_MODIF_BD1;
                conjuntoModel.FCH_HORA_MODIF_BD=FCH_HORA_MODIF_BD1;
                conjuntoModel.VERSION_INSTALAC=VERSION_INSTALAC1;
                conjuntoModel.NIT=NIT1;
                conjuntoModel.PAIS=PAIS1;
                conjuntoModel.GLN=GLN1;
                conjuntoModel.UBICACION=UBICACION1;
                conjuntoModel.IDIOMA=IDIOMA1;
                conjuntoModel.USA_SUCURSAL=USA_SUCURSAL1;
                conjuntoModel.MASCARA_SUCURSAL=MASCARA_SUCURSAL1;
                conjuntoModel.DIRECCION_WEB1=DIRECCION_WEB11;
                conjuntoModel.DIRECCION_WEB2=DIRECCION_WEB21;
                conjuntoModel.NOMBRE_WEB1=NOMBRE_WEB11;
                conjuntoModel.NOMBRE_WEB2=NOMBRE_WEB21;
                conjuntoModel.DIRECCION_PAG_WEB=DIRECCION_PAG_WEB1;
                conjuntoModel.EMAIL_DOC_ELECTRONICO=EMAIL_DOC_ELECTRONICO1;
                conjuntoModel.PAIS_DIVISION=PAIS_DIVISION1;
                conjuntoModel.DIVISION_GEOGRAFICA1=DIVISION_GEOGRAFICA11;
                conjuntoModel.DIVISION_GEOGRAFICA2=DIVISION_GEOGRAFICA21;
                //conjuntoModel.LOGO_CIA=LOGO_CIA1;
                conjuntoModel.NUMERO_REGISTRO=NUMERO_REGISTRO1;
                conjuntoModel.DIREC3=DIREC31;
                conjuntoModel.COD_POSTAL=COD_POSTAL1;
                conjuntoModel.DIVISION_GEOGRAFICA3=DIVISION_GEOGRAFICA31;
                conjuntoModel.DIVISION_GEOGRAFICA4=DIVISION_GEOGRAFICA41;
                conjuntoModel.REGIMEN_FISCAL=REGIMEN_FISCAL1;
                conjuntoModel.INVENTARIO_DOLAR = INVENTARIO_DOLAR1;
                conjuntoModel.RecordDate = RecordDate1;
                conjuntoModel.CreatedBy = CreatedBy1;
                conjuntoModel.UpdatedBy = UpdatedBy1;
                conjuntoModel.CreateDate = CreateDate1;
                switch (State)
                {
                    case EntityState.Added:
                        // Ejecutar reglas comerciales /Calculos
                        conjuntoRepository.Add(conjuntoModel);
                        message = "Compañia Agregado";
                        break;
                    case EntityState.Deleted:
                        conjuntoRepository.Remove(CONJUNTO1);
                        message = "Compañia Eliminado";
                        break;
                    case EntityState.Modified:
                        conjuntoRepository.Edit(conjuntoModel);
                        message = "Compañia Editado";
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

        public List<ConjuntoModel> GetAll()
        {
            var conjuntoDataModel = conjuntoRepository.GetAll();
            var listConjunto = new List<ConjuntoModel>();
            foreach (Conjunto item in conjuntoDataModel)
            {
                listConjunto.Add(new ConjuntoModel
                {
                 CONJUNTO =item.CONJUNTO,
                    NOMBRE=item.NOMBRE,
                    DIREC1=item.DIREC1,
                    DIREC2=item.DIREC2,
                    TELEFONO=item.TELEFONO,
                    LOGO=item.LOGO,
                    DOBLE_MONEDA=item.DOBLE_MONEDA,
                    DOBLE_CONTABILIDAD=item.DOBLE_CONTABILIDAD,
                    USA_LOTES=item.USA_LOTES,
                    USAR_CENTROS_COSTO=item.USAR_CENTROS_COSTO,
                    CONSOLIDA=item.CONSOLIDA,
                    CONSOLIDADORA=item.CONSOLIDADORA,
                    BD_CIA_CONSOLIDAD=item.BD_CIA_CONSOLIDAD,
                    CONTA_A_CONSOLID=item.CONTA_A_CONSOLID,
                    MISMO_CUADRO_CTB=item.MISMO_CUADRO_CTB,
                    USUARIO_ULT_MOD=item.USUARIO_ULT_MOD,
                    FCH_HORA_ULT_MOD=item.FCH_HORA_ULT_MOD,
                    NOTAS=item.NOTAS,
                    USA_UNIDADES=item.USA_UNIDADES,
                    UNIDAD_OMISION=item.UNIDAD_OMISION,
                    MONEDA_CONSOLIDA=item.MONEDA_CONSOLIDA,
                    VERSION_BD=item.VERSION_BD,
                    USUARIO_MODIF_BD=item.USUARIO_MODIF_BD,
                    FCH_HORA_MODIF_BD=item.FCH_HORA_MODIF_BD,
                    VERSION_INSTALAC=item.VERSION_INSTALAC,
                    NIT=item.NIT,
                    PAIS=item.PAIS,
                    GLN=item.GLN,
                    UBICACION=item.UBICACION,
                    IDIOMA=item.IDIOMA,
                    USA_SUCURSAL=item.USA_SUCURSAL,
                    MASCARA_SUCURSAL=item.MASCARA_SUCURSAL,
                    DIRECCION_WEB1=item.DIRECCION_WEB1,
                    DIRECCION_WEB2=item.DIRECCION_WEB2,
                    NOMBRE_WEB1=item.NOMBRE_WEB1,
                    NOMBRE_WEB2=item.NOMBRE_WEB2,
                    DIRECCION_PAG_WEB=item.DIRECCION_PAG_WEB,
                    EMAIL_DOC_ELECTRONICO=item.EMAIL_DOC_ELECTRONICO,
                    PAIS_DIVISION=item.PAIS_DIVISION,
                    DIVISION_GEOGRAFICA1=item.DIVISION_GEOGRAFICA1,
                    DIVISION_GEOGRAFICA2=item.DIVISION_GEOGRAFICA2,
                    LOGO_CIA=item.LOGO_CIA,
                    NUMERO_REGISTRO=item.NUMERO_REGISTRO,
                    DIREC3=item.DIREC3,
                    COD_POSTAL=item.COD_POSTAL,
                    DIVISION_GEOGRAFICA3=item.DIVISION_GEOGRAFICA3,
                    DIVISION_GEOGRAFICA4=item.DIVISION_GEOGRAFICA4,
                    REGIMEN_FISCAL=item.REGIMEN_FISCAL,
                    INVENTARIO_DOLAR1=item.INVENTARIO_DOLAR,
                    RecordDate1=item.RecordDate,
                    CreatedBy1=item.CreatedBy,
                    UpdatedBy1=item.UpdatedBy,
                    CreateDate1=item.CreateDate,
                });
            }
            return listConjunto;
        }

        public void borrar( string Conjunto)
        {
            conjuntoRepository.Remove(Conjunto);
        }

        public IEnumerable<ConjuntoModel> BuscarConjunto(string filter1)
        {
            return GetAll().FindAll(e => e.CONJUNTO1.Equals(filter1) );
        }



        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
