USE UNIVER;

DELETE FROM TEACHER WHERE TEACHER_NAME = 'John Doe';

INSERT INTO TEACHER (TEACHER, TEACHER_NAME, GENDER, PULPIT)
VALUES ('DD', 'Boris Tompson', 'л', 'рдо' );

DECLARE @teacher_id CHAR(10);

DECLARE teacher_cursor CURSOR FOR
SELECT TEACHER, TEACHER_NAME, GENDER
FROM TEACHER;

DECLARE @teacher_name VARCHAR(100), @gender CHAR(1);

OPEN teacher_cursor;

FETCH NEXT FROM teacher_cursor INTO @teacher_id, @teacher_name, @gender;

UPDATE TEACHER SET TEACHER_NAME = 'John Doe', GENDER = 'M'
WHERE CURRENT OF teacher_cursor;

CLOSE teacher_cursor;
DEALLOCATE teacher_cursor;

SELECT * FROM TEACHER;