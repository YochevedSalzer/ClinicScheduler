﻿CREATE TABLE [dbo].[Appointment]
(
	[Code] INT IDENTITY (1, 1) NOT NULL PRIMARY KEY,
	[DoctorCode] INT NOT NULL FOREIGN KEY ([DoctorCode])   REFERENCES [dbo].[Doctor] ([Code]) ,
	[AppointmentTime] DATETIME NOT NULL,
	[PatientCode] INT FOREIGN KEY ([PatientCode]) REFERENCES [dbo].[Patient] ([Code])


)

INSERT INTO Appointment
values(1,'2024-02-23 13:00:00',NULL),
	(1,'2024-02-23 13:30:00',NULL),
	(1,'2024-02-23 14:00:00',NULL),
	(1,'2024-02-23 14:30:00',NULL),
	(1,'2024-02-23 15:00:00',NULL),
	(1,'2024-02-23 15:30:00',NULL),
	(1,'2024-02-23 16:00:00',NULL),
	(1,'2024-02-23 16:30:00',NULL),
	(1,'2024-02-23 17:00:00',NULL),
	(1,'2024-02-23 17:30:00',NULL),
	(1,'2024-02-23 18:00:00',NULL),
	(1,'2024-02-26 13:00:00',NULL),
	(1,'2024-02-26 13:30:00',NULL),
	(1,'2024-02-26 14:00:00',NULL),
	(1,'2024-02-26 14:30:00',NULL),
	(1,'2024-02-26 15:00:00',NULL),
	(1,'2024-02-26 15:30:00',NULL),
	(1,'2024-02-26 16:00:00',NULL),
	(1,'2024-02-26 16:30:00',NULL),
	(1,'2024-02-26 17:00:00',NULL),
	(1,'2024-02-26 17:30:00',NULL),
	(1,'2024-02-26 18:00:00',NULL)
