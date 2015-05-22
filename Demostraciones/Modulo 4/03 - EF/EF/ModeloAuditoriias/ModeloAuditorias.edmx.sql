
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/30/2015 18:00:31
-- Generated from EDMX file: C:\Users\Victor\Documents\GitHub\UADER-La-Plataforma-de-Desarrollo-.NET\Demostraciones\Modulo 4\03 - EF\EF\ModeloAuditoriias\ModeloAuditorias.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Auditorias];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ActividadProceso]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ActividadSet] DROP CONSTRAINT [FK_ActividadProceso];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[ProcesoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProcesoSet];
GO
IF OBJECT_ID(N'[dbo].[ActividadSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ActividadSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'ProcesoSet'
CREATE TABLE [dbo].[ProcesoSet] (
    [IdProceso] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [Habilitado] bit  NOT NULL
);
GO

-- Creating table 'ActividadSet'
CREATE TABLE [dbo].[ActividadSet] (
    [IdActividad] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [Proceso_IdProceso] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdProceso] in table 'ProcesoSet'
ALTER TABLE [dbo].[ProcesoSet]
ADD CONSTRAINT [PK_ProcesoSet]
    PRIMARY KEY CLUSTERED ([IdProceso] ASC);
GO

-- Creating primary key on [IdActividad] in table 'ActividadSet'
ALTER TABLE [dbo].[ActividadSet]
ADD CONSTRAINT [PK_ActividadSet]
    PRIMARY KEY CLUSTERED ([IdActividad] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Proceso_IdProceso] in table 'ActividadSet'
ALTER TABLE [dbo].[ActividadSet]
ADD CONSTRAINT [FK_ActividadProceso]
    FOREIGN KEY ([Proceso_IdProceso])
    REFERENCES [dbo].[ProcesoSet]
        ([IdProceso])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ActividadProceso'
CREATE INDEX [IX_FK_ActividadProceso]
ON [dbo].[ActividadSet]
    ([Proceso_IdProceso]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------