Create table Employers
(
 Id INT IDENTITY(1,1) PRIMARY KEY,
 Name Nvarchar(50) ,
 Gmail varchar(50),
 Password varchar(50)
);
go
INSERT INTO Employers (Name, Gmail, Password) VALUES ('Toan', 'vancongtoan09102004@gmail.com', '1234');
INSERT INTO Employers (Name, Gmail, Password) VALUES ('Tuyen', 'tuyenbest1234@gmail.com', '1234');
INSERT INTO Employers (Name, Gmail, Password) VALUES ('Toan', 'trungnghien@gmail.com', '1234');
go
select *from Employers;