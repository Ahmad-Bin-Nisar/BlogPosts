USE [BlogDB]
GO
/****** Object:  StoredProcedure [dbo].[DeleteComment]    Script Date: 31/07/2023 12:29:50 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[DeleteComment]
    @Id int,
	@PId int

AS
BEGIN
    DELETE FROM Comments WHERE PostId = @PId AND Id = @Id
END