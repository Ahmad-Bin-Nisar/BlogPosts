USE [BlogDB]
GO
/****** Object:  StoredProcedure [dbo].[DeleteUser]    Script Date: 31/07/2023 12:30:42 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[DeleteUser]
    @Id int

AS
BEGIN
    DELETE FROM Users WHERE Id = @Id
END