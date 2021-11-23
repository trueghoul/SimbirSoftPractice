use [LibraryDB]
go

--Получить список книг автора, @author_id - id автора
declare @author_id int;

set @author_id = 1;

select a.first_name, a.last_name, b.name as 'book name', STRING_AGG(g.genre_name, ', ') genres 
from author a join book b on b.author_id = a.id
join book_genre bg on bg.book_id = b.id
join genre g on g.id = bg.genre_id
where a.id = @author_id
group by a.first_name, a.last_name, b.name