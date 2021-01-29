
select ProductName as ProductName, SUM([Order Details].UnitPrice * [Order Details].Quantity*(1-[Order Details].Discount))
as TotalGain from ((Products inner join [Order Details] on Products.ProductID = [Order Details].ProductID)
inner join Orders on [Order Details].OrderID= Orders.OrderID) group by Products.ProductName 

