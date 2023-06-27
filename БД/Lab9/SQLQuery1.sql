DECLARE @char_var char(10) = 'Hello';
DECLARE @varchar_var varchar(20) = 'World';
DECLARE @datetime_var datetime;
DECLARE @time_var time;
DECLARE @int_var int;
DECLARE @smallint_var smallint;
DECLARE @tinyint_var tinyint;
DECLARE @numeric_var numeric(12, 5);

SELECT
	@datetime_var = GETDATE(),
	@time_var = CONVERT(time, GETDATE()),
	@int_var = 123456;
SET @smallint_var = 123;
SET @tinyint_var = 1;
SET @numeric_var = 12345.67890;

SELECT @char_var, @varchar_var;
PRINT @datetime_var;
PRINT @time_var;
PRINT @int_var;
PRINT @smallint_var;
PRINT @tinyint_var;
PRINT @numeric_var;
