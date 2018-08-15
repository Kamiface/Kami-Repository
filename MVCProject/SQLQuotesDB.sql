CREATE DATABASE Insurance;
USE Insurance;

	CREATE TABLE Quotes (
	Id INT NOT NULL primary key  IDENTITY(1,1),
	[FirstName] VARCHAR(50) NOT NULL,
	[LastName] VARCHAR(50) NOT NULL,
	[EmailAddress] VARCHAR(100) NOT NULL,
	[DateOfBirth] DATETIME NOT NULL,
	[CarModelYear] INT NOT NULL,
	[CarMake] VARCHAR(50) NOT NULL,
	[CarModel] VARCHAR(50) NOT NULL,
	[SpeedingTickets] INT NOT NULL,
	[DUICheck] VARCHAR(50) NOT NULL,
	[CoverageType] VARCHAR(50) NOT NULL,
	[Total] INT NOT NULL
	)