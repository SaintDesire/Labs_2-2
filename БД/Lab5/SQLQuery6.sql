-- ������� 1
use Kor_MyBase;
SELECT DISTINCT �������.��������_�����_�������
FROM �������
INNER JOIN ������� ON �������.ID_������� = �������.ID_�������
WHERE �������.ID_����_������� IN (
    SELECT DISTINCT [���� ��������].ID_����_�������
    FROM [���� ��������]
    WHERE [���� ��������].��������_������� LIKE '%����������%'
);

-- ������� 2

SELECT DISTINCT ��.��������_�����_�������
FROM ������� AS ��
INNER JOIN ������� AS �� ON ��.ID_������� = ��.ID_�������
INNER JOIN (
SELECT DISTINCT [���� ��������].ID_����_�������
FROM [���� ��������]
WHERE [���� ��������].��������_������� LIKE '%����������%'
) AS AutoCreditTypes
ON ��.ID_����_������� = AutoCreditTypes.ID_����_�������;

-- ������� 3

SELECT DISTINCT �������.��������_�����_�������
FROM �������
INNER JOIN ������� ON �������.ID_������� = �������.ID_�������
INNER JOIN [���� ��������] ON �������.ID_����_������� = [���� ��������].ID_����_�������
WHERE [���� ��������].��������_������� LIKE '%����������%';

-- ������� 4

SELECT TOP 10 c.ID_�������, c.��������_�����_�������, c.�����, c.�������,
(SELECT SUM(�����) FROM ������� WHERE ID_������� = c.ID_�������) AS �����_��������
FROM ������� c
ORDER BY �����_�������� DESC

-- ������� 5

SELECT c.ID_�������, c.��������_�����_�������, c.�����, c.�������
FROM ������� c
WHERE NOT EXISTS (
SELECT 1
FROM ������� k
WHERE k.ID_������� = c.ID_�������
)


-- ������� 6

SELECT 
    ID_�������,
    AVG(CASE WHEN a.��������_�����_������� like '%���%' THEN 1 END) AS AVG_OOO,
    AVG(CASE WHEN a.��������_�����_������� like '%���%' THEN 2 END) AS AVG_OAO,
    AVG(CASE WHEN a.��������_�����_������� like '%���%' THEN 3 END) AS AVG_ZAO
FROM ������� a
GROUP BY ID_�������

-- ������� 7

SELECT * FROM �������
WHERE ID_����_������� = ALL (SELECT ID_����_������� FROM [�������] WHERE ID_������������� = '1')


-- ������� 8

SELECT * FROM �������
WHERE ID_����_������� = ANY (SELECT ID_����_������� FROM [�������] WHERE ID_������������� = '3')






