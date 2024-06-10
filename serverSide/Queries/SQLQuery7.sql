ALTER TABLE DoctorsSchedule
ADD AppointmentDuration INT NOT NULL;

ALTER TABLE DoctorsSchedule
DROP COLUMN AppointmentDuration;

DELETE FROM DoctorsSchedule ;



INSERT INTO DoctorsSchedule
VALUES (1, 1, '08:00:00','14:00:00',15),
(1, 2, '08:00:00','14:00:00',15),
(1, 4, '15:00:00','20:00:00',15),
(1, 5, '15:00:00','20:00:00',15),
(1, 6, '07:00:00','13:00:00',15);
