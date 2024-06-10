
CREATE TABLE [dbo].[DoctorsSchedule] (
    [Code]            INT      IDENTITY (1, 1) NOT NULL,
    [DoctorCode]      INT      NOT NULL,
    [DayInTheWeek] INT NOT NULL,
    [StartTime]     TIME(0)      NOT NULL,
    [FinishTime]    TIME(0)      NOT NULL,
    PRIMARY KEY CLUSTERED ([Code] ASC),
    FOREIGN KEY ([DoctorCode]) REFERENCES [dbo].[Doctor] ([Code])														
);

ALTER TABLE Appointment
ALTER COLUMN PatientCode int NOT NULL;	

DELETE FROM Appointment WHERE PatientCode is NULL;

INSERT INTO DoctorsSchedule
VALUES (1, 1, '08:00:00','14:00:00'),
(1, 2, '08:00:00','14:00:00'),
(1, 4, '15:00:00','20:00:00'),
(1, 5, '15:00:00','20:00:00'),
(1, 6, '07:00:00','13:00:00');