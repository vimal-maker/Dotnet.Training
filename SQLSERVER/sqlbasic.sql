create database employee1;

use employee1;

create table employee1
(EmpID int not null primary key,
empname varchar(50) not null,
ssn bigint not null,
salary float not null,
depid int not null);

insert into employee1 values(1,'mohan',23445,25000.00,1);
insert into employee1 values(2,'raj',28373,30000.00,2);
insert into employee1 values(3,'vimal',36353,40000.00,3);
insert into employee1 values(4,'tuhin',16151,50000,4);

create table department1
(depid int not null primary key,
deptname varchar(50) not null);

insert into department1 values(1,'dev');
insert into department1 values(2,'test');
insert into department1 values(3,'main');
insert into department1 values(4,'code');

select * from employee1;

select * from department1;


--group by

select top(3) salary from employee1
order by salary desc

select top(3) salary from employee1

select * from employee1;
select max(salary)[max salary], min(salary) [min salary], avg(salary)[avg salary] from employee1;

select depid, sum(salary) [total salary] from employee1 
group by depid 
order by depid;

select depid, sum (salary) [total salary] from Employee1
group by depid having sum (salary) >= 50000
order by depid;

select top(5) * from employee1;
select top(5) salary from employee1 
order by salary;


select depid,empid from employee1

--between

select empid
from employee1
where empid between 1 and 3;

select * from employee1

select * from department1

--joins

select e.empid,e.empname,e.salary,d.depid,d.deptname from employee1 as e inner join
 department1 as d on e.depid=d.depid;
 
 select e.empid,e.empname,e.salary,e.depid,d.deptname from employee1 as e left outer join 
 department1 as d on e.depid=d.depid;

 select e.empid,e.empname,e.salary,e.depid,d.deptname from employee1 as e right outer join
 department1 as d on e.depid=d.depid;

 insert into employee1 values(5,'anoop',54564,35000.00,5);
  insert into employee1 values(5,'anoop',54564,null,5);

--date functions
select getdate() as 'current date';

--select empname,datediff(yy,DOB,getdate()) as age from employee1;

select day(getdate()) as 'weekday';
select month(getdate()) as 'month';
select year(getdate()) as 'year';

--string functions
select empname,len(empname) as 'length' from employee1;

select upper(empname) as 'uppercase',lower(empname) as 'lowercase' from employee1;

select substring(empname,1,3) as 'partname' from employee1;

select substring('good morning everyone',1,10);

select empname,reverse(empname) as 'name reversed' from employee1;

select replace('good morning','evening','morning') as 'greetings';

--subquerry

select	EmpID,empname,salary from employee1 
where salary > (select avg(salary) from employee1)

select EmpID,empname,salary,depid from employee1
where depid = (select depid from department1 where deptname= 'dev');

select EmpID,empname,salary,depid from employee1
where depid = (select depid from department1 where deptname= 'main');

