BEGIN TRY
    DECLARE @dividend INT = 10
    DECLARE @divisor INT = 0
    DECLARE @result FLOAT
    
    SET @result = @dividend / @divisor
    
END TRY
BEGIN CATCH
    PRINT '������ �����: ' + CAST(ERROR_NUMBER() AS VARCHAR(50))
    PRINT '��������� �� ������: ' + ERROR_MESSAGE()
    PRINT '����� ������ � �������: ' + CAST(ERROR_LINE() AS VARCHAR(50))
    PRINT '��� ��������� ��� NULL: ' + COALESCE(ERROR_PROCEDURE(), 'NULL')
    PRINT '������� ����������� ������: ' + CAST(ERROR_SEVERITY() AS VARCHAR(50))
    PRINT '����� ������: ' + CAST(ERROR_STATE() AS VARCHAR(50))
END CATCH


SELECT 
