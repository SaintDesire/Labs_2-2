use Kor_MyBase;

-- 1
DECLARE @client_id INT
DECLARE @client_name VARCHAR(50)
DECLARE @client_address VARCHAR(50)
DECLARE client_cursor CURSOR FOR
SELECT ID_Клиента, Название_фирмы_клиента, Адрес
FROM Клиенты
OPEN client_cursor
FETCH NEXT FROM client_cursor INTO @client_id, @client_name, @client_address
WHILE @@FETCH_STATUS = 0
BEGIN
   PRINT 'Client ID: ' + CAST(@client_id AS VARCHAR(10)) + ', Name: ' + @client_name + ', Address: ' + @client_address
   FETCH NEXT FROM client_cursor INTO @client_id, @client_name, @client_address
END
CLOSE client_cursor
DEALLOCATE client_cursor


-- 2
DECLARE @loan_id INT
DECLARE @loan_type VARCHAR(50)
DECLARE @loan_amount MONEY
DECLARE loan_cursor CURSOR FOR
SELECT ID_Кредита, Название_кредита, Сумма
FROM Кредиты k JOIN [Типы кредитов] t ON k.ID_Типа_кредита = t.ID_Типа_кредита
OPEN loan_cursor
FETCH NEXT FROM loan_cursor INTO @loan_id, @loan_type, @loan_amount
WHILE @@FETCH_STATUS = 0
BEGIN
   PRINT 'Loan ID: ' + CAST(@loan_id AS VARCHAR(10)) + ', Type: ' + @loan_type + ', Amount: ' + CAST(@loan_amount AS VARCHAR(20))
   FETCH NEXT FROM loan_cursor INTO @loan_id, @loan_type, @loan_amount
END
CLOSE loan_cursor
DEALLOCATE loan_cursor


-- 3
DECLARE @property_id INT
DECLARE @property_type VARCHAR(50)
DECLARE property_cursor CURSOR FOR
SELECT ID_Собственности, Вид_собственности
FROM Собственность
OPEN property_cursor
FETCH NEXT FROM property_cursor INTO @property_id, @property_type
WHILE @@FETCH_STATUS = 0
BEGIN
   PRINT 'Property ID: ' + CAST(@property_id AS VARCHAR(10)) + ', Type: ' + @property_type
   FETCH NEXT FROM property_cursor INTO @property_id, @property_type
END
CLOSE property_cursor
DEALLOCATE property_cursor

