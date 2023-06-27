use UNIVER;

BEGIN TRANSACTION;

BEGIN TRY

-- Добавляем запись в таблицу PROGRESS для оставшегося студента
DECLARE @idstudent INT = (SELECT MAX(IDSTUDENT) FROM STUDENT);
INSERT INTO PROGRESS (SUBJECT, IDSTUDENT, PDATE, NOTE) 
VALUES ('БД', @idstudent, GETDATE(), 5);


-- Удаляем записи из таблицы STUDENT, где имя студента начинается на 'J'
DELETE FROM STUDENT WHERE NAME LIKE 'J%';

COMMIT TRANSACTION;

PRINT 'Records modified successfully.';

END TRY
BEGIN CATCH
ROLLBACK TRANSACTION;

PRINT 'Error occurred: ' + ERROR_MESSAGE();

END CATCH;