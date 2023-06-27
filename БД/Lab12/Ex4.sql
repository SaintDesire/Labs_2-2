USE UNIVER;

-- A ---
SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;
BEGIN TRANSACTION;

-------------------------- t1 ------------------
SELECT @@SPID, 'INSERT INTO STUDENT' AS 'результат', * FROM STUDENT WHERE NAME = 'Ivanov';
SELECT @@SPID, 'SELECT FROM PROGRESS' AS 'результат', SUBJECT, NOTE
FROM PROGRESS
WHERE SUBJECT = 'БД';

COMMIT;

-------------------------- t2 -----------------
--- B --
BEGIN TRANSACTION;

SELECT @@SPID;
INSERT INTO STUDENT VALUES (15, 23, 'Petrov', '1999-01-01', NULL, NULL, NULL);
UPDATE PROGRESS SET SUBJECT = 'БД', NOTE = 5 WHERE SUBJECT = 'ДД';

-------------------------- t1 --------------------
-------------------------- t2 --------------------

ROLLBACK;