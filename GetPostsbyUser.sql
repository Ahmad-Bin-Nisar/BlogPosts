USE [BlogDB]
GO
/****** Object:  StoredProcedure [dbo].[GetPostsbyUser]    Script Date: 31/07/2023 12:31:44 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[GetPostsbyUser]
    @Id int

AS
BEGIN
   SELECT * FROM Posts WHERE Id = @Id;
END