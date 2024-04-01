Create table Jobs
(
 Id INT IDENTITY(1,1) PRIMARY KEY,
 CompanyId INT FOREIGN KEY REFERENCES Employer(Id),
 NameJob varchar(50) ,
 PositionNeeded varchar(50),
 CompanyName varchar(50),
 Salary varchar(50),
 Address varchar(50),
 PostingTime varchar(50),
 NumberOfRecruit varchar(50)
);
go
INSERT INTO Jobs (CompanyId, NameJob, Password) VALUES ('Toan', 'vancongtoan09102004@gmail.com', '1234');
INSERT INTO Jobs (Name, Gmail, Password) VALUES ('Tuyen', 'tuyenbest1234@gmail.com', '1234');
INSERT INTO Jobs (Name, Gmail, Password) VALUES ('Toan', 'trungnghien@gmail.com', '1234');
go
select *from Employers;