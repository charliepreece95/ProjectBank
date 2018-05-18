CREATE PROCEDURE [dbo].[sproc_tblStaff_FiterByStaffNo]
--paramrter to stroe the staff no we are looking for
	@StaffNo int
AS
--select all fields from the table where the staff no matches the parameter data
	SELECT * from tblStaff WHERE StaffNo = @StaffNo

RETURN 0