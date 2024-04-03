Create table JobApplication
(
 Id INT IDENTITY(1,1) PRIMARY KEY,
 UserId INT FOREIGN KEY REFERENCES Candidates(Id),
 JobId INT FOREIGN KEY REFERENCES Jobs(Id),
 CompanyId INT FOREIGN KEY REFERENCES Employers(Id),
 Status INT DEFAULT 0
);
go
INSERT JobApplication(UserId,JobId,CompanyId,Status) VALUES(3,1,1,0)
select *from JobApplication;
