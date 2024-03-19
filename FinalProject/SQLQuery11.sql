Create table Jobs
(
 Id INT IDENTITY(1,1) PRIMARY KEY,
 CompanyId INT FOREIGN KEY REFERENCES Employers(Id),
 NameJob varchar(50) ,
 PositionNeeded varchar(50),
 CompanyName varchar(50),
 Salary varchar(50),
 Address varchar(50),
 PostingTime varchar(50),
 NumberOfRecruit varchar(50),
 Contact varchar(50)
);
go
INSERT INTO Jobs (CompanyId, NameJob, PositionNeeded,CompanyName,Salary,Address,PostingTime,NumberOfRecruit,Contact) VALUES (1, 'Manager','Middle','TamToanPhat','thuongluong','Quan Thu Duc , HCM','19/03/2024','5','vancongtoan09102004@gmail.com');
INSERT INTO Jobs (CompanyId, NameJob, PositionNeeded,CompanyName,Salary,Address,PostingTime,NumberOfRecruit,Contact) VALUES (2, 'Manager','Middle','TamToanPhat','thuongluong','Quan Thu Duc , HCM','19/03/2024','5','vancongtoan09102004@gmail.com');
INSERT INTO Jobs (CompanyId, NameJob, PositionNeeded,CompanyName,Salary,Address,PostingTime,NumberOfRecruit,Contact) VALUES (3, 'Manager','Middle','TamToanPhat','thuongluong','Quan Thu Duc , HCM','19/03/2024','5','vancongtoan09102004@gmail.com');
go
select *from Jobs;