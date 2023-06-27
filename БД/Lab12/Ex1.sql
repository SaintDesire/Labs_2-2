set nocount on
	if  exists (select * from  SYS.OBJECTS        -- таблица X есть?
	            where OBJECT_ID= object_id(N'DBO.Test') )	            
	drop table Test;           
	declare @c int, @flag char = 'r';           -- commit или rollback?
	SET IMPLICIT_TRANSACTIONS  ON   -- включ. режим неявной транзакции
	CREATE table Test(K nvarchar(20) );                         -- начало транзакции 
		INSERT Test values ('Москва'),('Санкт-Петербург'),('Белгород');
		set @c = (select count(*) from Test);
		print 'количество строк в таблице Test: ' + cast( @c as varchar(2));
		if @flag = 'c'  commit;                   -- завершение транзакции: фиксация 
	          else   rollback;                                 -- завершение транзакции: откат  
      SET IMPLICIT_TRANSACTIONS  OFF   -- выключ. режим неявной транзакции
	
	if  exists (select * from  SYS.OBJECTS       -- таблица X есть?
	            where OBJECT_ID= object_id(N'DBO.Test') )
	print 'таблица Test есть';  
      else print 'таблицы Test нет'
