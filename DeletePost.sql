USE [BlogDB]
GO
/****** Object:  StoredProcedure [dbo].[DeletePost]    Script Date: 31/07/2023 12:30:24 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[DeletePost]
    @PId int

AS
BEGIN
    DELETE FROM Categories WHERE PostId = @PId
	DELETE FROM Posts WHERE PostId = @PId
	DELETE FROM Comments WHERE PostId = @PId
END

