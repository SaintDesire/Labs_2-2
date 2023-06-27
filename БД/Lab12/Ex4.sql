USE UNIVER;

-- A ---
SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;
BEGIN TRANSACTION;

-------------------------- t1 ------------------
SELECT @@SPID, 'INSERT INTO STUDENT' AS '���������', * FROM STUDENT WHERE NAME = 'Ivanov';
SELECT @@SPID, 'SELECT FROM PROGRESS' AS '���������', SUBJECT, NOTE
FROM PROGRESS
WHERE SUBJECT = '��';

COMMIT;

-------------------------- t2 -----------------
--- B --
BEGIN TRANSACTION;

SELECT @@SPID;
INSERT INTO STUDENT VALUES (15, 23, 'Petrov', '1999-01-01', NULL, NULL, NULL);
UPDATE PROGRESS SET SUBJECT = '��', NOTE = 5 WHERE SUBJECT = '��';

-------------------------- t1 --------------------
-------------------------- t2 --------------------

ROLLBACK;