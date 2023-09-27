CREATE DATABASE VacineApplicantDB;

Use VacineApplicantDB
CREATE TABLE tblApplicants(
	ApplicantID INT PRIMARY KEY not null,
	FirstName varchar(50),
	LastName varchar(50),
	IDNumber varchar(13),
	Phone varchar(13)
	);
Go


Use VacineApplicantDB
INSERT INTO tblApplicants 
VALUES 
(1,'Kagiso','Kgobane','0210195554868','0605551234'),
(2,'Kabelo','Kgobane','9501053440768','0123456789'),
(3,'Katlego','Kgobane','911121545067','0112543698'),
(4,'Mick','Byers','8703194564021','0825554978'),
(5,'Jason','Todd','5502055264086','0716548890');


CREATE PROCEDURE spGetApplicants
AS
BEGIN
	SELECT * FROM tblApplicants
END

EXECUTE spGetApplicants

CREATE PROCEDURE spAddApplicant(
	@Id INT,
	@Name varchar(50),
	@Surname varchar(50),
	@IDnum varchar(13),
	@Phone varchar(10)
)
AS
BEGIN
	INSERT INTO tblApplicants
	VALUES (@Id,@Name,@Surname,@IDnum,@Phone)
END

CREATE PROCEDURE spUpdateApplicant(
	@Id INT,
	@Name varchar(50),
	@Surname varchar(50),
	@IDnum varchar(13),
	@Phone varchar(10)
)
AS
BEGIN
	UPDATE tblApplicants
	SET ApplicantId = @Id, FirstName = @Name, LastName = @Surname, IDNumber = @IDnum, Phone = @Phone
	WHERE ApplicantId = @Id
END

CREATE PROCEDURE spSearchApplicants(
@Id INT
)
AS
BEGIN
	SELECT * FROM tblApplicants WHERE ApplicantId = @Id
END

CREATE PROCEDURE spDeleteApplicants(
@Id INT
)
AS
BEGIN
	DELETE FROM tblApplicants WHERE ApplicantId = @Id
END