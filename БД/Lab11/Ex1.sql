use UNIVER;
DECLARE @disciplines VARCHAR(MAX) = ''
DECLARE @subject_name VARCHAR(100)

DECLARE discipline_cursor CURSOR FOR 
SELECT RTRIM(SUBJECT_NAME)
FROM SUBJECT 
INNER JOIN PULPIT ON SUBJECT.PULPIT = PULPIT.PULPIT
WHERE PULPIT.PULPIT = 'ศั่า'

OPEN discipline_cursor

FETCH NEXT FROM discipline_cursor INTO @subject_name

WHILE @@FETCH_STATUS = 0
BEGIN
    SET @disciplines = @disciplines + @subject_name + ', '
    FETCH NEXT FROM discipline_cursor INTO @subject_name
END

CLOSE discipline_cursor
DEALLOCATE discipline_cursor

PRINT SUBSTRING(@disciplines, 1, LEN(@disciplines))
