USE [BlogDB]
GO

/****** Object:  Table [dbo].[Categories]    Script Date: 31/07/2023 12:33:19 am ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Categories](
	[PostId] [int] NOT NULL,
	[Category] [varchar](30) NOT NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Categories]  WITH CHECK ADD  CONSTRAINT [FK_Categories_Posts] FOREIGN KEY([PostId])
REFERENCES [dbo].[Posts] ([PostId])
GO

ALTER TABLE [dbo].[Categories] CHECK CONSTRAINT [FK_Categories_Posts]
GO


