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