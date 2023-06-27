use Kor_MyBase;

go
CREATE FUNCTION выбрать_кредиты_по_диапазону_суммы(@мин_сумма DECIMAL(10, 2), @макс_сумма DECIMAL(10, 2))
RETURNS TABLE
AS
RETURN (
  SELECT *
  FROM Кредиты
  WHERE Сумма >= isnull(@мин_сумма, Сумма) AND Сумма <= isnull(@макс_сумма, Сумма)
)

SELECT * FROM выбрать_кредиты_по_диапазону_суммы(20000, 50000)

SELECT * FROM выбрать_кредиты_по_диапазону_суммы(50000, 100000)


go
CREATE FUNCTION выбрать_количество_кредитов_по_id(@ID_Клиента INT)
RETURNS INT
AS
BEGIN
  DECLARE @Количество_кредитов INT
  
  SELECT @Количество_кредитов = COUNT(*) 
  FROM Кредиты
  WHERE ID_Клиента = @ID_Клиента
  
  RETURN @Количество_кредитов
END


--DROP FUNCTION выбрать_количество_кредитов_по_id;

print 'ebat ' +  cast(dbo.выбрать_количество_кредитов_по_id(1) as varchar)
