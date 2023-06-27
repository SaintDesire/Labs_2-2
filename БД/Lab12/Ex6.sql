use UNIVER;

-- A ---
SET TRANSACTION ISOLATION LEVEL REPEATABLE READ;
BEGIN TRANSACTION;
SELECT FACULTY_NAME FROM FACULTY WHERE FACULTY = 'ИЭФ';
-------------------------- t1 ------------------
-------------------------- t2 -----------------
SELECT CASE
WHEN FACULTY_NAME = 'Инженерно-экономический' THEN 'INSERT INTO FACULTY'
ELSE ' '
END AS 'результат', FACULTY_NAME
FROM FACULTY
WHERE FACULTY_NAME = 'Инженерно-экономический';
COMMIT;

--- B ---
BEGIN TRANSACTION;	
-------------------------- t1 --------------------
INSERT INTO FACULTY (FACULTY, FACULTY_NAME)
VALUES ('ИЭФ2', 'Инженерно-экономический');
COMMIT;
-------------------------- t2 --------------------