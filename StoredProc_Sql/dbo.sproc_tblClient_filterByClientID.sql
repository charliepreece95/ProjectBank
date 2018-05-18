CREATE PROCEDURE [dbo].[sproc_tblClient_filterByClientID]
	--parameter to store the client no we are looking for 
	@ClientNo int 
AS
	--selecting all fields from the table where the client no matches the parameter data 

	SELECT* from tblClient where  ClientNo = @ClientNo

RETURN 0