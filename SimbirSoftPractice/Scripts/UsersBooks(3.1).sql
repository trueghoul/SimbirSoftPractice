use [LibraryDB]
go

--Получить все взятые книги пользователя, @person_id - id пользователя
declare @person_id int;

set @person_id = 1;

select b.name 'book name',  CONCAT(a.first_name,' ', a.last_name) author, STRING_AGG(g.genre_name, ', ') genres from 
library_card lb join book b on b.id = lb.book_id
join author a on b.author_id = a.id
join book_genre bg on b.id = bg.book_id
join genre g on g.id = bg.genre_id
where lb.person_id = @person_id
group by b.name, a.first_name, a.last_name