
insert into ERPL360.ACCION(ACCION,NOMBREACCION,DESCRIPCION,NOMBRECONSTANTE,ESMODULO,TIPO,SUBTIPO,TABLA,INVOCACION)
SELECT ACCION,NOMBREACCION,DESCRIPCION,NOMBRECONSTANTE,ESMODULO,TIPO,SUBTIPO,TABLA,INVOCACION FROM COAGRO2.ERPADMIN.ACCION 



INSERT INTO ERPL360.CONJUNTO(CONJUNTO,nombre,DIREC1,DIREC2,TELEFONO,LOGO,DOBLE_MONEDA,DOBLE_CONTABILIDAD,USA_LOTES,USAR_CENTROS_COSTO,CONSOLIDA,CONSOLIDADORA,BD_CIA_CONSOLIDAD,CONTA_A_CONSOLID,MISMO_CUADRO_CTB,USUARIO_ULT_MOD,FCH_HORA_ULT_MOD,NOTAS,USA_UNIDADES,UNIDAD_OMISION,MONEDA_CONSOLIDA,VERSION_BD,USUARIO_MODIF_BD,FCH_HORA_MODIF_BD,VERSION_INSTALAC,NIT,PAIS,GLN,UBICACION,IDIOMA,USA_SUCURSAL,MASCARA_SUCURSAL,DIRECCION_WEB1,DIRECCION_WEB2,NOMBRE_WEB1,NOMBRE_WEB2,EMAIL_DOC_ELECTRONICO,PAIS_DIVISION,DIVISION_GEOGRAFICA1,DIVISION_GEOGRAFICA2,LOGO_CIA,NUMERO_REGISTRO,DIREC3,COD_POSTAL,DIVISION_GEOGRAFICA3,DIVISION_GEOGRAFICA4,REGIMEN_FISCAL)
SELECT CONJUNTO,nombre,DIREC1,DIREC2,TELEFONO,LOGO,DOBLE_MONEDA,DOBLE_CONTABILIDAD,USA_LOTES,USAR_CENTROS_COSTO,CONSOLIDA,CONSOLIDADORA,BD_CIA_CONSOLIDAD,CONTA_A_CONSOLID,MISMO_CUADRO_CTB,USUARIO_ULT_MOD,FCH_HORA_ULT_MOD,NOTAS,USA_UNIDADES,UNIDAD_OMISION,MONEDA_CONSOLIDA,VERSION_BD,USUARIO_MODIF_BD,FCH_HORA_MODIF_BD,VERSION_INSTALAC,NIT,PAIS,GLN,UBICACION,IDIOMA,USA_SUCURSAL,MASCARA_SUCURSAL,DIRECCION_WEB1,DIRECCION_WEB2,NOMBRE_WEB1,NOMBRE_WEB2,EMAIL_DOC_ELECTRONICO,PAIS_DIVISION,DIVISION_GEOGRAFICA1,DIVISION_GEOGRAFICA2,LOGO_CIA,NUMERO_REGISTRO,DIREC3,COD_POSTAL,DIVISION_GEOGRAFICA3,DIVISION_GEOGRAFICA4,REGIMEN_FISCAL FROM  COAGRO2.ERPADMIN.CONJUNTO where CONJUNTO='CINCOH'


INSERT INTO ERPL360.ERPL360.MODULO_INSTALADO(CONJUNTO,ACCION)
SELECT CONJUNTO,ACCION FROM COAGRO2.ERPADMIN.MODULO_INSTALADO where CONJUNTO='CINCOH'



