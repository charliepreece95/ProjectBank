CREATE PROCEDURE [dbo]. sproc_tblStaff_Delete
--this stored proc is situated in the data layer (App_Data folder)

--this stored proc is used to delete a single record in the table tblStaff
-- it accepts a single parameter @StaffNo and returns no value

	--declare the paameter
	@StaffNo int
AS

	--delete the record in tblStaff specified by the value of @StaffNo
	delete from tblStaff where StaffNo = @StaffNo;