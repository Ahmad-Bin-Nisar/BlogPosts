USE [BlogDB]
GO
/****** Object:  StoredProcedure [dbo].[InsertUser]    Script Date: 31/07/2023 12:32:51 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[InsertUser]
     @firstname varchar(30),
	 @lastname varchar(30),
	 @Email varchar(30),

	 @PKID int = 0 output
AS
BEGIN
  INSERT INTO [Users](FirstName,LastName, Email)
     VALUES (@firstname,@lastname,@Email)

	 SET @PKID = @@IDENTITY

	 SELECT @PKID AS PKID
END
