--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--
-- Script de ejecución al crear nueva empresa      --
--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--
--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--
-- ITCR - Escuela de Computación
-- Ingeniería en Computación
-- Profesor: Diego Mora
--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--
-- Estudiantes:
-- Javier Álvarez González
-- Cesar Brenes
-- Erick Brenes
-- William Carrillo Alarcón
-- Carlos Osejo Bermúdez
--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--
--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--

USE [SIA2]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO



CREATE SCHEMA [jcewc] AUTHORIZATION [dbo]
--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--
-- Tablas
--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--
--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--


--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--
-- Moneda
--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--
CREATE TABLE [jcewc].[Moneda](
	[IdMoneda] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Simbolo] [varchar](10) NOT NULL,
 CONSTRAINT [PK_Moneda] PRIMARY KEY CLUSTERED 
(
	[IdMoneda] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--
-- TipoAsiento
--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--
CREATE TABLE [jcewc].[TipoAsiento](
	[IdTipoAsiento] [int] IDENTITY(1,1) NOT NULL,
	[Tipo] [varchar](2) NOT NULL,
	[Descripcion] [varchar](300) NOT NULL,
 CONSTRAINT [PK_TipoAsiento] PRIMARY KEY CLUSTERED 
(
	[IdTipoAsiento] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--
-- Puesto
--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--
CREATE TABLE [jcewc].[Puesto](
	[IdPuesto] [int] IDENTITY(1,1) NOT NULL,
	[Puesto] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Puesto] PRIMARY KEY CLUSTERED 
(
	[IdPuesto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--
-- TipoEstado
--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--
CREATE TABLE [jcewc].[TipoEstado](
	[IdTipoEstado] [int] IDENTITY(1,1) NOT NULL,
	[Estado] [varchar](100) NOT NULL,
 CONSTRAINT [PK_TipoEstado] PRIMARY KEY CLUSTERED 
(
	[IdTipoEstado] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--
-- TipoCuenta
--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--
CREATE TABLE [jcewc].[TipoCuenta](
	[IdTipoCuenta] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](15) NOT NULL,
	[NumeroTipoCuenta] [int] NULL,
 CONSTRAINT [PK_TipoCuenta] PRIMARY KEY CLUSTERED 
(
	[IdTipoCuenta] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--
-- TipoContacto
--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--
CREATE TABLE [jcewc].[TipoContacto](
	[IdTipoContacto] [int] IDENTITY(1,1) NOT NULL,
	[TipoContacto] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TipoContacto] PRIMARY KEY CLUSTERED 
(
	[IdTipoContacto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--
-- TipoCambio
--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--
CREATE TABLE [jcewc].[TipoCambio](
	[IdTipoCambio] [int] IDENTITY(1,1) NOT NULL,
	[Fk_IdMonedaBase] [int] NOT NULL,
	[Fk_IdMonedaCambio] [int] NOT NULL,
 CONSTRAINT [PK_TipoCambio] PRIMARY KEY CLUSTERED 
(
	[IdTipoCambio] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--
-- Asiento
--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--
CREATE TABLE [jcewc].[Asiento](
	[IdAsiento] [int] IDENTITY(1,1) NOT NULL,
	[CodigoAsiento] [int] NOT NULL,
	[Fk_IdTipoAsiento] [int] NOT NULL,
	[FechaContabilizado] [datetime] NOT NULL,
	[FechaDocumento] [datetime] NOT NULL,
	[Referencia1] [varchar](20) NULL,
	[Referencia2] [varchar](20) NULL,
 CONSTRAINT [PK_Asiento] PRIMARY KEY CLUSTERED 
(
	[IdAsiento] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--
-- Persona
--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--
CREATE TABLE [jcewc].[Persona](
	[IdPersona] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](150) NOT NULL,
	[Apellido] [varchar](150) NOT NULL,
	[Edad] [tinyint] NOT NULL,
	[Sexo] [char](1) NOT NULL,
	[Fk_IdPuesto] [int] NOT NULL,
 CONSTRAINT [PK_Persona] PRIMARY KEY CLUSTERED 
(
	[IdPersona] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--
-- PeriodoContable
--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--
CREATE TABLE [jcewc].[PeriodoContable](
	[IdPeriodoContable] [int] IDENTITY(1,1) NOT NULL,
	[NumeroPeriodo] [int] NOT NULL,
	[FechaInicioContabilidad] [date] NOT NULL,
	[FechaFinalContabilidad] [date] NOT NULL,
	[FechaInicioDocumento] [date] NOT NULL,
	[FechaFinalDocumento] [date] NOT NULL,
	[FechaInicioVencimiento] [date] NOT NULL,
	[FechaFinalVencimiento] [date] NOT NULL,
	[Fk_IdEstadoPeriodo] [int] NULL,
 CONSTRAINT [PK_PeridoContable] PRIMARY KEY CLUSTERED 
(
	[IdPeriodoContable] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
----------------------------------------------------------------------------------------------
--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--
-- Empresas
--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--
CREATE TABLE [jcewc].[Empresas](
	[IdEmpresa] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[Cedula_Juridica] [bigint] NOT NULL,
	[Logotipo] [varbinary](max) NOT NULL,
	[Fk_IdPeriodoContable] [int] NULL,
	[Fk_MonedaLocal] [int] NOT NULL,
	[Fk_MonedaSistema] [int] NOT NULL,
 CONSTRAINT [PK_Empresas] PRIMARY KEY CLUSTERED 
(
	[IdEmpresa] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--
-- TipoCambioHistorico
--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--
CREATE TABLE [jcewc].[TipoCambioHistorico](
	[IdTipoCambioHistorico] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[Cambio] [decimal](20, 4) NOT NULL,
	[Fk_IdTipoCambio] [int] NOT NULL,
 CONSTRAINT [PK_TipoCambioHistorico] PRIMARY KEY CLUSTERED 
(
	[IdTipoCambioHistorico] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--
-- Usuario
--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--
CREATE TABLE [jcewc].[Usuario](
	[IdUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Contrasena] [varbinary](200) NOT NULL,
	[Fk_IdEmpresa] [int] NOT NULL,
	[Fk_IdPersona] [int] NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--
-- Contacto
--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--
CREATE TABLE [jcewc].[Contacto](
	[IdContacto] [int] IDENTITY(1,1) NOT NULL,
	[Valor] [varchar](300) NOT NULL,
	[Fk_IdTipoContacto] [int] NOT NULL,
	[Fk_IdEmpresa] [int] NOT NULL,
 CONSTRAINT [PK_Contacto] PRIMARY KEY CLUSTERED 
(
	[IdContacto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--
-- Catalogo_Contable
--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--
CREATE TABLE [jcewc].[Catalogo_Contable](
	[IdCatalogo_Contable] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[Fk_IdEmpresa] [int] NOT NULL,
 CONSTRAINT [PK_Catalogo_Contable] PRIMARY KEY CLUSTERED 
(
	[IdCatalogo_Contable] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--
-- Cuenta
--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--
CREATE TABLE [jcewc].[Cuenta](
	[IdCuenta] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [varchar](100) NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[Nombre_Extranjero] [varchar](100) NOT NULL,
	[EsTitulo] [bit] NOT NULL,
	[Fk_IdTipoCuenta] [int] NOT NULL,
	[Fk_IdCatalogo_Contable] [int] NOT NULL,
	[Fk_IdMoneda] [int] NULL,
	[SaldoLocal] [decimal](20, 4) NOT NULL,
	[SaldoSistema] [decimal](20, 4) NOT NULL,
	[CuentaPadre] [int] NULL,
	[Habilitado] [bit] NOT NULL,
 CONSTRAINT [PK_Cuenta] PRIMARY KEY CLUSTERED 
(
	[IdCuenta] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--
-- CuentaPorAsiento
--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--
CREATE TABLE [jcewc].[CuentaPorAsiento](
	[idCuentaPorAsiento] [int] IDENTITY(1,1) NOT NULL,
	[Fk_IdAsiento] [int] NOT NULL,
	[Fk_IdCuenta] [int] NOT NULL,
	[Monto_Local] [decimal](20, 4) NULL,
	[Monto_Sistema] [decimal](20, 4) NOT NULL,
	[Debe_Haber] [bit] NOT NULL,
 CONSTRAINT [PK_CuentaPorAsiento] PRIMARY KEY CLUSTERED 
(
	[idCuentaPorAsiento] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO



--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--
-- Foreign Keys
--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--
/****** Object:  ForeignKey [FK_Asiento_TipoAsiento]    Script Date: 10/03/2012 21:57:55 ******/
ALTER TABLE [jcewc].[Asiento]  WITH CHECK ADD  CONSTRAINT [FK_Asiento_TipoAsiento] FOREIGN KEY([Fk_IdTipoAsiento])
REFERENCES [jcewc].[TipoAsiento] ([IdTipoAsiento])
GO
ALTER TABLE [jcewc].[Asiento] CHECK CONSTRAINT [FK_Asiento_TipoAsiento]
GO
/****** Object:  ForeignKey [FK_Catalogo_Contable_Empresas]    Script Date: 10/03/2012 21:57:55 ******/
ALTER TABLE [jcewc].[Catalogo_Contable]  WITH CHECK ADD  CONSTRAINT [FK_Catalogo_Contable_Empresas] FOREIGN KEY([Fk_IdEmpresa])
REFERENCES [jcewc].[Empresas] ([IdEmpresa])
GO
ALTER TABLE [jcewc].[Catalogo_Contable] CHECK CONSTRAINT [FK_Catalogo_Contable_Empresas]
GO
/****** Object:  ForeignKey [FK_Contacto_Empresas]    Script Date: 10/03/2012 21:57:55 ******/
ALTER TABLE [jcewc].[Contacto]  WITH CHECK ADD  CONSTRAINT [FK_Contacto_Empresas] FOREIGN KEY([Fk_IdEmpresa])
REFERENCES [jcewc].[Empresas] ([IdEmpresa])
GO
ALTER TABLE [jcewc].[Contacto] CHECK CONSTRAINT [FK_Contacto_Empresas]
GO
/****** Object:  ForeignKey [FK_Contacto_TipoContacto]    Script Date: 10/03/2012 21:57:55 ******/
ALTER TABLE [jcewc].[Contacto]  WITH CHECK ADD  CONSTRAINT [FK_Contacto_TipoContacto] FOREIGN KEY([Fk_IdTipoContacto])
REFERENCES [jcewc].[TipoContacto] ([IdTipoContacto])
GO
ALTER TABLE [jcewc].[Contacto] CHECK CONSTRAINT [FK_Contacto_TipoContacto]
GO
/****** Object:  ForeignKey [FK_Cuenta_Catalogo_Contable]    Script Date: 10/03/2012 21:57:55 ******/
ALTER TABLE [jcewc].[Cuenta]  WITH CHECK ADD  CONSTRAINT [FK_Cuenta_Catalogo_Contable] FOREIGN KEY([Fk_IdCatalogo_Contable])
REFERENCES [jcewc].[Catalogo_Contable] ([IdCatalogo_Contable])
GO
ALTER TABLE [jcewc].[Cuenta] CHECK CONSTRAINT [FK_Cuenta_Catalogo_Contable]
GO
/****** Object:  ForeignKey [FK_Cuenta_Cuenta]    Script Date: 10/03/2012 21:57:55 ******/
ALTER TABLE [jcewc].[Cuenta]  WITH CHECK ADD  CONSTRAINT [FK_Cuenta_Cuenta] FOREIGN KEY([CuentaPadre])
REFERENCES [jcewc].[Cuenta] ([IdCuenta])
GO
ALTER TABLE [jcewc].[Cuenta] CHECK CONSTRAINT [FK_Cuenta_Cuenta]
GO
/****** Object:  ForeignKey [FK_Cuenta_Moneda]    Script Date: 10/03/2012 21:57:55 ******/
ALTER TABLE [jcewc].[Cuenta]  WITH CHECK ADD  CONSTRAINT [FK_Cuenta_Moneda] FOREIGN KEY([Fk_IdMoneda])
REFERENCES [jcewc].[Moneda] ([IdMoneda])
GO
ALTER TABLE [jcewc].[Cuenta] CHECK CONSTRAINT [FK_Cuenta_Moneda]
GO
/****** Object:  ForeignKey [FK_Cuenta_TipoCuenta]    Script Date: 10/03/2012 21:57:55 ******/
ALTER TABLE [jcewc].[Cuenta]  WITH CHECK ADD  CONSTRAINT [FK_Cuenta_TipoCuenta] FOREIGN KEY([Fk_IdTipoCuenta])
REFERENCES [jcewc].[TipoCuenta] ([IdTipoCuenta])
GO
ALTER TABLE [jcewc].[Cuenta] CHECK CONSTRAINT [FK_Cuenta_TipoCuenta]
GO
/****** Object:  ForeignKey [FK_CuentaPorAsiento_Asiento]    Script Date: 10/03/2012 21:57:55 ******/
ALTER TABLE [jcewc].[CuentaPorAsiento]  WITH CHECK ADD  CONSTRAINT [FK_CuentaPorAsiento_Asiento] FOREIGN KEY([Fk_IdAsiento])
REFERENCES [jcewc].[Asiento] ([IdAsiento])
GO
ALTER TABLE [jcewc].[CuentaPorAsiento] CHECK CONSTRAINT [FK_CuentaPorAsiento_Asiento]
GO
/****** Object:  ForeignKey [FK_CuentaPorAsiento_Cuenta]    Script Date: 10/03/2012 21:57:55 ******/
ALTER TABLE [jcewc].[CuentaPorAsiento]  WITH CHECK ADD  CONSTRAINT [FK_CuentaPorAsiento_Cuenta] FOREIGN KEY([Fk_IdCuenta])
REFERENCES [jcewc].[Cuenta] ([IdCuenta])
GO
ALTER TABLE [jcewc].[CuentaPorAsiento] CHECK CONSTRAINT [FK_CuentaPorAsiento_Cuenta]
GO
/****** Object:  ForeignKey [FK_Empresas_Moneda]    Script Date: 10/03/2012 21:57:55 ******/
ALTER TABLE [jcewc].[Empresas]  WITH CHECK ADD  CONSTRAINT [FK_Empresas_Moneda] FOREIGN KEY([Fk_MonedaLocal])
REFERENCES [jcewc].[Moneda] ([IdMoneda])
GO
ALTER TABLE [jcewc].[Empresas] CHECK CONSTRAINT [FK_Empresas_Moneda]
GO
/****** Object:  ForeignKey [FK_Empresas_Moneda1]    Script Date: 10/03/2012 21:57:55 ******/
ALTER TABLE [jcewc].[Empresas]  WITH CHECK ADD  CONSTRAINT [FK_Empresas_Moneda1] FOREIGN KEY([Fk_MonedaSistema])
REFERENCES [jcewc].[Moneda] ([IdMoneda])
GO
ALTER TABLE [jcewc].[Empresas] CHECK CONSTRAINT [FK_Empresas_Moneda1]
GO
/****** Object:  ForeignKey [FK_Empresas_PeridoContable]    Script Date: 10/03/2012 21:57:55 ******/
ALTER TABLE [jcewc].[Empresas]  WITH CHECK ADD  CONSTRAINT [FK_Empresas_PeridoContable] FOREIGN KEY([Fk_IdPeriodoContable])
REFERENCES [jcewc].[PeriodoContable] ([IdPeriodoContable])
GO
ALTER TABLE [jcewc].[Empresas] CHECK CONSTRAINT [FK_Empresas_PeridoContable]
GO
/****** Object:  ForeignKey [FK_PeridoContable_TipoEstado]    Script Date: 10/03/2012 21:57:55 ******/
ALTER TABLE [jcewc].[PeriodoContable]  WITH CHECK ADD  CONSTRAINT [FK_PeridoContable_TipoEstado] FOREIGN KEY([Fk_IdEstadoPeriodo])
REFERENCES [jcewc].[TipoEstado] ([IdTipoEstado])
GO
ALTER TABLE [jcewc].[PeriodoContable] CHECK CONSTRAINT [FK_PeridoContable_TipoEstado]
GO
/****** Object:  ForeignKey [FK_Persona_Puesto]    Script Date: 10/03/2012 21:57:55 ******/
ALTER TABLE [jcewc].[Persona]  WITH CHECK ADD  CONSTRAINT [FK_Persona_Puesto] FOREIGN KEY([Fk_IdPuesto])
REFERENCES [jcewc].[Puesto] ([IdPuesto])
GO
ALTER TABLE [jcewc].[Persona] CHECK CONSTRAINT [FK_Persona_Puesto]
GO
/****** Object:  ForeignKey [FK_TipoCambio_Moneda]    Script Date: 10/03/2012 21:57:55 ******/
ALTER TABLE [jcewc].[TipoCambio]  WITH CHECK ADD  CONSTRAINT [FK_TipoCambio_Moneda] FOREIGN KEY([Fk_IdMonedaBase])
REFERENCES [jcewc].[Moneda] ([IdMoneda])
GO
ALTER TABLE [jcewc].[TipoCambio] CHECK CONSTRAINT [FK_TipoCambio_Moneda]
GO
/****** Object:  ForeignKey [FK_TipoCambio_Moneda1]    Script Date: 10/03/2012 21:57:55 ******/
ALTER TABLE [jcewc].[TipoCambio]  WITH CHECK ADD  CONSTRAINT [FK_TipoCambio_Moneda1] FOREIGN KEY([Fk_IdMonedaCambio])
REFERENCES [jcewc].[Moneda] ([IdMoneda])
GO
ALTER TABLE [jcewc].[TipoCambio] CHECK CONSTRAINT [FK_TipoCambio_Moneda1]
GO
/****** Object:  ForeignKey [FK_TipoCambioHistorico_TipoCambio]    Script Date: 10/03/2012 21:57:55 ******/
ALTER TABLE [jcewc].[TipoCambioHistorico]  WITH CHECK ADD  CONSTRAINT [FK_TipoCambioHistorico_TipoCambio] FOREIGN KEY([Fk_IdTipoCambio])
REFERENCES [jcewc].[TipoCambio] ([IdTipoCambio])
GO
ALTER TABLE [jcewc].[TipoCambioHistorico] CHECK CONSTRAINT [FK_TipoCambioHistorico_TipoCambio]
GO
/****** Object:  ForeignKey [FK_Usuario_Empresas]    Script Date: 10/03/2012 21:57:55 ******/
ALTER TABLE [jcewc].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Empresas] FOREIGN KEY([Fk_IdEmpresa])
REFERENCES [jcewc].[Empresas] ([IdEmpresa])
GO
ALTER TABLE [jcewc].[Usuario] CHECK CONSTRAINT [FK_Usuario_Empresas]
GO
/****** Object:  ForeignKey [FK_Usuario_Persona]    Script Date: 10/03/2012 21:57:55 ******/
ALTER TABLE [jcewc].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Persona] FOREIGN KEY([Fk_IdPersona])
REFERENCES [jcewc].[Persona] ([IdPersona])
GO
ALTER TABLE [jcewc].[Usuario] CHECK CONSTRAINT [FK_Usuario_Persona]
GO

--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--
--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--


--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--
--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--
-- Store Procedures
--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--
--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--/--


-- =============================================
-- Author:	    Javier Alcarez 
-- Create date: 22/09/2012
-- Description:	Obtiene los tipos de cuenta del sistema
-- =============================================

CREATE PROCEDURE [jcewc].[SP_OBTENER_TIPOS_CUENTA]
AS
BEGIN
	SET NOCOUNT ON;
	SELECT Nombre , IdTipoCuenta, NumeroTipoCuenta FROM jcewc.TipoCuenta 
END
GO


-- =============================================
-- Author:		William Carrillo
-- Create date: 22/09/2012
-- Description:	Obtiene los puestos disponibles
-- =============================================
CREATE PROCEDURE [jcewc].[SP_OBTENER_PUESTOS]
AS
BEGIN
	SET NOCOUNT ON;
	
	SELECT IdPuesto, Puesto FROM jcewc.Puesto

END
GO


-- =============================================
-- Author:		William Carrillo
-- Create date: 22/09/2012
-- Description:	Crear empresa
-- =============================================
CREATE PROCEDURE [jcewc].[SP_OBTENER_MONEDAS]
AS
BEGIN
	SET NOCOUNT ON;
	
	SELECT IdMoneda,Nombre,Simbolo FROM jcewc.Moneda
	
	
END
GO


-- =============================================
-- Author:		William Carrillo
-- Create date: 22/09/2012
-- Description:	Crear periodo contable
-- =============================================
CREATE PROCEDURE [jcewc].[SP_CREAR_PERIODO_CONTABLE]
	@pFechaInicioC date,
	@pFechaFinC date,
	@pFechaInicioD date,
	@pFechaFinD date,
	@pFechaInicioV date,
	@pFechaFinV date
AS
BEGIN
	SET NOCOUNT ON;
	DECLARE @NUMPERIODO AS INT
	SET @NUMPERIODO = (SELECT COUNT(NumeroPeriodo)FROM jcewc.PeriodoContable)
	SET @NUMPERIODO = @NUMPERIODO+1
	INSERT INTO jcewc.PeriodoContable (NumeroPeriodo,FechaInicioContabilidad,FechaFinalContabilidad,FechaInicioDocumento,FechaFinalDocumento,FechaInicioVencimiento,FechaFinalVencimiento)
		VALUES (@NUMPERIODO, @pFechaInicioC,@pFechaFinC, @pFechaInicioD,@pFechaFinD, @pFechaInicioV,@pFechaFinV)
	SELECT SCOPE_IDENTITY() IdPeriodoContable
	
END
GO


-- =============================================
-- Author:		William Carrillo
-- Create date: 22/09/2012
-- Description:	Obtiene tipo de cambio de una moneda
-- =============================================
CREATE PROCEDURE [jcewc].[SP_OBTENER_TIPO_CAMBIO]
	@pMonedaBase int,
	@pMonedaCambio int,
	@pFecha datetime
AS
BEGIN
	SET NOCOUNT ON;
	
	SELECT TCH.Cambio monto FROM jcewc.TipoCambio TC
	INNER JOIN jcewc.TipoCambioHistorico TCH ON Tc.IdTipoCambio = TCH.Fk_IdTipoCambio
	WHERE TC.Fk_IdMonedaBase = @pMonedaBase AND TC.Fk_IdMonedaCambio = @pMonedaCambio AND Fecha= @pFecha
	
	
	
END
GO


-- =============================================
-- Author:		Javier Álvarez
-- Create date: 03-10-12
-- Description:	Guarda un tipo de cambio
-- =============================================
CREATE PROCEDURE [jcewc].[SP_INGRESAR_TIPO_CAMBIO]
	-- Add the parameters for the stored procedure here
	@pIdMonedaBase int,
	@pIdMonedaCambio int,
	@pValor decimal(20,4)
AS
BEGIN
	SET NOCOUNT ON;
	DECLARE @existe as int
	DECLARE @idTipoCambio as int
	SET @existe= (SELECT COUNT(IdTipoCambio) FROM jcewc.TipoCambio WHERE Fk_IdMonedaBase=@pIdMonedaBase AND Fk_IdMonedaCambio=@pIdMonedaCambio)
	IF @existe=0
	BEGIN
		INSERT INTO jcewc.TipoCambio(Fk_IdMonedaBase,Fk_IdMonedaCambio) VALUES (@pIdMonedaBase,@pIdMonedaCambio)
		SET @idTipoCambio = SCOPE_IDENTITY()
	END
	ELSE
		SET @idTipoCambio = (SELECT IdTipoCambio FROM jcewc.TipoCambio WHERE Fk_IdMonedaBase=@pIdMonedaBase AND Fk_IdMonedaCambio=@pIdMonedaCambio)
	INSERT INTO jcewc.TipoCambioHistorico(Fecha, Cambio, Fk_IdTipoCambio) VALUES (CONVERT (datetime,CONVERT (char(10), getdate(), 112),1), @pValor, @idTipoCambio)
END
GO



-- =============================================
-- Author:		William Carrillo
-- Create date: 22/09/2012
-- Description:	Actualiza el periodo contable a empresa
-- =============================================
CREATE PROCEDURE [jcewc].[SP_INGRESAR_PERIODOCONTABLE_A_EMPRESA]
	@pIdPeriodoContable int,
	@pIdEmpresa int
AS
BEGIN
	SET NOCOUNT ON;
	
	UPDATE jcewc.Empresas SET Fk_IdPeriodoContable = @pIdPeriodoContable
		WHERE IdEmpresa = @pIdEmpresa

END
GO


-- =============================================
-- Author:		William Carrillo
-- Create date: 22/09/2012
-- Description:	Obtiene las empresa por el ID
-- =============================================
CREATE PROCEDURE [jcewc].[SP_OBTENER_EMPRESA]
	@pIdEmpresa int
AS
BEGIN
	SET NOCOUNT ON;
	
	SELECT IdEmpresa,Nombre,Logotipo,Fk_MonedaLocal,Fk_MonedaSistema FROM jcewc.Empresas
	WHERE IdEmpresa = @pIdEmpresa

END
GO


-- =============================================
-- Author:		Javier Alvarez
-- Create date: 23/09/2012
-- Description:	Obtiene el Catalogo Contable de una empresa
-- =============================================
CREATE PROCEDURE [jcewc].[SP_OBTENER_CATALOGO_CONTABLE]
	@pIdEmpresa int
AS
BEGIN
	SET NOCOUNT ON;
	
	SELECT IdCatalogo_Contable, Nombre, Fk_IdEmpresa FROM jcewc.Catalogo_Contable Where Fk_IdEmpresa = @pIdEmpresa
	
END
GO


-- =============================================
-- Author:		William Carrillo
-- Create date: 22/09/2012
-- Description:	Crear usuario
-- =============================================
CREATE PROCEDURE [jcewc].[SP_CREAR_USUARIO]
	@pNombre varchar(150),
	@pApellido varchar(150),
	@pEdad tinyint,
	@pSexo char(1),
	@pIdPuesto int,
	@pNombreUsuario varchar(50),
	@pContrasena varbinary(200),
	@pIdEmpresa int
AS
BEGIN
	SET NOCOUNT ON;
	
	DECLARE @idPersona int
	
	INSERT INTO jcewc.Persona (Nombre,Apellido,Edad,Sexo,Fk_IdPuesto)
		VALUES (@pNombre,@pApellido,@pEdad,@pSexo,@pSexo)
	
	SELECT @idPersona = SCOPE_IDENTITY()
	
	INSERT INTO jcewc.Usuario (Nombre,Contrasena,Fk_IdEmpresa,Fk_IdPersona)
		VALUES(@pNombreUsuario,@pContrasena,@pIdEmpresa,@idPersona)
	
END
GO


-- =============================================
-- Author:		William Carrillo
-- Create date: 22/09/2012
-- Description:	Autentica usuario en el sistema
-- =============================================
CREATE PROCEDURE [jcewc].[SP_AUTENTICAR_USUARIO]
	@pNombreUsuario varchar(50),
	@pContrasena varbinary(200)
AS
BEGIN
	SET NOCOUNT ON;
	
	SELECT ISNULL(IdUsuario,-1) FROM jcewc.Usuario 
	WHERE Nombre = @pNombreUsuario AND Contrasena = @pContrasena
	
END
GO


-- =============================================
-- Author:		William Carrillo
-- Create date: 22/09/2012
-- Description:	Crear empresa
-- =============================================
CREATE PROCEDURE [jcewc].[SP_CREAR_EMPRESA]
	@pNombre varchar(100),
	@pCedulaJuridica bigint,
	@pLogotipo varbinary(MAX),
	@pMonedaLocal varchar(100),
	@pMonedaSistema varchar(100),
	@pEsquema varchar(100)
AS
BEGIN
	SET NOCOUNT ON;
	Declare @IdMonedaLocal as int
	Declare @IdMonedaSistema as int
	
	SET @IdMonedaLocal = (SELECT IdMoneda FROM Moneda WHERE Nombre=@pMonedaLocal)
	SET @IdMonedaSistema = (SELECT IdMoneda FROM Moneda WHERE Nombre=@pMonedaSistema)
	
	INSERT INTO jcewc.Empresas (Nombre,Cedula_Juridica,Logotipo,Fk_MonedaLocal,Fk_MonedaSistema)
		VALUES (@pNombre,@pCedulaJuridica,@pLogotipo,@IdMonedaLocal,@IdMonedaSistema)
	INSERT INTO dbo.Grupo (Fk_IdEmpresa, NombreEmpresa, SchemaGrupo) VALUES (SCOPE_IDENTITY(),@pNombre, @pEsquema)
END
GO


-- =============================================
-- Author:		William Carrillo
-- Create date: 22/09/2012
-- Description:	Ingresar el contacto a una empresa
-- =============================================
CREATE PROCEDURE [jcewc].[SP_CREAR_CONTACTO]
	@pValor varchar(300),
	@pFk_IdTipoContacto int,
	@pFk_IdEmpresa int
AS
BEGIN
	SET NOCOUNT ON;
	
	INSERT INTO jcewc.Contacto (Valor,Fk_IdTipoContacto,Fk_IdEmpresa)
		VALUES (@pValor,@pFk_IdTipoContacto,@pFk_IdEmpresa)
	
	
END
GO


-- =============================================
-- Author:		William Carrillo
-- Create date: 23/09/2012
-- Description:	Deshabilita una cuenta del sistema
-- =============================================
CREATE PROCEDURE [jcewc].[SP_BORRAR_CUENTA]
	@pIdCuenta int
AS
BEGIN
	SET NOCOUNT ON;
	
	UPDATE jcewc.Cuenta SET Habilitado = 0
		WHERE IdCuenta = @pIdCuenta
	
END
GO


-- =============================================
-- Author:		William Carrillo
-- Create date: 23/09/2012
-- Description:	Obtiene una Cuentas de un catálogo contable
-- =============================================
CREATE PROCEDURE [jcewc].[SP_OBTENER_CUENTAS]
	@pIdCatalogoContable int
AS
BEGIN
	SET NOCOUNT ON;
	
	SELECT IdCuenta,Codigo,C.Nombre,Nombre_Extranjero,EsTitulo,Fk_IdTipoCuenta,
		Fk_IdCatalogo_Contable,Fk_IdMoneda,SaldoLocal,SaldoSistema,CuentaPadre
		FROM jcewc.Cuenta C
		INNER JOIN jcewc.Catalogo_Contable CC ON CC.IdCatalogo_Contable = C.Fk_IdCatalogo_Contable
		WHERE C.Fk_IdCatalogo_Contable = @pIdCatalogoContable AND C.Habilitado = 1
	
END
GO


-- =============================================
-- Author:		William Carrillo
-- Create date: 23/09/2012
-- Description:	Obtiene una Cuenta
-- =============================================
CREATE PROCEDURE [jcewc].[SP_OBTENER_CUENTA]
	@pIdCuenta int
AS
BEGIN
	SET NOCOUNT ON;
	
	SELECT IdCuenta,Codigo,Nombre,Nombre_Extranjero,EsTitulo,Fk_IdTipoCuenta,Fk_IdCatalogo_Contable,Fk_IdMoneda,SaldoLocal,SaldoSistema,CuentaPadre
		FROM jcewc.Cuenta WHERE IdCuenta = @pIdCuenta AND Habilitado = 1
	
END
GO


-- =============================================
-- Author:		William Carrillo
-- Create date: 22/09/2012
-- Description:	Actualiza el periodo contable a empresa
-- =============================================
CREATE PROCEDURE [jcewc].[SP_CREAR_CUENTA]
	@pCodigo varchar(100),
	@pNombre varchar(100),
	@pNombreExtranjero varchar(100),
	@pEsTitulo int,
	@pIdTipoCuenta int,
	@pIdCatalogoContable int,
	@pIdMoneda int,
	@pIdCuentaPadre int
AS
BEGIN
	SET NOCOUNT ON;
	
	INSERT INTO jcewc.Cuenta (Codigo, Nombre, Nombre_Extranjero, EsTitulo, Fk_IdTipoCuenta, Fk_IdCatalogo_Contable, Fk_IdMoneda,SaldoLocal, SaldoSistema, CuentaPadre, Habilitado)
	VALUES (@pCodigo, @pNombre, @pNombreExtranjero, @pEsTitulo, @pIdTipoCuenta, @pIdCatalogoContable, @pIdMoneda, 0, 0, @pIdCuentaPadre, 1)


END
GO


