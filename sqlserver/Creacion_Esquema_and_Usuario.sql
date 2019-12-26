USE [ERPL360]
GO

/****** Object:  Table [erpadmin].[USUARIO]    Script Date: 25/12/2019 06:23:51 p.m. ******/
SET ANSI_NULLS OFF
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO
CREATE SCHEMA ERPL360
CREATE TABLE ERPL360.USUARIO(
	Id int identity(1,1) primary key,
	USUARIO varchar(25) unique NOT NULL,
	NOMBRE varchar(100) NOT NULL,
	TIPO varchar(1) NOT NULL,
	ACTIVO varchar(1) NOT NULL,
	REQ_CAMBIO_CLAVE varchar(1) NOT NULL,
	FRECUENCIA_CLAVE smallint NOT NULL,
	FECHA_ULT_CLAVE datetime NOT NULL,
	MAX_INTENTOS_CONEX smallint NOT NULL,
	CLAVE varchar (68) NULL,
	CORREO_ELECTRONICO varchar(249) NULL,
	TIPO_ACCESO varchar(1) default ('T') NOT NULL,
	CELULAR varchar(25) NULL,
	TIPO_PERSONALIZADO varchar(256) NULL,
	RecordDate datetime  default (getdate())   NOT NULL ,
	CreatedBy varchar(30) default (suser_sname()) NOT NULL,
	UpdatedBy varchar(30) default (suser_sname()) NOT NULL,
	CreateDate datetime default (getdate()) NOT NULL)










