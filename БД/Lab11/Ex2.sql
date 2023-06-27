-- Глобальный курсор
DECLARE subject_cursor CURSOR FOR
SELECT SUBJECT_NAME FROM SUBJECT

DECLARE @subject_name VARCHAR(50)
OPEN subject_cursor
FETCH NEXT FROM subject_cursor INTO @subject_name
    PRINT @subject_name
go
DECLARE @subject_name VARCHAR(50)
FETCH NEXT FROM subject_cursor INTO @subject_name
PRINT @subject_name
CLOSE subject_cursor
DEALLOCATE subject_cursor
go

-- Локальный курсор
DECLARE @subject_cursor_local CURSOR
SET @subject_cursor_local = CURSOR LOCAL FOR
SELECT SUBJECT_NAME FROM SUBJECT


DECLARE @subject_name_local VARCHAR(50)
OPEN @subject_cursor_local
FETCH NEXT FROM @subject_cursor_local INTO @subject_name_local
    PRINT @subject_name_local
go
DECLARE @subject_name_local VARCHAR(50)
	FETCH NEXT FROM @subject_cursor_local INTO @subject_name_local
    PRINT @subject_name_local
CLOSE @subject_cursor_local
