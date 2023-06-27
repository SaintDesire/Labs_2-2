USE [View];
-- Задание 1
CREATE VIEW Преподаватель AS
SELECT 
  CODE, 
  NAME,		
  GENDER, 
  DEPARTMENT_CODE
FROM 
  TEACHER;

  CREATE TABLE TEACHER (
  CODE INT PRIMARY KEY,
  NAME VARCHAR(50),
  GENDER CHAR(1),
  DEPARTMENT_CODE INT
);

INSERT INTO TEACHER (CODE, NAME, GENDER, DEPARTMENT_CODE)
VALUES 
    (1, 'John Smith', 'M', 101),
    (2, 'Jane Doe', 'F', 102),
    (3, 'Bob Johnson', 'M', 101),
    (4, 'Samantha Lee', 'F', 103),
    (5, 'Mike Davis', 'M', 102);


SELECT * FROM Преподаватель;

-- Задание 2

CREATE TABLE FACULTY (
  FACULTY_CODE VARCHAR(10) PRIMARY KEY,
  FACULTY_NAME VARCHAR(100) NOT NULL
);

INSERT INTO FACULTY (FACULTY_CODE, FACULTY_NAME)
VALUES 
  ('FAC1', 'Факультет 1'),
  ('FAC2', 'Факультет 2'),
  ('FAC3', 'Факультет 3');

  CREATE TABLE PULPIT (
  PULPIT_CODE VARCHAR(10) PRIMARY KEY,
  PULPIT_NAME VARCHAR(100) NOT NULL,
  FACULTY_CODE VARCHAR(10) NOT NULL
);


INSERT INTO PULPIT (PULPIT_CODE, PULPIT_NAME, FACULTY_CODE)
VALUES 
  ('PUL1', 'Кафедра 1', 'FAC1'),
  ('PUL2', 'Кафедра 2', 'FAC1'),
  ('PUL3', 'Кафедра 3', 'FAC2'),
  ('PUL4', 'Кафедра 4', 'FAC3'),
  ('PUL5', 'Кафедра 5', 'FAC3'),
  ('PUL6', 'Кафедра 6', 'FAC3');


  
  DROP VIEW Количество_кафедр;


  CREATE VIEW Количество_кафедр AS
SELECT 
  FACULTY.FACULTY_NAME AS Факультет, 
  COUNT(PULPIT.PULPIT_CODE) AS Количество_кафедр
FROM 
  FACULTY 
  JOIN PULPIT ON FACULTY.FACULTY_CODE = PULPIT.FACULTY_CODE
GROUP BY 
  FACULTY.FACULTY_NAME;


  SELECT * FROM Количество_кафедр;


  -- Задание 3

  CREATE TABLE AUDITORIUM (
    CODE INT PRIMARY KEY,
    NAME VARCHAR(50) NOT NULL,
    AUDITORIUM_TYPE VARCHAR(10) NOT NULL
);

DELETE FROM AUDITORIUM;

INSERT INTO AUDITORIUM (CODE, NAME, AUDITORIUM_TYPE) VALUES
    (1, 'Аудитория 101', 'ЛК'),
    (2, 'Аудитория 102', 'ЛК'),
    (3, 'Аудитория 103', 'ПЗ'),
    (4, 'Аудитория 104', 'ЛК'),
    (5, 'Аудитория 105', 'ЛАБ');
	


CREATE VIEW Аудитории (Код, Наименование, Тип)
AS SELECT CODE, NAME, AUDITORIUM_TYPE
FROM AUDITORIUM
WHERE AUDITORIUM_TYPE LIKE 'ЛК%'
WITH CHECK OPTION;


DROP VIEW Аудитории;

INSERT INTO Аудитории (Код, Наименование, Тип)
VALUES ('6', 'Аудитория 106', 'ЛБ');


SELECT * FROM Аудитории;

SELECT * FROM AUDITORIUM;
--Задание 4

DROP VIEW Лекционные_аудитории;

CREATE VIEW Лекционные_аудитории AS
SELECT CODE, NAME
FROM AUDITORIUM
WHERE AUDITORIUM_TYPE LIKE 'ЛК%';

SELECT * FROM Лекционные_аудитории;


--Задание 5


CREATE TABLE SUBJECT (
    CODE INT PRIMARY KEY,
    NAME VARCHAR(50),
    PULPIT_CODE INT
);

INSERT INTO SUBJECT (CODE, NAME, PULPIT_CODE) 
VALUES 
  (1, 'Математический анализ', 101), 
  (2, 'Информатика', 102), 
  (3, 'Физика', 103), 
  (4, 'История', 104), 
  (5, 'Английский язык', 105);



DROP VIEW Дисциплины;

CREATE VIEW Дисциплины AS
SELECT TOP 10
    CODE,
    NAME,
    PULPIT_CODE
FROM
    SUBJECT
ORDER BY
    NAME ASC;


SELECT * FROM Дисциплины;


--Задание 6

ALTER VIEW dbo.Количество_кафедр
WITH SCHEMABINDING
AS
SELECT F.FACULTY_NAME AS Факультет, COUNT(P.FACULTY_CODE) AS [Количество кафедр]
FROM dbo.FACULTY AS F
JOIN dbo.PULPIT AS P ON F.FACULTY_CODE = P.FACULTY_CODE
GROUP BY F.FACULTY_NAME;


SELECT * FROM Количество_кафедр;


ALTER TABLE FACULTY
DROP COLUMN FACULTY_NAME;


