CREATE TABLE Therapist
(
	Id INT NOT NULL Identity(1,1) PRIMARY KEY,
	FirstName nvarchar NOT NULL, 
	LastName nvarchar NOT NULL ,
	PhoneNumber int Not Null,
	Email nvarchar NOT NULL

)
drop table Therapist
create table Type
(
Id INT NOT NULL Identity(1,1) PRIMARY KEY,
type nvarchar NOT NULL
)

CREATE TABLE Doctor
(
	Id INT NOT NULL Identity(1,1) PRIMARY KEY,
	FirstName nvarchar NOT NULL, 
	LastName nvarchar NOT NULL ,
	PhoneNumber int Not Null,
	Email nvarchar NOT NULL,
	DoctorType int NOT NULL 
)

alter table Doctor
add constraint Doctor_Type foreign key (DoctorType) references [Type](id)

CREATE TABLE Patient
(
	Id INT NOT NULL Identity(1,1) PRIMARY KEY,
	PatientId nvarchar NOT NULL,
	FirstName nvarchar NOT NULL, 
	LastName nvarchar NOT NULL ,
	PhoneNumber int Not Null,
	Email nvarchar NOT NULL,
	BirthDate date NOT NULL
)
