
--1. a stored procedure is a database object that contains speific business logic and that will be executed whenever it is invoked

--2. the query engine will have the execution plan for every stored procedure whenever it is compiled for the first time
--3 in real time application, most of the business logic will be stored inside this stored procedures and will be retrieved from the front end appliocation
--whenever it is required
--4using es increases the preferences of database applications when compared with sql quries across the network from every client

create procedure getcustomersbycountry @country varchar(30)
as
select * from customers where country = @country
go;

exec getcustomersbycountry 'UK';

select * from products;
select * from Categories;

create procedure getproduyctsbyacategoryid
(@categoryID int)
as

select p.productID,p.productname,p.unitprice,p.QuantityPerUnit,c.categoryID,c.categoryname from Products p inner join Categories c on c.CategoryID =c.CategoryID and c.CategoryID=@categoryID;

exec getproduyctsbyacategoryid '5';

--declaring local variables

declare @country as varchar(30);
set @country ='UK';
select * from customers where Country = @country;

alter procedure gettotalorderbydates
(@date1 date,@date2 date ,@countorder int output)
as
select @countorder=count(OrderID) FROM Orders where OrderDate between @date1 and @date2;
go

declare @count as int;

declare @date1 as date, @date2 as date;
set @date1='01/01/1990';
set @date2='12/31/1999';

exec gettotalorderbydates @date1,@date2,@count output;

print 'total number of orders placed:'+convert(varchar(10),@count);

--creating functions
--scalar fuction
alter function multiply(@n1 int,@n2 int)
 returns bigint
 as
begin
declare @prod as bigint
set @prod = @n1*@n2;
return @prod;
end

select dbo.multiply(50,30) as product;--dbo.schema

create function  getproducts(@country varchar(30)) returns table
as
return select * from customers where country = @Country;
go

select * from dbo.getproducts('germany')

create function mnm.llproductbycategoryID(@categoryID int) returns table
as
return select p.productID,p.productname,p.unitprice,p.QuantityPerUnit,c.categoryID,c.categoryname from Products p inner join Categories c on c.CategoryID =c.CategoryID and c.CategoryID=@categoryID;

select * from mnm.llproductbycategoryID(5);

create schema mnm;



--subqueries

--1. a subquerry is used as a part of a main query, and the value returned from the 
--subquery will be used by the main query for its execution

--2. sometimes a asubquery is used in the place of join operations to combine two tables
--but joins are preferred over subqueries because of their effeciancy


select productID,ProductName,UnitPrice,QuantityPerUnit,CategoryID from products
where unitprice >(select AVG (unitprice) from products) order by UnitPrice;

select * from orders;

use Northwind
select count(*)
from INFORMATION_SCHEMA.TABLES
where TABLE_SCHEMA = 'dbo';

Select customerID,CompanyName,Address, country from customers where exists
(select ContactName from Customers where country in ('usa','uk'));

Select customerID,CompanyName,Address, country from customers where not exists
(select ContactName from Customers where country = 'usa');