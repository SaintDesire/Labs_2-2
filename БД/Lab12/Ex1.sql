set nocount on
	if  exists (select * from  SYS.OBJECTS        -- ������� X ����?
	            where OBJECT_ID= object_id(N'DBO.Test') )	            
	drop table Test;           
	declare @c int, @flag char = 'r';           -- commit ��� rollback?
	SET IMPLICIT_TRANSACTIONS  ON   -- �����. ����� ������� ����������
	CREATE table Test(K nvarchar(20) );                         -- ������ ���������� 
		INSERT Test values ('������'),('�����-���������'),('��������');
		set @c = (select count(*) from Test);
		print '���������� ����� � ������� Test: ' + cast( @c as varchar(2));
		if @flag = 'c'  commit;                   -- ���������� ����������: �������� 
	          else   rollback;                                 -- ���������� ����������: �����  
      SET IMPLICIT_TRANSACTIONS  OFF   -- ������. ����� ������� ����������
	
	if  exists (select * from  SYS.OBJECTS       -- ������� X ����?
	            where OBJECT_ID= object_id(N'DBO.Test') )
	print '������� Test ����';  
      else print '������� Test ���'
