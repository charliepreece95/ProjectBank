CREATE PROCEDURE sproc_tblStaff_Insert
--create parametrs for the stored proc
--@StaffNo int,
@FirstName varchar (20),
@LastName varchar (20),
@Email varchar (50),
@Position varchar (15),
@TeleNo varchar (15)

AS

--insert the new record
INSERT INTO tblStaff (FirstName, LastName, Email, Position, TeleNo)
values (@FirstName, @LastName, @Email, @Position, @TeleNo)

--return the primary key of the new record
return @@Identity