
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 06/13/2012 16:11:31
-- Generated from EDMX file: C:\Users\Victor\Desktop\Ejemplos\Modulo 4\AccesoADatos\ModelFirstEF\Motocross.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Motocross];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_MarcaEquipo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Equipo] DROP CONSTRAINT [FK_MarcaEquipo];
GO
IF OBJECT_ID(N'[dbo].[FK_EquipoCorredor]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Corredor] DROP CONSTRAINT [FK_EquipoCorredor];
GO
IF OBJECT_ID(N'[dbo].[FK_CorredorClase]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Clase] DROP CONSTRAINT [FK_CorredorClase];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Equipo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Equipo];
GO
IF OBJECT_ID(N'[dbo].[Marca]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Marca];
GO
IF OBJECT_ID(N'[dbo].[Corredor]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Corredor];
GO
IF OBJECT_ID(N'[dbo].[Clase]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Clase];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Equipo'
CREATE TABLE [dbo].[Equipo] (
    [IDEquipo] int IDENTITY(1,1) NOT NULL,
    [NombreEquipo] bit  NOT NULL,
    [IsEquipoConSoponser] nvarchar(max)  NOT NULL,
    [IDMarca] int  NOT NULL,
    [Marca_IDMarca] int  NOT NULL
);
GO

-- Creating table 'Marca'
CREATE TABLE [dbo].[Marca] (
    [IDMarca] int IDENTITY(1,1) NOT NULL,
    [NombreMarca] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Corredor'
CREATE TABLE [dbo].[Corredor] (
    [IDCorredor] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL,
    [Apellido] nvarchar(max)  NOT NULL,
    [Edad] smallint  NOT NULL,
    [IDClase] int  NOT NULL,
    [IDEquipo] nvarchar(max)  NOT NULL,
    [Equipo_IDEquipo] int  NOT NULL
);
GO

-- Creating table 'Clase'
CREATE TABLE [dbo].[Clase] (
    [IDClase] int IDENTITY(1,1) NOT NULL,
    [NombreClase] nvarchar(max)  NOT NULL,
    [Corredor_IDCorredor] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IDEquipo] in table 'Equipo'
ALTER TABLE [dbo].[Equipo]
ADD CONSTRAINT [PK_Equipo]
    PRIMARY KEY CLUSTERED ([IDEquipo] ASC);
GO

-- Creating primary key on [IDMarca] in table 'Marca'
ALTER TABLE [dbo].[Marca]
ADD CONSTRAINT [PK_Marca]
    PRIMARY KEY CLUSTERED ([IDMarca] ASC);
GO

-- Creating primary key on [IDCorredor] in table 'Corredor'
ALTER TABLE [dbo].[Corredor]
ADD CONSTRAINT [PK_Corredor]
    PRIMARY KEY CLUSTERED ([IDCorredor] ASC);
GO

-- Creating primary key on [IDClase] in table 'Clase'
ALTER TABLE [dbo].[Clase]
ADD CONSTRAINT [PK_Clase]
    PRIMARY KEY CLUSTERED ([IDClase] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Marca_IDMarca] in table 'Equipo'
ALTER TABLE [dbo].[Equipo]
ADD CONSTRAINT [FK_MarcaEquipo]
    FOREIGN KEY ([Marca_IDMarca])
    REFERENCES [dbo].[Marca]
        ([IDMarca])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_MarcaEquipo'
CREATE INDEX [IX_FK_MarcaEquipo]
ON [dbo].[Equipo]
    ([Marca_IDMarca]);
GO

-- Creating foreign key on [Equipo_IDEquipo] in table 'Corredor'
ALTER TABLE [dbo].[Corredor]
ADD CONSTRAINT [FK_EquipoCorredor]
    FOREIGN KEY ([Equipo_IDEquipo])
    REFERENCES [dbo].[Equipo]
        ([IDEquipo])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EquipoCorredor'
CREATE INDEX [IX_FK_EquipoCorredor]
ON [dbo].[Corredor]
    ([Equipo_IDEquipo]);
GO

-- Creating foreign key on [Corredor_IDCorredor] in table 'Clase'
ALTER TABLE [dbo].[Clase]
ADD CONSTRAINT [FK_CorredorClase]
    FOREIGN KEY ([Corredor_IDCorredor])
    REFERENCES [dbo].[Corredor]
        ([IDCorredor])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CorredorClase'
CREATE INDEX [IX_FK_CorredorClase]
ON [dbo].[Clase]
    ([Corredor_IDCorredor]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------