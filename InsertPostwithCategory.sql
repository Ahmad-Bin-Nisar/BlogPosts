USE [BlogDB]
GO
/****** Object:  StoredProcedure [dbo].[InsertPostwithCategory]    Script Date: 31/07/2023 12:32:34 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[InsertPostwithCategory]
    @Id int,
	@Post varchar(1000),
	@Category varchar(30),

	@PKPID int output

AS
BEGIN
    INSERT INTO [Posts](Id,Post)
	  VALUES (@Id,@Post)
      
	  SET @PKPID = @@IDENTITY

	  INSERT INTO [Categories](PostId,Category)
	   VALUES (@PKPID,@Category)

	  SELECT @PKPID AS PKPID
END