use UNIVER;

-- A ---
set transaction isolation level READ COMMITTED
begin transaction
select count(*) from STUDENT where NAME LIKE 'J%';
-------------------------- t1 ------------------
-------------------------- t2 -----------------
select 'update Orders' 'result', count(*)
from STUDENT where NAME LIKE 'J%';
commit;

--- B ---
begin transaction
-------------------------- t1 --------------------
update STUDENT set NAME = 'Mason McParka'
where NAME Like 'J%'
commit;
-------------------------- t2 --------------------