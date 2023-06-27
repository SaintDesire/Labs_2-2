use UNIVER;

BEGIN TRANSACTION;

BEGIN TRY

-- ��������� ������ � ������� PROGRESS ��� ����������� ��������
DECLARE @idstudent INT = (SELECT MAX(IDSTUDENT) FROM STUDENT);
INSERT INTO PROGRESS (SUBJECT, IDSTUDENT, PDATE, NOTE) 
VALUES ('��', @idstudent, GETDATE(), 5);


-- ������� ������ �� ������� STUDENT, ��� ��� �������� ���������� �� 'J'
DELETE FROM STUDENT WHERE NAME LIKE 'J%';

COMMIT TRANSACTION;

PRINT 'Records modified successfully.';

END TRY
BEGIN CATCH
ROLLBACK TRANSACTION;

PRINT 'Error occurred: ' + ERROR_MESSAGE();

END CATCH;