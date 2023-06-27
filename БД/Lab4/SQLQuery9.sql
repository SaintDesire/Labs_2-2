use Kor_MyBase;
SELECT *
FROM Клиенты
LEFT OUTER JOIN Кредиты
ON Клиенты.ID_Клиента = Кредиты.ID_Клиента
WHERE Кредиты.ID_Кредита IS NULL;

SELECT *
FROM Кредиты
LEFT OUTER JOIN Клиенты
ON Клиенты.ID_Клиента = Кредиты.ID_Клиента
WHERE Клиенты.ID_Клиента IS NULL;

SELECT *
FROM Клиенты
FULL OUTER JOIN Кредиты
ON Клиенты.ID_Клиента = Кредиты.ID_Клиента;


SELECT Кредиты.ID_Кредита, [Типы кредитов].Название_кредита
FROM Кредиты
CROSS JOIN [Типы кредитов]
WHERE Кредиты.ID_Типа_кредита = [Типы кредитов].ID_Типа_кредита;

