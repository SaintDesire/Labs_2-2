use Kor_MyBase;

-- 1

DROP VIEW �������_�_�����������_�_��������;

CREATE VIEW �������_�_�����������_�_�������� AS 
SELECT �.ID_�������, �.ID_����_�������, �.������, �.�����, �.����_������, �.����_��������, 
    �.ID_�������, �.ID_�������������, 
    ��.��������_�����_�������, ��.�����, ��.�������,
    �.��������_�������
FROM ������� �
INNER JOIN ������� �� ON �.ID_������� = ��.ID_�������
INNER JOIN "���� ��������" � ON �.ID_����_������� = �.ID_����_�������;

SELECT * FROM �������_�_�����������_�_��������;

-- 2

DROP VIEW ������_��������_�_������_��������;

CREATE VIEW ������_��������_�_������_�������� AS
SELECT ��.��������_�����_�������, �.��������_�������
FROM ������� �
INNER JOIN ������� �� ON �.ID_������� = ��.ID_�������
INNER JOIN "���� ��������" � ON �.ID_����_������� = �.ID_����_�������
GROUP BY ��.��������_�����_�������, �.��������_�������;


SELECT * FROM ������_��������_�_������_��������;

-- 3

DROP VIEW ����������_��������_��_�����;

CREATE VIEW ����������_��������_��_�����
AS
SELECT [���� ��������].��������_�������, COUNT(�������.ID_�������) AS [���������� ��������]
FROM [���� ��������]
JOIN ������� ON [���� ��������].ID_����_������� = �������.ID_����_�������
GROUP BY [���� ��������].��������_�������;


SELECT * FROM ����������_��������_��_�����;