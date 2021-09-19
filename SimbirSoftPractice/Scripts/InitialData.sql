USE [LibraryDB]
GO

INSERT INTO [dbo].[person]
           ([id]
           ,[birh_date]
           ,[first_name]
           ,[last_name]
           ,[middle_name])
     VALUES
           (1,'2000-11-27','Ivan','Efimov', 'Anatol'),
		   (2,'1993-10-13','Semen','Cho', 'En'),
		   (3,'1992-09-22','Danya','Proger', 'El'),
		   (4,'1085-08-21','Kirill','Ryabov', 'Doter');
GO

INSERT INTO [dbo].[author]
           ([id]
           ,[first_name]
           ,[last_name]
           ,[middle_name])
     VALUES
			(1,'Ivan','Efimov', 'Anatol'),
			(2,'Sui','Isida', 'Mmm');
GO

INSERT INTO [dbo].[book]
           ([id]
           ,[name]
           ,[author_id])
     VALUES
		   (1, 'C# senior', 1),
           (2, 'Tokyo Ghoul', 2),
		   (3, 'Tokyo Ghoul:re', 2);

GO

INSERT INTO [dbo].[genre]
           ([id]
           ,[genre_name])
     VALUES
           (1, 'thriller'),
		   (2, 'fantasy'),
		   (3, 'drama'),
		   (4, 'horror');
GO

INSERT INTO [dbo].[book_genre]
           ([book_id]
           ,[genre_id])
     VALUES
           (1, 2),
		   (1, 3),
		   (2, 1),
		   (2, 2),
		   (3, 1),
		   (3, 2);
GO

INSERT INTO [dbo].[library_card]
           ([book_id]
           ,[person_id])
     VALUES
           (2, 1),
		   (3, 1),
		   (1, 3),
		   (2, 2);
GO
