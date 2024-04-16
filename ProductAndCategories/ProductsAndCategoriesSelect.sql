DECLARE @Categories TABLE (Id bigint, Name varchar(50));
DECLARE @Products TABLE (Id bigint, Name varchar(50));
DECLARE @ProductsCategories TABLE (Id bigint, ProductId bigint, CategoryId bigint);

INSERT INTO @Categories (Id, Name)
VALUES (1, 'Milk products'),
		(2, 'Bakery products'),
		(3, 'No sugar'),
		(4, 'With sugar'),
		(5, 'Meat products'),
		(6, 'Sweet'),
		(7, 'Vegetarian')

INSERT INTO @Products (Id, Name)
VALUES (1, 'Milk'),
		(2, 'Bread'),
		(3, 'Veggie burger'),
		(4, 'Sugar-free chocolate'),
		(5, 'Kefir'),
		(6, 'Shortbread'),
		(7, 'Strawberries'),
		(8, 'Cucumber')

INSERT INTO @ProductsCategories (Id, ProductId, CategoryId)
VALUES (1, 1, 1),
		(2, 2, 2),
		(3, 3, 2),
		(4, 3, 7),
		(5, 4, 6),
		(6, 4, 3),
		(7, 5, 1),
		(8, 6, 2)

SELECT products.Name as 'Product Name'
		,categories.Name as 'Category name'
FROM @Products products
LEFT JOIN @ProductsCategories productsCategories on products.Id = productsCategories.ProductId
LEFT JOIN @Categories categories on categories.Id = productsCategories.CategoryId

SELECT products.Name as 'Product Name'
		,STRING_AGG(categories.Name, '; ') as 'Categories name'
FROM @Products products
LEFT JOIN @ProductsCategories productsCategories on products.Id = productsCategories.ProductId
LEFT JOIN @Categories categories on categories.Id = productsCategories.CategoryId
group by products.Name
