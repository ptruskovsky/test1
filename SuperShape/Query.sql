/*
	dbo.Category 
	Id int,
	Name nvarchar(63)
----------------------
	dbo.Product
	Id int,
	Name nvarchar(63)
---------------------
	dbo.ProductCategory
	ProductId int,
	CategoryId int
*/

SELECT 
	[dbo].[Product].[Name] as [ProductName]
	,[dbo].[Category].[Name] as [CategoryName]
FROM [dbo].[ProductCategory] 
		LEFT JOIN [dbo].[Product] ON [dbo].[Product].[Id] = [dbo].[ProductCategory].[ProductId]
		LEFT JOIN [dbo].[Category] ON [dbo].[Category].[Id] = [dbo].[ProductCategory].[CategoryId]
	

