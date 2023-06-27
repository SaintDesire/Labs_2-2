use master
go 
CREATE DATABASE BankDatabase 
ON PRIMARY
(NAME = BankData1, FILENAME = 'C:\Users\Admin\Desktop\labs\labs 2_2\ад\Lab3\BankData1.ndf', SIZE = 10MB, MAXSIZE = UNLIMITED, FILEGROWTH = 10%),
FILEGROUP FG_DATA1
(NAME = BankData2, FILENAME = 'C:\Users\Admin\Desktop\labs\labs 2_2\ад\Lab3\BankData2.ndf', SIZE = 10MB, MAXSIZE = UNLIMITED, FILEGROWTH = 10%),
FILEGROUP FG_DATA2
(NAME = BankData3, FILENAME = 'C:\Users\Admin\Desktop\labs\labs 2_2\ад\Lab3\BankData3.ndf', SIZE = 10MB, MAXSIZE = UNLIMITED, FILEGROWTH = 10%),
FILEGROUP FG_DATA3
(NAME = BankData4, FILENAME = 'C:\Users\Admin\Desktop\labs\labs 2_2\ад\Lab3\BankData4.ndf', SIZE = 10MB, MAXSIZE = UNLIMITED, FILEGROWTH = 10%),
FILEGROUP FG_DATA4
(NAME = BankData5, FILENAME = 'C:\Users\Admin\Desktop\labs\labs 2_2\ад\Lab3\BankData5.ndf', SIZE = 10MB, MAXSIZE = UNLIMITED, FILEGROWTH = 10%)
LOG ON 
(NAME = BankLog, FILENAME = 'C:\Users\Admin\Desktop\labs\labs 2_2\ад\Lab3\BankLog.ldf', SIZE = 1MB, MAXSIZE = UNLIMITED, FILEGROWTH = 10%);



USE BankDatabase;
GO

CREATE TABLE Clients (
    ID_Client int PRIMARY KEY,
    CompanyName varchar(100),
    Address varchar(100),
    Phone varchar(20)
) ON FG_DATA1;
GO


CREATE TABLE Loans (
    ID_Loan int PRIMARY KEY,
    ID_LoanType int,
    InterestRate decimal(10,2),
    Amount decimal(18,2),
    LoanDate date,
    ReturnDate date,
    ID_Client int,
    ID_OwnershipType int
) ON FG_DATA2;

ALTER TABLE Loans
ADD CONSTRAINT FK_Loans_Clients FOREIGN KEY (ID_Client)
REFERENCES Clients(ID_Client);

ALTER TABLE Loans
ADD CONSTRAINT FK_Loans_LoanTypes 
FOREIGN KEY (ID_LoanType) 
REFERENCES LoanTypes(LoanTypeID);

ALTER TABLE Loans
ADD CONSTRAINT FK_Loans_Ownership 
FOREIGN KEY (ID_OwnershipType) 
REFERENCES Ownership(OwnershipID);


CREATE TABLE Ownership (
    OwnershipID int PRIMARY KEY,
    OwnershipType varchar(50)
) ON FG_DATA3;

CREATE TABLE LoanTypes (
    LoanTypeID int PRIMARY KEY,
    LoanTypeName varchar(50)
) ON FG_DATA4;


INSERT INTO Clients (ID_Client, CompanyName, Address, Phone)
VALUES 
(1, 'ABC Inc.', '123 Main St, Anytown USA', '+1 (555) 123-4567'),
(2, 'XYZ Corp.', '456 Elm St, Anytown USA', '+1 (555) 987-6543'),
(3, '123 Co.', '789 Oak St, Anytown USA', '+1 (555) 555-1212');

INSERT INTO Loans (ID_Loan, ID_LoanType, InterestRate, Amount, LoanDate, ReturnDate, ID_Client, ID_OwnershipType)
VALUES 
(1, 1, 5.25, 10000.00, '2022-01-01', '2023-01-01', 1, 1),
(2, 2, 6.50, 5000.00, '2022-02-01', '2022-08-01', 2, 2),
(3, 3, 4.75, 7500.00, '2022-03-01', '2022-09-01', 3, 1),
(4, 2, 7.25, 15000.00, '2022-04-01', '2023-04-01', 1, 2),
(5, 1, 6.00, 2500.00, '2022-05-01', '2022-11-01', 2, 1);

INSERT INTO Ownership (OwnershipID, OwnershipType)
VALUES 
(1, 'Real Estate'),
(2, 'Automobile'),
(3, 'Jewelry');

INSERT INTO LoanTypes (LoanTypeID, LoanTypeName)
VALUES 
(1, 'Personal Loan'),
(2, 'Auto Loan'),
(3, 'Business Loan');


SELECT c.CompanyName, l.Amount, l.InterestRate
FROM Clients c
INNER JOIN Loans l ON c.ID_Client = l.ID_Client
WHERE l.Amount > 7000 AND l.InterestRate > 5;
