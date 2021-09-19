CREATE DATABASE [LibraryDB]
go

use [LibraryDB]
go

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[person](
	[id] [int] NOT NULL,
	[birh_date] [date] NOT NULL,
	[first_name] [nvarchar](50) NULL,
	[last_name] [nvarchar](50) NULL,
	[middle_name] [nchar](10) NOT NULL,
 CONSTRAINT [PK_person] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[author](
	[id] [int] NOT NULL,
	[first_name] [nvarchar](50) NOT NULL,
	[last_name] [nvarchar](50) NOT NULL,
	[middle_name] [nchar](10) NULL,
 CONSTRAINT [PK_author] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[genre](
	[id] [int] NOT NULL,
	[genre_name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_genre] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


CREATE TABLE [dbo].[book](
	[id] [int] NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[author_id] [int] NOT NULL,
 CONSTRAINT [PK_book] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[book]  WITH CHECK ADD  CONSTRAINT [FK_book_author] FOREIGN KEY([author_id])
REFERENCES [dbo].[author] ([id])
GO

ALTER TABLE [dbo].[book] CHECK CONSTRAINT [FK_book_author]
GO

CREATE TABLE [dbo].[book_genre](
	[book_id] [int] NOT NULL,
	[genre_id] [int] NOT NULL,
 CONSTRAINT [PK_book_genre] PRIMARY KEY CLUSTERED 
(
	[book_id] ASC,
	[genre_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[book_genre]  WITH CHECK ADD  CONSTRAINT [FK_book_genre_book] FOREIGN KEY([book_id])
REFERENCES [dbo].[book] ([id])
GO

ALTER TABLE [dbo].[book_genre] CHECK CONSTRAINT [FK_book_genre_book]
GO

ALTER TABLE [dbo].[book_genre]  WITH CHECK ADD  CONSTRAINT [FK_book_genre_genre] FOREIGN KEY([genre_id])
REFERENCES [dbo].[genre] ([id])
GO

ALTER TABLE [dbo].[book_genre] CHECK CONSTRAINT [FK_book_genre_genre]
GO

CREATE TABLE [dbo].[library_card](
	[book_id] [int] NOT NULL,
	[person_id] [int] NOT NULL,
 CONSTRAINT [PK_library_card] PRIMARY KEY CLUSTERED 
(
	[book_id] ASC,
	[person_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[library_card]  WITH CHECK ADD  CONSTRAINT [FK_library_card_book] FOREIGN KEY([book_id])
REFERENCES [dbo].[book] ([id])
GO

ALTER TABLE [dbo].[library_card] CHECK CONSTRAINT [FK_library_card_book]
GO

ALTER TABLE [dbo].[library_card]  WITH CHECK ADD  CONSTRAINT [FK_library_card_person] FOREIGN KEY([person_id])
REFERENCES [dbo].[person] ([id])
GO

ALTER TABLE [dbo].[library_card] CHECK CONSTRAINT [FK_library_card_person]
GO
