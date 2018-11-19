IF OBJECT_ID('sp_AddCustomers','P') IS NOT NULL
DROP PROC sp_AddCustomers
GO
CREATE PROC sp_AddCustomers 
	@customerID varchar(50),@companyName varchar(50),
	@contactName varchar(50),@contactTitle varchar(50),
	@address varchar(50),@city varchar(50),@region varchar(50),
	@postalCode varchar(50),@country varchar(50),
	@phone varchar(50),@fax varchar(50)
AS
BEGIN
	IF EXISTS(SELECT*FROM Customers cs WHERE cs.CustomerID=@customerID)
		RETURN 0
	ELSE
	INSERT INTO Customers VALUES(@customerID,@companyName,@contactName,@contactTitle,@address,@city,@region,@postalCode,@country,@phone,@fax)
END
go
IF OBJECT_ID('sp_DeleteCustomers','P') IS NOT NULL
DROP PROC sp_DeleteCustomers
GO
CREATE PROC sp_DeleteCustomers @customerID varchar(50)
AS
BEGIN
	IF NOT EXISTS(SELECT * FROM Customers WHERE @customerID=CustomerID)
		RETURN 0
	ELSE
		DELETE FROM Customers WHERE @customerID=CustomerID
END
GO
IF OBJECT_ID('sp_UpdateCustomers','P') IS NOT NULL
DROP PROC sp_UpdateCustomers
GO
CREATE PROC sp_UpdateCustomers 
	@customerID varchar(50),@companyName varchar(50),
	@contactName varchar(50),@contactTitle varchar(50),
	@address varchar(50),@city varchar(50),@region varchar(50),
	@postalCode varchar(50),@country varchar(50),
	@phone varchar(50),@fax varchar(50)
AS
	BEGIN
		IF NOT EXISTS(SELECT*FROM Customers cs WHERE cs.CustomerID=@customerID)
			RETURN 0
		ELSE
			UPDATE Customers SET
						CompanyName = @companyName,
						ContactName = @contactName,
						ContactTitle = @contactTitle,
						Address = @address,
						City = @city,
						Region = @region,
						PostalCode = @postalCode,
						Country = @country,
						Phone = @phone,
						Fax = @fax
			WHERE
			CustomerID=@customerID		
	END
go
IF OBJECT_ID('sp_FindID','P') IS NOT NULL
DROP PROC sp_FindID
GO
CREATE PROC sp_FindID @customerID varchar(50)
as
BEGIN
	SELECT *FROM Customers WHERE CustomerID LIKE '%'+@customerID+'%'
END
GO
IF OBJECT_ID('sp_FindName','P') IS NOT NULL
DROP PROC sp_FindName
GO
CREATE PROC sp_FindName @companyName varchar(50)
as
BEGIN
	SELECT *FROM Customers WHERE CompanyName LIKE '%'+@companyName+'%'
END