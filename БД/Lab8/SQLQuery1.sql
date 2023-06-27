USE [View];
-- ������� 1
CREATE VIEW ������������� AS
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


SELECT * FROM �������������;

-- ������� 2

CREATE TABLE FACULTY (
  FACULTY_CODE VARCHAR(10) PRIMARY KEY,
  FACULTY_NAME VARCHAR(100) NOT NULL
);

INSERT INTO FACULTY (FACULTY_CODE, FACULTY_NAME)
VALUES 
  ('FAC1', '��������� 1'),
  ('FAC2', '��������� 2'),
  ('FAC3', '��������� 3');

  CREATE TABLE PULPIT (
  PULPIT_CODE VARCHAR(10) PRIMARY KEY,
  PULPIT_NAME VARCHAR(100) NOT NULL,
  FACULTY_CODE VARCHAR(10) NOT NULL
);


INSERT INTO PULPIT (PULPIT_CODE, PULPIT_NAME, FACULTY_CODE)
VALUES 
  ('PUL1', '������� 1', 'FAC1'),
  ('PUL2', '������� 2', 'FAC1'),
  ('PUL3', '������� 3', 'FAC2'),
  ('PUL4', '������� 4', 'FAC3'),
  ('PUL5', '������� 5', 'FAC3'),
  ('PUL6', '������� 6', 'FAC3');


  
  DROP VIEW ����������_������;


  CREATE VIEW ����������_������ AS
SELECT 
  FACULTY.FACULTY_NAME AS ���������, 
  COUNT(PULPIT.PULPIT_CODE) AS ����������_������
FROM 
  FACULTY 
  JOIN PULPIT ON FACULTY.FACULTY_CODE = PULPIT.FACULTY_CODE
GROUP BY 
  FACULTY.FACULTY_NAME;


  SELECT * FROM ����������_������;


  -- ������� 3

  CREATE TABLE AUDITORIUM (
    CODE INT PRIMARY KEY,
    NAME VARCHAR(50) NOT NULL,
    AUDITORIUM_TYPE VARCHAR(10) NOT NULL
);

DELETE FROM AUDITORIUM;

INSERT INTO AUDITORIUM (CODE, NAME, AUDITORIUM_TYPE) VALUES
    (1, '��������� 101', '��'),
    (2, '��������� 102', '��'),
    (3, '��������� 103', '��'),
    (4, '��������� 104', '��'),
    (5, '��������� 105', '���');
	


CREATE VIEW ��������� (���, ������������, ���)
AS SELECT CODE, NAME, AUDITORIUM_TYPE
FROM AUDITORIUM
WHERE AUDITORIUM_TYPE LIKE '��%'
WITH CHECK OPTION;


DROP VIEW ���������;

INSERT INTO ��������� (���, ������������, ���)
VALUES ('6', '��������� 106', '��');


SELECT * FROM ���������;

SELECT * FROM AUDITORIUM;
--������� 4

DROP VIEW ����������_���������;

CREATE VIEW ����������_��������� AS
SELECT CODE, NAME
FROM AUDITORIUM
WHERE AUDITORIUM_TYPE LIKE '��%';

SELECT * FROM ����������_���������;


--������� 5


CREATE TABLE SUBJECT (
    CODE INT PRIMARY KEY,
    NAME VARCHAR(50),
    PULPIT_CODE INT
);

INSERT INTO SUBJECT (CODE, NAME, PULPIT_CODE) 
VALUES 
  (1, '�������������� ������', 101), 
  (2, '�����������', 102), 
  (3, '������', 103), 
  (4, '�������', 104), 
  (5, '���������� ����', 105);



DROP VIEW ����������;

CREATE VIEW ���������� AS
SELECT TOP 10
    CODE,
    NAME,
    PULPIT_CODE
FROM
    SUBJECT
ORDER BY
    NAME ASC;


SELECT * FROM ����������;


--������� 6

ALTER VIEW dbo.����������_������
WITH SCHEMABINDING
AS
SELECT F.FACULTY_NAME AS ���������, COUNT(P.FACULTY_CODE) AS [���������� ������]
FROM dbo.FACULTY AS F
JOIN dbo.PULPIT AS P ON F.FACULTY_CODE = P.FACULTY_CODE
GROUP BY F.FACULTY_NAME;


SELECT * FROM ����������_������;


ALTER TABLE FACULTY
DROP COLUMN FACULTY_NAME;


