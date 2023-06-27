SELECT Наименование_товара, Дата_доставки, Заказчик
FROM  ЗАКАЗЫ
WHERE (Заказчик = N'BrightMinds')
ORDER BY Дата_доставки