

INSERT INTO DoctorType
VALUES ('ChildrensDoctor'),('FamilyDoctor'),('EyeDoctor'),('Gynecologist'),('SkinDoctor'),('Cardiologist');

CREATE TABLE [dbo].[DoctorType] (
    [Id]   INT          IDENTITY (1, 1) NOT NULL,
    [type] NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
INSERT INTO Doctor
VALUES ('435654645','David','Cohen','0527684343','dhggd@gmail.com',1);

CREATE TABLE [dbo].[Doctor] (
    [Code]          INT          IDENTITY (1, 1) NOT NULL,
    [Id] NVARCHAR(10) NOT NULL,
    [FirstName]   NVARCHAR (50) NOT NULL,
    [LastName]    NVARCHAR (50) NOT NULL,
    [PhoneNumber] INT          NOT NULL,
    [Email]       NVARCHAR (50) NOT NULL,
    [DoctorType]  INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([Code] ASC),
    FOREIGN KEY (DoctorType) REFERENCES DoctorType(Id)
);

CREATE TABLE [dbo].[Patient] (
    [Code]          INT          IDENTITY (1, 1) NOT NULL,
    [PatientId]   NVARCHAR (10) NOT NULL,
    [FirstName]   NVARCHAR (50) NOT NULL,
    [LastName]    NVARCHAR (50) NOT NULL,
    [PhoneNumber] INT          NOT NULL,
    [Email]       NVARCHAR (50) NOT NULL,
    [BirthDate]   DATE         NOT NULL,
    PRIMARY KEY CLUSTERED ([Code] ASC)
);