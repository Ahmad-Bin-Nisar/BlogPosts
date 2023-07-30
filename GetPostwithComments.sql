USE [BlogDB]
GO
/****** Object:  StoredProcedure [dbo].[GetPostwithComments]    Script Date: 31/07/2023 12:32:00 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[GetPostwithComments]
    @PId int

AS
BEGIN
   SELECT * FROM Posts WHERE PostId = @PId;
   SELECT * FROM Comments WHERE PostId = @PId;
END