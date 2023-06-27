-- Вычисление значения переменной z
DECLARE @t FLOAT = 2, @x FLOAT = 3.8, @z FLOAT;

IF (@t > @x)
SET @z = POWER(SIN(@t), 2);
ELSE IF (@t < @x)
SET @z = 4 * (@t + @x);
ELSE
SET @z = 1 - EXP(@x - 2);

PRINT 'Значение переменной z = ' + CAST(@z AS VARCHAR(20));


-- Преобразование полного ФИО студента в сокращенное
DECLARE @full_name VARCHAR(100) = 'Коршун Никита Игоревич';
DECLARE @short_name VARCHAR(30);

SELECT
@short_name = SUBSTRING(Фамилия, 1, 1) + '. ' + SUBSTRING(Имя, 1, 1) + '. ' + SUBSTRING(Отчество, 1, 1) + '.'
FROM
(
SELECT
PARSENAME(REPLACE(@full_name, ' ', '.'), 3) AS Фамилия,
PARSENAME(REPLACE(@full_name, ' ', '.'), 2) AS Имя,
PARSENAME(REPLACE(@full_name, ' ', '.'), 1) AS Отчество
) AS Names;

PRINT 'Полное ФИО: ' + @full_name;
PRINT 'Сокращенное ФИО: ' + @short_name;


-- Поиск студентов, у которых день рождения в следующем месяце
use UNIVER;
DECLARE @current_date DATE = GETDATE();
DECLARE @next_month DATE = DATEADD(MONTH, 1, @current_date);

SELECT
NAME,
BDAY,
DATEDIFF(YEAR, BDAY, @current_date) - CASE WHEN DATEADD(YEAR, DATEDIFF(YEAR, BDAY, @current_date), BDAY) > @current_date THEN 1 ELSE 0 END AS Возраст
FROM
STUDENT
WHERE
MONTH(BDAY) = MONTH(@next_month);


-- Поиск дня недели, в который студенты группы №307 сдавали экзамен по БД
SELECT
PDATE,
DATENAME(WEEKDAY, PDATE) AS День_недели
FROM
PROGRESS
WHERE
IDSTUDENT = '307' AND SUBJECT = 'БД';