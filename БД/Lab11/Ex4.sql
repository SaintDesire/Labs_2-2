USE UNIVER;
-- Создаем курсор с атрибутом SCROLL
DECLARE cursor_students SCROLL CURSOR FOR
SELECT IDSTUDENT, NAME, BDAY, STAMP
FROM STUDENT
ORDER BY IDSTUDENT;

-- Открываем курсор
OPEN cursor_students;

-- Прочитаем первую строку
FETCH FIRST FROM cursor_students;

-- Прочитаем последнюю строку
FETCH LAST FROM cursor_students;

-- Прочитаем строку, которая находится перед текущей строкой
FETCH PRIOR FROM cursor_students;

-- Прочитаем строку, которая находится после текущей строки
FETCH NEXT FROM cursor_students;

-- Прочитаем абсолютно любую строку в результирующем наборе
FETCH ABSOLUTE 5 FROM cursor_students;

-- Прочитаем строку, которая находится относительно текущей строки на 3 строки вперед
FETCH RELATIVE 3 FROM cursor_students;

-- Закрываем курсор
CLOSE cursor_students;
