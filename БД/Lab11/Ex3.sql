use UNIVER;

-- Создание статического курсора
DECLARE @Subject VARCHAR(50);
DECLARE @IdStudent INT;
DECLARE @Note INT;
DECLARE cursorStatic CURSOR STATIC FOR
    SELECT SUBJECT, IDSTUDENT, NOTE
    FROM PROGRESS
    WHERE SUBJECT = 'БД';

	INSERT INTO PROGRESS (SUBJECT, IDSTUDENT, PDATE, NOTE)
VALUES ('БД', 1, '01-12-2023', 5);


-- Открытие статического курсора
OPEN cursorStatic;
FETCH NEXT FROM cursorStatic INTO @Subject, @IdStudent, @Note;
print   'Количество строк : '+cast(@@CURSOR_ROWS as varchar(5)); 
--DELETE PROGRESS WHERE IDSTUDENT = 1;

-- Вывод значений из статического курсора
PRINT 'Статический курсор:';
WHILE @@FETCH_STATUS = 0
BEGIN
    PRINT CONCAT('Предмет: ', @Subject, ', ID студента: ', @IdStudent, ', Оценка: ', @Note);
    FETCH NEXT FROM cursorStatic INTO @Subject, @IdStudent, @Note;
END;

-- Закрытие статического курсора
CLOSE cursorStatic;
DEALLOCATE cursorStatic;

-- Создание динамического курсора
DECLARE @sql NVARCHAR(MAX);
SET @sql = '
DECLARE cursorDynamic CURSOR FOR
    SELECT SUBJECT, IDSTUDENT, NOTE
    FROM PROGRESS
    WHERE SUBJECT = ''БД'';
';
EXEC sp_executesql @sql;

-- Открытие динамического курсора
OPEN cursorDynamic;
FETCH NEXT FROM cursorDynamic INTO @Subject, @IdStudent, @Note;

print   'Количество строк : '+cast(@@CURSOR_ROWS as varchar(5)); 
DELETE PROGRESS WHERE IDSTUDENT = 1;
	INSERT INTO PROGRESS (SUBJECT, IDSTUDENT, PDATE, NOTE)
VALUES ('БД', 1, '01-12-2023', 5);

-- Вывод значений из динамического курсора
PRINT 'Динамический курсор:';
WHILE @@FETCH_STATUS = 0
BEGIN
    PRINT CONCAT('Предмет: ', @Subject, ', ID студента: ', @IdStudent, ', Оценка: ', @Note);
    FETCH NEXT FROM cursorDynamic INTO @Subject, @IdStudent, @Note;
END;

-- Закрытие динамического курсора
CLOSE cursorDynamic;
