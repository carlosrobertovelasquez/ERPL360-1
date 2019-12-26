using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcces.Contracts;
using DataAcces.Repositories;
using DataAcces.Entities;
using Domain.ValueObjects;


namespace Domain.Models
{
    public class UsuarioModel
    {
        private string USUARIO;
        private string NOMBRE;
        private string TIPO;
        private string ACTIVO;
        private string REQ_CAMBIO_CLAVE;
        private string FRECUENCIA_CLAVE;
        private DateTime FECHA_ULT_CLAVE;
        private string MAX_INTENTOS_CONEX;
        private string CLAVE;
        private string CORREO_ELECTRONICO;
        private string TIPO_ACCESO;
        private string CELULAR;
        private string TIPO_PERSONALIZADO;

        private IUsuarioRepository usuarioRepository;
        public EntityState state { private get; set; }



        public string USUARIO1 { get => USUARIO; set => USUARIO = value; }
        public string NOMBRE1 { get => NOMBRE; set => NOMBRE = value; }
        public string TIPO1 { get => TIPO; set => TIPO = value; }
        public string ACTIVO1 { get => ACTIVO; set => ACTIVO = value; }
        public string REQ_CAMBIO_CLAVE1 { get => REQ_CAMBIO_CLAVE; set => REQ_CAMBIO_CLAVE = value; }
        public string FRECUENCIA_CLAVE1 { get => FRECUENCIA_CLAVE; set => FRECUENCIA_CLAVE = value; }
        public DateTime FECHA_ULT_CLAVE1 { get => FECHA_ULT_CLAVE; set => FECHA_ULT_CLAVE = value; }
        public string MAX_INTENTOS_CONEX1 { get => MAX_INTENTOS_CONEX; set => MAX_INTENTOS_CONEX = value; }
        public string CLAVE1 { get => CLAVE; set => CLAVE = value; }
        public string CORREO_ELECTRONICO1 { get => CORREO_ELECTRONICO; set => CORREO_ELECTRONICO = value; }
        public string TIPO_ACCESO1 { get => TIPO_ACCESO; set => TIPO_ACCESO = value; }
        public string CELULAR1 { get => CELULAR; set => CELULAR = value; }
        public string TIPO_PERSONALIZADO1 { get => TIPO_PERSONALIZADO; set => TIPO_PERSONALIZADO = value; }
    }
}
