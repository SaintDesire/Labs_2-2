USE Kor_MyBase

CREATE TRIGGER �������_�������
ON �������
AFTER UPDATE, INSERT
AS
BEGIN
  IF EXISTS (SELECT * FROM inserted)
  BEGIN
    PRINT '����������� �������� UPDATE ��� INSERT � ������� "�������"'
  END
END

CREATE TRIGGER �������_�������
ON �������
AFTER UPDATE, INSERT
AS
BEGIN
  IF EXISTS (SELECT * FROM inserted)
  BEGIN
    PRINT '����������� �������� UPDATE ��� INSERT � ������� "�������"'
  END
END


UPDATE ������� SET ������ = 5.0 WHERE ID_������� = 1

UPDATE ������� SET ����� = '����� �����' WHERE ID_������� = 1

