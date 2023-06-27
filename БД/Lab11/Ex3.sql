use UNIVER;

-- �������� ������������ �������
DECLARE @Subject VARCHAR(50);
DECLARE @IdStudent INT;
DECLARE @Note INT;
DECLARE cursorStatic CURSOR STATIC FOR
    SELECT SUBJECT, IDSTUDENT, NOTE
    FROM PROGRESS
    WHERE SUBJECT = '��';

	INSERT INTO PROGRESS (SUBJECT, IDSTUDENT, PDATE, NOTE)
VALUES ('��', 1, '01-12-2023', 5);


-- �������� ������������ �������
OPEN cursorStatic;
FETCH NEXT FROM cursorStatic INTO @Subject, @IdStudent, @Note;
print   '���������� ����� : '+cast(@@CURSOR_ROWS as varchar(5)); 
--DELETE PROGRESS WHERE IDSTUDENT = 1;

-- ����� �������� �� ������������ �������
PRINT '����������� ������:';
WHILE @@FETCH_STATUS = 0
BEGIN
    PRINT CONCAT('�������: ', @Subject, ', ID ��������: ', @IdStudent, ', ������: ', @Note);
    FETCH NEXT FROM cursorStatic INTO @Subject, @IdStudent, @Note;
END;

-- �������� ������������ �������
CLOSE cursorStatic;
DEALLOCATE cursorStatic;

-- �������� ������������� �������
DECLARE @sql NVARCHAR(MAX);
SET @sql = '
DECLARE cursorDynamic CURSOR FOR
    SELECT SUBJECT, IDSTUDENT, NOTE
    FROM PROGRESS
    WHERE SUBJECT = ''��'';
';
EXEC sp_executesql @sql;

-- �������� ������������� �������
OPEN cursorDynamic;
FETCH NEXT FROM cursorDynamic INTO @Subject, @IdStudent, @Note;

print   '���������� ����� : '+cast(@@CURSOR_ROWS as varchar(5)); 
DELETE PROGRESS WHERE IDSTUDENT = 1;
	INSERT INTO PROGRESS (SUBJECT, IDSTUDENT, PDATE, NOTE)
VALUES ('��', 1, '01-12-2023', 5);

-- ����� �������� �� ������������� �������
PRINT '������������ ������:';
WHILE @@FETCH_STATUS = 0
BEGIN
    PRINT CONCAT('�������: ', @Subject, ', ID ��������: ', @IdStudent, ', ������: ', @Note);
    FETCH NEXT FROM cursorDynamic INTO @Subject, @IdStudent, @Note;
END;

-- �������� ������������� �������
CLOSE cursorDynamic;
