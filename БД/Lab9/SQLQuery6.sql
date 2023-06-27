use UNIVER;
SELECT s.NAME AS STUDENT_NAME,
       p.SUBJECT_NAME,
       pr.NOTE,
       CASE 
         WHEN pr.NOTE >= 9 THEN 'Отлично' 
         WHEN pr.NOTE >= 7 AND pr.NOTE < 9 THEN 'Хорошо' 
         WHEN pr.NOTE >= 5 AND pr.NOTE < 7 THEN 'Неплохо' 
         ELSE 'Неудовлетворительно' 
       END AS GRADE_MESSAGE
FROM STUDENT s 
JOIN [GROUP] g ON s.IDGROUP = g.IDGROUP
JOIN PROGRESS pr ON s.IDSTUDENT = pr.IDSTUDENT
JOIN SUBJECT p ON pr.SUBJECT = p.SUBJECT
JOIN PULPIT pulpit ON p.PULPIT = pulpit.PULPIT
JOIN FACULTY f ON pulpit.FACULTY = f.FACULTY
WHERE f.FACULTY_NAME = 'Информационных технологий';

