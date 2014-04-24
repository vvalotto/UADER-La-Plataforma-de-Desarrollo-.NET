
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/08/2014 22:36:13
-- Generated from EDMX file: C:\Users\Victor\Documents\GitHub\PlataformaNET\Ejercicios Plataforma .NET\Modulo 4\03 - EF\EF\Campeonato\Datos\ModeloCampeonato.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Campeonato];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_EquipoPartido]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PartidoSet] DROP CONSTRAINT [FK_EquipoPartido];
GO
IF OBJECT_ID(N'[dbo].[FK_EquipoPartido1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PartidoSet] DROP CONSTRAINT [FK_EquipoPartido1];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[EquipoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EquipoSet];
GO
IF OBJECT_ID(N'[dbo].[PartidoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PartidoSet];
GO
IF OBJECT_ID(N'[dbo].[TablaPosicionesSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TablaPosicionesSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Equipos'
CREATE TABLE [dbo].[Equipos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Partidos'
CREATE TABLE [dbo].[Partidos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [GolesLoca] nvarchar(max)  NOT NULL,
    [IdEquipoVisitante] nvarchar(max)  NOT NULL,
    [GolesVistante] nvarchar(max)  NOT NULL,
    [EquipoLocalId] int  NOT NULL,
    [EquipoVisitanteId] int  NOT NULL
);
GO

-- Creating table 'TablasPosiciones'
CREATE TABLE [dbo].[TablasPosiciones] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [PG] smallint  NOT NULL,
    [PE] smallint  NOT NULL,
    [PP] smallint  NOT NULL,
    [Equipo_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Equipos'
ALTER TABLE [dbo].[Equipos]
ADD CONSTRAINT [PK_Equipos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Partidos'
ALTER TABLE [dbo].[Partidos]
ADD CONSTRAINT [PK_Partidos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TablasPosiciones'
ALTER TABLE [dbo].[TablasPosiciones]
ADD CONSTRAINT [PK_TablasPosiciones]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [EquipoLocalId] in table 'Partidos'
ALTER TABLE [dbo].[Partidos]
ADD CONSTRAINT [FK_EquipoPartido]
    FOREIGN KEY ([EquipoLocalId])
    REFERENCES [dbo].[Equipos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EquipoPartido'
CREATE INDEX [IX_FK_EquipoPartido]
ON [dbo].[Partidos]
    ([EquipoLocalId]);
GO

-- Creating foreign key on [EquipoVisitanteId] in table 'Partidos'
ALTER TABLE [dbo].[Partidos]
ADD CONSTRAINT [FK_EquipoPartido1]
    FOREIGN KEY ([EquipoVisitanteId])
    REFERENCES [dbo].[Equipos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EquipoPartido1'
CREATE INDEX [IX_FK_EquipoPartido1]
ON [dbo].[Partidos]
    ([EquipoVisitanteId]);
GO

-- Creating foreign key on [Equipo_Id] in table 'TablasPosiciones'
ALTER TABLE [dbo].[TablasPosiciones]
ADD CONSTRAINT [FK_TablaPosicionesEquipo]
    FOREIGN KEY ([Equipo_Id])
    REFERENCES [dbo].[Equipos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_TablaPosicionesEquipo'
CREATE INDEX [IX_FK_TablaPosicionesEquipo]
ON [dbo].[TablasPosiciones]
    ([Equipo_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------