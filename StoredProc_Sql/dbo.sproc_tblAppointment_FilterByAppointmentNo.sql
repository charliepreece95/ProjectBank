CREATE PROCEDURE sproc_tblAppointment_FilterByAppointmentNo

@AppointmentNo int

AS

Select * from tblAppointment where AppointmentNo = @AppointmentNo

RETURN 0