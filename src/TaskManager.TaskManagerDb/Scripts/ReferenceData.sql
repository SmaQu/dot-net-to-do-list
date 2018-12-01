/*
 Pre-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be executed before the build script.	
 Use SQLCMD syntax to include a file in the pre-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the pre-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

-- Status table --
if not exists(select * from dbo.Status where Name = 'Not Started')
    insert into dbo.Status(Name, Ordinal) values(N'Not Started', 0);

if not exists(select * from dbo.Status where Name = 'In Progress')
    insert into dbo.Status(Name, Ordinal) values(N'In Progress', 1);

if not exists(select * from dbo.Status where Name = 'Completed')
    insert into dbo.Status(Name, Ordinal) values(N'Completed', 2);