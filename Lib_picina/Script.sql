/*
CREATE DATABASE db_picina;
GO 
USE db_picina;
GO 

CREATE TABLE [persona] (
    [Id] INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
    [Codigo] NVARCHAR(20) NOT NULL,
    [Nombre] NVARCHAR(50) NOT NULL,
    [Edad] INT NOT NULL,
    [Precio] FLOAT NOT NULL,
    [Activo] BIT NOT NULL,
    [Observaciones] NVARCHAR(500) NOT NULL,
);
*/