use UNIVER;
SELECT note AS Оценка, COUNT(*) AS Количество
FROM (
  SELECT CASE
           WHEN note < 3 THEN '2 и ниже'
           WHEN note < 4 THEN '3'
		   WHEN note < 5 THEN '4'
		   WHEN note < 6 THEN '5'
		   WHEN note < 7 THEN '6'
		   WHEN note < 8 THEN '7'
		   WHEN note < 9 THEN '8'
           ELSE 'Отлично'
         END AS note
  FROM PROGRESS
) as T
WHERE note BETWEEN '3' AND '8'
GROUP BY note
ORDER BY Оценка DESC;
