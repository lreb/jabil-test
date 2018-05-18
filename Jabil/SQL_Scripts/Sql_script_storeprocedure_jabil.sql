USE Jabil;  
GO  
CREATE PROCEDURE MainReport  
AS   

    SET NOCOUNT ON;  
	SELECT * FROM PartNumbers pn 
	LEFT OUTER JOIN Customers c ON pn.FKCustomer = c.PKCustomers
	LEFT OUTER JOIN Buildings b ON c.FKBuilding  = b.PKBuilding;
GO  

exec MainReport