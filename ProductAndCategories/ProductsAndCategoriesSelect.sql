DECLARE @Categories TABLE (Id bigint, Name varchar(50));
DECLARE @Products TABLE (Id bigint, Name varchar(50));
DECLARE @ProductsCategories TABLE (Id bigint, ProductId bigint, CategoryId bigint);

INSERT INTO @Categories (Id, Name)
VALUES (1, 'Молочные продукты'),
		(2, 'Хлебобулочные изделия'),
		(3, 'Без сахара'),
		(4, 'С сахаром'),
		(5, 'Мясные продукты'),
		(6, 'Сладкое'),
		(7, 'Вегетерианское')

INSERT INTO @Products (Id, Name)
VALUES (1, 'Молоко'),
		(2, 'Хлеб'),
		(3, 'Вегетерианский бургер'),
		(4, 'Шоколад без сахара'),
		(5, 'Кефир'),
		(6, 'Хлебцы'),
		(7, 'Клубника'),
		(8, 'Огурец')

INSERT INTO @ProductsCategories (Id, ProductId, CategoryId)
VALUES (1, 1, 1),
		(2, 2, 2),
		(3, 3, 2),
		(4, 3, 7),
		(5, 4, 6),
		(6, 4, 3),
		(7, 5, 1),
		(8, 6, 2)

SELECT products.Name as 'Название продукта'
		,categories.Name as 'Название категории'
FROM @Products products
LEFT JOIN @ProductsCategories productsCategories on products.Id = productsCategories.ProductId
LEFT JOIN @Categories categories on categories.Id = productsCategories.CategoryId

SELECT products.Name as 'Название продукта'
		,STRING_AGG(categories.Name, '; ') as 'Название категорий'
FROM @Products products
LEFT JOIN @ProductsCategories productsCategories on products.Id = productsCategories.ProductId
LEFT JOIN @Categories categories on categories.Id = productsCategories.CategoryId
group by products.Name
