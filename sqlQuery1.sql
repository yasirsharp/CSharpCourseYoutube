--Select 
Select ContactName Adi, CompanyName SirketAdi, City Sehir from Customers

Select * from Customers where City = 'Berlin'

--Case Insensitive
Select * from Products where categoryId = 1 or CategoryID = 3

Select * from Products where categoryId = 1 and UnitPrice >= 10

select * from Products where categoryID = 1 order by UnitPrice desc --asc (ascending) & desc (descending)

select count(*) from Products

select count(*) Adet from Products where CategoryID = 3

select categoryId, count(*) from Products where UnitPrice>20 group by CategoryID having count(*)<10

----------------------------------------------------

select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID

--DTO (Data Transformation Object)

--Inner Join Sadece eşleşen ürünler gösterilir

--Left Join solda olup sağda OLMAYAN ürünler gösterilir


Select * from Products p inner join [Order Details] od
on p.ProductID = od.ProductID
inner join Orders o 
on o.OrderID = od.OrderID

Select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null

