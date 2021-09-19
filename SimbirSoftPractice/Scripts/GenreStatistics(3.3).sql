use [LibraryDB]
go

--Статистика Жанров
select g.genre_name, count(b.name) as 'Number of books' from genre g full outer join book_genre bg on bg.genre_id = g.id
full outer join book b on b.id = bg.book_id
group by g.genre_name