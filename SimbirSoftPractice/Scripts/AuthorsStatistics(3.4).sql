use [LibraryDB]
go

--Статистика Авторов
select a.first_name, g.genre_name, count(b.name) books from author a join book b on b.author_id = a.id
join book_genre bg on bg.book_id = b.id
join genre g on g.id = bg.genre_id
group by a.first_name, g.genre_name