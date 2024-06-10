exec sp_rename 'dbo.Type', 'DoctorType'

ALTER TABLE Doctor DROP CONSTRAINT Doctor_Type;