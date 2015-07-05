USE PersonalDetails;
CREATE TABLE Person
(
	ID int IDENTITY(1,1) PRIMARY KEY,
	LastName varchar(255) NOT NULL,
	FirstName varchar(255),
	Gender Bit NOT NULL,
	DoB Date NOT NULL
);