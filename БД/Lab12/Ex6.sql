use UNIVER;

-- A ---
SET TRANSACTION ISOLATION LEVEL REPEATABLE READ;
BEGIN TRANSACTION;
SELECT FACULTY_NAME FROM FACULTY WHERE FACULTY = '���';
-------------------------- t1 ------------------
-------------------------- t2 -----------------
SELECT CASE
WHEN FACULTY_NAME = '���������-�������������' THEN 'INSERT INTO FACULTY'
ELSE ' '
END AS '���������', FACULTY_NAME
FROM FACULTY
WHERE FACULTY_NAME = '���������-�������������';
COMMIT;

--- B ---
BEGIN TRANSACTION;	
-------------------------- t1 --------------------
INSERT INTO FACULTY (FACULTY, FACULTY_NAME)
VALUES ('���2', '���������-�������������');
COMMIT;
-------------------------- t2 --------------------