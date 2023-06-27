USE UNIVER;

DECLARE @age INT
DECLARE @isAdult BIT
DECLARE @studentID INT

DECLARE student_cursor CURSOR FOR 
    SELECT IDSTUDENT FROM STUDENT

OPEN student_cursor;
FETCH NEXT FROM student_cursor INTO @studentID;

WHILE @@FETCH_STATUS = 0
BEGIN
    SELECT @age = DATEDIFF(YEAR, BDAY, GETDATE()) FROM STUDENT WHERE IDSTUDENT = @studentID

    IF @age >= 18
       SET @isAdult = 1
    ELSE
       SET @isAdult = 0

    IF @isAdult = 1
       PRINT 'Студент с ID ' + CAST(@studentID AS VARCHAR(10)) + ' является совершеннолетним'
    ELSE
       PRINT 'Студент с ID ' + CAST(@studentID AS VARCHAR(10)) + ' не является совершеннолетним'

    FETCH NEXT FROM student_cursor INTO @studentID;
END

CLOSE student_cursor;
DEALLOCATE student_cursor;
