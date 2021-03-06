﻿
-- DROP DATABASE Jabil;

create database Jabil;
use Jabil;

create table Buildings(
	PKBuilding int IDENTITY(1,1) PRIMARY KEY, 
	Building nvarchar(100) NOT NULL
);

INSERT INTO Buildings(Building) VALUES ('Building A');
INSERT INTO Buildings(Building) VALUES ('Building B');
INSERT INTO Buildings(Building) VALUES ('Building C');
INSERT INTO Buildings(Building) VALUES ('Building D');
INSERT INTO Buildings(Building) VALUES ('Building E');

create table Customers(
	PKCustomers int IDENTITY(1,1) PRIMARY KEY, 
	Customer nvarchar(100) NOT NULL,
	Prefix nvarchar(5) NOT NULL,
	FKBuilding int FOREIGN KEY REFERENCES Buildings(PKBuilding)
);

INSERT INTO Customers(Customer,Prefix,FKBuilding) VALUES ('John Mattensen','Mr',1);
INSERT INTO Customers(Customer,Prefix,FKBuilding) VALUES ('Brat Losan','Mr',1);
INSERT INTO Customers(Customer,Prefix,FKBuilding) VALUES ('John Mattensen','Mr',2);
INSERT INTO Customers(Customer,Prefix,FKBuilding) VALUES ('Jessica Math','Eng',3);

create table PartNumbers(
	PKPartNumber int IDENTITY(1,1) PRIMARY KEY, 
	PartNumber nvarchar(50) NOT NULL,	
	FKCustomer int FOREIGN KEY REFERENCES Customers(PKCustomers),
	Available bit NOT NULL
);

INSERT INTO PartNumbers(PartNumber,FKCustomer,Available) VALUES ('ABC123',1,1);
INSERT INTO PartNumbers(PartNumber,FKCustomer,Available) VALUES ('AB12C3',2,0);
INSERT INTO PartNumbers(PartNumber,FKCustomer,Available) VALUES ('1A2B3C',3,0);
INSERT INTO PartNumbers(PartNumber,FKCustomer,Available) VALUES ('123ABC',4,1);
INSERT INTO PartNumbers(PartNumber,FKCustomer,Available) VALUES ('321ABC',4,1);
