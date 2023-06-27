-- Создание временной локальной таблицы
CREATE TABLE #TempTable (
   Column1 INT,
   Column2 VARCHAR(50),
   Column3 DATETIME
)

-- Заполнение временной таблицы данными
DECLARE @i INT = 1
WHILE @i <= 10
BEGIN
   INSERT INTO #TempTable VALUES (@i, 'Value ' + CAST(@i AS VARCHAR(2)), GETDATE())
   SET @i = @i + 1
END

-- Вывод содержимого таблицы
SELECT * FROM #TempTable

-- Удаление временной таблицы
DROP TABLE #TempTable
