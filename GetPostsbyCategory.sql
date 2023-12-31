USE [BlogDB]
GO
/****** Object:  StoredProcedure [dbo].[GetPostsbyCategory]    Script Date: 31/07/2023 12:31:21 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[GetPostsbyCategory]
    @Category varchar(30),

	@PKPID int output

AS
BEGIN
   SELECT * FROM Categories WHERE Category = @Category;
   SET @PKPID = @@IDENTITY
   SELECT * FROM Posts WHERE PostId = @PKPID
END