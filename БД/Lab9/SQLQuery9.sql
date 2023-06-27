BEGIN TRY
    DECLARE @dividend INT = 10
    DECLARE @divisor INT = 0
    DECLARE @result FLOAT
    
    SET @result = @dividend / @divisor
    
END TRY
BEGIN CATCH
    PRINT 'Ошибка номер: ' + CAST(ERROR_NUMBER() AS VARCHAR(50))
    PRINT 'Сообщение об ошибке: ' + ERROR_MESSAGE()
    PRINT 'Номер строки с ошибкой: ' + CAST(ERROR_LINE() AS VARCHAR(50))
    PRINT 'Имя процедуры или NULL: ' + COALESCE(ERROR_PROCEDURE(), 'NULL')
    PRINT 'Уровень серьезности ошибки: ' + CAST(ERROR_SEVERITY() AS VARCHAR(50))
    PRINT 'Метка ошибки: ' + CAST(ERROR_STATE() AS VARCHAR(50))
END CATCH


SELECT 
