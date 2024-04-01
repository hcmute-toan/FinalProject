Create table Candidates
(
 Id INT IDENTITY(1,1) PRIMARY KEY,
 Name Nvarchar(50) ,
 Gmail varchar(50),
 Password varchar(50)
);
go
INSERT INTO Candidates (Name, Gmail, Password) VALUES ('Toan', 'vancongtoan09102004@gmail.com', '1234');
INSERT INTO Candidates (Name, Gmail, Password) VALUES ('Tuyen', 'tuyenbest1234@gmail.com', '1234');
INSERT INTO Candidates (Name, Gmail, Password) VALUES ('Toan', 'trungnghien@gmail.com', '1234');
go
select *from Candidates;

Create table Candidates
(
 Id INT IDENTITY(1,1) PRIMARY KEY,
 Name Nvarchar(50) ,
 Gmail varchar(50),
 Password varchar(50)
);
go
INSERT INTO Candidates (Name, Gmail, Password) VALUES ('Toan', 'vancongtoan09102004@gmail.com', '1234');
INSERT INTO Candidates (Name, Gmail, Password) VALUES ('Tuyen', 'tuyenbest1234@gmail.com', '1234');
INSERT INTO Candidates (Name, Gmail, Password) VALUES ('Toan', 'trungnghien@gmail.com', '1234');
go
select *from Candidates;

Create table CV
(
 Id INT IDENTITY(1,1) PRIMARY KEY,
 UserId INT FOREIGN KEY REFERENCES Candidates(Id),
 Name varchar(50) ,
 Gender VARCHAR (10) ,
 Address varchar(50),
 DateOfBirth  varchar(50) ,
 WorkExperience varchar(255),
 EducationAndCertifications varchar(255),
 ProfessionalSkills varchar(255),
 GoalsAtWork varchar(255)
);
go
INSERT INTO CV (UserId, Name, Gender,Address,DateOfBirth,WorkExperience,EducationAndCertifications,ProfessionalSkills,GoalsAtWork) VALUES (1, 'VanCongToan','Male','TpHCM','09/10/2024','Fresher','Graduated from UTE','WEB programming','Become a boss');
INSERT INTO CV (UserId, Name, Gender,Address,DateOfBirth,WorkExperience,EducationAndCertifications,ProfessionalSkills,GoalsAtWork) VALUES (2, 'TranVanTuyen','Male','TpHCM','30/10/2024','Fresher','Graduated from UTE','WEB programming','Become a boss');
INSERT INTO CV (UserId, Name, Gender,Address,DateOfBirth,WorkExperience,EducationAndCertifications,ProfessionalSkills,GoalsAtWork) VALUES (3, 'PhanDinhTrung','Male','TpHCM','14/02/2024','Fresher','Graduated from UTE','WEB programming','Become a boss');
go
select *from CV;

Create table Jobs
(
 Id INT IDENTITY(1,1) PRIMARY KEY,
 CompanyId varchar(50),
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
INSERT INTO Jobs (CompanyId, NameJob, PositionNeeded,CompanyName,Salary,Address,PostingTime,NumberOfRecruit,Contact) VALUES ('1', 'laocong','Middle','TamToanPhat','thuongluong','Quan Thu Duc , HCM','19/03/2024','5','vancongtoan09102004@gmail.com');
INSERT INTO Jobs (CompanyId, NameJob, PositionNeeded,CompanyName,Salary,Address,PostingTime,NumberOfRecruit,Contact) VALUES ('2', 'laocong','Middle','lalala123','thuongluong','Quan Thu Duc , HCM','19/03/2024','5','vancongtoan09102004@gmail.com');
INSERT INTO Jobs (CompanyId, NameJob, PositionNeeded,CompanyName,Salary,Address,PostingTime,NumberOfRecruit,Contact) VALUES ('1' , 'nhanvein','Middle','lalala123','thuongluong','Quan Thu Duc , HCM','19/03/2024','5','vancongtoan09102004@gmail.com');
INSERT INTO Jobs (CompanyId, NameJob, PositionNeeded,CompanyName,Salary,Address,PostingTime,NumberOfRecruit,Contact) VALUES ('1', 'Manager','Middle','lalala123','thuongluong','Quan Thu Duc , HCM','19/03/2024','5','vancongtoan09102004@gmail.com');
INSERT INTO Jobs (CompanyId, NameJob, PositionNeeded,CompanyName,Salary,Address,PostingTime,NumberOfRecruit,Contact) VALUES ('1', 'nhanvein','Middle','TamToanPhat','thuongluong','Quan Thu Duc , HCM','19/03/2024','5','vancongtoan09102004@gmail.com');
INSERT INTO Jobs (CompanyId, NameJob, PositionNeeded,CompanyName,Salary,Address,PostingTime,NumberOfRecruit,Contact) VALUES ('1', 'laocong','Middle','lalala123','thuongluong','Quan Thu Duc , HCM','19/03/2024','5','vancongtoan09102004@gmail.com');
INSERT INTO Jobs (CompanyId, NameJob, PositionNeeded,CompanyName,Salary,Address,PostingTime,NumberOfRecruit,Contact) VALUES ('1', 'laocong','Middle','TamToanPhat','thuongluong','Quan Thu Duc , HCM','19/03/2024','5','vancongtoan09102004@gmail.com');
INSERT INTO Jobs (CompanyId, NameJob, PositionNeeded,CompanyName,Salary,Address,PostingTime,NumberOfRecruit,Contact) VALUES ('1', 'nhanvein','Middle','lalala123','thuongluong','Quan Thu Duc , HCM','19/03/2024','5','vancongtoan09102004@gmail.com');
INSERT INTO Jobs (CompanyId, NameJob, PositionNeeded,CompanyName,Salary,Address,PostingTime,NumberOfRecruit,Contact) VALUES ('1', 'laocong','Middle','TamToanPhat','thuongluong','Quan Thu Duc , HCM','19/03/2024','5','vancongtoan09102004@gmail.com');
INSERT INTO Jobs (CompanyId, NameJob, PositionNeeded,CompanyName,Salary,Address,PostingTime,NumberOfRecruit,Contact) VALUES ('1', 'nhanvein','Middle','lalala123','thuongluong','Quan Thu Duc , HCM','19/03/2024','5','vancongtoan09102004@gmail.com');

go
select *from Jobs;