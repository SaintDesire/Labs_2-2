USE UNIVER;
-- ������� ������ � ��������� SCROLL
DECLARE cursor_students SCROLL CURSOR FOR
SELECT IDSTUDENT, NAME, BDAY, STAMP
FROM STUDENT
ORDER BY IDSTUDENT;

-- ��������� ������
OPEN cursor_students;

-- ��������� ������ ������
FETCH FIRST FROM cursor_students;

-- ��������� ��������� ������
FETCH LAST FROM cursor_students;

-- ��������� ������, ������� ��������� ����� ������� �������
FETCH PRIOR FROM cursor_students;

-- ��������� ������, ������� ��������� ����� ������� ������
FETCH NEXT FROM cursor_students;

-- ��������� ��������� ����� ������ � �������������� ������
FETCH ABSOLUTE 5 FROM cursor_students;

-- ��������� ������, ������� ��������� ������������ ������� ������ �� 3 ������ ������
FETCH RELATIVE 3 FROM cursor_students;

-- ��������� ������
CLOSE cursor_students;
