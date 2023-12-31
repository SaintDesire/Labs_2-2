use UNIVER;
SELECT DISTINCT PULPIT.PULPIT_NAME
FROM PULPIT
WHERE PULPIT.FACULTY IN (
    SELECT DISTINCT FACULTY.FACULTY
    FROM FACULTY
    INNER JOIN PROFESSION
        ON FACULTY.FACULTY = PROFESSION.FACULTY
    WHERE PROFESSION.PROFESSION_NAME LIKE '%технология%'
        OR PROFESSION.PROFESSION_NAME LIKE '%технологии%'
);



SELECT DISTINCT PULPIT.PULPIT_NAME
FROM PULPIT
INNER JOIN (
    SELECT DISTINCT FACULTY.FACULTY
    FROM FACULTY
    INNER JOIN PROFESSION
        ON FACULTY.FACULTY = PROFESSION.FACULTY
    WHERE PROFESSION.PROFESSION_NAME LIKE '%технология%'
        OR PROFESSION.PROFESSION_NAME LIKE '%технологии%'
) AS FACULTIES
ON PULPIT.FACULTY = FACULTIES.FACULTY;



SELECT DISTINCT PULPIT.PULPIT_NAME
FROM PULPIT
INNER JOIN PROFESSION
    ON PULPIT.FACULTY = PROFESSION.FACULTY
INNER JOIN FACULTY
    ON PROFESSION.FACULTY = FACULTY.FACULTY
WHERE PROFESSION.PROFESSION_NAME LIKE '%технология%'
    OR PROFESSION.PROFESSION_NAME LIKE '%технологии%';
