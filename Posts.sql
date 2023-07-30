USE [BlogDB]
GO

/****** Object:  Table [dbo].[Posts]    Script Date: 31/07/2023 12:34:15 am ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Posts](
	[Id] [int] NOT NULL,
	[PostId] [int] IDENTITY(1,1) NOT NULL,
	[Post] [varchar](1000) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PostId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Posts]  WITH CHECK ADD  CONSTRAINT [FK_Posts_Users] FOREIGN KEY([Id])
REFERENCES [dbo].[Users] ([Id])
GO

ALTER TABLE [dbo].[Posts] CHECK CONSTRAINT [FK_Posts_Users]
GO

