use Kor_MyBase;

EXEC SP_HELPINDEX '�������'
EXEC SP_HELPINDEX '�������'
EXEC SP_HELPINDEX '�������������'
EXEC SP_HELPINDEX '���� ��������'

CREATE CLUSTERED INDEX #index1 on �������(����� asc);
DROP INDEX #index1 on �������
--
SELECT * FROM ������� where ����� between 15000 and 200000 order by �����;
checkpoint;  
DBCC DROPCLEANBUFFERS;  