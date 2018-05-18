CREATE PROCEDURE [dbo].[sproc_tblCompany_SelectAll]
	--parameter to store the client no we are looking for 
	@CompanyNo int 
AS
	--selecting all fields from the table where the client no matches the parameter data 

	SELECT * 
	from tblCompany
    where  CompanyID = @CompanyNo;

RETURN 0