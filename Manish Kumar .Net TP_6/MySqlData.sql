create database Manish
use Manish
create table Details(emp_Id int, emp_Name varchar(50),City varchar(50))
insert into Details values (101,'Manish saini','Moradabad'),
                         (102,'Rahul saini','Noida'),
						 (103,'Gurmeet saini','Delhi'),
						 (104,'Amit saini','Dhampur'),
                         (105,'Abhishek Shager','Bijnor')
alter table Details add Mobile bigint

      update Details set Mobile=7906494033 where emp_Id=101
     update Details set Mobile=9634042711 where emp_Id=102
    update Details set Mobile=9634007427 where emp_Id=103
   update Details set Mobile=8074532515 where emp_Id=104
  update Details set Mobile=7351245620 where emp_Id=105

 delete Details where emp_Id=105

 alter table Details add Salary bigint

 update Details set Salary=35000 where emp_Id=101
  update Details set Salary=25000 where emp_Id=102
   update Details set Salary=30000 where emp_Id=103
    update Details set Salary=40000 where emp_Id=104
	 update Details set Salary=35000 where emp_Id=104
 



create table Details_1(emp_Id int, emp_Name varchar(50),City varchar(50),dept_Id int)
insert into Details_1 values (1,'Manish','Moradabad',101),
                             (2,'Rahul','Rampur',105),
							 (3,'Rakesh','Bariley',106),
							 (4,'Sonu','Pakwara',103),
							 (5,'Promad','Chandighar',108)

select*from Details
select*from Details_1

select e.emp_Name, e.Salary,d.City
from Details e
inner join Details_1 d
on e.emp_Id=d.dept_Id

