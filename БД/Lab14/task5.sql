use Kor_MyBase;

go
CREATE FUNCTION �������_�������_��_���������_�����(@���_����� DECIMAL(10, 2), @����_����� DECIMAL(10, 2))
RETURNS TABLE
AS
RETURN (
  SELECT *
  FROM �������
  WHERE ����� >= isnull(@���_�����, �����) AND ����� <= isnull(@����_�����, �����)
)

SELECT * FROM �������_�������_��_���������_�����(20000, 50000)

SELECT * FROM �������_�������_��_���������_�����(50000, 100000)


go
CREATE FUNCTION �������_����������_��������_��_id(@ID_������� INT)
RETURNS INT
AS
BEGIN
  DECLARE @����������_�������� INT
  
  SELECT @����������_�������� = COUNT(*) 
  FROM �������
  WHERE ID_������� = @ID_�������
  
  RETURN @����������_��������
END


--DROP FUNCTION �������_����������_��������_��_id;

print 'ebat ' +  cast(dbo.�������_����������_��������_��_id(1) as varchar)
