USE [BlogDB]
GO
/****** Object:  StoredProcedure [dbo].[GetAllPosts]    Script Date: 31/07/2023 12:31:00 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[GetAllPosts]
as
BEGIN
SELECT Post FROM Posts;
END
EXEC GetAllPosts