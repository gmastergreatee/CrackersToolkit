
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/28/2018 14:32:29
-- Generated from EDMX file: C:\Users\Rajarshi Vaidya\source\repos\RECollection\DataStore\StorageContext.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [DataCore];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[WinPositions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[WinPositions];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'WinPositions'
CREATE TABLE [dbo].[WinPositions] (
    [Id] int  NOT NULL,
    [Top] real  NOT NULL,
    [Left] real  NOT NULL,
    [Width] real  NOT NULL,
    [Height] real  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'WinPositions'
ALTER TABLE [dbo].[WinPositions]
ADD CONSTRAINT [PK_WinPositions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------