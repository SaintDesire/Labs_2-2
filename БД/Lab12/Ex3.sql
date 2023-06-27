use UNIVER;
BEGIN TRY
    BEGIN TRAN myTransaction; -- начало явной транзакции и задание имени "myTransaction"
    
	DECLARE @point varchar(32);
    -- выполнение операций изменения данных с использованием SAVE TRAN
    SET @point = 'p1'; SAVE TRAN savePoint;
    UPDATE FACULTY SET FACULTY_NAME = 'New Faculty Name' WHERE FACULTY = 'ИТ';
    --DELETE FROM STUDENT WHERE IDSTUDENT = 1;
    SET @point = 'p2'; SAVE TRAN savePoint;;
    INSERT INTO TEACHER (TEACHER, TEACHER_NAME, GENDER, PULPIT) VALUES (4, 'New Teacher', 'M', 'ИсИТ');
    --UPDATE PROGRESS SET NOTE = 5 WHERE IDSTUDENT = 2 AND SUBJECT = 1;
    SET @point = 'p3'; SAVE TRAN savePoint;;
    
    -- подтверждение транзакции
    COMMIT TRAN myTransaction;
    PRINT 'Transaction committed successfully';
END TRY
BEGIN CATCH
    -- откат транзакции при возникновении ошибки
    ROLLBACK TRAN myTransaction;
    PRINT 'Transaction rolled back due to error: ' + ERROR_MESSAGE();
	PRINT 'Rollback to savepoint: ' + @point;
END CATCH
