USE Jabil;  
GO  
CREATE PROCEDURE MainReport 
    /*@LastName nvarchar(50),   
    @FirstName nvarchar(50)*/   
AS   

    SET NOCOUNT ON;  
	SELECT * FROM PartNumbers pn 
	LEFT OUTER JOIN Customers c ON pn.FKCustomer = c.PKCustomers
	LEFT OUTER JOIN Buildings b ON c.FKBuilding  = b.PKBuilding;
GO  

exec MainReport