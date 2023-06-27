use UNIVER;
BEGIN TRY
    BEGIN TRAN myTransaction; -- ������ ����� ���������� � ������� ����� "myTransaction"
    
	DECLARE @point varchar(32);
    -- ���������� �������� ��������� ������ � �������������� SAVE TRAN
    SET @point = 'p1'; SAVE TRAN savePoint;
    UPDATE FACULTY SET FACULTY_NAME = 'New Faculty Name' WHERE FACULTY = '��';
    --DELETE FROM STUDENT WHERE IDSTUDENT = 1;
    SET @point = 'p2'; SAVE TRAN savePoint;;
    INSERT INTO TEACHER (TEACHER, TEACHER_NAME, GENDER, PULPIT) VALUES (4, 'New Teacher', 'M', '����');
    --UPDATE PROGRESS SET NOTE = 5 WHERE IDSTUDENT = 2 AND SUBJECT = 1;
    SET @point = 'p3'; SAVE TRAN savePoint;;
    
    -- ������������� ����������
    COMMIT TRAN myTransaction;
    PRINT 'Transaction committed successfully';
END TRY
BEGIN CATCH
    -- ����� ���������� ��� ������������� ������
    ROLLBACK TRAN myTransaction;
    PRINT 'Transaction rolled back due to error: ' + ERROR_MESSAGE();
	PRINT 'Rollback to savepoint: ' + @point;
END CATCH
