-- ���������� �������� ���������� z
DECLARE @t FLOAT = 2, @x FLOAT = 3.8, @z FLOAT;

IF (@t > @x)
SET @z = POWER(SIN(@t), 2);
ELSE IF (@t < @x)
SET @z = 4 * (@t + @x);
ELSE
SET @z = 1 - EXP(@x - 2);

PRINT '�������� ���������� z = ' + CAST(@z AS VARCHAR(20));


-- �������������� ������� ��� �������� � �����������
DECLARE @full_name VARCHAR(100) = '������ ������ ��������';
DECLARE @short_name VARCHAR(30);

SELECT
@short_name = SUBSTRING(�������, 1, 1) + '. ' + SUBSTRING(���, 1, 1) + '. ' + SUBSTRING(��������, 1, 1) + '.'
FROM
(
SELECT
PARSENAME(REPLACE(@full_name, ' ', '.'), 3) AS �������,
PARSENAME(REPLACE(@full_name, ' ', '.'), 2) AS ���,
PARSENAME(REPLACE(@full_name, ' ', '.'), 1) AS ��������
) AS Names;

PRINT '������ ���: ' + @full_name;
PRINT '����������� ���: ' + @short_name;


-- ����� ���������, � ������� ���� �������� � ��������� ������
use UNIVER;
DECLARE @current_date DATE = GETDATE();
DECLARE @next_month DATE = DATEADD(MONTH, 1, @current_date);

SELECT
NAME,
BDAY,
DATEDIFF(YEAR, BDAY, @current_date) - CASE WHEN DATEADD(YEAR, DATEDIFF(YEAR, BDAY, @current_date), BDAY) > @current_date THEN 1 ELSE 0 END AS �������
FROM
STUDENT
WHERE
MONTH(BDAY) = MONTH(@next_month);


-- ����� ��� ������, � ������� �������� ������ �307 ������� ������� �� ��
SELECT
PDATE,
DATENAME(WEEKDAY, PDATE) AS ����_������
FROM
PROGRESS
WHERE
IDSTUDENT = '307' AND SUBJECT = '��';