use Kor_MyBase;

EXEC SP_HELPINDEX 'Кредиты'
EXEC SP_HELPINDEX 'Кредиты'
EXEC SP_HELPINDEX 'Собственность'
EXEC SP_HELPINDEX 'Типы кредитов'

CREATE CLUSTERED INDEX #index1 on Кредиты(Сумма asc);
DROP INDEX #index1 on Кредиты
--
SELECT * FROM Кредиты where Сумма between 15000 and 200000 order by Сумма;
checkpoint;  
DBCC DROPCLEANBUFFERS;  