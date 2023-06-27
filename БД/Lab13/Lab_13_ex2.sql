use Kor_MyBase;

DROP PROCEDURE AddCredit;

CREATE PROCEDURE AddCredit
	@ID_������� INT,
    @ID_����_������� INT,
    @������ DECIMAL(10, 2),
    @����� DECIMAL(10, 2),
    @����_������ DATE,
    @����_�������� DATE,
    @ID_������� INT,
    @ID_������������� INT
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        INSERT INTO ������� (ID_�������,ID_����_�������, ������, �����, ����_������, ����_��������, ID_�������, ID_�������������)
        VALUES (@ID_�������,@ID_����_�������, @������, @�����, @����_������, @����_��������, @ID_�������, @ID_�������������);
        return 1;
    END TRY
    BEGIN CATCH
        -- ��������� ������
        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
        DECLARE @ErrorSeverity INT = ERROR_SEVERITY();
        DECLARE @ErrorState INT = ERROR_STATE();
        print @ErrorMessage;
        -- ��� ��� ��������� ������, ��������, ������ � ������ ������
    END CATCH;
END;


EXEC AddCredit
	@ID_������� = 18,
    @ID_����_������� = 1,
    @������ = 0.05,
    @����� = 10000,
    @����_������ = '2023-05-01',
    @����_�������� = '2023-06-01',
    @ID_������� = 1,
    @ID_������������� = 1;

SELECT * From �������;
