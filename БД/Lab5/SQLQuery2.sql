use UNIVER;
SELECT AUDITORIUM_TYPE, AUDITORIUM_NAME, AUDITORIUM_CAPACITY
FROM AUDITORIUM A1
WHERE AUDITORIUM_CAPACITY = (
    SELECT TOP 1 AUDITORIUM_CAPACITY
    FROM AUDITORIUM A2
    WHERE A1.AUDITORIUM_TYPE = A2.AUDITORIUM_TYPE
    ORDER BY AUDITORIUM_CAPACITY DESC
)
ORDER BY AUDITORIUM_TYPE ASC;
