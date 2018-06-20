CREATE DATABASE userRecords;
USE userRecords;

CREATE TABLE Users (
	IdUser INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Name VARCHAR(50) NULL,
	LastName VARCHAR(50) NULL,
	UserName VARCHAR(50) NULL,
	Email VARCHAR(50) NULL,
	Password VARCHAR(50) NULL
);

INSERT INTO Users(Name, LastName, UserName, Email, Password) VALUES ('Felix', 'Mendez', 'fmendez', 'fmendez@gmail.com', '123');
SELECT * FROM Users;