USE Kor_MyBase

CREATE TRIGGER триггер_кредиты
ON Кредиты
AFTER UPDATE, INSERT
AS
BEGIN
  IF EXISTS (SELECT * FROM inserted)
  BEGIN
    PRINT 'Выполняется операция UPDATE или INSERT в таблице "Кредиты"'
  END
END

CREATE TRIGGER триггер_клиенты
ON Клиенты
AFTER UPDATE, INSERT
AS
BEGIN
  IF EXISTS (SELECT * FROM inserted)
  BEGIN
    PRINT 'Выполняется операция UPDATE или INSERT в таблице "Клиенты"'
  END
END


UPDATE Кредиты SET Ставка = 5.0 WHERE ID_Кредита = 1

UPDATE Клиенты SET Адрес = 'Новый адрес' WHERE ID_Клиента = 1

