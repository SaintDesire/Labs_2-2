use UNIVER;

-- A --
set transaction isolation level SERIALIZABLE
begin transaction

select count(*) from STUDENT where NAME LIKE '�%';
-------------------------- t1 --------------------
-------------------------- t2 --------------------
insert into STUDENT (IDSTUDENT, IDGROUP, NAME, BDAY, STAMP, INFO, FOTO)
values (40, 25, '���� �������', NULL, NULL, NULL, NULL)
-------------------------- t1 --------------------
select count(*) from STUDENT where NAME LIKE '�%';

commit;


-- B --
begin transaction

select count(*) from STUDENT where NAME LIKE '�%';
-------------------------- t1 --------------------
-------------------------- t2 --------------------
insert into STUDENT (IDSTUDENT, IDGROUP, NAME, BDAY, STAMP, INFO, FOTO)
values (41, 27, '���� �������', NULL, NULL, NULL, NULL)
-------------------------- t1 --------------------
select count(*) from STUDENT where NAME LIKE '�%';

commit;