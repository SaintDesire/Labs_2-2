use Kor_MyBase;
SELECT �������.ID_�������, [���� ��������].��������_�������
FROM �������
INNER JOIN [���� ��������] ON �������.ID_����_������� = [���� ��������].ID_����_�������;


SELECT �������.ID_�������, �������.��������_�����_�������
FROM �������
INNER JOIN �������
ON �������.ID_������� = �������.ID_�������
WHERE �������.��������_�����_������� LIKE '%���%';
