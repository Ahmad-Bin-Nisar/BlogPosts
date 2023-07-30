USE [BlogDB]
GO
/****** Object:  StoredProcedure [dbo].[InsertComment]    Script Date: 31/07/2023 12:32:15 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[InsertComment]
    @Id int,
	@PId int,
	@Comment varchar(500)

AS
BEGIN
    INSERT INTO [Comments](Id,PostId,Comment)
	  VALUES (@Id,@PId,@Comment)

END