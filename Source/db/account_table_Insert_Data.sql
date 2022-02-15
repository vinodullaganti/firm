/****** Script to insert data into AccountMaster table ******/

USE [Firm]
GO

INSERT INTO [dbo].[AccountMaster]
           ([Account_ID]
           ,[Name]
           ,[Description]
           ,[Company_logo]
           ,[Planned_Start_Date]
           ,[Planned_End_Date]
           ,[Actual_Start_Date]
           ,[Actual_End_Date]
           ,[Primary_Contact_Name]
           ,[Primary_contact_Email]
           ,[Secondary_Contact_Name]
           ,[Secondary_Contact_Email]
           ,[Address_1]
           ,[Address_2]
           ,[City]
           ,[State]
           ,[Country]
           ,[Region]
           ,[Type]
           ,[isActive]
           ,[Flag]
           ,[Status]
           ,[Comments]
           ,[Created]
           ,[last_modified])
     VALUES
           ('F11'
           ,'Feuji'
           ,'Feuji Internal'
           ,null
           ,'2019-12-01'
           ,'2200-12-01'
           ,'2019-12-01'
           ,'2019-12-01'
           ,'HR'
           ,'hr@feuji.com'
           ,'HR@'
           ,'hr2@feuji.com'
           ,'Hitect City'	
           ,'Madhapur'
           ,'Hyderabad'
           ,'Telangana'
           ,'India'
           ,'South'
           ,'Testing'
           ,1
           ,1
           ,'Active'
           ,'Sample Comments'
           ,getdate()
           ,getdate())
GO