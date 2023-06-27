-- Задание 1
use Kor_MyBase;
SELECT DISTINCT Клиенты.Название_фирмы_клиента
FROM Клиенты
INNER JOIN Кредиты ON Клиенты.ID_Клиента = Кредиты.ID_Клиента
WHERE Кредиты.ID_Типа_кредита IN (
    SELECT DISTINCT [Типы Кредитов].ID_Типа_кредита
    FROM [Типы Кредитов]
    WHERE [Типы Кредитов].Название_кредита LIKE '%автокредит%'
);

-- Задание 2

SELECT DISTINCT Кл.Название_фирмы_клиента
FROM Клиенты AS Кл
INNER JOIN Кредиты AS Кр ON Кл.ID_Клиента = Кр.ID_Клиента
INNER JOIN (
SELECT DISTINCT [Типы Кредитов].ID_Типа_кредита
FROM [Типы Кредитов]
WHERE [Типы Кредитов].Название_кредита LIKE '%автокредит%'
) AS AutoCreditTypes
ON Кр.ID_Типа_кредита = AutoCreditTypes.ID_Типа_кредита;

-- Задание 3

SELECT DISTINCT Клиенты.Название_фирмы_клиента
FROM Клиенты
INNER JOIN Кредиты ON Клиенты.ID_Клиента = Кредиты.ID_Клиента
INNER JOIN [Типы Кредитов] ON Кредиты.ID_Типа_кредита = [Типы Кредитов].ID_Типа_кредита
WHERE [Типы Кредитов].Название_кредита LIKE '%автокредит%';

-- Задание 4

SELECT TOP 10 c.ID_Клиента, c.Название_фирмы_клиента, c.Адрес, c.Телефон,
(SELECT SUM(Сумма) FROM Кредиты WHERE ID_Клиента = c.ID_Клиента) AS Сумма_кредитов
FROM Клиенты c
ORDER BY Сумма_кредитов DESC

-- Задание 5

SELECT c.ID_Клиента, c.Название_фирмы_клиента, c.Адрес, c.Телефон
FROM Клиенты c
WHERE NOT EXISTS (
SELECT 1
FROM Кредиты k
WHERE k.ID_Клиента = c.ID_Клиента
)


-- Задание 6

SELECT 
    ID_Клиента,
    AVG(CASE WHEN a.Название_фирмы_клиента like '%ООО%' THEN 1 END) AS AVG_OOO,
    AVG(CASE WHEN a.Название_фирмы_клиента like '%ОАО%' THEN 2 END) AS AVG_OAO,
    AVG(CASE WHEN a.Название_фирмы_клиента like '%ЗАО%' THEN 3 END) AS AVG_ZAO
FROM Клиенты a
GROUP BY ID_Клиента

-- Задание 7

SELECT * FROM Кредиты
WHERE ID_Типа_кредита = ALL (SELECT ID_Типа_кредита FROM [Кредиты] WHERE ID_Собственности = '1')


-- Задание 8

SELECT * FROM Кредиты
WHERE ID_Типа_кредита = ANY (SELECT ID_Типа_кредита FROM [Кредиты] WHERE ID_Собственности = '3')






