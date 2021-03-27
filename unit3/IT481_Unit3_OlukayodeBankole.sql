Use Northwind

/* create role */ 
CREATE ROLE SalesRole;
CREATE ROLE HRRole;
CREATE ROLE CEORole; 

/* Modify role access */ 
GRANT SELECT ON dbo.Orders TO SalesRole;
GRANT SELECT ON dbo.Employees TO HRRole;
GRANT SELECT ON dbo Orders TO CEORole; 
GRANT SELECT ON dbo.customers TO CEORole;
GRANT SELECT ON dbo.Employees TO CEORole;

/* Create users */ 
Create user User_Sales; 
Create user User_HR; 
Create user User_CEO; 
CREATE LOGIN User_CEO WITH PASSWORD '123'; 
CREATE LOGIN User_HR WITH PASSWORD '1234'; 
CREATE LOGIN User_Sales WITH PASSWORD '12345';
 
/* Assign user roles */
Exec sp_addrolemember 'SalesRole', 'User_Sales'; 
Exec sp_addrolemember 'HRRole', 'User_HR'; 
Exec sp_addrolemember 'CEORole', 'User_CE0'; 

