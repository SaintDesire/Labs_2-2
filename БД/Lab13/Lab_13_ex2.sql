use Kor_MyBase;

DROP PROCEDURE AddCredit;

CREATE PROCEDURE AddCredit
	@ID_Кредита INT,
    @ID_Типа_кредита INT,
    @Ставка DECIMAL(10, 2),
    @Сумма DECIMAL(10, 2),
    @Дата_выдачи DATE,
    @Дата_возврата DATE,
    @ID_Клиента INT,
    @ID_Собственности INT
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        INSERT INTO Кредиты (ID_Кредита,ID_Типа_кредита, Ставка, Сумма, Дата_выдачи, Дата_возврата, ID_Клиента, ID_Собственности)
        VALUES (@ID_Кредита,@ID_Типа_кредита, @Ставка, @Сумма, @Дата_выдачи, @Дата_возврата, @ID_Клиента, @ID_Собственности);
        return 1;
    END TRY
    BEGIN CATCH
        -- Обработка ошибок
        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
        DECLARE @ErrorSeverity INT = ERROR_SEVERITY();
        DECLARE @ErrorState INT = ERROR_STATE();
        print @ErrorMessage;
        -- Ваш код обработки ошибок, например, запись в журнал ошибок
    END CATCH;
END;


EXEC AddCredit
	@ID_Кредита = 18,
    @ID_Типа_кредита = 1,
    @Ставка = 0.05,
    @Сумма = 10000,
    @Дата_выдачи = '2023-05-01',
    @Дата_возврата = '2023-06-01',
    @ID_Клиента = 1,
    @ID_Собственности = 1;

SELECT * From Кредиты;
