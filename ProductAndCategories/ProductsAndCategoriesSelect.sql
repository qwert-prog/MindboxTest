DECLARE @Categories TABLE (Id bigint, Name varchar(50));
DECLARE @Products TABLE (Id bigint, Name varchar(50));
DECLARE @ProductsCategories TABLE (Id bigint, ProductId bigint, CategoryId bigint);

INSERT INTO @Categories (Id, Name)
VALUES (1, '�������� ��������'),
		(2, '������������� �������'),
		(3, '��� ������'),
		(4, '� �������'),
		(5, '������ ��������'),
		(6, '�������'),
		(7, '��������������')

INSERT INTO @Products (Id, Name)
VALUES (1, '������'),
		(2, '����'),
		(3, '�������������� ������'),
		(4, '������� ��� ������'),
		(5, '�����'),
		(6, '������'),
		(7, '��������'),
		(8, '������')

INSERT INTO @ProductsCategories (Id, ProductId, CategoryId)
VALUES (1, 1, 1),
		(2, 2, 2),
		(3, 3, 2),
		(4, 3, 7),
		(5, 4, 6),
		(6, 4, 3),
		(7, 5, 1),
		(8, 6, 2)

SELECT products.Name as '�������� ��������'
		,categories.Name as '�������� ���������'
FROM @Products products
LEFT JOIN @ProductsCategories productsCategories on products.Id = productsCategories.ProductId
LEFT JOIN @Categories categories on categories.Id = productsCategories.CategoryId

SELECT products.Name as '�������� ��������'
		,STRING_AGG(categories.Name, '; ') as '�������� ���������'
FROM @Products products
LEFT JOIN @ProductsCategories productsCategories on products.Id = productsCategories.ProductId
LEFT JOIN @Categories categories on categories.Id = productsCategories.CategoryId
group by products.Name
